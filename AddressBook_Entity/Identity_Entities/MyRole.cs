using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Entity.Identity_Entities
{
    [Table("ROLES")]
    public class MyRole : IdentityRole
    {
        [Column(Order = 2)]
        public DateTime CreatedDate { get; set; }
        [Column(Order = 3)]
        [StringLength(250, MinimumLength = 2)]
        public override string? Name { get; set; }
        [Column(Order = 4)]
        [StringLength(1000)]
        public string? Description { get; set; }

        public bool IsDeleted { get; set; }

    }
}
