
#nullable enable

namespace Together
{
    /// <summary>
    /// Runtime information derived from the deployment's configuration.
    /// </summary>
    public sealed partial class DeRuntimeInfo
    {
        /// <summary>
        /// Serving engine, such as `vllm`, `trtllm`, or `sglang`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("engineType")]
        public string? EngineType { get; set; }

        /// <summary>
        /// Version of the serving engine.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("engineVersion")]
        public string? EngineVersion { get; set; }

        /// <summary>
        /// Whether the runtime accepts tool and function-calling requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functionCallingSupported")]
        public bool? FunctionCallingSupported { get; set; }

        /// <summary>
        /// Whether the runtime can constrain generation to a structured output schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structuredOutputSupported")]
        public bool? StructuredOutputSupported { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeRuntimeInfo" /> class.
        /// </summary>
        /// <param name="engineType">
        /// Serving engine, such as `vllm`, `trtllm`, or `sglang`.
        /// </param>
        /// <param name="engineVersion">
        /// Version of the serving engine.
        /// </param>
        /// <param name="functionCallingSupported">
        /// Whether the runtime accepts tool and function-calling requests.
        /// </param>
        /// <param name="structuredOutputSupported">
        /// Whether the runtime can constrain generation to a structured output schema.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeRuntimeInfo(
            string? engineType,
            string? engineVersion,
            bool? functionCallingSupported,
            bool? structuredOutputSupported)
        {
            this.EngineType = engineType;
            this.EngineVersion = engineVersion;
            this.FunctionCallingSupported = functionCallingSupported;
            this.StructuredOutputSupported = structuredOutputSupported;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeRuntimeInfo" /> class.
        /// </summary>
        public DeRuntimeInfo()
        {
        }

    }
}