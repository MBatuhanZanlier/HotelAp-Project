using AutoMapper;
using HotelProject.DtoLayer.Room;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.WebApi.Mapping
{
    public class AutoMapperConfing:Profile
    {
        public AutoMapperConfing()
        {
            CreateMap<RoomAddDto,Room>().ReverseMap(); 
            CreateMap<UpdateRoomDto,Room>().ReverseMap();   
        }
    }
}
