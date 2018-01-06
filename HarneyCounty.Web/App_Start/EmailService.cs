using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;

namespace HarneyCounty.Web.App_Start
{
    public class EmailService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            MailMessage msg = new MailMessage();
            msg.To.Add(new MailAddress(message.Destination, message.Subject));
            msg.From = new MailAddress(ConfigurationManager.AppSettings["supportEmail"], ConfigurationManager.AppSettings["supportEmailpassword"]);
            msg.Subject = "Reset password request";
            msg.Body = message.Body;
            msg.IsBodyHtml = true;
            // Plug in your email service here to send an email.
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            //client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(ConfigurationManager.AppSettings["supportEmail"], ConfigurationManager.AppSettings["supportEmailpassword"]);
            return client.SendMailAsync(msg);
            //return Task.FromResult(0);
        }
    }
}