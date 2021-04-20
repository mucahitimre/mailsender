# mailsender
c# basic fluent mail sender

```cs
internal class Program
{
    private static void Main()
    {
        Mail.Setting<MailSettingProvider>(w => w.GMailSetting)
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
```
