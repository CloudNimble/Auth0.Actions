using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// Query string parameters sent to the authorization request.
    /// </summary>
    public record Query
    {

        #region Properties

        /// <summary>
        /// The audience (API identifier) for the authorization request.
        /// </summary>
        [JsonPropertyName("audience")]
        public string Audience { get; set; }

        /// <summary>
        /// The client id of the application initiating the request.
        /// </summary>
        [JsonPropertyName("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// The PKCE code challenge value.
        /// </summary>
        [JsonPropertyName("code_challenge")]
        public string CodeChallenge { get; set; }

        /// <summary>
        /// The PKCE code challenge method (e.g., S256).
        /// </summary>
        [JsonPropertyName("code_challenge_method")]
        public string CodeChallengeMethod { get; set; }

        /// <summary>
        /// Instructions indicating whether the user may be prompted for re-authentication and consent.
        /// </summary>
        [JsonPropertyName("prompt")]
        public string Prompt { get; set; }

        /// <summary>
        /// The URL to which Auth0 will redirect the browser after the transaction is completed.
        /// </summary>
        [JsonPropertyName("redirect_uri")]
        public string RedirectUri { get; set; }

        /// <summary>
        /// The mechanism used for returning Authorization Endpoint parameters.
        /// </summary>
        /// <remarks>
        /// Possible values: 'query', 'fragment', 'form_post', 'web_message'.
        /// </remarks>
        [JsonPropertyName("response_mode")]
        public string ResponseMode { get; set; }

        /// <summary>
        /// The response type requested (e.g., 'code', 'token', 'id_token').
        /// </summary>
        [JsonPropertyName("response_type")]
        public string ResponseType { get; set; }

        /// <summary>
        /// The scopes requested in the authorization request.
        /// </summary>
        [JsonPropertyName("scope")]
        public string Scope { get; set; }

        /// <summary>
        /// An opaque, arbitrary alphanumeric string that Auth0 echoes back after redirect.
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }

        #endregion

    }

}
