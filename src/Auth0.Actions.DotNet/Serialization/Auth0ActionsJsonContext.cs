using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Auth0.Actions.V1.CustomEmailProvider;
using Auth0.Actions.V1.CustomPhoneProvider;
using Auth0.Actions.V1.CustomTokenExchange;
using Auth0.Actions.V1.EventStream;
using Auth0.Actions.V1.PasswordResetPostChallenge;
using Auth0.Actions.V1.PostChangePassword;
using Auth0.Actions.V1.PostUserRegistration;
using Auth0.Actions.V1.PreUserRegistration;
using Auth0.Actions.V1.SendPhoneMessage;
using Auth0.Actions.V2.CredentialsExchange;
using Auth0.Actions.V2.PostLogin;
using Auth0.Actions.V3.PostLogin;

namespace Auth0.Actions.Serialization
{
    /// <summary>
    /// Provides AOT-compatible JSON serialization context for Auth0 Actions types.
    /// This context uses source generators to pre-compile serialization code,
    /// eliminating the need for runtime reflection.
    /// </summary>
    /// <remarks>
    /// <para>
    /// For event types with generic parameters, this context registers versions using
    /// Dictionary&lt;string, string&gt; for secrets and metadata, and Dictionary&lt;string, object&gt;
    /// for flexible metadata. If you need other strongly-typed parameters, create your own
    /// <see cref="JsonSerializerContext"/> with additional type registrations.
    /// </para>
    /// <para>
    /// Usage example:
    /// <code>
    /// var options = new JsonSerializerOptions { TypeInfoResolver = Auth0ActionsJsonContext.Default };
    /// var evt = JsonSerializer.Deserialize&lt;V3PostLoginEvent&gt;(json, options);
    /// var serialized = JsonSerializer.Serialize(evt, options);
    /// </code>
    /// </para>
    /// </remarks>
    [JsonSourceGenerationOptions(
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
        WriteIndented = false,
        GenerationMode = JsonSourceGenerationMode.Default)]

    // Common types
    [JsonSerializable(typeof(JsonElement))]
    [JsonSerializable(typeof(Dictionary<string, string>))]
    [JsonSerializable(typeof(Dictionary<string, object>))]
    [JsonSerializable(typeof(Dictionary<string, JsonElement>))]

    // Enums
    [JsonSerializable(typeof(ConnectionStrategies))]

    // Shared types
    [JsonSerializable(typeof(AccessToken))]
    [JsonSerializable(typeof(AuthenticationInfoWithRiskAssessment))]
    [JsonSerializable(typeof(AuthenticationMethod))]
    [JsonSerializable(typeof(AuthorizationInfo))]
    [JsonSerializable(typeof(Client<Dictionary<string, string>>))]
    [JsonSerializable(typeof(Connection))]
    [JsonSerializable(typeof(CredentialsExchangeRequestBody))]
    [JsonSerializable(typeof(GeoIP))]
    [JsonSerializable(typeof(Identity))]
    [JsonSerializable(typeof(IPAddressDetails))]
    [JsonSerializable(typeof(NewDeviceDetails))]
    [JsonSerializable(typeof(Organization))]
    [JsonSerializable(typeof(Query))]
    [JsonSerializable(typeof(Request))]
    [JsonSerializable(typeof(RequestBase<Dictionary<string, JsonElement>>))]
    [JsonSerializable(typeof(RequestBase<CredentialsExchangeRequestBody>))]
    [JsonSerializable(typeof(RequestBase<Dictionary<string, object>>))]
    [JsonSerializable(typeof(ResourceServer))]
    [JsonSerializable(typeof(RiskAssessmentBase))]
    [JsonSerializable(typeof(RiskAssessments))]
    [JsonSerializable(typeof(RiskAssessmentSummary))]
    [JsonSerializable(typeof(RiskAssessmentWithDetails<IPAddressDetails>))]
    [JsonSerializable(typeof(Stats))]
    [JsonSerializable(typeof(Tenant))]
    [JsonSerializable(typeof(Transaction))]
    [JsonSerializable(typeof(TransactionBase))]
    [JsonSerializable(typeof(User<Dictionary<string, object>, Dictionary<string, object>>))]

    // V3 PostLogin types and supporting types
    [JsonSerializable(typeof(CustomDomain))]
    [JsonSerializable(typeof(EnrolledFactor))]
    [JsonSerializable(typeof(PromptData))]
    [JsonSerializable(typeof(RefreshToken))]
    [JsonSerializable(typeof(SecurityContext))]
    [JsonSerializable(typeof(Session))]
    [JsonSerializable(typeof(SessionTransferToken))]
    [JsonSerializable(typeof(Auth0.Actions.V3.PostLogin.PostLoginEvent<
        Dictionary<string, string>,
        Dictionary<string, string>,
        Dictionary<string, object>,
        Dictionary<string, object>>), TypeInfoPropertyName = "V3PostLoginEvent")]

    // V3 CredentialsExchange
    [JsonSerializable(typeof(Auth0.Actions.V3.CredentialsExchange.CredentialsExchangeEvent<
        Dictionary<string, string>,
        Dictionary<string, string>,
        CredentialsExchangeRequestBody>), TypeInfoPropertyName = "V3CredentialsExchangeEvent")]

