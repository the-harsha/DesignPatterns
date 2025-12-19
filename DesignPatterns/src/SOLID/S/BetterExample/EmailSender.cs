using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.src.SOLID.S.BetterExample
{
    public class EmailSender
    {
        public void SendEmail(string message, string recipient)
        {
            // Email sending logic
            Console.WriteLine($"Sending email to {recipient}: {message}");
        }
    }
}
