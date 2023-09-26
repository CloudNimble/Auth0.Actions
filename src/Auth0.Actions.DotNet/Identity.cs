using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// 
    /// </summary>
    public record Identity
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("userId")]
        public string AlternateUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("connection")]
        public string Connection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("isSocial")]
        public bool IsSocial { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("provider")]
        public string Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

    }

}
