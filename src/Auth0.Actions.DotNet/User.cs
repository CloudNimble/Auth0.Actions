using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// Contains common elements used for both constructing User-related requests, and comprising User-related responses.
    /// </summary>
    public record User<TAppMetadata, TUserMetadata> 
        where TAppMetadata : class
        where TUserMetadata : class
    {
        /// <summary>
        /// Contains user meta data. The user has read-only access to this.
        /// </summary>
        [JsonPropertyName("app_metadata")]
        public TAppMetadata AppMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the user's email address.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets whether the user's email address is verified.
        /// </summary>
        /// <remarks>
        /// True if the email address is verified, otherwise false.
        /// </remarks>
        [JsonPropertyName("email_verified")]
        public bool? EmailVerified { get; set; }

        /// <summary>
        /// The first name of the user (if available).
        /// </summary>
        /// <remarks>
        /// This is the given_name attribute supplied by the underlying API.
        /// </remarks>
        [JsonPropertyName("given_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// The full name of the user (e.g.: John Foo). ALWAYS GENERATED.
        /// </summary>
        /// <remarks>
        /// This is the name attribute supplied by the underlying API.
        /// </remarks>
        [JsonPropertyName("name")]
        public string FullName { get; set; }

        /// <summary>
        /// The last name of the user (if available).
        /// </summary>
        /// <remarks>
        /// This is the family_name attribute supplied by the underlying API.
        /// </remarks>
        [JsonPropertyName("family_name")]
        public string LastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("last_password_reset")]
        public string LastPasswordReset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("multifactor")]
        public List<string> Multifactor { get; set; }

        /// <summary>
        /// The Nickname of the user.
        /// </summary>
        [JsonPropertyName("nickname")]
        public string Nickname { get; set; }

        /// <summary>
        /// Gets or sets the user's phone number.
        /// </summary>
        /// <remarks>
        /// This is only valid for users from SMS connections.
        /// </remarks>
        [JsonPropertyName("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets whether the user's phone is verified.
        /// </summary>
        /// <remarks>
        /// True if the phone is verified, otherwise false.
        /// </remarks>
        [JsonPropertyName("phone_verified")]
        public bool? PhoneVerified { get; set; }

        /// <summary>
        /// URL pointing to the user picture (if not available, will use gravatar.com with the email). ALWAYS GENERATED
        /// </summary>
        [JsonPropertyName("picture")]
        public string Picture { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Contains user meta data. The user has read/write access to this.
        /// </summary>
        [JsonPropertyName("user_metadata")]
        public TUserMetadata UserMetadata { get; set; }

        /// <summary>
        /// Gets or sets the user' username.
        /// </summary>
        [JsonPropertyName("username")]
        public string UserName { get; set; }

    }

}