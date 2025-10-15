using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Entity.Identity_Entities
{
    [Table("USERS")]
    public class MyUser:IdentityUser
    {
        [Column(Order=2)]
        public DateTime CreatedDate { get; set; }

        [Column(Order = 2)]
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public DateTime Birthdate { get; set; }
        public Genders Gender { get; set; }
        public string ProfilePicturePath { get; set; }
        public bool IsDeleted { get; set; }

    }
}
