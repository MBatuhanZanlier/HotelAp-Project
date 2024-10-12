using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.AboutDto;
using HotelProject.WebUI.Dtos.LoginDto;
using HotelProject.WebUI.Dtos.RegisterDto;
using HotelProject.WebUI.Dtos.RoomDto;
using HotelProject.WebUI.Dtos.ServiceDto;
using HotelProject.WebUI.Dtos.SubscribeDto;

namespace HotelProject.WebUI.Mapping
{
    public class AutoMapperMapping : Profile
    {
        public AutoMapperMapping()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap(); 

            CreateMap<CreateNewUserDto,AppUser>().ReverseMap();
            CreateMap<LoginUserDto,AppUser>().ReverseMap();

            CreateMap<ResultAboutDto, About>().ReverseMap(); 
            CreateMap<UpdateAboutDto, About>().ReverseMap();    

            CreateMap<ResultRoomDto, Room>().ReverseMap();  
            
            
            CreateMap<CreateSubscribeDto,Subscribe>().ReverseMap();  
        }
    }
}
