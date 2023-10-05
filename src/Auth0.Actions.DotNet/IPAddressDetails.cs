using System.Text.Json.Serialization;

namespace Auth0.Actions
{
    /// <summary>
    /// 
    /// </summary>
    public record IPAddressDetails
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("category")]
        public string Category { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("ip")]
        public string IPAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("matches")]
        public string Matches { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }


    }

}


