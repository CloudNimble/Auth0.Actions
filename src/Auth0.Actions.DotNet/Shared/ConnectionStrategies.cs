using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// Defines the supported Auth0 connection strategy types for identity providers.
    /// </summary>
    /// <remarks>
    /// The strategy identifies the type of connection used to authenticate a user.
    /// For social connections, the strategy matches the connection name.
    /// For enterprise connections, values include 'waad', 'ad', or 'auth0'.
    /// </remarks>
    [JsonConverter(typeof(JsonStringEnumConverter<ConnectionStrategies>))]
    public enum ConnectionStrategies
    {

        /// <summary>
        /// Active Directory/LDAP connection.
        /// </summary>
        [EnumMember(Value = "ad")]
        AD,

        /// <summary>
        /// Active Directory Federation Services connection.
        /// </summary>
        [EnumMember(Value = "adfs")]
        Adfs,

        /// <summary>
        /// Amazon social connection.
        /// </summary>
        [EnumMember(Value = "amazon")]
        Amazon,

        /// <summary>
        /// Apple social connection.
        /// </summary>
        [EnumMember(Value = "apple")]
        Apple,

        /// <summary>
        /// AOL social connection.
        /// </summary>
        [EnumMember(Value = "aol")]
        Aol,

        /// <summary>
        /// Auth0 database connection.
        /// </summary>
        [EnumMember(Value = "auth0")]
        Auth0,

        /// <summary>
        /// Auth0 OIDC connection.
        /// </summary>
        [EnumMember(Value = "auth0-oidc")]
        Auth0_Oidc,

        /// <summary>
        /// Azure Active Directory (Entra ID) enterprise connection.
        /// </summary>
        [EnumMember(Value = "waad")]
        AzureActiveDirectory,

        /// <summary>
        /// Baidu social connection.
        /// </summary>
        [EnumMember(Value = "baidu")]
        Baidu,

        /// <summary>
        /// Bitbucket social connection.
        /// </summary>
        [EnumMember(Value = "bitbucket")]
        Bitbucket,

        /// <summary>
        /// Bitly social connection.
        /// </summary>
        [EnumMember(Value = "bitly")]
        Bitly,

        /// <summary>
        /// Box social connection.
        /// </summary>
        [EnumMember(Value = "box")]
        Box,

        /// <summary>
        /// Custom connection type.
        /// </summary>
        [EnumMember(Value = "custom")]
        Custom,

        /// <summary>
        /// D-Account social connection.
        /// </summary>
        [EnumMember(Value = "daccount")]
        Daccount,

        /// <summary>
        /// Dropbox social connection.
        /// </summary>
        [EnumMember(Value = "dropbox")]
        Dropbox,

        /// <summary>
        /// Dwolla social connection.
        /// </summary>
        [EnumMember(Value = "dwolla")]
        Dwolla,

        /// <summary>
        /// Passwordless email connection.
        /// </summary>
        [EnumMember(Value = "email")]
        Email,

        /// <summary>
        /// Evernote social connection.
        /// </summary>
        [EnumMember(Value = "evernote")]
        Evernote,

        /// <summary>
        /// Evernote sandbox social connection.
        /// </summary>
        [EnumMember(Value = "evernote-sandbox")]
        Evernote_Sandbox,

        /// <summary>
        /// Exact Online social connection.
        /// </summary>
        [EnumMember(Value = "exact")]
        Exact,

        /// <summary>
        /// Facebook social connection.
        /// </summary>
        [EnumMember(Value = "facebook")]
        Facebook,

        /// <summary>
        /// Fitbit social connection.
        /// </summary>
        [EnumMember(Value = "fitbit")]
        fitbit,

        /// <summary>
        /// Flickr social connection.
        /// </summary>
        [EnumMember(Value = "flickr")]
        flickr,

        /// <summary>
        /// GitHub social connection.
        /// </summary>
        [EnumMember(Value = "github")]
        github,

        /// <summary>
        /// Google Apps (Workspace) enterprise connection.
        /// </summary>
        [EnumMember(Value = "google-apps")]
        GoogleApps,

        /// <summary>
        /// Google OAuth 2.0 social connection.
        /// </summary>
        [EnumMember(Value = "google-oauth2")]
        Google_OAuth2,

        /// <summary>
        /// Instagram social connection.
        /// </summary>
        [EnumMember(Value = "instagram")]
        Instagram,

        /// <summary>
        /// IP address-based connection.
        /// </summary>
        [EnumMember(Value = "ip")]
        IP,

        /// <summary>
        /// LINE social connection.
        /// </summary>
        [EnumMember(Value = "line")]
        Line,

        /// <summary>
        /// LinkedIn social connection.
        /// </summary>
        [EnumMember(Value = "linkedin")]
        LinkedIn,

        /// <summary>
        /// miiCard social connection.
        /// </summary>
        [EnumMember(Value = "miicard")]
        Miicard,

        /// <summary>
        /// Generic OAuth 1.0 connection.
        /// </summary>
        [EnumMember(Value = "oauth1")]
        OAuth1,

        /// <summary>
        /// Generic OAuth 2.0 connection.
        /// </summary>
        [EnumMember(Value = "oauth2")]
        OAuth2,

        /// <summary>
        /// Microsoft Office 365 enterprise connection.
        /// </summary>
        [EnumMember(Value = "office365")]
        Office365,

        /// <summary>
        /// Generic OpenID Connect connection.
        /// </summary>
        [EnumMember(Value = "oidc")]
        Oidc,

        /// <summary>
        /// Okta enterprise connection.
        /// </summary>
        [EnumMember(Value = "okta")]
        Okta,

        /// <summary>
        /// PayPal social connection.
        /// </summary>
        [EnumMember(Value = "paypal")]
        Paypal,

        /// <summary>
        /// PayPal sandbox social connection.
        /// </summary>
        [EnumMember(Value = "paypal-sandbox")]
        Paypal_Sandbox,

        /// <summary>
        /// PingFederate enterprise connection.
        /// </summary>
        [EnumMember(Value = "pingfederate")]
        PingFederate,

        /// <summary>
        /// Planning Center social connection.
        /// </summary>
        [EnumMember(Value = "planningcenter")]
        PlanningCenter,

        /// <summary>
        /// Renren social connection.
        /// </summary>
        [EnumMember(Value = "renren")]
        Renren,

        /// <summary>
        /// Salesforce social connection.
        /// </summary>
        [EnumMember(Value = "salesforce")]
        Salesforce,

        /// <summary>
        /// Salesforce Community social connection.
        /// </summary>
        [EnumMember(Value = "salesforce-community")]
        Salesforce_Community,

        /// <summary>
        /// Salesforce sandbox social connection.
        /// </summary>
        [EnumMember(Value = "salesforce-sandbox")]
        Salesforce_Sandbox,

        /// <summary>
        /// SAML protocol enterprise connection.
        /// </summary>
        [EnumMember(Value = "samlp")]
        Samlp,

        /// <summary>
        /// SharePoint enterprise connection.
        /// </summary>
        [EnumMember(Value = "sharepoint")]
        Sharepoint,

        /// <summary>
        /// Shopify social connection.
        /// </summary>
        [EnumMember(Value = "shopify")]
        Shopify,

        /// <summary>
        /// Passwordless SMS connection.
        /// </summary>
        [EnumMember(Value = "sms")]
        Sms,

        /// <summary>
        /// SoundCloud social connection.
        /// </summary>
        [EnumMember(Value = "soundcloud")]
        SoundCloud,

        /// <summary>
        /// The City social connection.
        /// </summary>
        [EnumMember(Value = "thecity")]
        TheCity,

        /// <summary>
        /// The City sandbox social connection.
        /// </summary>
        [EnumMember(Value = "thecity-sandbox")]
        TheCity_Sandbox,

        /// <summary>
        /// 37signals (Basecamp) social connection.
        /// </summary>
        [EnumMember(Value = "thirtysevensignals")]
        ThirtySevenSignals,

        /// <summary>
        /// Twitter social connection.
        /// </summary>
        [EnumMember(Value = "twitter")]
        Twitter,

        /// <summary>
        /// Untappd social connection.
        /// </summary>
        [EnumMember(Value = "untappd")]
        Untappd,

        /// <summary>
        /// VKontakte social connection.
        /// </summary>
        [EnumMember(Value = "vkontakte")]
        Vkontakte,

        /// <summary>
        /// Weibo social connection.
        /// </summary>
        [EnumMember(Value = "weibo")]
        Weibo,

        /// <summary>
        /// Windows Live (Microsoft Account) social connection.
        /// </summary>
        [EnumMember(Value = "windowslive")]
        WindowsLive,

        /// <summary>
        /// WordPress social connection.
        /// </summary>
        [EnumMember(Value = "wordpress")]
        WordPress,

        /// <summary>
        /// Yahoo social connection.
        /// </summary>
        [EnumMember(Value = "yahoo")]
        Yahoo,

        /// <summary>
        /// Yammer enterprise social connection.
        /// </summary>
        [EnumMember(Value = "yammer")]
        Yammer,

        /// <summary>
        /// Yandex social connection.
        /// </summary>
        [EnumMember(Value = "yandex")]
        Yandex,

    }

}
