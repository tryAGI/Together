
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RlListMeta
    {
        /// <summary>
        /// Maximum number of items returned per page<br/>
        /// Example: 20
        /// </summary>
        /// <example>20</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Whether more items exist beyond this page<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// Cursor to use as the 'after' parameter for the next page. Empty when has_more is false.<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </summary>
        /// <example>123e4567-e89b-12d3-a456-426614174000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlListMeta" /> class.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of items returned per page<br/>
        /// Example: 20
        /// </param>
        /// <param name="hasMore">
        /// Whether more items exist beyond this page<br/>
        /// Example: true
        /// </param>
        /// <param name="nextCursor">
        /// Cursor to use as the 'after' parameter for the next page. Empty when has_more is false.<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlListMeta(
            int? limit,
            bool? hasMore,
            string? nextCursor)
        {
            this.Limit = limit;
            this.HasMore = hasMore;
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlListMeta" /> class.
        /// </summary>
        public RlListMeta()
        {
        }
    }
}