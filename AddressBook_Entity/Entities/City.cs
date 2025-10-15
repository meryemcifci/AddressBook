using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Entity.Entities
{
    [Table("CITY")]
    public class City : IBaseEntity<byte>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public byte Id { get; set; }
        [Column(Order = 2)]

        public DateTime CreatedDate { get; set; }
        [Column(Order = 3)]

        [StringLength(250, MinimumLength = 2)]
        public string Name { get; set; }
        [Column(Order = 4)]
        [StringLength(3, MinimumLength = 2)]
        public string PlateCode { get; set; }
        [Column(Order = 5)]

        public bool IsDeleted { get; set; }
    }
}
