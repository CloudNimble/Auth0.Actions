using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Auth0.Actions
{

    /// <summary>
    /// 
    /// </summary>
    public record Transaction : TransactionBase
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("acr_values")]
        public dynamic AcrValues { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("linking_id")]
        public string LinkingId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("locale")]
        public string Locale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("login_hint")]
        public string LoginHint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("prompt")]
        public List<string> Prompt { get; set; } = new();

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("redirect_uri")]
        public string RedirectUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("response_mode")]
        public string ResponseMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("response_type")]
        public List<string> ResponseType { get; set; } = new();

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("ui_locales")]
        public List<string> UILocales { get; set; } = new();

    }

}
