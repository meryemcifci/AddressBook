using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Entity.ViewModels
{
    public class CityDTO
    {
        public byte Id { get; set; }

        public DateTime CreatedDate { get; set; }

        [StringLength(250, MinimumLength = 2,ErrorMessage ="Max 250 min 2 karakter olmalıdır!")]
        [Required(ErrorMessage ="Şehir ismi zorunludur!")]
        public string Name { get; set; }
        [StringLength(3, MinimumLength = 2, ErrorMessage = "Max 3 min 2 karakter olmalıdır!")]
        [Required(ErrorMessage = "Plaka zorunludur!")]
        public string PlateCode { get; set; }

        public bool IsDeleted { get; set; }
    }
}
