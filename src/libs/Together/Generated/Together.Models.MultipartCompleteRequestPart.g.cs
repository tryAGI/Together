
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MultipartCompleteRequestPart
    {
        /// <summary>
        /// ETag returned from S3 part upload<br/>
        /// Example: "abc123def456"
        /// </summary>
        /// <example>"abc123def456"</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ETag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ETag { get; set; }

        /// <summary>
        /// Part number (1-based)<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("PartNumber")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PartNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipartCompleteRequestPart" /> class.
        /// </summary>
        /// <param name="eTag">
        /// ETag returned from S3 part upload<br/>
        /// Example: "abc123def456"
        /// </param>
        /// <param name="partNumber">
        /// Part number (1-based)<br/>
        /// Example: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultipartCompleteRequestPart(
            string eTag,
            int partNumber)
        {
            this.ETag = eTag ?? throw new global::System.ArgumentNullException(nameof(eTag));
            this.PartNumber = partNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipartCompleteRequestPart" /> class.
        /// </summary>
        public MultipartCompleteRequestPart()
        {
        }
    }
}