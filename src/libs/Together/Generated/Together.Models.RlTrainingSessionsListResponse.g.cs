
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RlTrainingSessionsListResponse
    {
        /// <summary>
        /// List of training sessions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Together.RlTrainingSession>? Data { get; set; }

        /// <summary>
        /// Pagination metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::Together.RlListMeta? Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlTrainingSessionsListResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// List of training sessions
        /// </param>
        /// <param name="meta">
        /// Pagination metadata
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlTrainingSessionsListResponse(
            global::System.Collections.Generic.IList<global::Together.RlTrainingSession>? data,
            global::Together.RlListMeta? meta)
        {
            this.Data = data;
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlTrainingSessionsListResponse" /> class.
        /// </summary>
        public RlTrainingSessionsListResponse()
        {
        }
    }
}