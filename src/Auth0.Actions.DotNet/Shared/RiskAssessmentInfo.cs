using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// A summary of risk assessments obtained during the login or password reset flow.
    /// </summary>
    public record RiskAssessmentSummary
    {

        #region Properties

        /// <summary>
        /// The individual risk assessment results.
        /// </summary>
        [JsonPropertyName("assessments")]
        public RiskAssessments Assessments { get; set; }

        /// <summary>
        /// The overall risk confidence score.
        /// </summary>
        /// <remarks>
        /// Possible values: 'low', 'medium', 'high', 'neutral'.
        /// </remarks>
        [JsonPropertyName("confidence")]
        public string Confidence { get; set; }

        /// <summary>
        /// The version of the risk assessment engine used.
        /// </summary>
        [JsonPropertyName("version")]
        public string Version { get; set; }

        #endregion

    }

}
