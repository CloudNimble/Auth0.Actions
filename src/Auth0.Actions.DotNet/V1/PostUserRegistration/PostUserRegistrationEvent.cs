using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Auth0.Actions.V1.PostUserRegistration
{

    /// <summary>
    /// Triggered asynchronously after a new user is created, allowing side effects such as
    /// logging, notifications, or syncing with external systems.
    /// </summary>
    /// <typeparam name="TSecret">The type used to represent the secrets dictionary configured for this action.</typeparam>
    /// <typeparam name="TClientMetadata">The type used to represent the client metadata dictionary.</typeparam>
    /// <typeparam name="TAppMetadata">The type used to represent the user's application metadata dictionary.</typeparam>
    /// <typeparam name="TUserMetadata">The type used to represent the user's user metadata dictionary.</typeparam>
    /// <remarks>PostUserRegistrationEvent V1 - Asynchronous; cannot block user registration.</remarks>
    public record PostUserRegistrationEvent<TSecret, TClientMetadata, TAppMetadata, TUserMetadata>
        where TSecret : class
        where TClientMetadata : class
        where TAppMetadata : class
        where TUserMetadata : class
    {

        #region Properties

        /// <summary>
        /// Information about the client (application) where the user registered.
        /// </summary>
        [JsonPropertyName("client")]
        public Auth0.Actions.Client<TClientMetadata>? Client { get; set; }

        /// <summary>
        /// Configuration values provided to the action at deployment time.
        /// </summary>
        [JsonPropertyName("configuration")]
        public Dictionary<string, JsonElement>? Configuration { get; set; }

        /// <summary>
        /// Information about the connection used during registration.
        /// </summary>
        [JsonPropertyName("connection")]
        public Auth0.Actions.Connection? Connection { get; set; }

        /// <summary>
        /// Details about the HTTP request that initiated the user registration.
        /// </summary>
        [JsonPropertyName("request")]
        public Auth0.Actions.Request? Request { get; set; }

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

        /// <summary>
        /// The newly created user, including profile data and metadata.
        /// </summary>
        [JsonPropertyName("user")]
        public Auth0.Actions.User<TAppMetadata, TUserMetadata>? User { get; set; }

        #endregion

    }

}
