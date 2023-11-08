using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.DTOs.AboutDto;
using HotelProject.WebUI.DTOs.LoginDto;
using HotelProject.WebUI.DTOs.RegisterDto;
using HotelProject.WebUI.DTOs.ServiceDto;
using HotelProject.WebUI.DTOs.StaffDto;
using HotelProject.WebUI.DTOs.SubscribeDto;
using HotelProject.WebUI.DTOs.TestimonialDto;

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
            CreateMap<LoginUserDto, AppUser>().ReverseMap();


            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();


            CreateMap<ResultTestimonialDto, Testimonial>().ReverseMap();
            CreateMap<ResultStaffDto, Staff>().ReverseMap();

            CreateMap<ResultSubscribeDto, Subscribe>().ReverseMap();
            CreateMap<CreateSubscribeDto, Subscribe>().ReverseMap();


        }
    }
}
