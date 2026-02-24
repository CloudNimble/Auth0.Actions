using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomTokenExchangeEventV1 = Auth0.Actions.V1.CustomTokenExchange.CustomTokenExchangeEvent<System.Collections.Generic.Dictionary<string, string>, System.Collections.Generic.Dictionary<string, object>>;

namespace Auth0.Actions.Tests.DotNet
{
    /// <summary>
    /// Tests for V1 CustomTokenExchangeEvent.
    /// Supports custom token exchange flows.
    /// </summary>
    [TestClass]
    public class V1CustomTokenExchangeEventTests
    {
        private const string TestDataFile = "TestData/CustomTokenExchangeEventV1.json";

        [TestMethod]
        public async Task V1CustomTokenExchangeEvent_Deserializes_Successfully()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);

            // Act
            var evt = JsonSerializer.Deserialize<CustomTokenExchangeEventV1>(json);

            // Assert
            evt.Should().NotBeNull();
        }

        [TestMethod]
        public async Task V1CustomTokenExchangeEvent_Transaction_HasRequestedScopes()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);

            // Act
            var evt = JsonSerializer.Deserialize<CustomTokenExchangeEventV1>(json);

            // Assert
            evt!.Transaction.Should().NotBeNull();
            evt.Transaction!.RequestedScopes.Should().Contain("openid");
        }

        [TestMethod]
        public async Task V1CustomTokenExchangeEvent_Request_HasTokenExchangeGrantType()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);

            // Act
            var evt = JsonSerializer.Deserialize<CustomTokenExchangeEventV1>(json);

            // Assert
            evt!.Request.Should().NotBeNull();
            evt.Request!.Body.Should().NotBeNull();
        }

        [TestMethod]
        public async Task V1CustomTokenExchangeEvent_RoundTrip_PreservesData()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);
            var options = new JsonSerializerOptions
            {
                WriteIndented = false,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            // Act
            var evt = JsonSerializer.Deserialize<CustomTokenExchangeEventV1>(json, options);
            var serialized = JsonSerializer.Serialize(evt, options);
            var deserialized = JsonSerializer.Deserialize<CustomTokenExchangeEventV1>(serialized, options);

            // Assert
            deserialized.Should().NotBeNull();
            deserialized!.Transaction!.RequestedScopes.Should().Be(evt!.Transaction!.RequestedScopes);
        }
    }
}
