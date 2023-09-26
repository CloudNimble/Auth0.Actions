using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// 
    /// </summary>
    public record RiskAssessmentInfo
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("confidence")]
        public string Confidence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("version")]
        public string Version { get; set; }
    }

}
