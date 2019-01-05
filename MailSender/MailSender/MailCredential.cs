﻿namespace MailSender
{
    /// <summary>
    /// The mail credential
    /// </summary>
    public class MailCredential
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MailCredential"/> class.
        /// </summary>
        public MailCredential()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MailCredential"/> class.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="password">The password.</param>
        public MailCredential(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        /// <summary>
        /// Gets the name of the user.
        /// </summary>
        /// <value>
        /// The name of the user.
        /// </value>
        public string UserName { get; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string Password { get; set; }
    }
}