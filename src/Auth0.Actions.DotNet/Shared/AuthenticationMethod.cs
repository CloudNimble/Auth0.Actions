using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// Represents an authentication method a user has completed during their session.
    /// </summary>
    public record AuthenticationMethod
    {

        #region Properties

        /// <summary>
        /// The name of the first factor that was completed.
        /// </summary>
        /// <remarks>
        /// Possible values are: 'federated', 'passkey', 'pwd', 'sms', 'email', 'mfa', 'mock', or a custom URL.
        /// </remarks>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The timestamp indicating when the authentication method was completed.
        /// </summary>
        [JsonPropertyName("timestamp")]
        public string Timestamp { get; set; }

        /// <summary>
        /// A specific MFA factor. Only present when name is set to 'mfa'.
        /// </summary>
        /// <remarks>
        /// Possible values include: 'email', 'otp', 'push-notification', 'recovery-code', 'phone',
        /// 'webauthn-roaming', 'webauthn-platform'.
        /// </remarks>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        #endregion

    }

}
