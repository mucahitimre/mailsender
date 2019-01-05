using System;

namespace MailSender
{
    /// <summary>
    /// The mail
    /// </summary>
    public static class Mail
    {
        /// <summary>
        /// Settings the specified mail setting.
        /// </summary>
        /// <param name="mailSetting">The mail setting.</param>
        /// <returns></returns>
        public static MailSenderBuilder Setting(MailSetting mailSetting)
        {
            return new MailSenderBuilder(mailSetting);
        }

        public static MailSenderBuilder Setting<TProvider>(Func<TProvider, MailSetting> mailSetting)
        {
            var instance = Activator.CreateInstance<TProvider>();

            return new MailSenderBuilder(mailSetting.Invoke(instance));
        }
    }
}