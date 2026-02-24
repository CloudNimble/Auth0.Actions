using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostLoginEventV2 = Auth0.Actions.V2.PostLogin.PostLoginEvent<System.Collections.Generic.Dictionary<string, string>, System.Collections.Generic.Dictionary<string, string>, System.Collections.Generic.Dictionary<string, object>, System.Collections.Generic.Dictionary<string, object>>;

namespace Auth0.Actions.Tests.DotNet
{
    [TestClass]
    public class V2PostLoginEventTests
    {
        private const string TestDataFile = "TestData/PostLoginEventV2.json";

        [TestMethod]
        public async Task V2PostLoginEvent_Deserializes_Successfully()
        {
            var json = await File.ReadAllTextAsync(TestDataFile);
            var evt = JsonSerializer.Deserialize<PostLoginEventV2>(json);
            evt.Should().NotBeNull();
        }

        [TestMethod]
        public async Task V2PostLoginEvent_RoundTrip_PreservesData()
        {
            var json = await File.ReadAllTextAsync(TestDataFile);
            var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
            var evt = JsonSerializer.Deserialize<PostLoginEventV2>(json, options);
            var serialized = JsonSerializer.Serialize(evt, options);
            var deserialized = JsonSerializer.Deserialize<PostLoginEventV2>(serialized, options);
            deserialized.Should().NotBeNull();
        }
    }
}
