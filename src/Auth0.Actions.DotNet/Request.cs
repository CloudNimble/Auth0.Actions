using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// 
    /// </summary>
    public record Request
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("body")]
        public dynamic Body { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("geoip")]
        public GeoIP GeoIP { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("hostname")]
        public string HostName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("ip")]
        public string IpAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("method")]
        public string Method { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("query")]
        public Query Query { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("user_agent")]
        public string UserAgent { get; set; }

    }

}
