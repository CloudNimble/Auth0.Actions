using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// 
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum ConnectionStrategies
    {

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "ad")]
        AD,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "adfs")]
        Adfs,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "amazon")]
        Amazon,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "apple")]
        Apple,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "dropbox")]
        Dropbox,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "bitbucket")]
        Bitbucket,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "aol")]
        Aol,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "auth0-oidc")]
        Auth0_Oidc,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "auth0")]
        Auth0,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "baidu")]
        Baidu,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "bitly")]
        Bitly,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "box")]
        Box,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "custom")]
        Custom,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "daccount")]
        Daccount,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "dwolla")]
        Dwolla,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "email")]
        Email,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "evernote-sandbox")]
        Evernote_Sandbox,
     
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "evernote")]
        Evernote,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "exact")]
        Exact,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "facebook")]
        Facebook,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "fitbit")]
        fitbit,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "flickr")]
        flickr,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "github")]
        github,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "google-apps")]
        GoogleApps,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "google-oauth2")]
        Google_OAuth2,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "instagram")]
        Instagram,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "ip")]
        IP,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "line")]
        Line,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "linkedin")]
        LinkedIn,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "miicard")]
        Miicard,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "oauth1")]
        OAuth1,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "oauth2")]
        OAuth2,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "office365")]
        Office365,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "oidc")]
        Oidc,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "okta")]
        Okta,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "paypal")]
        Paypal,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "paypal-sandbox")]
        Paypal_Sandbox,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "pingfederate")]
        PingFederate,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "planningcenter")]
        PlanningCenter,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "renren")]
        Renren,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "salesforce-community")]
        Salesforce_Community,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "salesforce-sandbox")]
        Salesforce_Sandbox,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "salesforce")]
        Salesforce,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "samlp")]
        Samlp,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "sharepoint")]
        Sharepoint,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "shopify")]
        Shopify,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "sms")]
        Sms,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "soundcloud")]
        SoundCloud,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "thecity-sandbox")]
        TheCity_Sandbox,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "thecity")]
        TheCity,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "thirtysevensignals")]
        ThirtySevenSignals,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "twitter")]
        Twitter,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "untappd")]
        Untappd,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "vkontakte")]
        Vkontakte,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "waad")]
        AzureActiveDirectory,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "weibo")]
        Weibo,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "windowslive")]
        WindowsLive,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "wordpress")]
        WordPress,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "yahoo")]
        Yahoo,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "yammer")]
        Yammer,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "yandex")]
        Yandex,

    }

}
