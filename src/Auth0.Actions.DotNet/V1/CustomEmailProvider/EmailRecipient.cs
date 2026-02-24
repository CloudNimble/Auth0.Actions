using System.Text.Json.Serialization;

namespace Auth0.Actions.V1.CustomEmailProvider
{

    /// <summary>
    /// Contains information about the intended recipient of the email.
    /// </summary>
    public record EmailRecipient
    {

        #region Properties

        /// <summary>
        /// The email address of the recipient.
        /// </summary>
        [JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// The Auth0 user ID of the recipient, if available.
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        #endregion

    }

}
