using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.src.SOLID.S.BetterExample
{
    public class UserService
    {
        public void RegisterUser(User user)
        {
            EmailSender emailSender = new EmailSender();
            emailSender.SendEmail("Welcome to our platform!", user.Email);
        }
    }
}
