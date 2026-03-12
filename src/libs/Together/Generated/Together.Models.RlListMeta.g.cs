
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RlListMeta
    {
        /// <summary>
        /// Total number of items matching the filter<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public string? Total { get; set; }

        /// <summary>
        /// Maximum number of items returned per page<br/>
        /// Example: 20
        /// </summary>
        /// <example>20</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Number of items skipped<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlListMeta" /> class.
        /// </summary>
        /// <param name="total">
        /// Total number of items matching the filter<br/>
        /// Example: 42
        /// </param>
        /// <param name="limit">
        /// Maximum number of items returned per page<br/>
        /// Example: 20
        /// </param>
        /// <param name="offset">
        /// Number of items skipped<br/>
        /// Example: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlListMeta(
            string? total,
            int? limit,
            int? offset)
        {
            this.Total = total;
            this.Limit = limit;
            this.Offset = offset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlListMeta" /> class.
        /// </summary>
        public RlListMeta()
        {
        }
    }
}