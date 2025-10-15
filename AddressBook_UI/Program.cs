using AddressBook_Business.ImplementsOfManagers;
using AddressBook_Business.InterfacesOfManagers;
using AddressBook_DataAccess.ContextInfo;
using AddressBook_Entity.AutoMapperConfig;
using AddressBook_Entity.Identity_Entities;
using AutoMapper.Extensions.ExpressionMapping;
using DocumentFormat.OpenXml.InkML;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AddressBook_UI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AddressBookContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
           



            //automapper ayarý
            builder.Services.AddAutoMapper(opt =>
            {
                opt.AllowNullCollections = true;
                //ihtiyaç olursa
                opt.ShouldMapMethod = (m => false);
                //opt.ShouldMapField = (x => true);
                //opt.ShouldMapProperty = (x => true);
                //opt.ShouldUseConstructor = (x => false);

                opt.AddProfile(typeof(MyProile));// _mapper.Map için eklendi
                opt.AddExpressionMapping(); //  _mapper.MapExpression için eklendi.
            });


            //usermanagere ve rolmanager ---> identity paketi
            builder.Services.AddIdentity<MyUser, MyRole>(opt =>
            {
                //ayarlar
                opt.Password.RequireUppercase = true;
                opt.Password.RequireLowercase = true;
                opt.Password.RequiredUniqueChars = 2;
                opt.Password.RequiredLength = 12;
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequireDigit = true;
                opt.User.RequireUniqueEmail = true; //account controller register  var emailExist 
                //abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+
                opt.User.AllowedUserNameCharacters = "abcçdefghijklmnopqrstuvwxyzABCÇDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+&*";


            }).AddDefaultTokenProviders().AddEntityFrameworkStores<AddressBookContext>();

            builder.Services.AddScoped<ICityManager, CityManager>();



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
