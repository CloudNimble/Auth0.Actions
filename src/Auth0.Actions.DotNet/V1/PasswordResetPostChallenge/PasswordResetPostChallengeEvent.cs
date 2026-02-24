using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Auth0.Actions.V1.PasswordResetPostChallenge
{

    /// <summary>
    /// Triggered after a password reset challenge has been verified, allowing additional
    /// validation or blocking of the password reset operation.
    /// </summary>
    /// <typeparam name="TSecret">The type used to represent the secrets dictionary configured for this action.</typeparam>
    /// <typeparam name="TClientMetadata">The type used to represent the client metadata dictionary.</typeparam>
    /// <typeparam name="TAppMetadata">The type used to represent the user's application metadata dictionary.</typeparam>
    /// <typeparam name="TUserMetadata">The type used to represent the user's user metadata dictionary.</typeparam>
    /// <remarks>PasswordResetPostChallengeEvent V1 - Allows blocking password reset or performing additional validation.</remarks>
    public record PasswordResetPostChallengeEvent<TSecret, TClientMetadata, TAppMetadata, TUserMetadata>
        where TSecret : class
        where TClientMetadata : class
        where TAppMetadata : class
        where TUserMetadata : class
    {

        #region Properties

        /// <summary>
        /// Information about the client (application) that initiated the password reset.
        /// </summary>
        [JsonPropertyName("client")]
        public Auth0.Actions.Client<TClientMetadata>? Client { get; set; }

        /// <summary>
        /// Configuration values provided to the action at deployment time.
        /// </summary>
        [JsonPropertyName("configuration")]
        public Dictionary<string, JsonElement>? Configuration { get; set; }

        /// <summary>
        /// Information about the connection associated with the user's account.
        /// </summary>
        [JsonPropertyName("connection")]
        public Auth0.Actions.Connection? Connection { get; set; }

        /// <summary>
        /// Details about the HTTP request that initiated the password reset.
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
        /// The user attempting to reset their password.
        /// </summary>
        [JsonPropertyName("user")]
        public Auth0.Actions.User<TAppMetadata, TUserMetadata>? User { get; set; }

        #endregion

    }

}
