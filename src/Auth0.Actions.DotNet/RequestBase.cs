using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// Details about the request that initiated the transaction.
    /// </summary>
    /// <typeparam name="TBody"></typeparam>
    public record RequestBase<TBody>
        where TBody : class
    {

        /// <summary>
        /// The body of the POST request.
        /// </summary>
        /// <remarks>
        /// This data will only be available during refresh token, Client Credential Exchange flows, and PreUserRegistration actions.
        /// </remarks>
        [JsonPropertyName("body")]
        public TBody Body { get; set; }

        /// <summary>
        /// Contains geographical information about the request.
        /// </summary>
        [JsonPropertyName("geoip")]
        public GeoIP GeoIP { get; set; }

        /// <summary>
        /// The hostname that is being used for the authentication flow.
        /// </summary>
        [JsonPropertyName("hostname")]
        public string HostName { get; set; }

        /// <summary>
        /// The originating IP address of the request.
        /// </summary>
        [JsonPropertyName("ip")]
        public string IpAddress { get; set; }

        /// <summary>
        /// The language requested by the browser.
        /// </summary>
        [JsonPropertyName("language")]
        public string Language { get; set; }

        /// <summary>
        /// The HTTP method used for the request.
        /// </summary>
        [JsonPropertyName("method")]
        public string Method { get; set; }

        /// <summary>
        /// The value of the User-Agent header received when initiating the transaction.
        /// </summary>
        [JsonPropertyName("user_agent")]
        public string UserAgent { get; set; }

    }
}