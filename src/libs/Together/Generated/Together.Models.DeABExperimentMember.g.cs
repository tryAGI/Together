
#nullable enable

namespace Together
{
    /// <summary>
    /// Deployment participating in an A/B experiment.
    /// </summary>
    public sealed partial class DeABExperimentMember
    {
        /// <summary>
        /// Deployment under the parent endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentId { get; set; }

        /// <summary>
        /// Role of this deployment within the A/B experiment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeABExperimentMemberRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.DeABExperimentMemberRole Role { get; set; }

        /// <summary>
        /// Integer traffic percent in [1, 100]. Percentages across all members must sum to 100.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Percent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeABExperimentMember" /> class.
        /// </summary>
        /// <param name="deploymentId">
        /// Deployment under the parent endpoint.
        /// </param>
        /// <param name="role">
        /// Role of this deployment within the A/B experiment.
        /// </param>
        /// <param name="percent">
        /// Integer traffic percent in [1, 100]. Percentages across all members must sum to 100.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeABExperimentMember(
            string deploymentId,
            global::Together.DeABExperimentMemberRole role,
            int percent)
        {
            this.DeploymentId = deploymentId ?? throw new global::System.ArgumentNullException(nameof(deploymentId));
            this.Role = role;
            this.Percent = percent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeABExperimentMember" /> class.
        /// </summary>
        public DeABExperimentMember()
        {
        }

    }
}