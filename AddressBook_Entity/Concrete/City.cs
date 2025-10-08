using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Entity.Concrete
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PlateCode { get; set; }
        public string IsDeleted { get; set; }
           
        public List<District> Districts { get; set; }

    }
}
