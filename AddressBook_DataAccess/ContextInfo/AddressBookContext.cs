using AddressBook_Entity.Entities;
using AddressBook_Entity.Identity_Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_DataAccess.ContextInfo
{
    public class AddressBookContext : IdentityDbContext<MyUser, MyRole, string>
    {

        public AddressBookContext()
        {

        }
        public AddressBookContext(DbContextOptions<AddressBookContext> opt) : base(opt)
        {

        }

        public virtual DbSet<City> CityTable { get; set; }
        public virtual DbSet<District> DistrictTable { get; set; }
        public virtual DbSet<Neighborhood> NeighborhoodTable { get; set; }
        public virtual DbSet<UserAddress> UserAddressTable { get; set; }

        //burada identityDBcontexten kalıtım aldığımız için user role tablolarını kalıtım aldığımız class dbsetlerini zaten yazmış!

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }


            modelBuilder.Entity<UserAddress>()
                          .HasOne<City>() // tip belirt
                          .WithMany()
                          .HasForeignKey(c => c.CityID)
                          .OnDelete(DeleteBehavior.Restrict);



            modelBuilder.Entity<UserAddress>()
                         .HasOne<District>() // tip belirt
                         .WithMany()
                         .HasForeignKey(c => c.DistrictID)
                         .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<UserAddress>()
                         .HasOne<Neighborhood>() // tip belirt
                         .WithMany()
                         .HasForeignKey(c => c.NeighborhoodID)
                         .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<UserAddress>()
                       .HasOne<MyUser>() // tip belirt
                       .WithMany()
                       .HasForeignKey(c => c.UserID)
                       .OnDelete(DeleteBehavior.Restrict);


            base.OnModelCreating(modelBuilder);
        }
    }
}
