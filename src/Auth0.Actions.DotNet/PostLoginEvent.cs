using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// PostLoginEvent - Backward compatibility alias for V3.PostLogin.PostLoginEvent.
    /// </summary>
    /// <typeparam name="TSecret">The type for the secrets dictionary.</typeparam>
    /// <typeparam name="TClientMetadata">The type for client metadata.</typeparam>
    /// <typeparam name="TAppMetadata">The type for user app_metadata.</typeparam>
    /// <typeparam name="TUserMetadata">The type for user user_metadata.</typeparam>
    /// <remarks>
    /// This is a backward compatibility alias. For new code, use:
    /// <code>Auth0.Actions.V3.PostLogin.PostLoginEvent</code>
    ///
    /// Migration guide:
    /// - V2: Auth0.Actions.V2.PostLogin.PostLoginEvent (legacy)
    /// - V3: Auth0.Actions.V3.PostLogin.PostLoginEvent (latest with 30+ new properties)
    /// </remarks>
    [Obsolete("Use Auth0.Actions.V3.PostLogin.PostLoginEvent for new implementations. This alias will be removed in a future version.")]
    public record PostLoginEvent<TSecret, TClientMetadata, TAppMetadata, TUserMetadata>
        where TSecret : class
        where TClientMetadata : class
        where TAppMetadata : class
        where TUserMetadata : class
    {

        #region Properties

        /// <summary>
        /// Details about authentication signals obtained during the login flow.
        /// </summary>
        [JsonPropertyName("authentication")]
        public AuthenticationInfoWithRiskAssessment Authentication { get; set; }

        /// <summary>
        /// Information describing the authorization granted to the user.
        /// </summary>
        [JsonPropertyName("authorization")]
        public AuthorizationInfo Authorization { get; set; }

        /// <summary>
        /// Information about the Client with which this login transaction was initiated.
        /// </summary>
        [JsonPropertyName("client")]
        public Client<TClientMetadata> Client { get; set; }

        /// <summary>
        /// Configuration values provided to the action.
        /// </summary>
        [JsonPropertyName("configuration")]
        public Dictionary<string, JsonElement>? Configuration { get; set; }

        /// <summary>
        /// Details about the Connection used to authenticate the user.
        /// </summary>
        [JsonPropertyName("connection")]
        public Connection Connection { get; set; }

        /// <summary>
        /// Details about the Organization associated with the current transaction.
        /// </summary>
        [JsonPropertyName("organization")]
        public Organization Organization { get; set; }

        /// <summary>
        /// Details about the request that initiated the transaction.
        /// </summary>
        [JsonPropertyName("request")]
        public Request Request { get; set; }

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
        /// Login statistics for the current user.
        /// </summary>
        [JsonPropertyName("stats")]
        public Stats Stats { get; set; }

        /// <summary>
        /// Details about the Auth0 Tenant associated with the current transaction.
        /// </summary>
        [JsonPropertyName("tenant")]
        public Tenant Tenant { get; set; }

        /// <summary>
        /// Details about the current transaction.
        /// </summary>
        [JsonPropertyName("transaction")]
        public Transaction Transaction { get; set; }

        /// <summary>
        /// Object describing the user on whose behalf the current transaction was initiated.
        /// </summary>
        [JsonPropertyName("user")]
        public User<TAppMetadata, TUserMetadata> User { get; set; }

        #endregion

    }

}
