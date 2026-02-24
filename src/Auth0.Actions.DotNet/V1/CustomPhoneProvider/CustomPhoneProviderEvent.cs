using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Auth0.Actions.V1.CustomPhoneProvider
{

    /// <summary>
    /// Triggered when Auth0 needs to send a phone message, allowing integration with a custom
    /// phone/SMS provider for full custom provider integration.
    /// </summary>
    /// <typeparam name="TSecret">The type used to represent the secrets dictionary configured for this action.</typeparam>
    /// <remarks>CustomPhoneProviderEvent V1 - Broader scope than SendPhoneMessage for full custom provider integration.</remarks>
    public record CustomPhoneProviderEvent<TSecret>
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
        [JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// The phone number of the recipient, in E.164 format.
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// The purpose of the message (e.g., "mfa_enrollment", "mfa_verification").
        /// </summary>
        [JsonPropertyName("purpose")]
        public string? Purpose { get; set; }

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
