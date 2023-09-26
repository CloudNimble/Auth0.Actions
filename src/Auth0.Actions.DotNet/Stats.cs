using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// 
    /// </summary>
    public record Stats
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("logins_count")]
        public int LoginsCount { get; set; }

    }

}
