using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// Information about the access token to be issued.
    /// </summary>
    public record AccessToken
    {

        #region Properties

        /// <summary>
        /// Custom claims to be added to the access token.
        /// </summary>
        [JsonPropertyName("customClaims")]
        public Dictionary<string, JsonElement>? CustomClaims { get; set; }

        /// <summary>
        /// The scopes included in the access token.
        /// </summary>
        [JsonPropertyName("scope")]
        public List<string> Scopes { get; set; } = [];

        #endregion

    }

}
