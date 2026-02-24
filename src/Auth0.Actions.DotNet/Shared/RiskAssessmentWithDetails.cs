using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// A risk assessment that includes additional detail information beyond the base code and confidence.
    /// </summary>
    /// <typeparam name="TDetails">The type containing the specific detail properties for this risk assessment.</typeparam>
    public record RiskAssessmentWithDetails<TDetails> : RiskAssessmentBase
    {

        #region Properties

        /// <summary>
        /// Additional details specific to this risk assessment type.
        /// </summary>
        [JsonPropertyName("details")]
        public TDetails Details { get; set; }

        #endregion

    }

}
