
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RpcStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public int? Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public global::System.Collections.Generic.IList<global::Together.ProtobufAny>? Details { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RpcStatus" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="details"></param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RpcStatus(
            int? code,
            global::System.Collections.Generic.IList<global::Together.ProtobufAny>? details,
            string? message)
        {
            this.Code = code;
            this.Details = details;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RpcStatus" /> class.
        /// </summary>
        public RpcStatus()
        {
        }
    }
}