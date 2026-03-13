
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RlInferenceCheckpointResult
    {
        /// <summary>
        /// Registered model name for downloading the checkpoint<br/>
        /// Example: username/Meta-Llama-3-8B-rl-step-42-20260216
        /// </summary>
        /// <example>username/Meta-Llama-3-8B-rl-step-42-20260216</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        public string? ModelName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlInferenceCheckpointResult" /> class.
        /// </summary>
        /// <param name="modelName">
        /// Registered model name for downloading the checkpoint<br/>
        /// Example: username/Meta-Llama-3-8B-rl-step-42-20260216
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlInferenceCheckpointResult(
            string? modelName)
        {
            this.ModelName = modelName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlInferenceCheckpointResult" /> class.
        /// </summary>
        public RlInferenceCheckpointResult()
        {
        }
    }
}