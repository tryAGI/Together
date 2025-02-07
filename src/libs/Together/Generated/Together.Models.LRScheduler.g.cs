
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LRScheduler
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lr_scheduler_args")]
        public global::Together.LinearLRSchedulerArgs? LrSchedulerArgs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lr_scheduler_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LrSchedulerType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LRScheduler" /> class.
        /// </summary>
        /// <param name="lrSchedulerArgs"></param>
        /// <param name="lrSchedulerType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LRScheduler(
            string lrSchedulerType,
            global::Together.LinearLRSchedulerArgs? lrSchedulerArgs)
        {
            this.LrSchedulerType = lrSchedulerType ?? throw new global::System.ArgumentNullException(nameof(lrSchedulerType));
            this.LrSchedulerArgs = lrSchedulerArgs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LRScheduler" /> class.
        /// </summary>
        public LRScheduler()
        {
        }
    }
}