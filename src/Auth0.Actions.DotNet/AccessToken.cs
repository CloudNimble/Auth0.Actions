using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// Information about the access token to be issued.
    /// </summary>
    public record AccessToken
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("customClaims")]
        public dynamic CustomClaims { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("scope")]
        public List<string> Scopes { get; set; } = new();

    }

}
