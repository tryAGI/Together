
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListJobsResponseDataItemArgs
    {
        /// <summary>
        /// Example: Finetuned Qwen2.5-72B-Instruct by Unsloth
        /// </summary>
        /// <example>Finetuned Qwen2.5-72B-Instruct by Unsloth</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Example: necolinehubner/Qwen2.5-72B-Instruct
        /// </summary>
        /// <example>necolinehubner/Qwen2.5-72B-Instruct</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelName")]
        public string? ModelName { get; set; }

        /// <summary>
        /// Example: unsloth/Qwen2.5-72B-Instruct
        /// </summary>
        /// <example>unsloth/Qwen2.5-72B-Instruct</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelSource")]
        public string? ModelSource { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListJobsResponseDataItemArgs" /> class.
        /// </summary>
        /// <param name="description">
        /// Example: Finetuned Qwen2.5-72B-Instruct by Unsloth
        /// </param>
        /// <param name="modelName">
        /// Example: necolinehubner/Qwen2.5-72B-Instruct
        /// </param>
        /// <param name="modelSource">
        /// Example: unsloth/Qwen2.5-72B-Instruct
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListJobsResponseDataItemArgs(
            string? description,
            string? modelName,
            string? modelSource)
        {
            this.Description = description;
            this.ModelName = modelName;
            this.ModelSource = modelSource;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListJobsResponseDataItemArgs" /> class.
        /// </summary>
        public ListJobsResponseDataItemArgs()
        {
        }
    }
}