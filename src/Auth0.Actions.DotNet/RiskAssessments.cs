using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// 
    /// </summary>
    public record RiskAssessments
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("ImpossibleTravel")]
        public RiskAssessmentBase ImpossibleTravel { get; set; }

                /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("NewDevice")]
        public RiskAssessmentWithDetails<NewDeviceDetails> NewDevice { get; set; }

                /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("UntrustedIP")]
        public RiskAssessmentWithDetails<IPAddressDetails> UntrustedIP { get; set; }

    }

}
