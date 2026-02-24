using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// Details about authentication signals obtained during the login flow.
    /// </summary>
    public record AuthenticationInfoWithRiskAssessment
    {

        #region Properties

        /// <summary>
        /// Contains the authentication methods a user has completed during their session.
        /// </summary>
        [JsonPropertyName("methods")]
        public List<AuthenticationMethod> Methods { get; set; } = [];

        /// <summary>
        /// Risk assessments obtained during the login or password reset flow.
        /// </summary>
        [JsonPropertyName("riskAssessment")]
        public RiskAssessmentSummary RiskAssessment { get; set; }

        #endregion

    }

}
