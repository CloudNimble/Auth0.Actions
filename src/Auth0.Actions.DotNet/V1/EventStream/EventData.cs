using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Auth0.Actions.V1.EventStream
{

    /// <summary>
    /// Contains the event data and metadata for an event stream entry.
    /// </summary>
    public record EventData
    {

        #region Properties

        /// <summary>
        /// The event payload data, containing the details of what occurred.
        /// </summary>
        [JsonPropertyName("data")]
        public Dictionary<string, JsonElement>? Data { get; set; }

        /// <summary>
        /// The unique identifier for this event.
        /// </summary>
        [JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The type of event that occurred (e.g., "login", "signup", "password_reset").
        /// </summary>
        [JsonPropertyName("event_type")]
        public string? EventType { get; set; }

        /// <summary>
        /// The timestamp indicating when the event occurred, in ISO 8601 format.
        /// </summary>
        [JsonPropertyName("timestamp")]
        public string? Timestamp { get; set; }

        #endregion

    }

}
