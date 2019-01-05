using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;

namespace MailSender
{
    /// <summary>
    /// The mail sender builder
    /// </summary>
    public class MailSenderBuilder
    {
        /// <summary>
        /// The mail sender
        /// </summary>
        private readonly MailSender _mailSender = new MailSender();

        /// <summary>
        /// Initializes a new instance of the <see cref="MailSenderBuilder"/> class.
        /// </summary>
        /// <param name="mailSetting">The mail setting.</param>
        public MailSenderBuilder(MailSetting mailSetting)
        {
            _mailSender.MailSetting = mailSetting;
        }

        /// <summary>
        /// To the specified mail address.
        /// </summary>
        /// <param name="mail">The mail.</param>
        /// <returns></returns>
        public MailSenderBuilder To(string mail)
        {
            _mailSender.ToList.Add(mail);

            return this;
        }

        /// <summary>
        /// To the specified mail list.
        /// </summary>
        /// <param name="mailList">The mail list.</param>
        /// <returns></returns>
        public MailSenderBuilder To(List<string> mailList)
        {
            _mailSender.ToList.AddRange(mailList);

            return this;
        }

        /// <summary>
        /// From the specified from.
        /// </summary>
        /// <param name="from">From.</param>
        /// <returns></returns>
        public MailSenderBuilder From(string from)
        {
            _mailSender.From = from;

            return this;
        }

        /// <summary>
        /// From the specified is default.
        /// </summary>
        /// <param name="isDefault">if set to <c>true</c> [is default].</param>
        /// <returns></returns>
        public MailSenderBuilder From(bool isDefault = true)
        {
            _mailSender.IsDefaultFrom = isDefault;

            return this;
        }

        /// <summary>
        /// Displays the name.
        /// </summary>
        /// <param name="displayName">The display name.</param>
        /// <returns></returns>
        public MailSenderBuilder DisplayName(string displayName)
        {
            _mailSender.DisplayName = displayName;

            return this;
        }

        /// <summary>
        /// Credentials the specified email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public MailSenderBuilder Credential(string email, string password)
        {
            _mailSender.MailCredential = new MailCredential(email, password);

            return this;
        }

        /// <summary>
        /// Credentials the specified credential.
        /// </summary>
        /// <param name="credential">The credential.</param>
        /// <returns></returns>
        public MailSenderBuilder Credential(MailCredential credential)
        {
            _mailSender.MailCredential = credential;

            return this;
        }

        /// <summary>
        /// Subjects the specified subject.
        /// </summary>
        /// <param name="subject">The subject.</param>
        /// <returns></returns>
        public MailSenderBuilder Subject(string subject)
        {
            _mailSender.Subject = subject;

            return this;
        }

        /// <summary>
        /// Bodies the specified body.
        /// </summary>
        /// <param name="body">The body.</param>
        /// <param name="isBodyHtml">if set to <c>true</c> [is body HTML].</param>
        /// <returns></returns>
        public MailSenderBuilder Body(string body, bool isBodyHtml = false)
        {
            _mailSender.Body = body;
            _mailSender.IsBodyHtml = isBodyHtml;

            return this;
        }

        /// <summary>
        /// Sends the specified is asynchronous.
        /// </summary>
        /// <param name="isAsync">if set to <c>true</c> [is asynchronous].</param>
        public void Send(bool isAsync = false)
        {
            if (_mailSender.IsDefaultFrom)
            {
                _mailSender.From = _mailSender.MailCredential.UserName;
            }

            var address = new MailAddress(_mailSender.From);
            if (!string.IsNullOrEmpty(_mailSender.DisplayName))
            {
                address = new MailAddress(_mailSender.From, _mailSender.DisplayName);
            }

            var message = new MailMessage
            {
                From = address,
                Subject = _mailSender.Subject,
                Body = _mailSender.Body,
                IsBodyHtml = _mailSender.IsBodyHtml
            };

            _mailSender.ToList
                .Select(mailAddress => new MailAddress(mailAddress))
                .ToList()
                .ForEach(mailAddress => { message.To.Add(mailAddress); });

            using (var smtp = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = _mailSender.MailCredential.UserName,
                    Password = _mailSender.MailCredential.Password
                };
                smtp.Credentials = credential;
                smtp.Host = _mailSender.MailSetting.Host;
                smtp.Port = _mailSender.MailSetting.Port;
                smtp.EnableSsl = _mailSender.MailSetting.EnableSsl;
                smtp.Send(message);

                //TODO:
                //await smtp.SendMailAsync(message);
            }
        }
    }
}