
#nullable enable

namespace Together
{
    /// <summary>
    /// Full-weight training config. If present, the model supports full-weight training.
    /// </summary>
    public sealed partial class RlModelFullModeConfig
    {
        /// <summary>
        /// Maximum global batch size accepted by a forward-backward step<br/>
        /// Example: 512
        /// </summary>
        /// <example>512</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_batch_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxBatchSize { get; set; }

        /// <summary>
        /// Maximum sequence length in tokens<br/>
        /// Example: 40960
        /// </summary>
        /// <example>40960</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_seq_length")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxSeqLength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlModelFullModeConfig" /> class.
        /// </summary>
        /// <param name="maxBatchSize">
        /// Maximum global batch size accepted by a forward-backward step<br/>
        /// Example: 512
        /// </param>
        /// <param name="maxSeqLength">
        /// Maximum sequence length in tokens<br/>
        /// Example: 40960
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlModelFullModeConfig(
            int maxBatchSize,
            int maxSeqLength)
        {
            this.MaxBatchSize = maxBatchSize;
            this.MaxSeqLength = maxSeqLength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlModelFullModeConfig" /> class.
        /// </summary>
        public RlModelFullModeConfig()
        {
        }

    }
}