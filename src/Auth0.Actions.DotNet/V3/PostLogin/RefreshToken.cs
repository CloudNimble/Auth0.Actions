using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Auth0.Actions.V3.PostLogin
{

    /// <summary>
    /// [Enterprise Customers] Information about the refresh token for the authentication request.
    /// </summary>
    public record RefreshToken
    {

        #region Properties

        /// <summary>
        /// The resource server identifiers the refresh token is valid for.
        /// </summary>
        [JsonPropertyName("audience")]
        public List<string>? Audience { get; set; }

        /// <summary>
        /// The expiration time of the refresh token in seconds.
        /// </summary>
        [JsonPropertyName("expires_at")]
        public long? ExpiresAt { get; set; }

        /// <summary>
        /// The unique identifier of the refresh token.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Idle timeout for the refresh token in seconds.
        /// </summary>
        [JsonPropertyName("idle_expires_at")]
        public long? IdleExpiresAt { get; set; }

        /// <summary>
        /// The maximum number of times the refresh token can be used.
        /// </summary>
        [JsonPropertyName("max_uses")]
        public int? MaxUses { get; set; }

        /// <summary>
        /// Whether the refresh token rotates on use.
        /// </summary>
        [JsonPropertyName("rotate")]
        public bool? Rotate { get; set; }

        /// <summary>
        /// The scopes granted to the refresh token.
        /// </summary>
        [JsonPropertyName("scopes")]
        public List<string>? Scopes { get; set; }

        /// <summary>
        /// The number of times the refresh token has been used.
        /// </summary>
        [JsonPropertyName("use_count")]
        public int? UseCount { get; set; }

        #endregion

    }

}
