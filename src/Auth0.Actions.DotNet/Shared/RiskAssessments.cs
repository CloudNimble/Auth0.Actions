using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// Contains the individual risk assessment results for different risk categories.
    /// </summary>
    public record RiskAssessments
    {

        #region Properties

        /// <summary>
        /// Determines if the user is logging in from a location that signals impossible travel from their last login.
        /// </summary>
        [JsonPropertyName("ImpossibleTravel")]
        public RiskAssessmentBase ImpossibleTravel { get; set; }

        /// <summary>
        /// Determines if the user is logging in from a known or unknown device.
        /// </summary>
        [JsonPropertyName("NewDevice")]
        public RiskAssessmentWithDetails<NewDeviceDetails> NewDevice { get; set; }

        /// <summary>
        /// Shows if the IP address was found in Auth0's repository of low reputation IP addresses.
        /// </summary>
        [JsonPropertyName("UntrustedIP")]
        public RiskAssessmentWithDetails<IPAddressDetails> UntrustedIP { get; set; }

        #endregion

    }

}
