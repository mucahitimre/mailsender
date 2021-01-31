namespace MailSender.Senders
{
    /// <summary>
    /// gmail setting
    /// </summary>
    public class GMailSetting : IMailSetting
    {
        /// <summary>
        /// The host 
        /// </summary>
        public string Host => "smtp.gmail.com";

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