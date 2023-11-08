using AutoMapper;
using HotelProject.DtoLayer.DTOs.RoomDto;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.WebApiConsume.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDto, Room>().ReverseMap();
            CreateMap<RoomUpdateDto, Room>().ReverseMap();

        }
    }
}
