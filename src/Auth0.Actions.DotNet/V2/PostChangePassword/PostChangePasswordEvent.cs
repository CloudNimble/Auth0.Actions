using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Auth0.Actions.V2.PostChangePassword
{

    /// <summary>
    /// PostChangePasswordEvent V2 - Triggered after a user changes their password (async).
    /// Used for notifications, logging, or triggering workflows after password changes.
    /// </summary>
    /// <typeparam name="TSecret">The type for the secrets dictionary.</typeparam>
    /// <typeparam name="TClientMetadata">The type for client metadata.</typeparam>
    /// <typeparam name="TAppMetadata">The type for user app_metadata.</typeparam>
    /// <typeparam name="TUserMetadata">The type for user user_metadata.</typeparam>
    /// <remarks>
    /// V2 adds custom domain, organization, and transaction support over V1.
    /// </remarks>
    public record PostChangePasswordEvent<TSecret, TClientMetadata, TAppMetadata, TUserMetadata>
        where TSecret : class
        where TClientMetadata : class
        where TAppMetadata : class
        where TUserMetadata : class
    {

        #region Properties

        /// <summary>
        /// Information about the Client with which this transaction was initiated.
        /// </summary>
        [JsonPropertyName("client")]
        public Auth0.Actions.Client<TClientMetadata>? Client { get; set; }

        /// <summary>
        /// Configuration values provided to the action.
        /// </summary>
        [JsonPropertyName("configuration")]
        public Dictionary<string, JsonElement>? Configuration { get; set; }

        /// <summary>
        /// Details about the Connection the user used to change their password.
        /// </summary>
        [JsonPropertyName("connection")]
        public Auth0.Actions.Connection? Connection { get; set; }

        /// <summary>
        /// Custom domain information if the tenant is using a custom domain.
        /// </summary>
        [JsonPropertyName("custom_domain")]
        public V3.PostLogin.CustomDomain? CustomDomain { get; set; }

        /// <summary>
        /// Details about the Organization associated with the current transaction.
        /// </summary>
        [JsonPropertyName("organization")]
        public Auth0.Actions.Organization? Organization { get; set; }

        /// <summary>
        /// Details about the request that initiated the transaction.
        /// </summary>
        [JsonPropertyName("request")]
        public Auth0.Actions.Request? Request { get; set; }

        /// <summary>
        /// Secret values configured for this action.
        /// </summary>
        [JsonPropertyName("secrets")]
        public TSecret? Secrets { get; set; }

        /// <summary>
        /// Details about the Auth0 Tenant associated with the current transaction.
        /// </summary>
        [JsonPropertyName("tenant")]
        public Auth0.Actions.Tenant? Tenant { get; set; }

        /// <summary>
        /// Details about the current transaction.
        /// </summary>
        [JsonPropertyName("transaction")]
        public Auth0.Actions.Transaction? Transaction { get; set; }

        /// <summary>
        /// Object describing the user who changed their password.
        /// </summary>
        [JsonPropertyName("user")]
        public Auth0.Actions.User<TAppMetadata, TUserMetadata>? User { get; set; }

        #endregion

    }

}
