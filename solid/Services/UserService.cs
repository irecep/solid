using solid.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace solid.Services
{
    //srp
    public class UserService
    {
        private SmtpClient _smtpClient;

        public UserService()
        {
        }

        public void Register(string email, string password)
        {
            if (!ValidateEmail(email))
                throw new ValidationException("Email is not an email");

            var user = new User(email, password);

            SendEmail(new MailMessage("dummy@email.com", email) { Subject = "HEllo foo" });
        }

        public virtual bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }

        public bool SendEmail(MailMessage message)
        {
            _smtpClient.Send(message);
            return true;
        }
    }
}
