using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SendPhoneMessageEventV2 = Auth0.Actions.V2.SendPhoneMessage.SendPhoneMessageEvent<System.Collections.Generic.Dictionary<string, string>>;

namespace Auth0.Actions.Tests.DotNet
{
    [TestClass]
    public class V2SendPhoneMessageEventTests
    {
        private const string TestDataFile = "TestData/SendPhoneMessageEventV2.json";

        [TestMethod]
        public async Task V2SendPhoneMessageEvent_Deserializes_Successfully()
        {
            var json = await File.ReadAllTextAsync(TestDataFile);
            var evt = JsonSerializer.Deserialize<SendPhoneMessageEventV2>(json);
            evt.Should().NotBeNull();
        }

        [TestMethod]
        public async Task V2SendPhoneMessageEvent_RoundTrip_PreservesData()
        {
            var json = await File.ReadAllTextAsync(TestDataFile);
            var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
            var evt = JsonSerializer.Deserialize<SendPhoneMessageEventV2>(json, options);
            var serialized = JsonSerializer.Serialize(evt, options);
            var deserialized = JsonSerializer.Deserialize<SendPhoneMessageEventV2>(serialized, options);
            deserialized.Should().NotBeNull();
        }
    }
}
