
#nullable enable

namespace Together
{
    /// <summary>
    /// Performance benchmark metrics for a supported model profile.
    /// </summary>
    public sealed partial class DeSupportedModelPerformanceBenchmarks
    {
        /// <summary>
        /// Decoding throughput in tokens per second.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decodingSpeedTps")]
        public double? DecodingSpeedTps { get; set; }

        /// <summary>
        /// Time to first token in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeToFirstTokenMs")]
        public int? TimeToFirstTokenMs { get; set; }

        /// <summary>
        /// Maximum context length supported by the profile.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxContextLength")]
        public string? MaxContextLength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeSupportedModelPerformanceBenchmarks" /> class.
        /// </summary>
        /// <param name="decodingSpeedTps">
        /// Decoding throughput in tokens per second.
        /// </param>
        /// <param name="timeToFirstTokenMs">
        /// Time to first token in milliseconds.
        /// </param>
        /// <param name="maxContextLength">
        /// Maximum context length supported by the profile.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeSupportedModelPerformanceBenchmarks(
            double? decodingSpeedTps,
            int? timeToFirstTokenMs,
            string? maxContextLength)
        {
            this.DecodingSpeedTps = decodingSpeedTps;
            this.TimeToFirstTokenMs = timeToFirstTokenMs;
            this.MaxContextLength = maxContextLength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeSupportedModelPerformanceBenchmarks" /> class.
        /// </summary>
        public DeSupportedModelPerformanceBenchmarks()
        {
        }

    }
}