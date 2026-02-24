using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// The body of the POST request for a credentials exchange (M2M) flow.
    /// </summary>
    public record CredentialsExchangeRequestBody
    {

        #region Properties

        /// <summary>
        /// The audience (API identifier) for which the access token is being requested.
        /// </summary>
        [JsonPropertyName("audience")]
        public string Audience { get; set; }

        /// <summary>
        /// The client id of the application requesting the access token.
        /// </summary>
        [JsonPropertyName("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// The client secret used to authenticate the application.
        /// </summary>
        [JsonPropertyName("client_secret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// The OAuth 2.0 grant type for this request.
        /// </summary>
        [JsonPropertyName("grant_type")]
        public string GrantType { get; set; }

        #endregion

    }

}
