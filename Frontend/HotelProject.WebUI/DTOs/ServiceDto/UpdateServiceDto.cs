using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.DTOs.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceId { get; set; }
        [Required(ErrorMessage = "Hizmet ikon linkini giriniz")]
        public string ServiceRoom { get; set; } = string.Empty;
        [Required(ErrorMessage = "Hizmet başlığı giriniz")]
        [StringLength(100, ErrorMessage = "En fazla 100 karakter girilebilir.")]
        public string Title { get; set; } = string.Empty;
        [Required(ErrorMessage = "Hizmet açıklaması giriniz")]
        [StringLength(500, ErrorMessage = "En fazla 500 karakter girilebilir.")]

        public string Description { get; set; } = string.Empty;
    }
}
