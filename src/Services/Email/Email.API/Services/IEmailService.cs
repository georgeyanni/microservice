using Email.API.Dtos;

namespace Email.API.Services
{
    public interface IEmailService
    {
        bool SendEmailMessage(ProductMessageDto product);
    }
}
