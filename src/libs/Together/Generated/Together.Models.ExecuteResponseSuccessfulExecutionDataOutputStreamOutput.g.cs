
#nullable enable

namespace Together
{
    /// <summary>
    /// Outputs that were printed to stdout or stderr
    /// </summary>
    public sealed partial class ExecuteResponseSuccessfulExecutionDataOutputStreamOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.ExecuteResponseSuccessfulExecutionDataOutputStreamOutputTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.ExecuteResponseSuccessfulExecutionDataOutputStreamOutputType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteResponseSuccessfulExecutionDataOutputStreamOutput" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecuteResponseSuccessfulExecutionDataOutputStreamOutput(
            global::Together.ExecuteResponseSuccessfulExecutionDataOutputStreamOutputType type,
            string data)
        {
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteResponseSuccessfulExecutionDataOutputStreamOutput" /> class.
        /// </summary>
        public ExecuteResponseSuccessfulExecutionDataOutputStreamOutput()
        {
        }
    }
}