using Email.API.Dtos;
using Email.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Email.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;
        private readonly ILogger<EmailController> _logger;
       
        public EmailController(IEmailService emailService,ILogger<EmailController> logger)
        {
            _emailService = emailService;
            _logger = logger;
        }


        [HttpPost]
        public ActionResult<bool> SendEmail(ProductMessageDto product)
        {
           
            return _emailService.SendEmailMessage(product);
        }

    }
}
