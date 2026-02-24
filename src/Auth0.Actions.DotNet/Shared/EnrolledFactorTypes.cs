using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Auth0.Actions.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// Defines the known types of MFA authentication factors that a user can enroll.
    /// </summary>
    [JsonConverter(typeof(EnrolledFactorTypesConverter))]
    public enum EnrolledFactorTypes
    {

        /// <summary>
        /// An unknown or unrecognized factor type. Used as a fallback when new factor types
        /// are introduced by Auth0 that are not yet defined in this enum.
        /// </summary>
        Unknown,

        /// <summary>
        /// Email-based authentication factor.
        /// </summary>
        [EnumMember(Value = "email")]
        Email,

        /// <summary>
        /// One-time password (OTP) authentication factor, typically via an authenticator app.
        /// </summary>
        [EnumMember(Value = "otp")]
        Otp,

        /// <summary>
        /// Phone-based authentication factor (voice or SMS).
        /// </summary>
        [EnumMember(Value = "phone")]
        Phone,

        /// <summary>
        /// Push notification-based authentication factor.
        /// </summary>
        [EnumMember(Value = "push-notification")]
        PushNotification,

        /// <summary>
        /// Platform-bound WebAuthn authenticator (e.g., fingerprint, face recognition).
        /// </summary>
        [EnumMember(Value = "webauthn-platform")]
        WebAuthnPlatform,

        /// <summary>
        /// Roaming WebAuthn authenticator (e.g., security key).
        /// </summary>
        [EnumMember(Value = "webauthn-roaming")]
        WebAuthnRoaming,

    }

}
