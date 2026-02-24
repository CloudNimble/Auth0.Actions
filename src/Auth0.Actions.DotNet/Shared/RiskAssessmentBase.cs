using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// Base risk assessment information containing a code and confidence level.
    /// </summary>
    public record RiskAssessmentBase
    {

        #region Properties

        /// <summary>
        /// The risk assessment result code indicating the specific finding.
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// The confidence level of the risk assessment.
        /// </summary>
        /// <remarks>
        /// Possible values: 'low', 'medium', 'high', 'neutral'.
        /// </remarks>
        [JsonPropertyName("confidence")]
        public string Confidence { get; set; }

        #endregion

    }

}
