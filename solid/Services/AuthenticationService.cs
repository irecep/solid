using solid.Models;
using System;
using System.Linq;
using System.Net.Mail;

namespace solid.Services
{
    //oop
    public class AuthenticationService
    {
        private readonly ShoppingContext _shoppingContext;
        private SmtpClient _smtpClient;

        public AuthenticationService(ShoppingContext shoppingContext)
        {
            _shoppingContext = shoppingContext;
        }

        public string Authenticate(string email, string password)
        {
            string status = String.Empty;

            var user = _shoppingContext.User
                .Where(e => e.Email == email && e.Password == password)
                .FirstOrDefault();

            if (user != null)
            {
                if (user.MultiFactorAuthentication == "email")
                {
                    SendEmail(new MailMessage("dummy@email.com", email) { Subject = "HEllo foo" });
                }
            }
            status = "code-sent";
            return status;
        }

        private bool SendEmail(MailMessage message)
        {
            _smtpClient.Send(message);
            return true;
        }
    }
}
