
#nullable enable

namespace Together
{
    /// <summary>
    /// List of base models supported by the RL service
    /// </summary>
    public sealed partial class RlSupportedModelsListResponse
    {
        /// <summary>
        /// Supported base models for RL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.RlSupportedModel> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlSupportedModelsListResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Supported base models for RL
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlSupportedModelsListResponse(
            global::System.Collections.Generic.IList<global::Together.RlSupportedModel> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlSupportedModelsListResponse" /> class.
        /// </summary>
        public RlSupportedModelsListResponse()
        {
        }

    }
}