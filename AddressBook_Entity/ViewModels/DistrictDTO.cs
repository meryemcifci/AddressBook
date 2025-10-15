using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Entity.ViewModels
{
    public class DistrictDTO
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }

        [Required(ErrorMessage = "İlçe ismi gereklidir!")]
        [StringLength(250, MinimumLength = 2,ErrorMessage ="Max 250 min 2 karakter olmalıdır!")]
        public string Name { get; set; }
        public byte CityID { get; set; } //FK


        public bool IsDeleted { get; set; }

        public  CityDTO? City { get; set; }
    }
}
