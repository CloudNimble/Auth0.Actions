using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TSecret"></typeparam>
    /// <typeparam name="TClientMetadata"></typeparam>
    public record CredentialsExchangeEvent<TSecret, TClientMetadata>
        where TSecret : class
        where TClientMetadata : class
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("accessToken")]
        public AccessToken AccessToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("client")]
        public Client<TClientMetadata> Client { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("request")]
        public RequestBase<CredentialsExchangeRequestBody> Request { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("resource_server")]
        public ResourceServer ResourceServer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("secrets")]
        public TSecret Secrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("tenant")]
        public Tenant Tenant { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("transaction")]
        public TransactionBase Transaction { get; set; }

    }

}
