
#nullable enable

namespace Together
{
    /// <summary>
    /// Threshold criteria that fail when the target metric violates the configured bound.
    /// </summary>
    public sealed partial class DeThresholdCheck
    {
        /// <summary>
        /// Finite threshold value. Interpreted in the metric's unit:<br/>
        /// router_error_rate is a ratio in [0, 1], router_latency is<br/>
        /// milliseconds, and inflight_requests is in-flight requests per ready<br/>
        /// replica averaged over the rule window. Thresholds that no<br/>
        /// achievable value could pass, or that every achievable value passes,<br/>
        /// are rejected at create.<br/>
        /// Omitting this value is read as 0. Set 0 explicitly for the strictest<br/>
        /// threshold: nothing at all is tolerated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public double? Value { get; set; }

        /// <summary>
        /// Required comparison operator applied to the target metric value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeThresholdCheckOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.DeThresholdCheckOperator Operator { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeThresholdCheck" /> class.
        /// </summary>
        /// <param name="operator">
        /// Required comparison operator applied to the target metric value.
        /// </param>
        /// <param name="value">
        /// Finite threshold value. Interpreted in the metric's unit:<br/>
        /// router_error_rate is a ratio in [0, 1], router_latency is<br/>
        /// milliseconds, and inflight_requests is in-flight requests per ready<br/>
        /// replica averaged over the rule window. Thresholds that no<br/>
        /// achievable value could pass, or that every achievable value passes,<br/>
        /// are rejected at create.<br/>
        /// Omitting this value is read as 0. Set 0 explicitly for the strictest<br/>
        /// threshold: nothing at all is tolerated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeThresholdCheck(
            global::Together.DeThresholdCheckOperator @operator,
            double? value)
        {
            this.Value = value;
            this.Operator = @operator;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeThresholdCheck" /> class.
        /// </summary>
        public DeThresholdCheck()
        {
        }

    }
}