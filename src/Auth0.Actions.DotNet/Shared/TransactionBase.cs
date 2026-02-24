using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// Base transaction information shared across different action trigger types.
    /// </summary>
    public record TransactionBase
    {

        #region Properties

        /// <summary>
        /// The scopes requested (if any) when requesting the access token.
        /// </summary>
        [JsonPropertyName("requested_scopes")]
        public string RequestedScopes { get; set; }

        #endregion

    }

}
