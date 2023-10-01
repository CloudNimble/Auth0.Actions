using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// 
    /// </summary>
    public record AuthorizationInfo
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("roles")]
        public List<string> Roles { get; set; } = new();

    }

}
