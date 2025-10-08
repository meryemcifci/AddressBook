using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Entity.Concrete
{
    public class Neighborhood
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("District")]
        public string DistrictId { get; set; }
        public string Name { get; set; }
        public string IsDeleted { get; set; }
    }
}
