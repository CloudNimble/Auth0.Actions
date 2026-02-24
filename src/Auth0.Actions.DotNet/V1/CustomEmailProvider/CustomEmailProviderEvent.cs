using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Auth0.Actions.V1.CustomEmailProvider
{

    /// <summary>
    /// Triggered when Auth0 needs to send an email, allowing integration with a custom
    /// third-party email delivery provider.
    /// </summary>
    /// <typeparam name="TSecret">The type used to represent the secrets dictionary configured for this action.</typeparam>
    /// <remarks>CustomEmailProviderEvent V1 - Allows replacing the default Auth0 email provider with a custom integration.</remarks>
    public record CustomEmailProviderEvent<TSecret>
        where TSecret : class
    {

        #region Properties

        /// <summary>
        /// Configuration values provided to the action at deployment time.
        /// </summary>
        [JsonPropertyName("configuration")]
        public Dictionary<string, JsonElement>? Configuration { get; set; }

        /// <summary>
        /// The email content to be delivered, including subject, body, and template information.
        /// </summary>
        [JsonPropertyName("email")]
        public EmailContent? Email { get; set; }

        /// <summary>
        /// The intended recipient of the email, including their email address and user ID.
        /// </summary>
        [JsonPropertyName("recipient")]
        public EmailRecipient? Recipient { get; set; }

        /// <summary>
        /// Secret values configured for this action, such as API keys or passwords.
        /// </summary>
        [JsonPropertyName("secrets")]
        public TSecret? Secrets { get; set; }

        /// <summary>
        /// Information about the Auth0 tenant processing the request.
        /// </summary>
        [JsonPropertyName("tenant")]
        public Auth0.Actions.Tenant? Tenant { get; set; }

        #endregion

    }

}
