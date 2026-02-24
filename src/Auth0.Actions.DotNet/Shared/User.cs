using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// Object describing the user on whose behalf the current transaction was initiated.
    /// </summary>
    /// <typeparam name="TAppMetadata">The custom type for the app_metadata property.</typeparam>
    /// <typeparam name="TUserMetadata">The custom type for the user_metadata property.</typeparam>
    public record User<TAppMetadata, TUserMetadata>
        where TAppMetadata : class
        where TUserMetadata : class
    {

        #region Properties

        /// <summary>
        /// Custom fields that store info about a user that influences the user's access, such as support plans, security roles, or access control groups.
        /// </summary>
        [JsonPropertyName("app_metadata")]
        public TAppMetadata AppMetadata { get; set; }

        /// <summary>
        /// Timestamp indicating when the user profile was first created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        /// <summary>
        /// The user's email address (unique).
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Indicates whether the user has verified their email address.
        /// </summary>
        [JsonPropertyName("email_verified")]
        public bool? EmailVerified { get; set; }

        /// <summary>
        /// Array of MFA factors the user has enrolled.
        /// </summary>
        /// <remarks>
        /// Each factor contains a type (e.g., 'push-notification', 'phone', 'email', 'otp',
        /// 'webauthn-roaming', 'webauthn-platform') and optional additional options.
        /// </remarks>
        [JsonPropertyName("enrolled_factors")]
        public List<object>? EnrolledFactors { get; set; }

        /// <summary>
        /// The user's given (first) name.
        /// </summary>
        [JsonPropertyName("given_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// The user's full name (e.g., John Foo). ALWAYS GENERATED.
        /// </summary>
        [JsonPropertyName("name")]
        public string FullName { get; set; }

        /// <summary>
        /// Information from identity providers used by the user, including linked accounts.
        /// </summary>
        [JsonPropertyName("identities")]
        public List<Identity> Identities { get; set; } = [];

        /// <summary>
        /// The user's family (last) name.
        /// </summary>
        [JsonPropertyName("family_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Timestamp of the most recent password change or reset. Only available for Database connections.
        /// </summary>
        [JsonPropertyName("last_password_reset")]
        public string LastPasswordReset { get; set; }

        /// <summary>
        /// List of MFA providers with which the user is enrolled.
        /// </summary>
        [JsonPropertyName("multifactor")]
        public List<string> Multifactor { get; set; }

        /// <summary>
        /// The user's nickname.
        /// </summary>
        [JsonPropertyName("nickname")]
        public string Nickname { get; set; }

        /// <summary>
        /// The user's phone number. Only valid for users from SMS connections.
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Indicates whether the user has verified their phone number.
        /// </summary>
        [JsonPropertyName("phone_verified")]
        public bool? PhoneVerified { get; set; }

        /// <summary>
        /// URL pointing to the user's profile picture (uses gravatar.com if not available). ALWAYS GENERATED.
        /// </summary>
        [JsonPropertyName("picture")]
        public string Picture { get; set; }

        /// <summary>
        /// User information associated with the identity provider connection.
        /// </summary>
        [JsonPropertyName("profileData")]
        public Dictionary<string, JsonElement>? ProfileData { get; set; }

        /// <summary>
        /// Timestamp indicating when the user's profile was last updated or modified (ISO 8601 format).
        /// </summary>
        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// The user's unique identifier.
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// Custom fields that store info about a user that does not impact their level of access, such as addresses or preferences.
        /// </summary>
        [JsonPropertyName("user_metadata")]
        public TUserMetadata UserMetadata { get; set; }

        /// <summary>
        /// The user's username (unique).
        /// </summary>
        [JsonPropertyName("username")]
        public string UserName { get; set; }

        #endregion

    }

}
