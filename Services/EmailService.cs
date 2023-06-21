﻿using System.Net;
using System.Net.Mail;

namespace Blog.Services {
    public class EmailService {
        public bool Send(
            string toName,
            string toEmail,
            string subject,
            string body,
            string fromName = "Equipe balta.io",
            string fromEmail = "email@balta.io")
        {
            var smtpClient = new SmtpClient(Configuration.Smpt.Host, Configuration.Smpt.Port);

            smtpClient.Credentials = new NetworkCredential(Configuration.Smpt.UserName, Configuration.Smpt.Password);
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            //smtpClient.UseDefaultCredentials = false;
            smtpClient.EnableSsl = true;

            var mail = new MailMessage();

            mail.From = new MailAddress(fromEmail, fromName);
            mail.To.Add(new MailAddress(toEmail, toName));
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;

            try {
                smtpClient.Send(mail);
                return true;
            }
            catch {
                return false;
            }
        }
    }
}
