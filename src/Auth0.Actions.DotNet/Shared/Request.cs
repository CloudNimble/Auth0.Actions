using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// Details about the request that initiated the transaction.
    /// </summary>
    public record Request : RequestBase<Dictionary<string, JsonElement>>
    {

        #region Properties

        /// <summary>
        /// The Autonomous System Number (ASN) for the client's IP address.
        /// </summary>
        [JsonPropertyName("asn")]
        public string? Asn { get; set; }

        /// <summary>
        /// Query string parameters sent to the authorization request.
        /// </summary>
        [JsonPropertyName("query")]
        public Query Query { get; set; }

        #endregion

    }

}
