using AddressBook_Entity.Identity_Entities;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Entity.Concrete
{
    [Table("USERADDRESS")]
    public class UserAddress : IBaseEntity<int>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order =1)]
        public int Id { get; set; }

        [Column(Order = 2)]
        public DateTime CreatedDate { get ; set; }

        [Column(Order = 3)]
        public string AddressTitle { get; set; }


        [Column(Order = 6)]
        public bool IsDeleted { get; set; }

        [ForeignKey("UserId")]
        public string UserId { get; set; }
        public virtual MyUser User { get; set; }

        [ForeignKey("CityId")]
        public string CityId { get; set; }
        public virtual City City { get; set; }

        [ForeignKey("NeighborhoodId")]
        public string NeighborhoodId { get; set; }
        public virtual Neighborhood Neighborhood { get; set; }


    }
}
