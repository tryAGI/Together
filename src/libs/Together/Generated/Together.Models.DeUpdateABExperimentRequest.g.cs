
#nullable enable

namespace Together
{
    /// <summary>
    /// Mutable description and traffic allocation for an A/B experiment.
    /// </summary>
    public sealed partial class DeUpdateABExperimentRequest
    {
        /// <summary>
        /// Updated free-form description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Complete replacement member set. Requires two to 20 deployments, exactly one control, and percentages that add up to 100.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        public global::System.Collections.Generic.IList<global::Together.DeABExperimentMember>? Members { get; set; }

        /// <summary>
        /// Opaque version tag from a prior read for optimistic concurrency.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("etag")]
        public string? Etag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeUpdateABExperimentRequest" /> class.
        /// </summary>
        /// <param name="description">
        /// Updated free-form description.
        /// </param>
        /// <param name="members">
        /// Complete replacement member set. Requires two to 20 deployments, exactly one control, and percentages that add up to 100.
        /// </param>
        /// <param name="etag">
        /// Opaque version tag from a prior read for optimistic concurrency.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeUpdateABExperimentRequest(
            string? description,
            global::System.Collections.Generic.IList<global::Together.DeABExperimentMember>? members,
            string? etag)
        {
            this.Description = description;
            this.Members = members;
            this.Etag = etag;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeUpdateABExperimentRequest" /> class.
        /// </summary>
        public DeUpdateABExperimentRequest()
        {
        }

    }
}