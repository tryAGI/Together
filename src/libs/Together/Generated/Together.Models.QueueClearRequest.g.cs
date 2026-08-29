
#nullable enable

namespace Together
{
    /// <summary>
    /// Request to clear pending jobs for a model.
    /// </summary>
    public sealed partial class QueueClearRequest
    {
        /// <summary>
        /// Model identifier whose pending jobs should be canceled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueClearRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// Model identifier whose pending jobs should be canceled
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueClearRequest(
            string model)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueClearRequest" /> class.
        /// </summary>
        public QueueClearRequest()
        {
        }

    }
}