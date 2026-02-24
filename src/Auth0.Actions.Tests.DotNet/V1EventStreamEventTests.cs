using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EventStreamEventV1 = Auth0.Actions.V1.EventStream.EventStreamEvent<System.Collections.Generic.Dictionary<string, string>>;

namespace Auth0.Actions.Tests.DotNet
{
    /// <summary>
    /// Tests for V1 EventStreamEvent.
    /// Supports real-time event streaming and webhooks.
    /// </summary>
    [TestClass]
    public class V1EventStreamEventTests
    {
        private const string TestDataFile = "TestData/EventStreamEventV1.json";

        [TestMethod]
        public async Task V1EventStreamEvent_Deserializes_Successfully()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);

            // Act
            var evt = JsonSerializer.Deserialize<EventStreamEventV1>(json);

            // Assert
            evt.Should().NotBeNull();
        }

        [TestMethod]
        public async Task V1EventStreamEvent_Event_HasType()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);

            // Act
            var evt = JsonSerializer.Deserialize<EventStreamEventV1>(json);

            // Assert
            evt!.Event.Should().NotBeNull();
            evt.Event!.EventType.Should().Be("sapi");
            evt.Event.EventId.Should().Be("evt_123456");
            evt.Event.Timestamp.Should().Be("2025-02-04T20:00:00.000Z");
        }

        [TestMethod]
        public async Task V1EventStreamEvent_Event_HasData()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);

            // Act
            var evt = JsonSerializer.Deserialize<EventStreamEventV1>(json);

            // Assert
            evt!.Event!.Data.Should().NotBeNull();
            evt.Event.Data.Should().ContainKey("user_id");
            evt.Event.Data.Should().ContainKey("user_name");
        }

        [TestMethod]
        public async Task V1EventStreamEvent_RoundTrip_PreservesData()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);
            var options = new JsonSerializerOptions
            {
                WriteIndented = false,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            // Act
            var evt = JsonSerializer.Deserialize<EventStreamEventV1>(json, options);
            var serialized = JsonSerializer.Serialize(evt, options);
            var deserialized = JsonSerializer.Deserialize<EventStreamEventV1>(serialized, options);

            // Assert
            deserialized.Should().NotBeNull();
            deserialized!.Event!.EventType.Should().Be(evt!.Event!.EventType);
        }
    }
}
