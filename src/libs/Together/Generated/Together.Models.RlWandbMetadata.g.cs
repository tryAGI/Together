
#nullable enable

namespace Together
{
    /// <summary>
    /// Details that associate a training session with a Weights &amp; Biases run
    /// </summary>
    public sealed partial class RlWandbMetadata
    {
        /// <summary>
        /// Weights &amp; Biases username or team that owns the project<br/>
        /// Example: example-org
        /// </summary>
        /// <example>example-org</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity")]
        public string? Entity { get; set; }

        /// <summary>
        /// Weights &amp; Biases project containing the run<br/>
        /// Example: grpo-gsm8k
        /// </summary>
        /// <example>grpo-gsm8k</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public string? Project { get; set; }

        /// <summary>
        /// Weights &amp; Biases group used to organize related runs<br/>
        /// Example: gsm8k-35b-sweep
        /// </summary>
        /// <example>gsm8k-35b-sweep</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("group")]
        public string? Group { get; set; }

        /// <summary>
        /// Human-readable name of the Weights &amp; Biases run<br/>
        /// Example: exp2-thinking-4k-ctx
        /// </summary>
        /// <example>exp2-thinking-4k-ctx</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_name")]
        public string? RunName { get; set; }

        /// <summary>
        /// Unique identifier assigned to the run by Weights &amp; Biases<br/>
        /// Example: abc123
        /// </summary>
        /// <example>abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        public string? RunId { get; set; }

        /// <summary>
        /// HTTPS URL for the Weights &amp; Biases run<br/>
        /// Example: https://wandb.ai/example-org/example-project/runs/run-id
        /// </summary>
        /// <example>https://wandb.ai/example-org/example-project/runs/run-id</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlWandbMetadata" /> class.
        /// </summary>
        /// <param name="entity">
        /// Weights &amp; Biases username or team that owns the project<br/>
        /// Example: example-org
        /// </param>
        /// <param name="project">
        /// Weights &amp; Biases project containing the run<br/>
        /// Example: grpo-gsm8k
        /// </param>
        /// <param name="group">
        /// Weights &amp; Biases group used to organize related runs<br/>
        /// Example: gsm8k-35b-sweep
        /// </param>
        /// <param name="runName">
        /// Human-readable name of the Weights &amp; Biases run<br/>
        /// Example: exp2-thinking-4k-ctx
        /// </param>
        /// <param name="runId">
        /// Unique identifier assigned to the run by Weights &amp; Biases<br/>
        /// Example: abc123
        /// </param>
        /// <param name="url">
        /// HTTPS URL for the Weights &amp; Biases run<br/>
        /// Example: https://wandb.ai/example-org/example-project/runs/run-id
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlWandbMetadata(
            string? entity,
            string? project,
            string? group,
            string? runName,
            string? runId,
            string? url)
        {
            this.Entity = entity;
            this.Project = project;
            this.Group = group;
            this.RunName = runName;
            this.RunId = runId;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlWandbMetadata" /> class.
        /// </summary>
        public RlWandbMetadata()
        {
        }

    }
}