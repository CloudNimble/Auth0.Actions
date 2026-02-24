using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Auth0.Actions.V1.CustomTokenExchange
{

    /// <summary>
    /// Triggered during custom token exchange flows, allowing custom logic to be executed
    /// before the post-login trigger.
    /// </summary>
    /// <typeparam name="TSecret">The type used to represent the secrets dictionary configured for this action.</typeparam>
    /// <typeparam name="TClientMetadata">The type used to represent the client metadata dictionary.</typeparam>
    /// <remarks>CustomTokenExchangeEvent V1 - Runs before the post-login trigger. Synchronous only.</remarks>
    public record CustomTokenExchangeEvent<TSecret, TClientMetadata>
        where TSecret : class
        where TClientMetadata : class
    {

        #region Properties

        /// <summary>
        /// Information about the access token to be issued upon successful exchange.
        /// </summary>
        [JsonPropertyName("accessToken")]
        public Auth0.Actions.AccessToken? AccessToken { get; set; }

        /// <summary>
        /// Information about the client (application) making the token exchange request.
        /// </summary>
        [JsonPropertyName("client")]
        public Auth0.Actions.Client<TClientMetadata>? Client { get; set; }

        /// <summary>
        /// Configuration values provided to the action at deployment time.
        /// </summary>
        [JsonPropertyName("configuration")]
        public Dictionary<string, JsonElement>? Configuration { get; set; }

        /// <summary>
        /// Custom grant type parameters provided in the token exchange request.
        /// </summary>
        [JsonPropertyName("grant")]
        public Dictionary<string, JsonElement>? Grant { get; set; }

        /// <summary>
        /// Details about the HTTP request that initiated the token exchange.
        /// </summary>
        [JsonPropertyName("request")]
        public Auth0.Actions.Request? Request { get; set; }

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
        /// Transaction information for the token exchange, including protocol details.
        /// </summary>
        [JsonPropertyName("transaction")]
        public Auth0.Actions.TransactionBase? Transaction { get; set; }

        #endregion

    }

}
