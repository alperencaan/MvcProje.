using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.DTO.About
{
    public class AboutUpdateDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "İsim boş geçilemez")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyisim boş geçilemez")]
        public string Surname { get; set; }

        public string Address { get; set; }

        [Phone(ErrorMessage = "Geçerli bir telefon numarası girin")]
        public string Phone { get; set; }

        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi girin")]
        public string Mail { get; set; }

        public string Description { get; set; }

        public string Image { get; set; } // İstersen dosya yükleme alanı da yapabiliriz
    }

}
