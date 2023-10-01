using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// 
    /// </summary>
    public record AuthenticationInfoWithRiskAssessment
    {

        /** Contains the authentication methods a user has completed during their session. */
        [JsonPropertyName("methods")]
        List<AuthenticationMethod> Methods { get; set; } = new();

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("riskAssessment")]
        public RiskAssessmentInfo RiskAssessment { get; set; }

    }

}
