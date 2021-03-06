﻿using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace LawyerApp.Infrastructures
{
    public class EmailService
    {
        private readonly EmailServiceOption _option;

        public EmailService(IOptions<EmailServiceOption> options)
        {
            _option = options.Value;
        }

        public async Task SendMailAsync(string toEmail, string subject, string message)
        {
            using (MailMessage msg = new MailMessage())
            {
                using (SmtpClient connect = new SmtpClient(_option.Host,_option.Port))
                {
                    msg.From = new MailAddress(_option.Email, _option.DisplayName, System.Text.Encoding.UTF8);
                    msg.To.Add(toEmail);
                    msg.Subject = subject;
                    msg.Body = message;
                    connect.Credentials = new NetworkCredential(_option.Email, _option.Password);
                    connect.EnableSsl = _option.EnableSSL;
                    await connect.SendMailAsync(msg);
                }
            }
        }
    }

    public class EmailServiceOption
    {
        public string DisplayName { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }

        public string Host { get; set; }

        public int Port { get; set; }

        public bool EnableSSL { get; set; }
    }
}
