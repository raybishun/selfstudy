using Microsoft.AspNetCore.Identity.UI.Services;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETCoreIdentityDemo.Services
{
    public class EmailSenderService : IEmailSender
    {
        private string _userName;
        private string _apikey;

        public EmailSenderService(string userName, string apiKey)
        {
            _userName = userName;
            _apikey = apiKey;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var client = new SendGridClient(_apikey);

            var message = new SendGridMessage 
            { 
                From = new EmailAddress("info@example.com", _userName),
                Subject = subject,
                HtmlContent = htmlMessage
            };

            message.AddTo(new EmailAddress(email));

            return client.SendEmailAsync(message);
        }
    }
}
