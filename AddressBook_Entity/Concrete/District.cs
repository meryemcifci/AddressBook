using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Entity.Concrete
{
    [Table("DISTRICT")]
    public class District:IBaseEntity<int>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int Id { get; set; }

        [ForeignKey("CityId")]
        public virtual City City { get; set; }
        [Column(Order = 4)]
        public int CityId { get; set; }

        [Column(Order = 3)]
        public string Name { get; set; }

        [Column(Order = 5)]
        public bool IsDeleted { get; set; }

        [Column(Order = 2)]
        public DateTime CreatedDate { get ; set; }
    }
}
