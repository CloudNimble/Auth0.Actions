using System.Text.Json.Serialization;

namespace Auth0.Actions.V3.PostLogin
{

    /// <summary>
    /// Information about an MFA factor that a user has enrolled.
    /// </summary>
    public record EnrolledFactor
    {

        #region Properties

        /// <summary>
        /// When the factor was enrolled (ISO 8601 format).
        /// </summary>
        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// When the factor was last used for authentication (ISO 8601 format).
        /// </summary>
        [JsonPropertyName("last_auth")]
        public string? LastAuth { get; set; }

        /// <summary>
        /// The name/label assigned to this factor by the user.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The type of MFA factor (e.g., 'otp', 'sms', 'push-notification', 'email', 'webauthn-roaming', 'webauthn-platform').
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        #endregion

    }

}
