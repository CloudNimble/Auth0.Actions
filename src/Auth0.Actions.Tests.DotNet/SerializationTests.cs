using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Auth0.Actions.Tests.DotNet
{

    [TestClass]
    public class SerializationTests
    {

        private const string Request1Path = @"Baselines\Auth0ActionsRequest1.json";


        [TestMethod]
        public async Task PostLoginEvent_CanDeserialize()
        {
            var content = await File.ReadAllTextAsync(Request1Path);
            content.Should().NotBeNullOrWhiteSpace().And.Contain("client_id");

            var postLoginEvent = JsonSerializer.Deserialize<PostLoginEvent<dynamic, dynamic, dynamic, dynamic>>(content);
            postLoginEvent.Should().NotBeNull();

            postLoginEvent.Authentication.Should().NotBeNull();
            postLoginEvent.Authentication.Methods.Should().NotBeNull().And.HaveCount(2);

            postLoginEvent.Authorization.Should().NotBeNull();
            postLoginEvent.Authorization.Roles.Should().NotBeNull().And.BeEmpty();

            postLoginEvent.Client.Should().NotBeNull();
            postLoginEvent.Client.ClientId.Should().Be("gmOWNgklfRm4tyl5YYnl3JDSJy19h1bR");

            //postLoginEvent.Configuration.Should().BeNull();
            postLoginEvent.Connection.Should().NotBeNull();
            postLoginEvent.Connection.Id.Should().Be("con_fpe5kj482KO1eOzQ");
            postLoginEvent.Connection.Name.Should().Be("Username-Password-Authentication");
            postLoginEvent.Connection.Strategy.Should().Be("auth0");

            postLoginEvent.Organization.Should().NotBeNull();

            postLoginEvent.Request.Should().NotBeNull();

            postLoginEvent.ResourceServer.Should().NotBeNull();
            postLoginEvent.ResourceServer.Identifier.Should().Be("auth0actions.auth0.com/api/v2");

            //postLoginEvent.Secrets.Should().NotBeNull();

            postLoginEvent.Stats.Should().NotBeNull();

            postLoginEvent.Tenant.Should().NotBeNull();
            postLoginEvent.Tenant.Id.Should().Be("auth0actions");

            postLoginEvent.Transaction.Should().NotBeNull();

            postLoginEvent.User.Should().NotBeNull();

        }

    }

}
