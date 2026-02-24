using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// Details about the Connection used to authenticate the user.
    /// </summary>
    public record Connection
    {

        #region Properties

        /// <summary>
        /// The connection's unique identifier.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Metadata associated with the connection in the form of an object with string values (max 255 chars).
        /// </summary>
        /// <remarks>
        /// Maximum of 10 metadata properties allowed.
        /// </remarks>
        [JsonPropertyName("metadata")]
        public Dictionary<string, object> Metadata { get; set; } = [];

        /// <summary>
        /// The name of the connection used to authenticate the user.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The type of connection, related to the identity provider.
        /// </summary>
        /// <remarks>
        /// For social connections, the strategy matches the connection name (e.g., twitter, google-oauth2).
        /// For enterprise connections, values include 'waad', 'ad', or 'auth0'.
        /// </remarks>
        [JsonPropertyName("strategy")]
        public ConnectionStrategies Strategy { get; set; }

        #endregion

    }

}
