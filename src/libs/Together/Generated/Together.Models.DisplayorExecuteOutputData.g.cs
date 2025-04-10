
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DisplayorExecuteOutputData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("application/geo+json")]
        public object? ApplicationGeoJson { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("application/javascript")]
        public string? ApplicationJavascript { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("application/json")]
        public object? ApplicationJson { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("application/pdf")]
        public byte[]? ApplicationPdf { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("application/vnd.vega.v5+json")]
        public object? ApplicationVndVegaV5Json { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("application/vnd.vegalite.v4+json")]
        public object? ApplicationVndVegaliteV4Json { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image/gif")]
        public byte[]? ImageGif { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image/jpeg")]
        public byte[]? ImageJpeg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image/png")]
        public byte[]? ImagePng { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image/svg+xml")]
        public string? ImageSvgXml { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text/html")]
        public string? TextHtml { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text/latex")]
        public string? TextLatex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text/markdown")]
        public string? TextMarkdown { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text/plain")]
        public string? TextPlain { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayorExecuteOutputData" /> class.
        /// </summary>
        /// <param name="applicationGeoJson"></param>
        /// <param name="applicationJavascript"></param>
        /// <param name="applicationJson"></param>
        /// <param name="applicationPdf"></param>
        /// <param name="applicationVndVegaV5Json"></param>
        /// <param name="applicationVndVegaliteV4Json"></param>
        /// <param name="imageGif"></param>
        /// <param name="imageJpeg"></param>
        /// <param name="imagePng"></param>
        /// <param name="imageSvgXml"></param>
        /// <param name="textHtml"></param>
        /// <param name="textLatex"></param>
        /// <param name="textMarkdown"></param>
        /// <param name="textPlain"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DisplayorExecuteOutputData(
            object? applicationGeoJson,
            string? applicationJavascript,
            object? applicationJson,
            byte[]? applicationPdf,
            object? applicationVndVegaV5Json,
            object? applicationVndVegaliteV4Json,
            byte[]? imageGif,
            byte[]? imageJpeg,
            byte[]? imagePng,
            string? imageSvgXml,
            string? textHtml,
            string? textLatex,
            string? textMarkdown,
            string? textPlain)
        {
            this.ApplicationGeoJson = applicationGeoJson;
            this.ApplicationJavascript = applicationJavascript;
            this.ApplicationJson = applicationJson;
            this.ApplicationPdf = applicationPdf;
            this.ApplicationVndVegaV5Json = applicationVndVegaV5Json;
            this.ApplicationVndVegaliteV4Json = applicationVndVegaliteV4Json;
            this.ImageGif = imageGif;
            this.ImageJpeg = imageJpeg;
            this.ImagePng = imagePng;
            this.ImageSvgXml = imageSvgXml;
            this.TextHtml = textHtml;
            this.TextLatex = textLatex;
            this.TextMarkdown = textMarkdown;
            this.TextPlain = textPlain;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayorExecuteOutputData" /> class.
        /// </summary>
        public DisplayorExecuteOutputData()
        {
        }
    }
}