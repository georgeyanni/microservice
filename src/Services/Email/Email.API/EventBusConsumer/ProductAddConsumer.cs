using AutoMapper;
using Email.API.Dtos;
using Email.API.Services;
using EventBus.Messages.Events;
using MassTransit;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Email.API.EventBusConsumer
{
    public class ProductAddConsumer : IConsumer<ProductAddEvent>
    {
        private readonly IEmailService _emailService;
        private readonly ILogger<ProductAddConsumer> _logger;
        private readonly IMapper _mapper;

        public ProductAddConsumer(IEmailService emailService, 
            IMapper mapper,
            ILogger<ProductAddConsumer> logger)
        {
            _emailService = emailService;
            _mapper = mapper;
            _logger = logger;

        }
        public async Task Consume(ConsumeContext<ProductAddEvent> context)
        {
           var productMessage=_mapper.Map<ProductMessageDto>(context.Message);
            var result = _emailService.SendEmailMessage(productMessage) ;
            _logger.LogInformation($"ProductAddEvent consumed successfully. IsEmailsent :{result}");
        }
    }
}
