using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Entity.Concrete
{
    [Table("CITY")]
    public class City:IBaseEntity<byte>//türkiyede 81 il var ondan byte dedim. Kesinlikle 254'ü geçmez!!!!
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order =1)]
        public byte Id { get; set; }

        [StringLength(250,MinimumLength =2)]
        [Column(Order = 3)]
        public string Name { get; set; }

        [Column(Order = 4)]
        public string PlateCode { get; set; }

        [Column(Order = 2)]
        public DateTime CreatedDate { get; set; }

        [Column(Order = 5)]
        public bool IsDeleted { get; set; }
        
    }
}
