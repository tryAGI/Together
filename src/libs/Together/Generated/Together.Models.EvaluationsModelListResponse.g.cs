
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluationsModelListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_list")]
        public global::System.Collections.Generic.IList<string>? ModelList { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationsModelListResponse" /> class.
        /// </summary>
        /// <param name="modelList"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationsModelListResponse(
            global::System.Collections.Generic.IList<string>? modelList)
        {
            this.ModelList = modelList;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationsModelListResponse" /> class.
        /// </summary>
        public EvaluationsModelListResponse()
        {
        }
    }
}