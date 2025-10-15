using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Entity.Entities
{
    [Table("USERADDRESS")]
    public class UserAddress : IBaseEntity<int>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int Id { get; set; }
        [Column(Order = 2)]

        public DateTime CreatedDate { get; set; }
        [Column(Order = 3)]
        public string UserID { get; set; }


        [Column(Order = 4)]
        public byte CityID { get; set; }
        [Column(Order = 5)]
        public int DistrictID { get; set; }

        [Column(Order = 6)]
        public int NeighborhoodID { get; set; }
        [Column(Order = 7)]
        [StringLength(250, MinimumLength = 2)]

        public string Title { get; set; }
        [Column(Order = 8)]
        [StringLength(500, MinimumLength = 2)]

        public string Details { get; set; }
        [Column(Order = 9)]
        [StringLength(10)]

        public string? PostalCode { get; set; }
        [Column(Order = 10)]

        public bool IsDefaultAddress { get; set; }
        [Column(Order = 11)]

        public bool IsDeleted { get; set; }

        //[ForeignKey("UserID")]
        //public virtual MyUser User { get; set; }

        //[ForeignKey("CityID")]
        //public virtual City City { get; set; }

        //[ForeignKey("DistrictID")]
        //public virtual District District { get; set; }
        //[ForeignKey("NeighborhoodID")]
        //public Neighborhood Neighborhood { get; set; }
    }
}
