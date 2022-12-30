using AutoMapper;
using LANMessanger.Server.Models;
using LANMessenger.Shared.Models;
namespace LANMessenger.Server.AutoMapper
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile() 
        {
            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();
        }
    }
}
