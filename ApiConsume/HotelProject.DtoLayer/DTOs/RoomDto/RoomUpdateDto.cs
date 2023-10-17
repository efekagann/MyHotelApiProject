using System.ComponentModel.DataAnnotations;

namespace HotelProject.DtoLayer.DTOs.RoomDto
{
    public class RoomUpdateDto
    {
        public int RoomId { get; set; }
        [Required(ErrorMessage = "Lütfen oda numarasını yazınız")]
        public string RoomNumber { get; set; } = string.Empty;
        [Required(ErrorMessage = "Lütfen oda görseli giriniz")]
        public string RoomCoverImage { get; set; } = string.Empty;
        [Required(ErrorMessage = "Lütfen fiyat bilgisini giriniz")]
        public int Price { get; set; } = default;

        [Required(ErrorMessage = "Lütfen oda başlığı bilgisini giriniz")]
        [StringLength(100, ErrorMessage = "Lütfen en fazla 100 karakter veri girişi yapınız")]
        public string Title { get; set; } = string.Empty;
        [Required(ErrorMessage = "Lütfen yatak sayısı bilgisini giriniz")]
        public string BedCount { get; set; } = string.Empty;
        [Required(ErrorMessage = "Lütfen banyo sayısı bilgisini giriniz")]
        public string BathCount { get; set; } = string.Empty;
        public string Wifi { get; set; } = string.Empty;
        [Required(ErrorMessage = "Lütfen açıklamayı yazınız")]

        public string Description { get; set; } = string.Empty;
    }
}
