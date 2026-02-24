using System.Text.Json.Serialization;

namespace Auth0.Actions.V3.PostLogin
{

    /// <summary>
    /// Token used for transferring sessions between native and web applications (Native-to-Web SSO).
    /// </summary>
    public record SessionTransferToken
    {

        #region Properties

        /// <summary>
        /// When the session transfer token expires (Unix timestamp).
        /// </summary>
        [JsonPropertyName("expires_at")]
        public long? ExpiresAt { get; set; }

        /// <summary>
        /// The session transfer token value.
        /// </summary>
        [JsonPropertyName("token")]
        public string? Token { get; set; }

        #endregion

    }

}
