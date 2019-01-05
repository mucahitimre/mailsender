namespace MailSender
{
    /// <summary>
    /// The mail setting
    /// </summary>
    public class MailSetting
    {
        /// <summary>
        /// Gets or sets the host.
        /// </summary>
        /// <value>
        /// The host.
        /// </value>
        public string Host { get; set; }

        /// <summary>
        /// Gets or sets the port.
        /// </summary>
        /// <value>
        /// The port.
        /// </value>
        public int Port { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [enable SSL].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [enable SSL]; otherwise, <c>false</c>.
        /// </value>
        public bool EnableSsl { get; set; }
    }
}