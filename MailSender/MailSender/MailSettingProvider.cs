namespace MailSender
{
    /// <summary>
    /// The mail setting provider
    /// </summary>
    public class MailSettingProvider
    {
        /// <summary>
        /// Initializes the <see cref="MailSettingProvider"/> class.
        /// </summary>
        public MailSettingProvider()
        {
            GMailSetting = new MailSetting
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true
            };

            OutlookSetting = new MailSetting
            {
                Host = "smtp-mail.outlook.com",
                Port = 587,
                EnableSsl = true
            };
        }

        /// <summary>
        /// Gets or sets the g mail setting.
        /// </summary>
        /// <value>
        /// The g mail setting.
        /// </value>
        public MailSetting GMailSetting { get; set; }

        /// <summary>
        /// Gets or sets the outlook setting.
        /// </summary>
        /// <value>
        /// The outlook setting.
        /// </value>
        public MailSetting OutlookSetting { get; set; }
    }
}