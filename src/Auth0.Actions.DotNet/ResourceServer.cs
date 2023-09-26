using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// 
    /// </summary>
    public record ResourceServer
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("identifier")]
        public string Identifier { get; set; }

    }

}
