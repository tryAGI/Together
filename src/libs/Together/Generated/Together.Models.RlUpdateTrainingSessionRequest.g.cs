
#nullable enable

namespace Together
{
    /// <summary>
    /// Fields to update on a training session
    /// </summary>
    public sealed partial class RlUpdateTrainingSessionRequest
    {
        /// <summary>
        /// Display name to update. An empty string clears the existing display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Metadata fields to update. Omitted fields remain unchanged, and empty strings clear existing values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Together.RlTrainingSessionMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlUpdateTrainingSessionRequest" /> class.
        /// </summary>
        /// <param name="displayName">
        /// Display name to update. An empty string clears the existing display name.
        /// </param>
        /// <param name="metadata">
        /// Metadata fields to update. Omitted fields remain unchanged, and empty strings clear existing values.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlUpdateTrainingSessionRequest(
            string? displayName,
            global::Together.RlTrainingSessionMetadata? metadata)
        {
            this.DisplayName = displayName;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlUpdateTrainingSessionRequest" /> class.
        /// </summary>
        public RlUpdateTrainingSessionRequest()
        {
        }

    }
}