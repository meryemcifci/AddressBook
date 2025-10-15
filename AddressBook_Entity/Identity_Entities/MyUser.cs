using AddressBook_Entity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_2025October_EL.Identity_Entities
{
    [Table("USERS")]
    public class MyUser : IdentityUser
    {

        [Column(Order = 2)]
        public DateTime CreatedDate { get; set; }
        [Column(Order = 3)]
        [StringLength(200, MinimumLength = 2)]
        public string FirstName { get; set; }
        [Column(Order = 4)]
        [StringLength(200, MinimumLength = 2)]
        public string Surname { get; set; }
        [Column(Order = 5)]
        public DateTime? BirthDate { get; set; }
        [Column(Order = 6)]
        public Genders Gender { get; set; }
        [Column(Order = 7)]
        public string? ProfilePicturePath { get; set; }


        public bool IsDeleted { get; set; }



    }
}
