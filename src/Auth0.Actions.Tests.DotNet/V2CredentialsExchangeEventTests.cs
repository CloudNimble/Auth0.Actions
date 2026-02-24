using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CredentialsExchangeEventV2 = Auth0.Actions.V2.CredentialsExchange.CredentialsExchangeEvent<System.Collections.Generic.Dictionary<string, string>, System.Collections.Generic.Dictionary<string, string>, Auth0.Actions.CredentialsExchangeRequestBody>;

namespace Auth0.Actions.Tests.DotNet
{
    [TestClass]
    public class V2CredentialsExchangeEventTests
    {
        private const string TestDataFile = "TestData/CredentialsExchangeEventV2.json";

        [TestMethod]
        public async Task V2CredentialsExchangeEvent_Deserializes_Successfully()
        {
            var json = await File.ReadAllTextAsync(TestDataFile);
            var evt = JsonSerializer.Deserialize<CredentialsExchangeEventV2>(json);
            evt.Should().NotBeNull();
        }

        [TestMethod]
        public async Task V2CredentialsExchangeEvent_RoundTrip_PreservesData()
        {
            var json = await File.ReadAllTextAsync(TestDataFile);
            var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
            var evt = JsonSerializer.Deserialize<CredentialsExchangeEventV2>(json, options);
            var serialized = JsonSerializer.Serialize(evt, options);
            var deserialized = JsonSerializer.Deserialize<CredentialsExchangeEventV2>(serialized, options);
            deserialized.Should().NotBeNull();
        }
    }
}
