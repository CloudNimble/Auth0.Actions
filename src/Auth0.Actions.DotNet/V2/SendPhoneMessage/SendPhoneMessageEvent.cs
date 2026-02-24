using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Auth0.Actions.V2.SendPhoneMessage
{

    /// <summary>
    /// SendPhoneMessageEvent V2 - Triggered when Auth0 needs to send an SMS or phone message.
    /// Used for custom SMS/phone message providers.
    /// </summary>
    /// <typeparam name="TSecret">The type for the secrets dictionary.</typeparam>
    /// <remarks>
    /// V2 adds user information and tenant details over V1.
    /// </remarks>
    public record SendPhoneMessageEvent<TSecret>
        where TSecret : class
    {

        #region Properties

        /// <summary>
        /// Configuration values provided to the action.
        /// </summary>
        [JsonPropertyName("configuration")]
        public Dictionary<string, JsonElement>? Configuration { get; set; }

        /// <summary>
        /// The message text to be sent to the recipient.
        /// </summary>
        [JsonPropertyName("message_text")]
        public string? MessageText { get; set; }

        /// <summary>
        /// The type of message being sent (e.g., "enrollment", "verification", "second_factor").
        /// </summary>
        [JsonPropertyName("message_type")]
        public string? MessageType { get; set; }

        /// <summary>
        /// The phone number to send the message to.
        /// </summary>
        [JsonPropertyName("recipient")]
        public string? Recipient { get; set; }

        /// <summary>
        /// Secret values configured for this action.
        /// </summary>
        [JsonPropertyName("secrets")]
        public TSecret? Secrets { get; set; }

        /// <summary>
        /// Details about the Auth0 Tenant associated with the current transaction.
        /// </summary>
        [JsonPropertyName("tenant")]
        public Auth0.Actions.Tenant? Tenant { get; set; }

        /// <summary>
        /// Information about the user the message is being sent to, if available.
        /// </summary>
        [JsonPropertyName("user")]
        public Dictionary<string, JsonElement>? User { get; set; }

        #endregion

    }

}
