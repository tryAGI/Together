
#pragma warning disable CS0618 // Type or member is obsolete

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.LinearLRSchedulerArgs, global::Together.CosineLRSchedulerArgs>))]
        public global::Together.OneOf<global::Together.LinearLRSchedulerArgs, global::Together.CosineLRSchedulerArgs>? LrSchedulerArgs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lr_scheduler_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.LRSchedulerLrSchedulerTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.LRSchedulerLrSchedulerType LrSchedulerType { get; set; }

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
            global::Together.LRSchedulerLrSchedulerType lrSchedulerType,
            global::Together.OneOf<global::Together.LinearLRSchedulerArgs, global::Together.CosineLRSchedulerArgs>? lrSchedulerArgs)
        {
            this.LrSchedulerType = lrSchedulerType;
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