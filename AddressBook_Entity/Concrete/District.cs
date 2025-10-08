using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Entity.Concrete
{
    public class District
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("City")]
        public int CityId { get; set; }

        public string Name { get; set; }
        public string IsDeleted { get; set; }

        public List<Neighborhood> Neighborhoods { get; set; }
    }
}
