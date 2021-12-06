namespace MailSender.Senders
{
    /// <summary>
    /// The yandex setting
    /// </summary>
    public class YandexSetting : IMailSetting
    {
        /// <summary>
        /// The host 
        /// </summary>
        public string Host => "smtp.yandex.com";

        /// <summary>
        /// the port
        /// </summary>
        public int Port => 465;

        /// <summary>
        /// The enable ssl
        /// </summary>
        public bool EnableSsl => true;
    }
}