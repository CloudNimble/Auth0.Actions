using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// Details about the Auth0 Tenant associated with the current transaction.
    /// </summary>
    public record Tenant
    {

        #region Properties

        /// <summary>
        /// The name of the tenant.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        #endregion

    }

}
