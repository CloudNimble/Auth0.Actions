using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TBody"></typeparam>
    public record RequestBase<TBody>
        where TBody : class
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("body")]
        public TBody Body { get; set; }

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
        [JsonPropertyName("language")]
        public string Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("method")]
        public string Method { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("user_agent")]
        public string UserAgent { get; set; }
    }
}