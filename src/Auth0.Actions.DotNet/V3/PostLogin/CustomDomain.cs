using System.Text.Json.Serialization;

namespace Auth0.Actions.V3.PostLogin
{

    /// <summary>
    /// Information about the custom domain used for the authentication request.
    /// </summary>
    public record CustomDomain
    {

        #region Properties

        /// <summary>
        /// The custom domain where the authentication event occurred.
        /// </summary>
        [JsonPropertyName("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// The custom domain identifier.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Whether this is the primary domain for the tenant.
        /// </summary>
        [JsonPropertyName("primary")]
        public bool? Primary { get; set; }

        /// <summary>
        /// The status of the custom domain (e.g., 'ready', 'pending_verification').
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// The type of custom domain (e.g., 'auth0_managed_certs', 'self_managed_certs').
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        #endregion

    }

}
