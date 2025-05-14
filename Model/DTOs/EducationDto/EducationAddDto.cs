using System.ComponentModel.DataAnnotations;

namespace Model.DTOs
{
    public class EducationAddDTO
    {
        [Required(ErrorMessage = "Başlık alanı zorunludur")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Alt başlık alanı zorunludur")]
        public string SubTitle { get; set; }

        [Required(ErrorMessage = "Alt başlık 2 alanı zorunludur")]
        public string Subtitle2 { get; set; }

        [Required(ErrorMessage = "GNO alanı zorunludur")]
        public string Gno { get; set; }

        [Required(ErrorMessage = "Tarih alanı zorunludur")]
        public string Date { get; set; }
    }

    public class EducationUpdateDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Başlık alanı zorunludur")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Alt başlık alanı zorunludur")]
        public string SubTitle { get; set; }

        [Required(ErrorMessage = "Alt başlık 2 alanı zorunludur")]
        public string Subtitle2 { get; set; }

        [Required(ErrorMessage = "GNO alanı zorunludur")]
        public string Gno { get; set; }

        [Required(ErrorMessage = "Tarih alanı zorunludur")]
        public string Date { get; set; }
    }
}