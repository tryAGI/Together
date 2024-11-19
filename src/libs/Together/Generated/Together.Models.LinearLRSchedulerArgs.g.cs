
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LinearLRSchedulerArgs
    {
        /// <summary>
        /// The ratio of the final learning rate to the peak learning rate<br/>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_lr_ratio")]
        public float? MinLrRatio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LinearLRSchedulerArgs" /> class.
        /// </summary>
        /// <param name="minLrRatio">
        /// The ratio of the final learning rate to the peak learning rate<br/>
        /// Default Value: 0F
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public LinearLRSchedulerArgs(
            float? minLrRatio)
        {
            this.MinLrRatio = minLrRatio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinearLRSchedulerArgs" /> class.
        /// </summary>
        public LinearLRSchedulerArgs()
        {
        }
    }
}