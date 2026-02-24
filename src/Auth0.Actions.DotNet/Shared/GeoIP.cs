using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// Contains geographical information about the originating request based on IP address geolocation.
    /// </summary>
    public record GeoIP
    {

        #region Properties

        /// <summary>
        /// The name of the city associated with the IP address.
        /// </summary>
        [JsonPropertyName("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// The two-letter continent code (e.g., NA, EU, AS).
        /// </summary>
        [JsonPropertyName("continent_code")]
        public string ContinentCode { get; set; }

        /// <summary>
        /// The full name of the country associated with the IP address.
        /// </summary>
        [JsonPropertyName("country_name")]
        public string CountryName { get; set; }

        /// <summary>
        /// The approximate latitude coordinate of the IP address location.
        /// </summary>
        [JsonPropertyName("latitude")]
        public float Latitude { get; set; }

        /// <summary>
        /// The approximate longitude coordinate of the IP address location.
        /// </summary>
        [JsonPropertyName("longitude")]
        public float Longitude { get; set; }

        /// <summary>
        /// The subdivision (state/province) code for the IP address location.
        /// </summary>
        [JsonPropertyName("subdivisionCode")]
        public string SubdivisionCode { get; set; }

        /// <summary>
        /// The subdivision (state/province) name for the IP address location.
        /// </summary>
        [JsonPropertyName("subdivisionName")]
        public string SubdivisionName { get; set; }

        /// <summary>
        /// The three-letter country code (ISO 3166-1 alpha-3) for the IP address location.
        /// </summary>
        [JsonPropertyName("country_code3")]
        public string ThreeLetterCountryCode { get; set; }

        /// <summary>
        /// The time zone identifier for the IP address location (e.g., America/Los_Angeles).
        /// </summary>
        [JsonPropertyName("time_zone")]
        public string TimeZone { get; set; }

        /// <summary>
        /// The two-letter country code (ISO 3166-1 alpha-2) for the IP address location.
        /// </summary>
        [JsonPropertyName("country_code")]
        public string TwoLetterCountryCode { get; set; }

        #endregion

    }

}
