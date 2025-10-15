using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Entity.Concrete
{
    [Table("NEIGHBORHOOD")]
    public class Neighborhood:IBaseEntity<int>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int Id { get; set; }

        [Column(Order = 3)]
        [ForeignKey("District")]
        public string DistrictId { get; set; }
        public virtual District District { get; set; }

        [Column(Order = 4)]
        public string Name { get; set; }

        [Column(Order = 5)]
        public bool IsDeleted { get; set; }

        [Column(Order =2)]
        public DateTime CreatedDate { get; set; }
    }
}
