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
            postLoginEvent.Authentication.RiskAssessment.Should().NotBeNull();
            postLoginEvent.Authentication.RiskAssessment.Confidence.Should().Be("low");
            postLoginEvent.Authentication.RiskAssessment.Version.Should().Be("1");
            postLoginEvent.Authentication.RiskAssessment.Assessments.Should().NotBeNull();
            postLoginEvent.Authentication.RiskAssessment.Assessments.ImpossibleTravel.Should().NotBeNull();
            postLoginEvent.Authentication.RiskAssessment.Assessments.ImpossibleTravel.Code.Should().Be("impossible_travel_from_last_login");
            postLoginEvent.Authentication.RiskAssessment.Assessments.ImpossibleTravel.Confidence.Should().Be("low");
            postLoginEvent.Authentication.RiskAssessment.Assessments.NewDevice.Should().NotBeNull();
            postLoginEvent.Authentication.RiskAssessment.Assessments.NewDevice.Details.Should().NotBeNull();
            postLoginEvent.Authentication.RiskAssessment.Assessments.NewDevice.Details.Device.Should().Be("unknown");
            postLoginEvent.Authentication.RiskAssessment.Assessments.UntrustedIP.Should().NotBeNull();
            postLoginEvent.Authentication.RiskAssessment.Assessments.UntrustedIP.Details.Should().NotBeNull();
            postLoginEvent.Authentication.RiskAssessment.Assessments.UntrustedIP.Details.IPAddress.Should().Be("1.1.1.1");

            postLoginEvent.Authorization.Should().NotBeNull();
            postLoginEvent.Authorization.Roles.Should().NotBeNull().And.BeEmpty();

            postLoginEvent.Client.Should().NotBeNull();
            postLoginEvent.Client.ClientId.Should().Be("gmOWNgklfRm4tyl5YYnl3JDSJy19h1bR");
            postLoginEvent.Client.Name.Should().Be("All Applications");

            //postLoginEvent.Configuration.Should().BeNull();
            postLoginEvent.Connection.Should().NotBeNull();
            postLoginEvent.Connection.Id.Should().Be("con_fpe5kj482KO1eOzQ");
            postLoginEvent.Connection.Name.Should().Be("Username-Password-Authentication");
            postLoginEvent.Connection.Strategy.Should().Be("auth0");

            postLoginEvent.Organization.Should().NotBeNull();
            postLoginEvent.Organization.DisplayName.Should().Be("My Organization");
            postLoginEvent.Organization.Id.Should().Be("org_juG7cAQ0CymOcVpV");
            postLoginEvent.Organization.Name.Should().Be("my-organization");

            postLoginEvent.Request.Should().NotBeNull();

            postLoginEvent.ResourceServer.Should().NotBeNull();
            postLoginEvent.ResourceServer.Identifier.Should().Be("auth0actions.auth0.com/api/v2");

            //postLoginEvent.Secrets.Should().NotBeNull();

            postLoginEvent.Stats.Should().NotBeNull();
            postLoginEvent.Stats.LoginsCount.Should().Be(62);

            postLoginEvent.Tenant.Should().NotBeNull();
            postLoginEvent.Tenant.Id.Should().Be("auth0actions");

            postLoginEvent.Transaction.Should().NotBeNull();

            postLoginEvent.User.Should().NotBeNull();
            postLoginEvent.User.Identities.Should().ContainSingle();
            postLoginEvent.User.Identities[0].AccessToken.Should().StartWith("eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWI");
            postLoginEvent.User.Identities[0].Connection.Should().Be("Username-Password-Authentication");
        }

    }

}
