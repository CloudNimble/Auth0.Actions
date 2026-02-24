using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Auth0.Actions.Serialization;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostLoginEventV3 = Auth0.Actions.V3.PostLogin.PostLoginEvent<System.Collections.Generic.Dictionary<string, string>, System.Collections.Generic.Dictionary<string, string>, System.Collections.Generic.Dictionary<string, object>, System.Collections.Generic.Dictionary<string, object>>;

namespace Auth0.Actions.Tests.DotNet
{
    /// <summary>
    /// Comprehensive serialization tests for V3 PostLoginEvent.
    /// Tests deserialization, property mapping, and roundtrip serialization.
    /// </summary>
    [TestClass]
    public class V3PostLoginEventTests
    {
        private const string TestDataFile = "TestData/PostLoginEventV3.json";

        [TestMethod]
        public async Task V3PostLoginEvent_Deserializes_Successfully()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);
            json.Should().NotBeNullOrWhiteSpace();

            // Act - Using source-generated AOT serialization
            var evt = JsonSerializer.Deserialize(json, Auth0ActionsJsonContext.Default.V3PostLoginEvent);

            // Assert
            evt.Should().NotBeNull();
        }

        [TestMethod]
        public async Task V3PostLoginEvent_Authentication_DeserializesCorrectly()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);

            // Act - Using source-generated AOT serialization
            var evt = JsonSerializer.Deserialize(json, Auth0ActionsJsonContext.Default.V3PostLoginEvent);

            // Assert
            evt!.Authentication.Should().NotBeNull();
            evt.Authentication!.Methods.Should().HaveCount(2);
            evt.Authentication.RiskAssessment.Should().NotBeNull();
            evt.Authentication.RiskAssessment!.Confidence.Should().Be("low");
            evt.Authentication.RiskAssessment.Version.Should().Be("1");
        }

        [TestMethod]
        public async Task V3PostLoginEvent_Client_DeserializesWithMetadata()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);

            // Act
            var evt = JsonSerializer.Deserialize(json, Auth0ActionsJsonContext.Default.V3PostLoginEvent);

            // Assert
            evt!.Client.Should().NotBeNull();
            evt.Client!.ClientId.Should().Be("test-client-123");
            evt.Client.Name.Should().Be("Test Application");
            evt.Client.Metadata.Should().ContainKey("environment");
            evt.Client.Metadata!["environment"].Should().Be("production");
        }

        [TestMethod]
        public async Task V3PostLoginEvent_CustomDomain_DeserializesCorrectly()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);

            // Act
            var evt = JsonSerializer.Deserialize(json, Auth0ActionsJsonContext.Default.V3PostLoginEvent);

            // Assert
            evt!.CustomDomain.Should().NotBeNull();
            evt.CustomDomain!.Id.Should().Be("cd_123");
            evt.CustomDomain.Domain.Should().Be("login.example.com");
            evt.CustomDomain.Primary.Should().BeTrue();
            evt.CustomDomain.Status.Should().Be("ready");
            evt.CustomDomain.Type.Should().Be("auth0_managed_certs");
        }

        [TestMethod]
        public async Task V3PostLoginEvent_RefreshToken_DeserializesWithEnterpriseFeatures()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);

            // Act
            var evt = JsonSerializer.Deserialize(json, Auth0ActionsJsonContext.Default.V3PostLoginEvent);

            // Assert
            evt!.RefreshToken.Should().NotBeNull();
            evt.RefreshToken!.Id.Should().Be("rt_123");
            evt.RefreshToken.Rotate.Should().BeTrue();
            evt.RefreshToken.Scopes.Should().Contain("openid");
            evt.RefreshToken.UseCount.Should().Be(0);
            evt.RefreshToken.MaxUses.Should().Be(100);
        }

        [TestMethod]
        public async Task V3PostLoginEvent_SecurityContext_DeserializesFingerprints()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);

            // Act
            var evt = JsonSerializer.Deserialize(json, Auth0ActionsJsonContext.Default.V3PostLoginEvent);

            // Assert
            evt!.SecurityContext.Should().NotBeNull();
            evt.SecurityContext!.JA3.Should().Be("abc123def456");
            evt.SecurityContext.JA4.Should().Be("xyz789uvw012");
        }

        [TestMethod]
        public async Task V3PostLoginEvent_Session_DeserializesWithEnterpriseData()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);

            // Act
            var evt = JsonSerializer.Deserialize(json, Auth0ActionsJsonContext.Default.V3PostLoginEvent);

            // Assert
            evt!.Session.Should().NotBeNull();
            evt.Session!.Id.Should().Be("sess_123");
            evt.Session.AuthenticationMethods.Should().Contain("pwd");
            evt.Session.AuthenticationMethods.Should().Contain("mfa");
        }

        [TestMethod]
        public async Task V3PostLoginEvent_Transaction_IncludesCorrelationId()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);

            // Act
            var evt = JsonSerializer.Deserialize(json, Auth0ActionsJsonContext.Default.V3PostLoginEvent);

            // Assert
            evt!.Transaction.Should().NotBeNull();
            evt.Transaction!.Id.Should().Be("tx_123");
            evt.Transaction.CorrelationId.Should().Be("corr_456");
            evt.Transaction.Metadata.Should().NotBeNull();
        }

        [TestMethod]
        public async Task V3PostLoginEvent_User_IncludesEnrolledFactors()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);

            // Act
            var evt = JsonSerializer.Deserialize(json, Auth0ActionsJsonContext.Default.V3PostLoginEvent);

            // Assert
            evt!.User.Should().NotBeNull();
            evt.User!.Email.Should().Be("user@example.com");
            evt.User.EnrolledFactors.Should().NotBeNull();
            evt.User.EnrolledFactors.Should().HaveCountGreaterThan(0);
        }

        [TestMethod]
        public async Task V3PostLoginEvent_Request_IncludesASN()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);

            // Act
            var evt = JsonSerializer.Deserialize(json, Auth0ActionsJsonContext.Default.V3PostLoginEvent);

            // Assert
            evt!.Request.Should().NotBeNull();
            evt.Request!.Asn.Should().Be("AS15169");
        }

        [TestMethod]
        public async Task V3PostLoginEvent_Request_IncludesGeoIP()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);

            // Act
            var evt = JsonSerializer.Deserialize(json, Auth0ActionsJsonContext.Default.V3PostLoginEvent);

            // Assert
            evt!.Request!.GeoIP.Should().NotBeNull();
            evt.Request.GeoIP!.CityName.Should().Be("San Francisco");
            evt.Request.GeoIP.TwoLetterCountryCode.Should().Be("US");
            evt.Request.GeoIP.Latitude.Should().BeApproximately(37.7749f, 0.0001f);
        }

        [TestMethod]
        public async Task V3PostLoginEvent_User_IncludesIdentities()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);

            // Act
            var evt = JsonSerializer.Deserialize(json, Auth0ActionsJsonContext.Default.V3PostLoginEvent);

            // Assert
            evt!.User!.Identities.Should().NotBeNull();
            evt.User.Identities.Should().HaveCountGreaterThan(0);
            var identity = evt.User.Identities[0];
            identity.Connection.Should().Be("Username-Password-Authentication");
            identity.Provider.Should().Be("auth0");
            identity.IsSocial.Should().BeFalse();
        }

        [TestMethod]
        public async Task V3PostLoginEvent_User_EnrolledFactors_Populated()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);

            // Act
            var evt = JsonSerializer.Deserialize(json, Auth0ActionsJsonContext.Default.V3PostLoginEvent);

            // Assert
            evt!.User!.EnrolledFactors.Should().NotBeNull();
            evt.User.EnrolledFactors.Should().HaveCountGreaterThan(0);
        }

        [TestMethod]
        public async Task V3PostLoginEvent_RoundTrip_PreservesData()
        {
            // Arrange
            var json = await File.ReadAllTextAsync(TestDataFile);

            // Act - Using source-generated AOT serialization for round-trip
            var evt = JsonSerializer.Deserialize(json, Auth0ActionsJsonContext.Default.V3PostLoginEvent);
            var serialized = JsonSerializer.Serialize(evt, Auth0ActionsJsonContext.Default.V3PostLoginEvent);
            var deserialized = JsonSerializer.Deserialize(serialized, Auth0ActionsJsonContext.Default.V3PostLoginEvent);

            // Assert
            deserialized.Should().NotBeNull();
            deserialized!.Client!.ClientId.Should().Be(evt!.Client!.ClientId);
            deserialized.User!.Email.Should().Be(evt.User!.Email);
            deserialized.CustomDomain!.Domain.Should().Be(evt.CustomDomain!.Domain);
        }
    }
}
