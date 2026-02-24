using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PreUserRegistrationEventV1 = Auth0.Actions.V1.PreUserRegistration.PreUserRegistrationEvent<System.Collections.Generic.Dictionary<string, string>, System.Collections.Generic.Dictionary<string, string>, System.Collections.Generic.Dictionary<string, object>, System.Collections.Generic.Dictionary<string, object>>;

namespace Auth0.Actions.Tests.DotNet
{
    /// <summary>
    /// Comprehensive serialization tests for V1 PreUserRegistrationEvent.
    /// Tests deserialization, property mapping, and roundtrip serialization.
    /// </summary>
    [TestClass]
    public class V1PreUserRegistrationEventTests
    {
        private const string TestDataFile = "TestData/PreUserRegistrationEventV1.json";

        [TestMethod]
        public async Task V1PreUserRegistrationEvent_Deserializes_Successfully()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);

            // Act
            var evt = JsonSerializer.Deserialize<PreUserRegistrationEventV1>(json);

            // Assert
            evt.Should().NotBeNull();
        }

        [TestMethod]
        public async Task V1PreUserRegistrationEvent_User_DeserializesCorrectly()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);

            // Act
            var evt = JsonSerializer.Deserialize<PreUserRegistrationEventV1>(json);

            // Assert
            evt!.User.Should().NotBeNull();
            evt.User!.Email.Should().Be("newuser@example.com");
            evt.User.UserName.Should().Be("newuser");
            evt.User.EmailVerified.Should().BeFalse();
        }

        [TestMethod]
        public async Task V1PreUserRegistrationEvent_Client_DeserializesWithMetadata()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);

            // Act
            var evt = JsonSerializer.Deserialize<PreUserRegistrationEventV1>(json);

            // Assert
            evt!.Client.Should().NotBeNull();
            evt.Client!.ClientId.Should().Be("reg-client-123");
            evt.Client.Name.Should().Be("Registration Application");
            evt.Client.Metadata.Should().ContainKey("app_type");
        }

        [TestMethod]
        public async Task V1PreUserRegistrationEvent_Connection_DeserializesCorrectly()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);

            // Act
            var evt = JsonSerializer.Deserialize<PreUserRegistrationEventV1>(json);

            // Assert
            evt!.Connection.Should().NotBeNull();
            evt.Connection!.Name.Should().Be("Username-Password-Authentication");
            evt.Connection.Strategy.Should().Be(Auth0.Actions.ConnectionStrategies.Auth0);
        }

        [TestMethod]
        public async Task V1PreUserRegistrationEvent_RoundTrip_PreservesData()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);
            var options = new JsonSerializerOptions
            {
                WriteIndented = false,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            // Act
            var evt = JsonSerializer.Deserialize<PreUserRegistrationEventV1>(json, options);
            var serialized = JsonSerializer.Serialize(evt, options);
            var deserialized = JsonSerializer.Deserialize<PreUserRegistrationEventV1>(serialized, options);

            // Assert
            deserialized.Should().NotBeNull();
            deserialized!.User!.Email.Should().Be(evt!.User!.Email);
            deserialized.Client!.ClientId.Should().Be(evt.Client!.ClientId);
        }
    }
}
