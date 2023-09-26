using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// 
    /// </summary>
    public record AuthenticationMethod
    {

        /// <summary>
        /// The name of the first factor that was completed. 
        /// Possible values are: 'federated', 'passkey', 'pwd', 'sms', 'email', 'mfa', 'mock', or a custom name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("timestamp")]
        public string Timestamp { get; set; }

        /// <summary>
        /// A specific MFA factor. Only present when name is set to 'mfa'.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

    }

}
