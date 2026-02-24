using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomEmailProviderEventV1 = Auth0.Actions.V1.CustomEmailProvider.CustomEmailProviderEvent<System.Collections.Generic.Dictionary<string, string>>;

namespace Auth0.Actions.Tests.DotNet
{
    /// <summary>
    /// Tests for V1 CustomEmailProviderEvent.
    /// Allows implementing custom email delivery providers.
    /// </summary>
    [TestClass]
    public class V1CustomEmailProviderEventTests
    {
        private const string TestDataFile = "TestData/CustomEmailProviderEventV1.json";

        [TestMethod]
        public async Task V1CustomEmailProviderEvent_Deserializes_Successfully()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);

            // Act
            var evt = JsonSerializer.Deserialize<CustomEmailProviderEventV1>(json);

            // Assert
            evt.Should().NotBeNull();
        }

        [TestMethod]
        public async Task V1CustomEmailProviderEvent_Recipient_HasEmailAndUserId()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);

            // Act
            var evt = JsonSerializer.Deserialize<CustomEmailProviderEventV1>(json);

            // Assert
            evt!.Recipient.Should().NotBeNull();
            evt.Recipient!.Email.Should().Be("user@example.com");
            evt.Recipient.UserId.Should().Be("auth0|123456");
        }

        [TestMethod]
        public async Task V1CustomEmailProviderEvent_Email_HasSubjectAndBody()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);

            // Act
            var evt = JsonSerializer.Deserialize<CustomEmailProviderEventV1>(json);

            // Assert
            evt!.Email.Should().NotBeNull();
            evt.Email!.Subject.Should().Be("Verify your email");
            evt.Email.Body.Should().Contain("verify");
            evt.Email.Type.Should().Be("verification");
        }

        [TestMethod]
        public async Task V1CustomEmailProviderEvent_RoundTrip_PreservesData()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);
            var options = new JsonSerializerOptions
            {
                WriteIndented = false,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            // Act
            var evt = JsonSerializer.Deserialize<CustomEmailProviderEventV1>(json, options);
            var serialized = JsonSerializer.Serialize(evt, options);
            var deserialized = JsonSerializer.Deserialize<CustomEmailProviderEventV1>(serialized, options);

            // Assert
            deserialized.Should().NotBeNull();
            deserialized!.Recipient!.Email.Should().Be(evt!.Recipient!.Email);
        }
    }
}
