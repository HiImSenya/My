using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace ConsoleApp6
{
    class Informer
    {
        public void Buy(Customer customer,Product product)
        {
            double price = product.GetDiscountPrice(customer);
            customer.ReduceBalance(price);

            var fromAddress = new MailAddress("hiimsenya@gmail.com");
            var fromPassword = "Arseni4e4en";
            var toAddress = new MailAddress("shiirsky@gmail.com");

            string subject = "subject";
            string body = ($"{customer.Name} купил {product.Name} за {price}. Заказ отправлен на склад");


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


             fromAddress = new MailAddress("hiimsenya@gmail.com");
             fromPassword = "Arseni4e4en";
             toAddress = new MailAddress(customer.Email);

             subject = "subject";
             body = ($"Вы купили {product.Name} за {price}.Ваш заказ отправлен на склад");


            System.Net.Mail.SmtpClient smtpk = new System.Net.Mail.SmtpClient
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


                smtpk.Send(message);


        }
    }
}
