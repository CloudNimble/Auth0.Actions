using System.Text.Json.Serialization;

namespace Auth0.Actions.V3.PostLogin
{

    /// <summary>
    /// An object containing fingerprint signatures; available only when traffic is handled through Auth0 Edge.
    /// </summary>
    public record SecurityContext
    {

        #region Properties

        /// <summary>
        /// JA3 fingerprint signature. Only available if the client is using a TLS connection.
        /// </summary>
        [JsonPropertyName("ja3")]
        public string? JA3 { get; set; }

        /// <summary>
        /// JA4 fingerprint signature. Only available if the client is using a TLS connection.
        /// </summary>
        [JsonPropertyName("ja4")]
        public string? JA4 { get; set; }

        #endregion

    }

}
