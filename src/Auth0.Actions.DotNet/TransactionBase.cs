using System.Text.Json.Serialization;

namespace Auth0.Actions
{
    public record TransactionBase
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("rquested_scopes")]
        public string RequestedScopes { get; set; }
    }
}