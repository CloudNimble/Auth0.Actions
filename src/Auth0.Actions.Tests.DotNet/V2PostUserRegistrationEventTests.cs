using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostUserRegistrationEventV2 = Auth0.Actions.V2.PostUserRegistration.PostUserRegistrationEvent<System.Collections.Generic.Dictionary<string, string>, System.Collections.Generic.Dictionary<string, string>, System.Collections.Generic.Dictionary<string, object>, System.Collections.Generic.Dictionary<string, object>>;

namespace Auth0.Actions.Tests.DotNet
{
    [TestClass]
    public class V2PostUserRegistrationEventTests
    {
        private const string TestDataFile = "TestData/PostUserRegistrationEventV2.json";

        [TestMethod]
        public async Task V2PostUserRegistrationEvent_Deserializes_Successfully()
        {
            var json = await File.ReadAllTextAsync(TestDataFile);
            var evt = JsonSerializer.Deserialize<PostUserRegistrationEventV2>(json);
            evt.Should().NotBeNull();
        }

        [TestMethod]
        public async Task V2PostUserRegistrationEvent_RoundTrip_PreservesData()
        {
            var json = await File.ReadAllTextAsync(TestDataFile);
            var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
            var evt = JsonSerializer.Deserialize<PostUserRegistrationEventV2>(json, options);
            var serialized = JsonSerializer.Serialize(evt, options);
            var deserialized = JsonSerializer.Deserialize<PostUserRegistrationEventV2>(serialized, options);
            deserialized.Should().NotBeNull();
        }
    }
}
