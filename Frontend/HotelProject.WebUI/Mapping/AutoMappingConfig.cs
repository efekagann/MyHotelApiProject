using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.DTOs.RegisterDto;
using HotelProject.WebUI.DTOs.ServiceDto;

namespace HotelProject.WebUI.Mapping
{
    public class AutoMappingConfig : Profile
    {
        public AutoMappingConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();
            CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
        }
    }
}
