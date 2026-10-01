
#nullable enable

namespace Together
{
    /// <summary>
    /// Deployment status broken down by each supported dimension.
    /// </summary>
    public sealed partial class DeStatusDetails
    {
        /// <summary>
        /// Regions where the deployment is actually scheduled or serving replicas, sorted by region.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.DeRegionStatus> Region { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeStatusDetails" /> class.
        /// </summary>
        /// <param name="region">
        /// Regions where the deployment is actually scheduled or serving replicas, sorted by region.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeStatusDetails(
            global::System.Collections.Generic.IList<global::Together.DeRegionStatus> region)
        {
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeStatusDetails" /> class.
        /// </summary>
        public DeStatusDetails()
        {
        }

    }
}