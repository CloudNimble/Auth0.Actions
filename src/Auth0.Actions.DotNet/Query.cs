using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// 
    /// </summary>
    public record Query
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("audience")]
        public string Audience { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("code_challenge")]
        public string CodeChallenge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("code_challenge_method")]
        public string CodeChallengeMethod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("prompt")]
        public string Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("redirect_uri")]
        public string RedirectUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("response_mode")]
        public string ResponseMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("response_type")]
        public string ResponseType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("scope")]
        public string Scope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }

    }

}
