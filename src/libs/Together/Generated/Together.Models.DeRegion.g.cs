
#nullable enable

namespace Together
{
    /// <summary>
    /// Region where an instance type is offered.
    /// </summary>
    public sealed partial class DeRegion
    {
        /// <summary>
        /// Region name where an instance type is offered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Best-effort replica headroom across every cluster in this region, attested or not. Read `compliance` for compliance-scoped headroom. Omitted when unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headroom")]
        public global::Together.DeHeadroom? Headroom { get; set; }

        /// <summary>
        /// Compliance regimes certified in this region with best-effort headroom for each policy. Entries can overlap; read the entry matching the deployment policy instead of summing entries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compliance")]
        public global::System.Collections.Generic.IList<global::Together.DeComplianceAvailability>? Compliance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeRegion" /> class.
        /// </summary>
        /// <param name="name">
        /// Region name where an instance type is offered.
        /// </param>
        /// <param name="headroom">
        /// Best-effort replica headroom across every cluster in this region, attested or not. Read `compliance` for compliance-scoped headroom. Omitted when unavailable.
        /// </param>
        /// <param name="compliance">
        /// Compliance regimes certified in this region with best-effort headroom for each policy. Entries can overlap; read the entry matching the deployment policy instead of summing entries.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeRegion(
            string name,
            global::Together.DeHeadroom? headroom,
            global::System.Collections.Generic.IList<global::Together.DeComplianceAvailability>? compliance)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Headroom = headroom;
            this.Compliance = compliance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeRegion" /> class.
        /// </summary>
        public DeRegion()
        {
        }

    }
}