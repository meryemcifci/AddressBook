using AddressBook_Entity.Concrete;
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
    public class AddressBookContext:IdentityDbContext<MyUser,MyRole,string>
    {
        public AddressBookContext()
        {
        }
        public AddressBookContext(DbContextOptions<AddressBookContext> options):base(options)
        {
        }

        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<District> District { get; set; }
        public virtual DbSet<Neighborhood> Neighborhood { get; set; }
        public virtual DbSet<UserAddress> UserAddress { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           
        }


    }
}
