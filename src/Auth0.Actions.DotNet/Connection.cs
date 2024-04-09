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
        /// The connection's identifier
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Metadata associated with the connection in the form of an object with string values (max 255 chars).
        /// </summary>
        /// <remarks>Maximum of 10 metadata properties allowed.</remarks>
        [JsonPropertyName("metadata")]
        public Dictionary<string, object> Metadata { get; set; } = new();

        /// <summary>
        /// The name of the connection
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The type of the connection, related to the identity provider
        /// </summary>
        [JsonPropertyName("strategy")]
        public ConnectionStrategies Strategy { get; set; }

    }

}
