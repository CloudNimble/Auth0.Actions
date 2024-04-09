using System.Text.Json.Serialization;

namespace Auth0.Actions.Tests.DotNet.Models
{

    public record ExtendedCredentialsExchangeRequestBody : CredentialsExchangeRequestBody
    {

        [JsonPropertyName("extraparam")]
        public string ExtraParam { get; set; }

    }

}
