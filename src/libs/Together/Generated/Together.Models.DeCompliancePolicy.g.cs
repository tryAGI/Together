
#nullable enable

namespace Together
{
    /// <summary>
    /// Compliance regimes required by a deployment placement policy.
    /// </summary>
    public sealed partial class DeCompliancePolicy
    {
        /// <summary>
        /// Restrict placement to HIPAA-attested clusters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hipaa")]
        public bool? Hipaa { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeCompliancePolicy" /> class.
        /// </summary>
        /// <param name="hipaa">
        /// Restrict placement to HIPAA-attested clusters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeCompliancePolicy(
            bool? hipaa)
        {
            this.Hipaa = hipaa;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeCompliancePolicy" /> class.
        /// </summary>
        public DeCompliancePolicy()
        {
        }

    }
}