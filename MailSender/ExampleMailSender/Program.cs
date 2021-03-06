﻿using MailSender;
using MailSender.Senders;

namespace ExampleMailSender
{
    internal class Program
    {
        private static void Main()
        {
            Mail.Setting<GMailSetting>()
                //.Credential(new MailCredential("myMail@mail.com","psw")) // Optionally
                .Credential("myMail@mail.com", "psw")
                .Body("html body", true)
                //.From("example@mail.com")  - Optionally
                .From(true) //default Credential mail
                .DisplayName("Example activation mail")
                .Subject("Example activation mail Subject")
                //.To(new List<string>{"mail1@mail.com", "mail2@mail.com" })  - Optionally
                .To("mail@mail.com")
                .Send();
        }
    }
}
