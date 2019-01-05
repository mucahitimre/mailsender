using System.Collections.Generic;

namespace MailSender
{
    /// <summary>
    /// The mail sender
    /// </summary>
    public class MailSender
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MailSender"/> class.
        /// </summary>
        public MailSender()
        {
            ToList = new List<string>();
            MailSetting = new MailSetting();
            MailCredential = new MailCredential();
        }

        /// <summary>
        /// Gets or sets to list.
        /// </summary>
        /// <value>
        /// To list.
        /// </value>
        public List<string> ToList { get; set; }

        /// <summary>
        /// Gets or sets from.
        /// </summary>
        /// <value>
        /// From.
        /// </value>
        public string From { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is default from.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is default from; otherwise, <c>false</c>.
        /// </value>
        public bool IsDefaultFrom { get; set; }

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        /// <value>
        /// The display name.
        /// </value>
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the subject.
        /// </summary>
        /// <value>
        /// The subject.
        /// </value>
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the body.
        /// </summary>
        /// <value>
        /// The body.
        /// </value>
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is body HTML.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is body HTML; otherwise, <c>false</c>.
        /// </value>
        public bool IsBodyHtml { get; set; }

        /// <summary>
        /// Gets or sets the mail setting.
        /// </summary>
        /// <value>
        /// The mail setting.
        /// </value>
        public MailSetting MailSetting { get; set; }

        /// <summary>
        /// Gets or sets the mail credential.
        /// </summary>
        /// <value>
        /// The mail credential.
        /// </value>
        public MailCredential MailCredential { get; set; }
    }
}