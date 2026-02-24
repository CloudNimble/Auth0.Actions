using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// Contains information from an identity provider used by the user, including linked accounts.
    /// </summary>
    public record Identity
    {

        #region Properties

        /// <summary>
        /// The access token returned by the identity provider.
        /// </summary>
        [JsonPropertyName("accessToken")]
        public string AccessToken { get; set; }

        /// <summary>
        /// The unique identifier for the user from this specific identity provider connection.
        /// </summary>
        [JsonPropertyName("userId")]
        public string AlternateUserId { get; set; }

        /// <summary>
        /// The name of the Auth0 connection used for this identity.
        /// </summary>
        [JsonPropertyName("connection")]
        public string Connection { get; set; }

        /// <summary>
        /// Indicates whether the connection is a social identity provider.
        /// </summary>
        [JsonPropertyName("isSocial")]
        public bool IsSocial { get; set; }

        /// <summary>
        /// The name of the entity that is authenticating the user (e.g., Facebook, Google, SAML).
        /// </summary>
        [JsonPropertyName("provider")]
        public string Provider { get; set; }

        /// <summary>
        /// The user's unique identifier for this connection/provider.
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        #endregion

    }

}
