using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// Details about a device from the NewDevice risk assessment.
    /// </summary>
    public record NewDeviceDetails
    {

        #region Properties

        /// <summary>
        /// The device status ('known' or 'unknown').
        /// </summary>
        [JsonPropertyName("device")]
        public string Device { get; set; }

        /// <summary>
        /// The user-agent status ('known' or 'unknown').
        /// </summary>
        [JsonPropertyName("useragent")]
        public string UserAgent { get; set; }

        #endregion

    }

}
