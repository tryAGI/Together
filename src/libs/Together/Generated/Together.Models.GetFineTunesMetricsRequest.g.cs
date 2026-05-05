
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetFineTunesMetricsRequest
    {
        /// <summary>
        /// Return only metrics with global_step &gt;= this value.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("global_step_from")]
        public long? GlobalStepFrom { get; set; }

        /// <summary>
        /// Return only metrics with global_step &lt;= this value.<br/>
        /// Example: 500
        /// </summary>
        /// <example>500</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("global_step_to")]
        public long? GlobalStepTo { get; set; }

        /// <summary>
        /// Return only metrics logged at or after this ISO-8601 timestamp.<br/>
        /// Example: 2024-01-01T00:00:00Z
        /// </summary>
        /// <example>2024-01-01T00:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("logged_at_from")]
        public global::System.DateTime? LoggedAtFrom { get; set; }

        /// <summary>
        /// Return only metrics logged at or before this ISO-8601 timestamp.<br/>
        /// Example: 2024-01-01T12:00:00Z
        /// </summary>
        /// <example>2024-01-01T12:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("logged_at_to")]
        public global::System.DateTime? LoggedAtTo { get; set; }

        /// <summary>
        /// Number of (uniformly sampled) train metrics to return.<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        public long? Resolution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFineTunesMetricsRequest" /> class.
        /// </summary>
        /// <param name="globalStepFrom">
        /// Return only metrics with global_step &gt;= this value.<br/>
        /// Example: 0
        /// </param>
        /// <param name="globalStepTo">
        /// Return only metrics with global_step &lt;= this value.<br/>
        /// Example: 500
        /// </param>
        /// <param name="loggedAtFrom">
        /// Return only metrics logged at or after this ISO-8601 timestamp.<br/>
        /// Example: 2024-01-01T00:00:00Z
        /// </param>
        /// <param name="loggedAtTo">
        /// Return only metrics logged at or before this ISO-8601 timestamp.<br/>
        /// Example: 2024-01-01T12:00:00Z
        /// </param>
        /// <param name="resolution">
        /// Number of (uniformly sampled) train metrics to return.<br/>
        /// Example: 100
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetFineTunesMetricsRequest(
            long? globalStepFrom,
            long? globalStepTo,
            global::System.DateTime? loggedAtFrom,
            global::System.DateTime? loggedAtTo,
            long? resolution)
        {
            this.GlobalStepFrom = globalStepFrom;
            this.GlobalStepTo = globalStepTo;
            this.LoggedAtFrom = loggedAtFrom;
            this.LoggedAtTo = loggedAtTo;
            this.Resolution = resolution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFineTunesMetricsRequest" /> class.
        /// </summary>
        public GetFineTunesMetricsRequest()
        {
        }
    }
}