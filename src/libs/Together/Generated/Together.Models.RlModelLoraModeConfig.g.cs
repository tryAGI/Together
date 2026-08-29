
#nullable enable

namespace Together
{
    /// <summary>
    /// LoRA training config. If present, the model supports LoRA training.
    /// </summary>
    public sealed partial class RlModelLoraModeConfig
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
        /// Maximum LoRA rank<br/>
        /// Example: 64
        /// </summary>
        /// <example>64</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_rank")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxRank { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlModelLoraModeConfig" /> class.
        /// </summary>
        /// <param name="maxBatchSize">
        /// Maximum global batch size accepted by a forward-backward step<br/>
        /// Example: 512
        /// </param>
        /// <param name="maxSeqLength">
        /// Maximum sequence length in tokens<br/>
        /// Example: 40960
        /// </param>
        /// <param name="maxRank">
        /// Maximum LoRA rank<br/>
        /// Example: 64
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlModelLoraModeConfig(
            int maxBatchSize,
            int maxSeqLength,
            int maxRank)
        {
            this.MaxBatchSize = maxBatchSize;
            this.MaxSeqLength = maxSeqLength;
            this.MaxRank = maxRank;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlModelLoraModeConfig" /> class.
        /// </summary>
        public RlModelLoraModeConfig()
        {
        }

    }
}