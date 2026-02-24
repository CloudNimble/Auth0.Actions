using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomPhoneProviderEventV1 = Auth0.Actions.V1.CustomPhoneProvider.CustomPhoneProviderEvent<System.Collections.Generic.Dictionary<string, string>>;

namespace Auth0.Actions.Tests.DotNet
{
    /// <summary>
    /// Tests for V1 CustomPhoneProviderEvent.
    /// Allows implementing custom SMS/phone providers.
    /// </summary>
    [TestClass]
    public class V1CustomPhoneProviderEventTests
    {
        private const string TestDataFile = "TestData/CustomPhoneProviderEventV1.json";

        [TestMethod]
        public async Task V1CustomPhoneProviderEvent_Deserializes_Successfully()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);

            // Act
            var evt = JsonSerializer.Deserialize<CustomPhoneProviderEventV1>(json);

            // Assert
            evt.Should().NotBeNull();
        }

        [TestMethod]
        public async Task V1CustomPhoneProviderEvent_PhoneNumber_DeserializesCorrectly()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);

            // Act
            var evt = JsonSerializer.Deserialize<CustomPhoneProviderEventV1>(json);

            // Assert
            evt!.PhoneNumber.Should().Be("+15551234567");
            evt.Message.Should().Contain("654321");
            evt.Purpose.Should().Be("mfa_verification");
        }

        [TestMethod]
        public async Task V1CustomPhoneProviderEvent_Tenant_IsPresent()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);

            // Act
            var evt = JsonSerializer.Deserialize<CustomPhoneProviderEventV1>(json);

            // Assert
            evt!.Tenant.Should().NotBeNull();
            evt.Tenant!.Id.Should().Be("tenant-789");
        }

        [TestMethod]
        public async Task V1CustomPhoneProviderEvent_RoundTrip_PreservesData()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);
            var options = new JsonSerializerOptions
            {
                WriteIndented = false,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            // Act
            var evt = JsonSerializer.Deserialize<CustomPhoneProviderEventV1>(json, options);
            var serialized = JsonSerializer.Serialize(evt, options);
            var deserialized = JsonSerializer.Deserialize<CustomPhoneProviderEventV1>(serialized, options);

            // Assert
            deserialized.Should().NotBeNull();
            deserialized!.PhoneNumber.Should().Be(evt!.PhoneNumber);
        }
    }
}
