using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SendPhoneMessageEventV1 = Auth0.Actions.V1.SendPhoneMessage.SendPhoneMessageEvent<System.Collections.Generic.Dictionary<string, string>>;

namespace Auth0.Actions.Tests.DotNet
{
    /// <summary>
    /// Tests for V1 SendPhoneMessageEvent.
    /// Triggered when Auth0 needs to send SMS messages for MFA or verification.
    /// </summary>
    [TestClass]
    public class V1SendPhoneMessageEventTests
    {
        private const string TestDataFile = "TestData/SendPhoneMessageEventV1.json";

        [TestMethod]
        public async Task V1SendPhoneMessageEvent_Deserializes_Successfully()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);

            // Act
            var evt = JsonSerializer.Deserialize<SendPhoneMessageEventV1>(json);

            // Assert
            evt.Should().NotBeNull();
        }

        [TestMethod]
        public async Task V1SendPhoneMessageEvent_ContainsRecipientAndMessageText()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);

            // Act
            var evt = JsonSerializer.Deserialize<SendPhoneMessageEventV1>(json);

            // Assert
            evt!.Recipient.Should().Be("+15551234567");
            evt.MessageText.Should().Contain("123456");
            evt.MessageType.Should().Be("enrollment");
        }

        [TestMethod]
        public async Task V1SendPhoneMessageEvent_Tenant_IsPresent()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);

            // Act
            var evt = JsonSerializer.Deserialize<SendPhoneMessageEventV1>(json);

            // Assert
            evt!.Tenant.Should().NotBeNull();
            evt.Tenant!.Id.Should().Be("tenant-789");
        }

        [TestMethod]
        public async Task V1SendPhoneMessageEvent_RoundTrip_PreservesData()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);
            var options = new JsonSerializerOptions
            {
                WriteIndented = false,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            // Act
            var evt = JsonSerializer.Deserialize<SendPhoneMessageEventV1>(json, options);
            var serialized = JsonSerializer.Serialize(evt, options);
            var deserialized = JsonSerializer.Deserialize<SendPhoneMessageEventV1>(serialized, options);

            // Assert
            deserialized.Should().NotBeNull();
            deserialized!.Recipient.Should().Be(evt!.Recipient);
        }
    }
}
