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
        public static MailSenderBuilder Setting(IMailSetting mailSetting)
        {
            return new MailSenderBuilder(mailSetting);
        }

        /// <summary>
        /// Settings the specified mail setting.
        /// </summary>
        /// <typeparam name="TSetting"></typeparam>
        /// <returns></returns>
        public static MailSenderBuilder Setting<TSetting>()
            where TSetting : IMailSetting, new()
        {
            var instance = (IMailSetting)Activator.CreateInstance<TSetting>();

            return new MailSenderBuilder(instance);
        }
    }
}