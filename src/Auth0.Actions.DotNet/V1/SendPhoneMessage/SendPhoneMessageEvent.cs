using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Auth0.Actions.V1.SendPhoneMessage
{

    /// <summary>
    /// Triggered when Auth0 needs to send an SMS or phone message, allowing customization
    /// of the SMS provider or message content.
    /// </summary>
    /// <typeparam name="TSecret">The type used to represent the secrets dictionary configured for this action.</typeparam>
    /// <remarks>SendPhoneMessageEvent V1 - Allows customization of SMS provider or message content.</remarks>
    public record SendPhoneMessageEvent<TSecret>
        where TSecret : class
    {

        #region Properties

        /// <summary>
        /// Configuration values provided to the action at deployment time.
        /// </summary>
        [JsonPropertyName("configuration")]
        public Dictionary<string, JsonElement>? Configuration { get; set; }

        /// <summary>
        /// The message text to be sent to the recipient.
        /// </summary>
        [JsonPropertyName("message_text")]
        public string? MessageText { get; set; }

        /// <summary>
        /// The type of message being sent (e.g., "enrollment", "verification").
        /// </summary>
        [JsonPropertyName("message_type")]
        public string? MessageType { get; set; }

        /// <summary>
        /// The phone number of the recipient, in E.164 format.
        /// </summary>
        [JsonPropertyName("recipient")]
        public string? Recipient { get; set; }

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
