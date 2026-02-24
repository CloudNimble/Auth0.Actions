using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// Login statistics for the current user.
    /// </summary>
    public record Stats
    {

        #region Properties

        /// <summary>
        /// The number of times the user has logged in.
        /// </summary>
        [JsonPropertyName("logins_count")]
        public int LoginsCount { get; set; }

        #endregion

    }

}
