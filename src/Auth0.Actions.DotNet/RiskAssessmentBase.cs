using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// 
    /// </summary>
    public record RiskAssessmentBase
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

                /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("confidence")]
        public string Confidence { get; set; }

    }

}