    // V2 PostLogin
    [JsonSerializable(typeof(Auth0.Actions.V2.PostLogin.PostLoginEvent<
        Dictionary<string, string>,
        Dictionary<string, string>,
        Dictionary<string, object>,
        Dictionary<string, object>>), TypeInfoPropertyName = "V2PostLoginEvent")]

    // V2 CredentialsExchange
    [JsonSerializable(typeof(Auth0.Actions.V2.CredentialsExchange.CredentialsExchangeEvent<
        Dictionary<string, string>,
        Dictionary<string, string>,
        CredentialsExchangeRequestBody>), TypeInfoPropertyName = "V2CredentialsExchangeEvent")]

    // V2 PreUserRegistration
    [JsonSerializable(typeof(Auth0.Actions.V2.PreUserRegistration.PreUserRegistrationEvent<
        Dictionary<string, string>,
        Dictionary<string, string>,
        Dictionary<string, object>,
        Dictionary<string, object>>), TypeInfoPropertyName = "V2PreUserRegistrationEvent")]

    // V2 PostUserRegistration
    [JsonSerializable(typeof(Auth0.Actions.V2.PostUserRegistration.PostUserRegistrationEvent<
        Dictionary<string, string>,
        Dictionary<string, string>,
        Dictionary<string, object>,
        Dictionary<string, object>>), TypeInfoPropertyName = "V2PostUserRegistrationEvent")]

    // V2 PostChangePassword
    [JsonSerializable(typeof(Auth0.Actions.V2.PostChangePassword.PostChangePasswordEvent<
        Dictionary<string, string>,
        Dictionary<string, string>,
        Dictionary<string, object>,
        Dictionary<string, object>>), TypeInfoPropertyName = "V2PostChangePasswordEvent")]

    // V2 SendPhoneMessage
    [JsonSerializable(typeof(Auth0.Actions.V2.SendPhoneMessage.SendPhoneMessageEvent<
        Dictionary<string, string>>), TypeInfoPropertyName = "V2SendPhoneMessageEvent")]

    // V1 PreUserRegistration
    [JsonSerializable(typeof(Auth0.Actions.V1.PreUserRegistration.PreUserRegistrationEvent<
        Dictionary<string, string>,
        Dictionary<string, string>,
        Dictionary<string, object>,
        Dictionary<string, object>>), TypeInfoPropertyName = "V1PreUserRegistrationEvent")]

    // V1 PostUserRegistration
    [JsonSerializable(typeof(Auth0.Actions.V1.PostUserRegistration.PostUserRegistrationEvent<
        Dictionary<string, string>,
        Dictionary<string, string>,
        Dictionary<string, object>,
        Dictionary<string, object>>), TypeInfoPropertyName = "V1PostUserRegistrationEvent")]

    // V1 PostChangePassword
    [JsonSerializable(typeof(Auth0.Actions.V1.PostChangePassword.PostChangePasswordEvent<
        Dictionary<string, string>,
        Dictionary<string, string>,
        Dictionary<string, object>,
        Dictionary<string, object>>), TypeInfoPropertyName = "V1PostChangePasswordEvent")]

    // V1 PasswordResetPostChallenge
    [JsonSerializable(typeof(PasswordResetPostChallengeEvent<
        Dictionary<string, string>,
        Dictionary<string, string>,
        Dictionary<string, object>,
        Dictionary<string, object>>), TypeInfoPropertyName = "V1PasswordResetPostChallengeEvent")]

    // V1 SendPhoneMessage
    [JsonSerializable(typeof(SendPhoneMessageEvent<Dictionary<string, string>>), TypeInfoPropertyName = "V1SendPhoneMessageEvent")]

    // V1 CustomPhoneProvider
    [JsonSerializable(typeof(CustomPhoneProviderEvent<Dictionary<string, string>>), TypeInfoPropertyName = "V1CustomPhoneProviderEvent")]

    // V1 CustomTokenExchange
    [JsonSerializable(typeof(CustomTokenExchangeEvent<Dictionary<string, string>, Dictionary<string, object>>), TypeInfoPropertyName = "V1CustomTokenExchangeEvent")]

    // V1 CustomEmailProvider
    [JsonSerializable(typeof(CustomEmailProviderEvent<Dictionary<string, string>>), TypeInfoPropertyName = "V1CustomEmailProviderEvent")]
    [JsonSerializable(typeof(EmailContent))]
    [JsonSerializable(typeof(EmailRecipient))]

    // V1 EventStream
    [JsonSerializable(typeof(EventStreamEvent<Dictionary<string, string>>), TypeInfoPropertyName = "V1EventStreamEvent")]
    [JsonSerializable(typeof(EventData))]

    // Root namespace backward compatibility types
    [JsonSerializable(typeof(PostLoginEvent<
        Dictionary<string, string>,
        Dictionary<string, string>,
        Dictionary<string, object>,
        Dictionary<string, object>>), TypeInfoPropertyName = "RootPostLoginEvent")]
    [JsonSerializable(typeof(CredentialsExchangeEvent<
        Dictionary<string, string>,
        Dictionary<string, string>,
        CredentialsExchangeRequestBody>), TypeInfoPropertyName = "RootCredentialsExchangeEvent")]

    public partial class Auth0ActionsJsonContext : JsonSerializerContext
    {
    }
}
