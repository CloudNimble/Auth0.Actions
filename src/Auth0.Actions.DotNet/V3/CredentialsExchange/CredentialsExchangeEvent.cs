using System.Text.Json.Serialization;

namespace Auth0.Actions.V3.CredentialsExchange
{

    /// <summary>
    /// Triggered during M2M (machine-to-machine) authentication flows.
    /// </summary>
    /// <typeparam name="TSecret">The type used to represent the secrets dictionary configured for this action.</typeparam>
    /// <typeparam name="TClientMetadata">The type used to represent the client metadata dictionary.</typeparam>
    /// <typeparam name="TRequest">The type used to represent the request body.</typeparam>
    /// <remarks>CredentialsExchangeEvent V3 - Latest version with enhanced features including custom domain support.</remarks>
    public record CredentialsExchangeEvent<TSecret, TClientMetadata, TRequest>
        where TSecret : class
        where TClientMetadata : class
        where TRequest : Auth0.Actions.CredentialsExchangeRequestBody
    {

        #region Properties

        /// <summary>
        /// Information about the access token to be issued upon successful authentication.
        /// </summary>
        [JsonPropertyName("accessToken")]
        public Auth0.Actions.AccessToken? AccessToken { get; set; }

        /// <summary>
        /// Information about the client (application) making the authentication request.
        /// </summary>
        [JsonPropertyName("client")]
        public Auth0.Actions.Client<TClientMetadata>? Client { get; set; }

        /// <summary>
        /// Information about the custom domain used for the authentication request, if applicable.
        /// </summary>
        [JsonPropertyName("custom_domain")]
        public V3.PostLogin.CustomDomain? CustomDomain { get; set; }

        /// <summary>
        /// Information about the organization, if the authentication occurs within an organization context.
        /// </summary>
        [JsonPropertyName("organization")]
        public Auth0.Actions.Organization? Organization { get; set; }

        /// <summary>
        /// Details about the HTTP request that initiated the credentials exchange.
        /// </summary>
        [JsonPropertyName("request")]
        public Auth0.Actions.RequestBase<TRequest>? Request { get; set; }

        /// <summary>
        /// Information about the resource server (API) being accessed by the client.
        /// </summary>
        [JsonPropertyName("resource_server")]
        public Auth0.Actions.ResourceServer? ResourceServer { get; set; }

        /// <summary>
        /// Secret values configured for this action, such as API keys or passwords.
        /// </summary>
        [JsonPropertyName("secrets")]
        public TSecret? Secrets { get; set; }

        /// <summary>
        /// Information about the Auth0 tenant processing the request.
        /// </summary>
        [JsonPropertyName("tenant")]
        public Auth0.Actions.Tenant? Tenant { get; set; }

        /// <summary>
        /// Transaction information for the credentials exchange, including protocol details.
        /// </summary>
        [JsonPropertyName("transaction")]
        public Auth0.Actions.TransactionBase? Transaction { get; set; }

        #endregion

    }

}
