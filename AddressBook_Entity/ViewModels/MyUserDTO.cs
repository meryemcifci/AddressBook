using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace AddressBook_Entity.ViewModels
{
    public  class MyUserDTO
    {
        public string Id { get; set; } 

        public DateTime CreatedDate { get; set; }
        [StringLength(200, MinimumLength = 2)]
        public string FirstName { get; set; }
        [StringLength(200, MinimumLength = 2)]
        public string Surname { get; set; }
        public DateTime? BirthDate { get; set; }
        public Genders Gender { get; set; }
        public string? ProfilePicturePath { get; set; }


        public bool IsDeleted { get; set; }



       
        public  string? UserName { get; set; }

      
        public  string? NormalizedUserName { get; set; }

      
        public  string? Email { get; set; }

        public  string? NormalizedEmail { get; set; }

        public  bool EmailConfirmed { get; set; }

        public  string? PasswordHash { get; set; }

        public  string? SecurityStamp { get; set; }

        public  string? ConcurrencyStamp { get; set; }

        public  string? PhoneNumber { get; set; }

        public  bool PhoneNumberConfirmed { get; set; }

        public  bool TwoFactorEnabled { get; set; }

        public  DateTimeOffset? LockoutEnd { get; set; }
        public  bool LockoutEnabled { get; set; }

        public  int AccessFailedCount { get; set; }

    }
}
