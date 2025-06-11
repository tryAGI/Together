
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchJobWithWarning
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job")]
        public global::Together.BatchJob? Job { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warning")]
        public string? Warning { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchJobWithWarning" /> class.
        /// </summary>
        /// <param name="job"></param>
        /// <param name="warning"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchJobWithWarning(
            global::Together.BatchJob? job,
            string? warning)
        {
            this.Job = job;
            this.Warning = warning;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchJobWithWarning" /> class.
        /// </summary>
        public BatchJobWithWarning()
        {
        }
    }
}