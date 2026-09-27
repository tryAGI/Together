
#nullable enable

namespace Together
{
    /// <summary>
    /// Compliance-specific regional availability for one instance type policy.
    /// </summary>
    public sealed partial class DeComplianceAvailability
    {
        /// <summary>
        /// Compliance regimes certified by the clusters counted in this entry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.DeCompliancePolicy Policy { get; set; }

        /// <summary>
        /// Best-effort replica headroom on clusters certified for at least this policy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headroom")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.DeHeadroom Headroom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeComplianceAvailability" /> class.
        /// </summary>
        /// <param name="policy">
        /// Compliance regimes certified by the clusters counted in this entry.
        /// </param>
        /// <param name="headroom">
        /// Best-effort replica headroom on clusters certified for at least this policy.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeComplianceAvailability(
            global::Together.DeCompliancePolicy policy,
            global::Together.DeHeadroom headroom)
        {
            this.Policy = policy ?? throw new global::System.ArgumentNullException(nameof(policy));
            this.Headroom = headroom ?? throw new global::System.ArgumentNullException(nameof(headroom));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeComplianceAvailability" /> class.
        /// </summary>
        public DeComplianceAvailability()
        {
        }

    }
}