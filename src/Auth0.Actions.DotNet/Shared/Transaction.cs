using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// Details about the current transaction, including OAuth/OIDC protocol information.
    /// </summary>
    public record Transaction : TransactionBase
    {

        #region Properties

        /// <summary>
        /// Any acr_values provided in the original authentication request.
        /// </summary>
        [JsonPropertyName("acr_values")]
        public List<string>? AcrValues { get; set; }

        /// <summary>
        /// Correlation identifier for tracking related transactions.
        /// </summary>
        [JsonPropertyName("correlation_id")]
        public string? CorrelationId { get; set; }

        /// <summary>
        /// Unique transaction identifier (only available for browser-based flows).
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Dynamic Linking ID to reference this transaction.
        /// </summary>
        [JsonPropertyName("linking_id")]
        public string LinkingId { get; set; }

        /// <summary>
        /// The locale chosen for this transaction based on browser language preferences and tenant settings.
        /// </summary>
        [JsonPropertyName("locale")]
        public string Locale { get; set; }

        /// <summary>
        /// A hint about the login identifier the end-user might use to log in.
        /// </summary>
        [JsonPropertyName("login_hint")]
        public string LoginHint { get; set; }

        /// <summary>
        /// Shared data across custom Actions for the duration of the transaction.
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, JsonElement>? Metadata { get; set; }

        /// <summary>
        /// Instructions indicating whether the user may be prompted for re-authentication and consent.
        /// </summary>
        [JsonPropertyName("prompt")]
        public List<string> Prompt { get; set; } = [];

        /// <summary>
        /// The authentication protocol used for this transaction.
        /// </summary>
        /// <remarks>
        /// Possible values include: 'oidc-basic-profile', 'oidc-implicit-profile', 'samlp', 'wsfed',
        /// 'wstrust-usernamemixed', 'oauth2-webauthn', 'oauth2-device-code', 'oauth2-resource-owner',
        /// 'oauth2-resource-owner-jwt-bearer', 'oauth2-password', 'oauth2-access-token',
        /// 'oauth2-refresh-token', 'oauth2-token-exchange'.
        /// </remarks>
        [JsonPropertyName("protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// The URL to which Auth0 will redirect the browser after the transaction is completed.
        /// </summary>
        [JsonPropertyName("redirect_uri")]
        public string RedirectUri { get; set; }

        /// <summary>
        /// The mechanism used for returning Authorization Endpoint response parameters.
        /// </summary>
        /// <remarks>
        /// Possible values: 'query', 'fragment', 'form_post', 'web_message'.
        /// </remarks>
        [JsonPropertyName("response_mode")]
        public string ResponseMode { get; set; }

        /// <summary>
        /// The response types requested for the transaction.
        /// </summary>
        /// <remarks>
        /// Possible values: 'code', 'token', 'id_token'.
        /// </remarks>
        [JsonPropertyName("response_type")]
        public List<string> ResponseType { get; set; } = [];

        /// <summary>
        /// An opaque, arbitrary alphanumeric string that Auth0 echoes back after redirect.
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// The ui_locales provided in the original authentication request.
        /// </summary>
        [JsonPropertyName("ui_locales")]
        public List<string> UILocales { get; set; } = [];

        #endregion

    }

}
