using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace Model
{
    public abstract class Email : Model
    {
        //Sends an email to a user requesting a new password
        public static void emailPassword(string Email,string User,string Password)
        { 
            var fromAddress = new MailAddress("testing69php@gmail.com", "NoDesk Support");
            var toAddress = new MailAddress(Email, User);
            const string fromPassword = "phpisheelleuk12";
            const string subject = "New Password for your account";
            string body = "Hello, we've updated your noDesk password to: " + Password + "."; 

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
    }
}
