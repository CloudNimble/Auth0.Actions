using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Auth0.Actions.V3.PostLogin
{

    /// <summary>
    /// Triggered after a user logs in, providing access to user, client, and session information
    /// with enhanced features including custom domains, session management, security context,
    /// and enterprise features.
    /// </summary>
    /// <typeparam name="TSecret">The type used to represent the secrets dictionary configured for this action.</typeparam>
    /// <typeparam name="TClientMetadata">The type used to represent the client metadata dictionary.</typeparam>
    /// <typeparam name="TAppMetadata">The type used to represent the user's application metadata dictionary.</typeparam>
    /// <typeparam name="TUserMetadata">The type used to represent the user's user metadata dictionary.</typeparam>
    /// <remarks>PostLoginEvent V3 - Latest version with enhanced features including custom domains,
    /// session management, security context, and enterprise features.</remarks>
    public record PostLoginEvent<TSecret, TClientMetadata, TAppMetadata, TUserMetadata>
        where TSecret : class
        where TClientMetadata : class
        where TAppMetadata : class
        where TUserMetadata : class
    {

        #region Properties

        /// <summary>
        /// Authentication information for the current login, including risk assessment details.
        /// </summary>
        [JsonPropertyName("authentication")]
        public Auth0.Actions.AuthenticationInfoWithRiskAssessment? Authentication { get; set; }

        /// <summary>
        /// Authorization information including roles granted to the user.
        /// </summary>
        [JsonPropertyName("authorization")]
        public Auth0.Actions.AuthorizationInfo? Authorization { get; set; }

        /// <summary>
        /// Information about the client (application) making the authentication request.
        /// </summary>
        [JsonPropertyName("client")]
        public Auth0.Actions.Client<TClientMetadata>? Client { get; set; }

        /// <summary>
        /// Configuration values provided to the action at deployment time.
        /// </summary>
        [JsonPropertyName("configuration")]
        public Dictionary<string, JsonElement>? Configuration { get; set; }

        /// <summary>
        /// Information about the connection used for authentication.
        /// </summary>
        [JsonPropertyName("connection")]
        public Auth0.Actions.Connection? Connection { get; set; }

        /// <summary>
        /// Information about the custom domain used for the authentication request, if applicable.
        /// </summary>
        [JsonPropertyName("custom_domain")]
        public CustomDomain? CustomDomain { get; set; }

        /// <summary>
        /// Information about the organization, if the authentication occurs within an organization context.
        /// </summary>
        [JsonPropertyName("organization")]
        public Auth0.Actions.Organization? Organization { get; set; }

        /// <summary>
        /// Data collected from custom prompt screens rendered during the login flow.
        /// </summary>
        [JsonPropertyName("prompt")]
        public PromptData? Prompt { get; set; }

        /// <summary>
        /// Refresh token information for this authentication.
        /// </summary>
        /// <remarks>[Enterprise Customers] This property is only available to enterprise customers.</remarks>
        [JsonPropertyName("refresh_token")]
        public RefreshToken? RefreshToken { get; set; }

        /// <summary>
        /// Details about the HTTP request that initiated the authentication.
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
        /// An object containing TLS fingerprint signatures (JA3/JA4), available only when traffic
        /// is handled through Auth0 Edge.
        /// </summary>
        [JsonPropertyName("security_context")]
        public SecurityContext? SecurityContext { get; set; }

        /// <summary>
        /// Session information for the authentication.
        /// </summary>
        /// <remarks>[Enterprise Customers] This property is only available to enterprise customers.</remarks>
        [JsonPropertyName("session")]
        public Session? Session { get; set; }

        /// <summary>
        /// Token for transferring sessions from native to web applications (Native-to-Web SSO).
        /// </summary>
        [JsonPropertyName("session_transfer_token")]
        public SessionTransferToken? SessionTransferToken { get; set; }

        /// <summary>
        /// Usage statistics for the user account, such as login counts.
        /// </summary>
        [JsonPropertyName("stats")]
        public Auth0.Actions.Stats? Stats { get; set; }

        /// <summary>
        /// Information about the Auth0 tenant processing the request.
        /// </summary>
        [JsonPropertyName("tenant")]
        public Auth0.Actions.Tenant? Tenant { get; set; }

        /// <summary>
        /// Transaction information including OAuth/OIDC protocol details such as scopes,
        /// redirect URIs, and response types.
        /// </summary>
        [JsonPropertyName("transaction")]
        public Auth0.Actions.Transaction? Transaction { get; set; }

        /// <summary>
        /// User information for the authenticating user, including profile data and metadata.
        /// </summary>
        [JsonPropertyName("user")]
        public Auth0.Actions.User<TAppMetadata, TUserMetadata>? User { get; set; }

        #endregion

    }

}
