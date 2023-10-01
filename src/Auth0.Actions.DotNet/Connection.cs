using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// 
    /// </summary>
    public record Connection
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, object> Metadata { get; set; } = new();

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("strategy")]
        public string Strategy { get; set; }

    }

}
