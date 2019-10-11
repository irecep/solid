using System;
namespace solid.Models
{
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string MultiFactorAuthentication { get; set; }
        public string PhoneNumber { get; set; }

        public User(string email, string password)
        {

        }
    }
}
