using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// Information describing the authorization granted to the user.
    /// </summary>
    public record AuthorizationInfo
    {

        #region Properties

        /// <summary>
        /// An array containing the names of a user's assigned roles.
        /// </summary>
        [JsonPropertyName("roles")]
        public List<string> Roles { get; set; } = [];

        #endregion

    }

}
