using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressBook_Entity.Identity_Entities;

namespace AddressBook_Entity.ViewModels
{
    public class UserAddressDTO // UserAddressViewModel UserAddressVM
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }
        public string UserID { get; set; }


        public byte CityID { get; set; }
        public int DistrictID { get; set; }

        public int NeighborhoodID { get; set; }
        [StringLength(250, MinimumLength = 2)]

        public string Title { get; set; }
        [StringLength(500, MinimumLength = 2)]

        public string Details { get; set; }
        [StringLength(10)]

        public string? PostalCode { get; set; }

        public bool IsDefaultAddress { get; set; }

        public bool IsDeleted { get; set; }

        public  MyUser? User { get; set; }

        public  CityDTO? City { get; set; }

        public  DistrictDTO? District { get; set; }
        public NeighborhoodDTO? Neighborhood { get; set; }

    }
}
