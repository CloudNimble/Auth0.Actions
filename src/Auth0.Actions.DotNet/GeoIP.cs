using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// 
    /// </summary>
    public record GeoIP
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("continent_code")]
        public string ContinentCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("country_name")]
        public string CountryName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("latitude")]
        public float Latitude { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("longitude")]
        public float Longitude { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("subdivisionCode")]
        public string SubdivisionCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("subdivisionName")]
        public string SubdivisionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("country_code3")]
        public string ThreeLetterCountryCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("time_zone")]
        public string TimeZone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("country_code")]
        public string TwoLetterCountryCode { get; set; }

    }

}
