
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PartInfo
    {
        /// <summary>
        /// Headers to include with the upload request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Part number (1-based)<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("PartNumber")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PartNumber { get; set; }

        /// <summary>
        /// Presigned URL for uploading this part<br/>
        /// Example: https://s3.amazonaws.com/...
        /// </summary>
        /// <example>https://s3.amazonaws.com/...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("URL")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string URL { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartInfo" /> class.
        /// </summary>
        /// <param name="headers">
        /// Headers to include with the upload request
        /// </param>
        /// <param name="partNumber">
        /// Part number (1-based)<br/>
        /// Example: 1
        /// </param>
        /// <param name="uRL">
        /// Presigned URL for uploading this part<br/>
        /// Example: https://s3.amazonaws.com/...
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartInfo(
            int partNumber,
            string uRL,
            global::System.Collections.Generic.Dictionary<string, string>? headers)
        {
            this.PartNumber = partNumber;
            this.URL = uRL ?? throw new global::System.ArgumentNullException(nameof(uRL));
            this.Headers = headers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartInfo" /> class.
        /// </summary>
        public PartInfo()
        {
        }
    }
}