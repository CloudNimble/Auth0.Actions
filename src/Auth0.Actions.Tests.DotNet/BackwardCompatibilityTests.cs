using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Auth0.Actions;
using Auth0.Actions.Serialization;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Auth0.Actions.Tests.DotNet
{
    /// <summary>
    /// Tests for backward compatibility aliases in the root Auth0.Actions namespace.
    /// These types are obsolete but still supported for existing code.
    /// </summary>
    [TestClass]
    public class BackwardCompatibilityTests
    {
        [TestMethod]
        public async Task RootNamespace_PostLoginEvent_StillWorks()
        {
            // Arrange
            var json = await File.ReadAllTextAsync("TestData/PostLoginEventV2.json");

            // Act - Using source-generated AOT serialization
            #pragma warning disable CS0618 // Type is obsolete
            var evt = JsonSerializer.Deserialize(json, Auth0ActionsJsonContext.Default.RootPostLoginEvent);
            #pragma warning restore CS0618

            // Assert - Test all properties to achieve 100% coverage
            evt.Should().NotBeNull();
            evt!.Client.Should().NotBeNull();
            evt.Client!.ClientId.Should().Be("login-client-v2-123");
            evt.Authentication.Should().NotBeNull();
            evt.Authorization.Should().BeNull(); // Not in V2 JSON
            evt.Configuration.Should().BeNull(); // Not in V2 JSON
            evt.Connection.Should().NotBeNull();
            evt.Connection!.Name.Should().Be("Username-Password-Authentication");
            evt.Organization.Should().BeNull(); // Not in V2 JSON
            evt.Request.Should().NotBeNull();
            evt.Request!.IpAddress.Should().Be("203.0.113.1");
            evt.ResourceServer.Should().BeNull(); // Not in V2 JSON
            evt.Secrets.Should().NotBeNull();
            evt.Stats.Should().BeNull(); // Not in V2 JSON
            evt.Tenant.Should().NotBeNull();
            evt.Tenant!.Id.Should().Be("tenant-v2-789");
            evt.Transaction.Should().NotBeNull();
            evt.Transaction!.RequestedScopes.Should().Contain("openid");
            evt.User.Should().NotBeNull();
            evt.User!.Email.Should().Be("user.v2@example.com");
        }

        [TestMethod]
        public async Task RootNamespace_CredentialsExchangeEvent_StillWorks()
        {
            // Arrange
            var json = await File.ReadAllTextAsync("TestData/CredentialsExchangeEventV2.json");

            // Act - Using source-generated AOT serialization
            #pragma warning disable CS0618 // Type is obsolete
            var evt = JsonSerializer.Deserialize(json, Auth0ActionsJsonContext.Default.RootCredentialsExchangeEvent);
            #pragma warning restore CS0618

            // Assert
            evt.Should().NotBeNull();
            evt!.Client.Should().NotBeNull();
        }
    }
}
