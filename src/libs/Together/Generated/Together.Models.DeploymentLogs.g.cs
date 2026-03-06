
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploymentLogs
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lines")]
        public global::System.Collections.Generic.IList<string>? Lines { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentLogs" /> class.
        /// </summary>
        /// <param name="lines"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentLogs(
            global::System.Collections.Generic.IList<string>? lines)
        {
            this.Lines = lines;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentLogs" /> class.
        /// </summary>
        public DeploymentLogs()
        {
        }
    }
}