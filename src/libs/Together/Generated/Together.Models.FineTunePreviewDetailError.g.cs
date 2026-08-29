
#nullable enable

namespace Together
{
    /// <summary>
    /// Error response with a detail field returned by the preview tokenization service.
    /// </summary>
    public sealed partial class FineTunePreviewDetailError
    {
        /// <summary>
        /// Human-readable error detail.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTunePreviewDetailError" /> class.
        /// </summary>
        /// <param name="detail">
        /// Human-readable error detail.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FineTunePreviewDetailError(
            string detail)
        {
            this.Detail = detail ?? throw new global::System.ArgumentNullException(nameof(detail));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTunePreviewDetailError" /> class.
        /// </summary>
        public FineTunePreviewDetailError()
        {
        }

    }
}