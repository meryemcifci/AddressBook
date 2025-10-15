using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Entity.Entities
{
    [Table("NEIGHBORHOOD")]
    public class Neighborhood : IBaseEntity<int>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int Id { get; set; }
        [Column(Order = 2)]

        public DateTime CreatedDate { get; set; }
        [Column(Order = 3)]

        [StringLength(250, MinimumLength = 2)]
        public string Name { get; set; }
        [Column(Order = 4)]
        public int DistrictID { get; set; } //FK


        [Column(Order = 5)]

        public bool IsDeleted { get; set; }

        [ForeignKey("DistrictID")]
        public virtual District District { get; set; }
    }
}
