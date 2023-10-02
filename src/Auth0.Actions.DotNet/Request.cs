using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// 
    /// </summary>
    public record Request : RequestBase<dynamic>
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("query")]
        public Query Query { get; set; }

    }

}
