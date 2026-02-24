using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// Details about the resource server (API) to which access is being requested.
    /// </summary>
    public record ResourceServer
    {

        #region Properties

        /// <summary>
        /// The identifier of the resource server (API).
        /// </summary>
        [JsonPropertyName("identifier")]
        public string Identifier { get; set; }

        #endregion

    }

}
