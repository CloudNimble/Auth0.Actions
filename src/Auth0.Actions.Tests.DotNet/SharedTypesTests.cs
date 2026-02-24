using System.Text.Json;
using Auth0.Actions;
using Auth0.Actions.V3.PostLogin;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Auth0.Actions.Tests.DotNet
{
    /// <summary>
    /// Tests for shared types that are used across multiple action types.
    /// </summary>
    [TestClass]
    public class SharedTypesTests
    {
        [TestMethod]
        public void IPAddressDetails_Serializes_Successfully()
        {
            // Arrange
            var ipDetails = new IPAddressDetails
            {
                Category = "suspicious",
                IPAddress = "192.168.1.1",
                Matches = "blacklist",
                Source = "internal"
            };

            // Act
            var json = JsonSerializer.Serialize(ipDetails);
            var deserialized = JsonSerializer.Deserialize<IPAddressDetails>(json);

            // Assert
            deserialized.Should().NotBeNull();
            deserialized!.IPAddress.Should().Be("192.168.1.1");
            deserialized.Category.Should().Be("suspicious");
        }

        [TestMethod]
        public void NewDeviceDetails_Serializes_Successfully()
        {
            // Arrange
            var deviceDetails = new NewDeviceDetails
            {
                Device = "mobile",
                UserAgent = "Mozilla/5.0"
            };

            // Act
            var json = JsonSerializer.Serialize(deviceDetails);
            var deserialized = JsonSerializer.Deserialize<NewDeviceDetails>(json);

            // Assert
            deserialized.Should().NotBeNull();
            deserialized!.Device.Should().Be("mobile");
            deserialized.UserAgent.Should().Be("Mozilla/5.0");
        }

        [TestMethod]
        public void RiskAssessmentBase_Serializes_Successfully()
        {
            // Arrange
            var riskAssessment = new RiskAssessmentBase
            {
                Code = "high_risk",
                Confidence = "high"
            };

            // Act
            var json = JsonSerializer.Serialize(riskAssessment);
            var deserialized = JsonSerializer.Deserialize<RiskAssessmentBase>(json);

            // Assert
            deserialized.Should().NotBeNull();
            deserialized!.Code.Should().Be("high_risk");
            deserialized.Confidence.Should().Be("high");
        }

        [TestMethod]
        public void EnrolledFactor_Serializes_Successfully()
        {
            // Arrange
            var factor = new EnrolledFactor
            {
                Type = "otp",
                Name = "Authenticator App",
                CreatedAt = "2024-01-01T00:00:00.000Z",
                LastAuth = "2024-01-15T10:30:00.000Z"
            };

            // Act
            var json = JsonSerializer.Serialize(factor);
            var deserialized = JsonSerializer.Deserialize<EnrolledFactor>(json);

            // Assert
            deserialized.Should().NotBeNull();
            deserialized!.Type.Should().Be("otp");
            deserialized.Name.Should().Be("Authenticator App");
        }

        [TestMethod]
        public void RiskAssessmentWithDetails_Serializes_Successfully()
        {
            // Arrange
            var riskAssessment = new RiskAssessmentWithDetails<IPAddressDetails>
            {
                Code = "high_risk",
                Confidence = "high",
                Details = new IPAddressDetails
                {
                    Category = "suspicious",
                    IPAddress = "192.168.1.1",
                    Matches = "blacklist",
                    Source = "internal"
                }
            };

            // Act
            var json = JsonSerializer.Serialize(riskAssessment);
            var deserialized = JsonSerializer.Deserialize<RiskAssessmentWithDetails<IPAddressDetails>>(json);

            // Assert
            deserialized.Should().NotBeNull();
            deserialized!.Code.Should().Be("high_risk");
            deserialized.Details.Should().NotBeNull();
            deserialized.Details!.IPAddress.Should().Be("192.168.1.1");
        }
    }
}
