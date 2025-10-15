
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Entity.ViewModels
{
    public class NeighborhoodDTO
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }

        [StringLength(250, MinimumLength = 2)]
        public string Name { get; set; }
        public int DistrictID { get; set; } //FK


        public bool IsDeleted { get; set; }

        public DistrictDTO? District { get; set; }

    }
}
