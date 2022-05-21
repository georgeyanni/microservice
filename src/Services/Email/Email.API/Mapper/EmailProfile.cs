using AutoMapper;
using Email.API.Dtos;
using EventBus.Messages.Events;

namespace Email.API.Mapper
{
    public class EmailProfile:Profile
    {
        public EmailProfile()
        {
            CreateMap<ProductMessageDto,ProductAddEvent>().ReverseMap();
        }
    }
}
