namespace HotelProject.WebUI.DTOs.RoomDto
{
    public class ResultRoomDto
    {
        public int RoomId { get; set; }
        public string RoomNumber { get; set; } = string.Empty;
        public string RoomCoverImage { get; set; } = string.Empty;
        public int Price { get; set; } = default;
        public string Title { get; set; } = string.Empty;
        public string BedCount { get; set; } = string.Empty;
        public string BathCount { get; set; } = string.Empty;
        public string Wifi { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
