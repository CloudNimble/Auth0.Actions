using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TMetadata"></typeparam>
    public record Client<TMetadata>
        where TMetadata : class
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("metadata")]
        public TMetadata Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("strategy")]
        public string Strategy { get; set; }

    }

}
