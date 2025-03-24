
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CosineLRSchedulerArgs
    {
        /// <summary>
        /// The ratio of the final learning rate to the peak learning rate<br/>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_lr_ratio")]
        public float? MinLrRatio { get; set; }

        /// <summary>
        /// Number or fraction of cycles for the cosine learning rate scheduler<br/>
        /// Default Value: 0.5F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_cycles")]
        public float? NumCycles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CosineLRSchedulerArgs" /> class.
        /// </summary>
        /// <param name="minLrRatio">
        /// The ratio of the final learning rate to the peak learning rate<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="numCycles">
        /// Number or fraction of cycles for the cosine learning rate scheduler<br/>
        /// Default Value: 0.5F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CosineLRSchedulerArgs(
            float? minLrRatio,
            float? numCycles)
        {
            this.MinLrRatio = minLrRatio;
            this.NumCycles = numCycles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CosineLRSchedulerArgs" /> class.
        /// </summary>
        public CosineLRSchedulerArgs()
        {
        }
    }
}