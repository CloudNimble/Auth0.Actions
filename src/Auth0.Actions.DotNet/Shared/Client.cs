using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// Information about the Client with which this transaction was initiated.
    /// </summary>
    /// <typeparam name="TMetadata">The custom type for the Metadata properties.</typeparam>
    public record Client<TMetadata>
        where TMetadata : class
    {

        #region Properties

        /// <summary>
        /// The client id of the application the user is logging in to.
        /// </summary>
        [JsonPropertyName("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// An object for holding other application properties.
        /// </summary>
        [JsonPropertyName("metadata")]
        public TMetadata Metadata { get; set; }

        /// <summary>
        /// The name of the application (as defined in the Dashboard).
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The type of connection strategy associated with this client.
        /// </summary>
        [JsonPropertyName("strategy")]
        public string Strategy { get; set; }

        #endregion

    }

}
