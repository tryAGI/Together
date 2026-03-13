
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExecuteResponseSuccessfulExecution
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public object? Errors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.ExecuteResponseSuccessfulExecutionData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteResponseSuccessfulExecution" /> class.
        /// </summary>
        /// <param name="errors"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecuteResponseSuccessfulExecution(
            global::Together.ExecuteResponseSuccessfulExecutionData data,
            object? errors)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteResponseSuccessfulExecution" /> class.
        /// </summary>
        public ExecuteResponseSuccessfulExecution()
        {
        }
    }
}