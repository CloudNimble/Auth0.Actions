using System.Text.Json.Serialization;

namespace Auth0.Actions.V1.CustomEmailProvider
{

    /// <summary>
    /// Contains the email content and template information to be delivered by a custom email provider.
    /// </summary>
    public record EmailContent
    {

        #region Properties

        /// <summary>
        /// The HTML or plain-text body content of the email.
        /// </summary>
        [JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        /// The subject line of the email.
        /// </summary>
        [JsonPropertyName("subject")]
        public string? Subject { get; set; }

        /// <summary>
        /// The name of the email template being used, if applicable.
        /// </summary>
        [JsonPropertyName("template")]
        public string? Template { get; set; }

        /// <summary>
        /// The type of email being sent (e.g., "verification", "password_reset", "welcome").
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        #endregion

    }

}
