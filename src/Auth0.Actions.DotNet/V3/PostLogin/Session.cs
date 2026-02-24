using System.Text.Json.Serialization;

namespace Auth0.Actions.V3.PostLogin
{

    /// <summary>
    /// [Enterprise Customers] Session information for the authentication.
    /// </summary>
    public record Session
    {

        #region Properties

        /// <summary>
        /// The authentication methods used in this session.
        /// </summary>
        [JsonPropertyName("authentication_methods")]
        public string[]? AuthenticationMethods { get; set; }

        /// <summary>
        /// When the session was created (Unix timestamp).
        /// </summary>
        [JsonPropertyName("created_at")]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// When the session expires (Unix timestamp).
        /// </summary>
        [JsonPropertyName("expires_at")]
        public long? ExpiresAt { get; set; }

        /// <summary>
        /// The unique identifier of the session.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Idle timeout for the session in seconds.
        /// </summary>
        [JsonPropertyName("idle_expires_at")]
        public long? IdleExpiresAt { get; set; }

        /// <summary>
        /// When the session was last accessed (Unix timestamp).
        /// </summary>
        [JsonPropertyName("last_interacted_at")]
        public long? LastInteractedAt { get; set; }

        #endregion

    }

}
