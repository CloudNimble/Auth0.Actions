using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostChangePasswordEventV2 = Auth0.Actions.V2.PostChangePassword.PostChangePasswordEvent<System.Collections.Generic.Dictionary<string, string>, System.Collections.Generic.Dictionary<string, string>, System.Collections.Generic.Dictionary<string, object>, System.Collections.Generic.Dictionary<string, object>>;

namespace Auth0.Actions.Tests.DotNet
{
    [TestClass]
    public class V2PostChangePasswordEventTests
    {
        private const string TestDataFile = "TestData/PostChangePasswordEventV2.json";

        [TestMethod]
        public async Task V2PostChangePasswordEvent_Deserializes_Successfully()
        {
            var json = await File.ReadAllTextAsync(TestDataFile);
            var evt = JsonSerializer.Deserialize<PostChangePasswordEventV2>(json);
            evt.Should().NotBeNull();
        }

        [TestMethod]
        public async Task V2PostChangePasswordEvent_RoundTrip_PreservesData()
        {
            var json = await File.ReadAllTextAsync(TestDataFile);
            var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
            var evt = JsonSerializer.Deserialize<PostChangePasswordEventV2>(json, options);
            var serialized = JsonSerializer.Serialize(evt, options);
            var deserialized = JsonSerializer.Deserialize<PostChangePasswordEventV2>(serialized, options);
            deserialized.Should().NotBeNull();
        }
    }
}
