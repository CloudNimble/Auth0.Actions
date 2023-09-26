using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TSecret"></typeparam>
    /// <typeparam name="TClientMetadata"></typeparam>
    /// <typeparam name="TAppMetadata"></typeparam>
    /// <typeparam name="TUserMetadata"></typeparam>
    public record PostLoginEvent<TSecret, TClientMetadata, TAppMetadata, TUserMetadata>
        where TSecret : class
        where TClientMetadata : class
        where TAppMetadata : class
        where TUserMetadata : class
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("authentication")]
        public AuthenticationInfoWithRiskAssessment Authentication { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("authorization")]
        public AuthorizationInfo Authorization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("client")]
        public Client<TClientMetadata> Client { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("configuration")]
        public dynamic Configuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("connection")]
        public Connection Connection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("organization")]
        public Organization Organization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("request")]
        public Request Request { get; set; }

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
        [JsonPropertyName("stats")]
        public Stats Stats { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("tenant")]
        public Tenant Tenant { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("transaction")]
        public Transaction Transaction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("user")]
        public User<TAppMetadata, TUserMetadata> User { get; set; }

    }

}
