
#nullable enable

namespace Together
{
    /// <summary>
    /// A non-blocking finding attached to a rollout defaults preview.
    /// </summary>
    public sealed partial class DePreviewWarning
    {
        /// <summary>
        /// Machine-readable warning code, such as START_WILL_REJECT, ROLLOUT_WILL_RAISE_TARGET_MAX, FINAL_BELOW_INHERITED_MIN, or FINAL_BELOW_SOURCE_MIN. Render message for unrecognized codes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// Plain-language description of the finding, safe to show users as-is.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DePreviewWarning" /> class.
        /// </summary>
        /// <param name="code">
        /// Machine-readable warning code, such as START_WILL_REJECT, ROLLOUT_WILL_RAISE_TARGET_MAX, FINAL_BELOW_INHERITED_MIN, or FINAL_BELOW_SOURCE_MIN. Render message for unrecognized codes.
        /// </param>
        /// <param name="message">
        /// Plain-language description of the finding, safe to show users as-is.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DePreviewWarning(
            string code,
            string message)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DePreviewWarning" /> class.
        /// </summary>
        public DePreviewWarning()
        {
        }

    }
}