using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Auth0.Actions.V3.PostLogin
{

    /// <summary>
    /// Collected data from rendered custom prompt screens.
    /// </summary>
    public record PromptData
    {

        #region Properties

        /// <summary>
        /// Custom data collected from the prompt screens as key-value pairs.
        /// </summary>
        [JsonPropertyName("data")]
        public Dictionary<string, JsonElement>? Data { get; set; }

        #endregion

    }

}
