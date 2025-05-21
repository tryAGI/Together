
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExecuteResponseVariant1Data
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.OutputsItem> Outputs { get; set; }

        /// <summary>
        /// Identifier of the current session. Used to make follow-up calls.<br/>
        /// Example: ses_abcDEF123
        /// </summary>
        /// <example>ses_abcDEF123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// Status of the execution. Currently only supports success.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.ExecuteResponseVariant1DataStatusJsonConverter))]
        public global::Together.ExecuteResponseVariant1DataStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteResponseVariant1Data" /> class.
        /// </summary>
        /// <param name="outputs"></param>
        /// <param name="sessionId">
        /// Identifier of the current session. Used to make follow-up calls.<br/>
        /// Example: ses_abcDEF123
        /// </param>
        /// <param name="status">
        /// Status of the execution. Currently only supports success.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecuteResponseVariant1Data(
            global::System.Collections.Generic.IList<global::Together.OutputsItem> outputs,
            string sessionId,
            global::Together.ExecuteResponseVariant1DataStatus? status)
        {
            this.Outputs = outputs ?? throw new global::System.ArgumentNullException(nameof(outputs));
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteResponseVariant1Data" /> class.
        /// </summary>
        public ExecuteResponseVariant1Data()
        {
        }
    }
}