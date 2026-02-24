using System.Text.Json.Serialization;

namespace Auth0.Actions.V2.CredentialsExchange
{

    /// <summary>
    /// CredentialsExchangeEvent V2 - Legacy version maintained for backward compatibility.
    /// </summary>
    /// <typeparam name="TSecret">The type for the secrets dictionary.</typeparam>
    /// <typeparam name="TClientMetadata">The type for client metadata.</typeparam>
    /// <typeparam name="TRequest">The type for the request body, must inherit from CredentialsExchangeRequestBody.</typeparam>
    /// <remarks>
    /// For new implementations, use:
    /// <code>Auth0.Actions.V3.CredentialsExchange.CredentialsExchangeEvent</code>
    /// </remarks>
    public record CredentialsExchangeEvent<TSecret, TClientMetadata, TRequest>
        where TSecret : class
        where TClientMetadata : class
        where TRequest : CredentialsExchangeRequestBody
    {

        #region Properties

        /// <summary>
        /// Information about the access token to be issued.
        /// </summary>
        [JsonPropertyName("accessToken")]
        public AccessToken AccessToken { get; set; }

        /// <summary>
        /// Information about the Client with which this transaction was initiated.
        /// </summary>
        [JsonPropertyName("client")]
        public Client<TClientMetadata> Client { get; set; }

        /// <summary>
        /// Details about the request that initiated the transaction.
        /// </summary>
        [JsonPropertyName("request")]
        public RequestBase<TRequest> Request { get; set; }

        /// <summary>
        /// Details about the resource server (API) to which access is being requested.
        /// </summary>
        [JsonPropertyName("resource_server")]
        public ResourceServer ResourceServer { get; set; }

        /// <summary>
        /// Secret values configured for this action.
        /// </summary>
        [JsonPropertyName("secrets")]
        public TSecret Secrets { get; set; }

        /// <summary>
        /// Details about the Auth0 Tenant associated with the current transaction.
        /// </summary>
        [JsonPropertyName("tenant")]
        public Tenant Tenant { get; set; }

        /// <summary>
        /// Transaction information for the credentials exchange.
        /// </summary>
        [JsonPropertyName("transaction")]
        public TransactionBase Transaction { get; set; }

        #endregion

    }

}
