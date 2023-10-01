using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TDetails"></typeparam>
    public record RiskAssessmentWithDetails<TDetails> : RiskAssessmentBase
    {


        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("details")]
        public TDetails Details { get; set; }

    }

}
