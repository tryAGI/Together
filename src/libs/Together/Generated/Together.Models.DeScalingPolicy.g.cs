
#nullable enable

namespace Together
{
    /// <summary>
    /// Replica rate-limit policy applied over a trailing window.
    /// </summary>
    public sealed partial class DeScalingPolicy
    {
        /// <summary>
        /// Whether `value` is a replica count or a percentage of the replica count at the start<br/>
        /// of the trailing period. Scaling events within that period count against the allowance;<br/>
        /// percentages are rounded to whole replicas.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeScalingPolicyTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.DeScalingPolicyType Type { get; set; }

        /// <summary>
        /// Positive replica count or percentage used as the rate-limit amount.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Value { get; set; }

        /// <summary>
        /// Trailing rate-limit window in seconds, from 1 to 1800.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("periodSeconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PeriodSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeScalingPolicy" /> class.
        /// </summary>
        /// <param name="type">
        /// Whether `value` is a replica count or a percentage of the replica count at the start<br/>
        /// of the trailing period. Scaling events within that period count against the allowance;<br/>
        /// percentages are rounded to whole replicas.
        /// </param>
        /// <param name="value">
        /// Positive replica count or percentage used as the rate-limit amount.
        /// </param>
        /// <param name="periodSeconds">
        /// Trailing rate-limit window in seconds, from 1 to 1800.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeScalingPolicy(
            global::Together.DeScalingPolicyType type,
            int value,
            int periodSeconds)
        {
            this.Type = type;
            this.Value = value;
            this.PeriodSeconds = periodSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeScalingPolicy" /> class.
        /// </summary>
        public DeScalingPolicy()
        {
        }

    }
}