using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Auth0.Actions.V1.EventStream
{

    /// <summary>
    /// Triggered for event streaming and webhook integrations, allowing real-time event
    /// processing and integration with external systems.
    /// </summary>
    /// <typeparam name="TSecret">The type used to represent the secrets dictionary configured for this action.</typeparam>
    /// <remarks>EventStreamEvent V1 - Provides real-time event streaming capabilities for Auth0 tenant events.</remarks>
    public record EventStreamEvent<TSecret>
        where TSecret : class
    {

        #region Properties

        /// <summary>
        /// Configuration values provided to the action at deployment time.
        /// </summary>
        [JsonPropertyName("configuration")]
        public Dictionary<string, JsonElement>? Configuration { get; set; }

        /// <summary>
        /// The event data and metadata to be streamed, including the event type and payload.
        /// </summary>
        [JsonPropertyName("event")]
        public EventData? Event { get; set; }

        /// <summary>
        /// Secret values configured for this action, such as API keys or passwords.
        /// </summary>
        [JsonPropertyName("secrets")]
        public TSecret? Secrets { get; set; }

        /// <summary>
        /// Information about the Auth0 tenant processing the request.
        /// </summary>
        [JsonPropertyName("tenant")]
        public Auth0.Actions.Tenant? Tenant { get; set; }

        #endregion

    }

}
