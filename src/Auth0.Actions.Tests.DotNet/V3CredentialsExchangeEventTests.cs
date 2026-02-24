using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CredentialsExchangeEventV3 = Auth0.Actions.V3.CredentialsExchange.CredentialsExchangeEvent<System.Collections.Generic.Dictionary<string, string>, System.Collections.Generic.Dictionary<string, string>, Auth0.Actions.CredentialsExchangeRequestBody>;

namespace Auth0.Actions.Tests.DotNet
{
    [TestClass]
    public class V3CredentialsExchangeEventTests
    {
        private const string TestDataFile = "TestData/CredentialsExchangeEventV3.json";

        [TestMethod]
        public async Task V3CredentialsExchangeEvent_Deserializes_Successfully()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);

            // Act
            var evt = JsonSerializer.Deserialize<CredentialsExchangeEventV3>(json);

            // Assert
            evt.Should().NotBeNull();
            evt!.Client.Should().NotBeNull();
            evt.Client!.ClientId.Should().Be("m2m-client-123");
        }

        [TestMethod]
        public async Task V3CredentialsExchangeEvent_CustomDomain_DeserializesCorrectly()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);

            // Act
            var evt = JsonSerializer.Deserialize<CredentialsExchangeEventV3>(json);

            // Assert
            evt!.CustomDomain.Should().NotBeNull();
            evt.CustomDomain!.Domain.Should().Be("api.example.com");
            evt.CustomDomain.Type.Should().Be("self_managed_certs");
        }

        [TestMethod]
        public async Task V3CredentialsExchangeEvent_Organization_IsPresent()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);

            // Act
            var evt = JsonSerializer.Deserialize<CredentialsExchangeEventV3>(json);

            // Assert
            evt!.Organization.Should().NotBeNull();
            evt.Organization!.Name.Should().Be("api-org");
        }

        [TestMethod]
        public async Task V3CredentialsExchangeEvent_Transaction_HasCorrelationId()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);

            // Act
            var evt = JsonSerializer.Deserialize<CredentialsExchangeEventV3>(json);

            // Assert
            evt!.Transaction.Should().NotBeNull();
            evt.Transaction!.RequestedScopes.Should().Contain("read:data");
        }

        [TestMethod]
        public async Task V3CredentialsExchangeEvent_AccessToken_HasScopes()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);

            // Act
            var evt = JsonSerializer.Deserialize<CredentialsExchangeEventV3>(json);

            // Assert
            evt!.AccessToken.Should().NotBeNull();
            evt.AccessToken!.Scopes.Should().Contain("read:data");
            evt.AccessToken.Scopes.Should().Contain("write:data");
        }

        [TestMethod]
        public async Task V3CredentialsExchangeEvent_RoundTrip_PreservesData()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);
            var options = new JsonSerializerOptions
            {
                WriteIndented = false,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            // Act
            var evt = JsonSerializer.Deserialize<CredentialsExchangeEventV3>(json, options);
            var serialized = JsonSerializer.Serialize(evt, options);
            var deserialized = JsonSerializer.Deserialize<CredentialsExchangeEventV3>(serialized, options);

            // Assert
            deserialized.Should().NotBeNull();
            deserialized!.Client!.ClientId.Should().Be(evt!.Client!.ClientId);
            deserialized.CustomDomain!.Domain.Should().Be(evt.CustomDomain!.Domain);
        }
    }
}
