
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploymentListResponse
    {
        /// <summary>
        /// Data is the array of deployment items
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Together.DeploymentResponseItem>? Data { get; set; }

        /// <summary>
        /// The object type, which is always `list`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentListResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Data is the array of deployment items
        /// </param>
        /// <param name="object">
        /// The object type, which is always `list`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentListResponse(
            global::System.Collections.Generic.IList<global::Together.DeploymentResponseItem>? data,
            string? @object)
        {
            this.Data = data;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentListResponse" /> class.
        /// </summary>
        public DeploymentListResponse()
        {
        }
    }
}