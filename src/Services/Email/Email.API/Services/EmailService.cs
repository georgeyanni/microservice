using Email.API.Dtos;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace Email.API.Services
{
    public class EmailService:IEmailService
    {

        private readonly ILogger<EmailService> _logger;
      
        public EmailService(ILogger<EmailService> logger)
        {
            _logger = logger;
        }
        public bool SendEmailMessage(ProductMessageDto product)
        {
            
            try
            {
                var mail = new MailMessage { From = new MailAddress(Configuration.SmtpSettings.FromAddress, Configuration.SmtpSettings.FromDisplayName) };
                mail.To.Add(new MailAddress(Configuration.SmtpSettings.ToAddress));
                

                mail.Subject = "New Product Has Added";
                mail.SubjectEncoding = System.Text.Encoding.UTF8;
                mail.Body = @$"Their is a new product has added <br/>
                            id: { product.Id} <br/>
                            name: { product.Name }<br/>
                            price: { product.Price }";

                mail.BodyEncoding = System.Text.Encoding.UTF8;
                mail.IsBodyHtml = Configuration.SmtpSettings.IsHtml;

                using var client = new SmtpClient(Configuration.SmtpSettings.Host, Configuration.SmtpSettings.Port)
                {
                    UseDefaultCredentials = false,
                    Credentials = new System.Net.NetworkCredential(Configuration.SmtpSettings.UserName, Configuration.SmtpSettings.Password),
                    EnableSsl = Configuration.SmtpSettings.EnableSsl,
                    Host = Configuration.SmtpSettings.Host,
                   
                };
                client.Send(message: mail);
                return true;
            }

            catch (Exception ex)
            {
                _logger.LogError(ex.Message);

                return false;
            }
        }

       
    }
}
