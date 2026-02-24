using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostUserRegistrationEventV1 = Auth0.Actions.V1.PostUserRegistration.PostUserRegistrationEvent<System.Collections.Generic.Dictionary<string, string>, System.Collections.Generic.Dictionary<string, string>, System.Collections.Generic.Dictionary<string, object>, System.Collections.Generic.Dictionary<string, object>>;

namespace Auth0.Actions.Tests.DotNet
{
    /// <summary>
    /// Tests for V1 PostUserRegistrationEvent.
    /// Triggered asynchronously after user registration completes.
    /// </summary>
    [TestClass]
    public class V1PostUserRegistrationEventTests
    {
        private const string TestDataFile = "TestData/PostUserRegistrationEventV1.json";

        [TestMethod]
        public async Task V1PostUserRegistrationEvent_Deserializes_Successfully()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);

            // Act
            var evt = JsonSerializer.Deserialize<PostUserRegistrationEventV1>(json);

            // Assert
            evt.Should().NotBeNull();
        }

        [TestMethod]
        public async Task V1PostUserRegistrationEvent_User_HasCompleteProfile()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);

            // Act
            var evt = JsonSerializer.Deserialize<PostUserRegistrationEventV1>(json);

            // Assert
            evt!.User.Should().NotBeNull();
            evt.User!.UserId.Should().Be("auth0|123456");
            evt.User.Email.Should().Be("newuser@example.com");
            evt.User.CreatedAt.Should().NotBeNullOrWhiteSpace();
        }

        [TestMethod]
        public async Task V1PostUserRegistrationEvent_RoundTrip_PreservesData()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);
            var options = new JsonSerializerOptions
            {
                WriteIndented = false,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            // Act
            var evt = JsonSerializer.Deserialize<PostUserRegistrationEventV1>(json, options);
            var serialized = JsonSerializer.Serialize(evt, options);
            var deserialized = JsonSerializer.Deserialize<PostUserRegistrationEventV1>(serialized, options);

            // Assert
            deserialized.Should().NotBeNull();
            deserialized!.User!.UserId.Should().Be(evt!.User!.UserId);
        }
    }
}
