using AutoMapper;
using LANMessanger.Server.Models;
using LANMessenger.Shared.Models;
namespace LANMessenger.Server.AutoMapper
{
    public class MessageMappingProfile : Profile
    {
        public MessageMappingProfile()
        {
            CreateMap<Message, MessageDTO>();
            CreateMap<MessageDTO, Message>();
        }
    }
}
