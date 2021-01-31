namespace MailSender.Senders
{
    /// <summary>
    /// outlook setting
    /// </summary>
    public class OutlookSetting : IMailSetting
    {
        /// <summary>
        /// The host 
        /// </summary>
        public string Host => "smtp-mail.outlook.com";

        /// <summary>
        /// the port
        /// </summary>
        public int Port => 587;

        /// <summary>
        /// The enable ssl
        /// </summary>
        public bool EnableSsl => true;
    }
}