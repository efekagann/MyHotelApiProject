using System.ComponentModel.DataAnnotations;

namespace HotelProject.DtoLayer.DTOs.RoomDto
{
    public class RoomAddDto
    {
        [Required(ErrorMessage = "Lütfen oda numarasını yazınız")]
        public string RoomNumber { get; set; } = string.Empty;
        public string RoomCoverImage { get; set; } = string.Empty;
        [Required(ErrorMessage = "Lütfen fiyat bilgisini giriniz")]
        public int Price { get; set; } = default;
        public string Title { get; set; } = string.Empty;
        [Required(ErrorMessage = "Lütfen yatak sayısı bilgisini giriniz")]
        public string BedCount { get; set; } = string.Empty;
        [Required(ErrorMessage = "Lütfen banyo sayısı bilgisini giriniz")]
        public string BathCount { get; set; } = string.Empty;
        public string Wifi { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
