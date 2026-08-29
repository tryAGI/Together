
#nullable enable

namespace Together
{
    /// <summary>
    /// Best-effort estimate of how many additional replicas currently fit in a region.
    /// </summary>
    public sealed partial class DeHeadroom
    {
        /// <summary>
        /// Capped count of replicas that currently fit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public int? Value { get; set; }

        /// <summary>
        /// Whether the value is exact or a lower bound.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeHeadroomRelationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.DeHeadroomRelation Relation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeHeadroom" /> class.
        /// </summary>
        /// <param name="relation">
        /// Whether the value is exact or a lower bound.
        /// </param>
        /// <param name="value">
        /// Capped count of replicas that currently fit.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeHeadroom(
            global::Together.DeHeadroomRelation relation,
            int? value)
        {
            this.Value = value;
            this.Relation = relation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeHeadroom" /> class.
        /// </summary>
        public DeHeadroom()
        {
        }

    }
}