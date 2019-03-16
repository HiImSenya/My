using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace ConsoleApp6
{
    class Email
    {
        public void Confirm(Customer customer)
        {
            var fromAddress = new MailAddress("hiimsenya@gmail.com");
            var fromPassword = "Arseni4e4en";
            var toAddress = new MailAddress(customer.Email);

            string subject = "Подтверждение";
            string body = ("Ваш код для подтверждения: 3451");


            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)

            };

            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })


                smtp.Send(message);

        }
    }
}
