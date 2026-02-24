using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordResetPostChallengeEventV1 = Auth0.Actions.V1.PasswordResetPostChallenge.PasswordResetPostChallengeEvent<System.Collections.Generic.Dictionary<string, string>, System.Collections.Generic.Dictionary<string, string>, System.Collections.Generic.Dictionary<string, object>, System.Collections.Generic.Dictionary<string, object>>;

namespace Auth0.Actions.Tests.DotNet
{
    /// <summary>
    /// Tests for V1 PasswordResetPostChallengeEvent.
    /// Triggered after password reset challenge verification.
    /// </summary>
    [TestClass]
    public class V1PasswordResetPostChallengeEventTests
    {
        private const string TestDataFile = "TestData/PasswordResetPostChallengeEventV1.json";

        [TestMethod]
        public async Task V1PasswordResetPostChallengeEvent_Deserializes_Successfully()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);

            // Act
            var evt = JsonSerializer.Deserialize<PasswordResetPostChallengeEventV1>(json);

            // Assert
            evt.Should().NotBeNull();
        }

        [TestMethod]
        public async Task V1PasswordResetPostChallengeEvent_User_DeserializesCorrectly()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);

            // Act
            var evt = JsonSerializer.Deserialize<PasswordResetPostChallengeEventV1>(json);

            // Assert
            evt!.User.Should().NotBeNull();
            evt.User!.Email.Should().Be("user@example.com");
            evt.User.EmailVerified.Should().BeTrue();
        }

        [TestMethod]
        public async Task V1PasswordResetPostChallengeEvent_Connection_IsPasswordBased()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);

            // Act
            var evt = JsonSerializer.Deserialize<PasswordResetPostChallengeEventV1>(json);

            // Assert
            evt!.Connection.Should().NotBeNull();
            evt.Connection!.Strategy.Should().Be(Auth0.Actions.ConnectionStrategies.Auth0);
        }

        [TestMethod]
        public async Task V1PasswordResetPostChallengeEvent_RoundTrip_PreservesData()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);
            var options = new JsonSerializerOptions
            {
                WriteIndented = false,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            // Act
            var evt = JsonSerializer.Deserialize<PasswordResetPostChallengeEventV1>(json, options);
            var serialized = JsonSerializer.Serialize(evt, options);
            var deserialized = JsonSerializer.Deserialize<PasswordResetPostChallengeEventV1>(serialized, options);

            // Assert
            deserialized.Should().NotBeNull();
            deserialized!.User!.Email.Should().Be(evt!.User!.Email);
        }
    }
}
