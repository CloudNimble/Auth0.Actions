using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// Details about an IP address from the UntrustedIP risk assessment, including its reputation information.
    /// </summary>
    public record IPAddressDetails
    {

        #region Properties

        /// <summary>
        /// The category of the IP address reputation match.
        /// </summary>
        [JsonPropertyName("category")]
        public string Category { get; set; }

        /// <summary>
        /// The IP address that was assessed.
        /// </summary>
        [JsonPropertyName("ip")]
        public string IPAddress { get; set; }

        /// <summary>
        /// The type of match found in the reputation database.
        /// </summary>
        [JsonPropertyName("matches")]
        public string Matches { get; set; }

        /// <summary>
        /// The source of the IP reputation data.
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        #endregion

    }

}
