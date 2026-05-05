
#nullable enable

namespace Together
{
    /// <summary>
    /// Example: {"metrics":[{"train/loss":0.5,"train/learning_rate":0.0001,"train/global_step":7},{"train/loss":0.45,"train/learning_rate":0.00009,"train/global_step":14}]}
    /// </summary>
    public sealed partial class GetFineTunesMetricsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, double>>? Metrics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFineTunesMetricsResponse" /> class.
        /// </summary>
        /// <param name="metrics"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetFineTunesMetricsResponse(
            global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, double>>? metrics)
        {
            this.Metrics = metrics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFineTunesMetricsResponse" /> class.
        /// </summary>
        public GetFineTunesMetricsResponse()
        {
        }
    }
}