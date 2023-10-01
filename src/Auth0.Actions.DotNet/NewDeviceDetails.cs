using System.Text.Json.Serialization;
/// <summary>
/// 
/// </summary>
public record NewDeviceDetails
{

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("device")]
        public string Device { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("useragent")]
        public string UserAgent { get; set; }

}