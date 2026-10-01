
#nullable enable

namespace Together
{
    /// <summary>
    /// Request body identifying the deployment revision to roll back to.
    /// </summary>
    public sealed partial class RollbackDeploymentRequest
    {
        /// <summary>
        /// Revision number or revision ID to roll back to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision_identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RevisionIdentifier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RollbackDeploymentRequest" /> class.
        /// </summary>
        /// <param name="revisionIdentifier">
        /// Revision number or revision ID to roll back to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RollbackDeploymentRequest(
            string revisionIdentifier)
        {
            this.RevisionIdentifier = revisionIdentifier ?? throw new global::System.ArgumentNullException(nameof(revisionIdentifier));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RollbackDeploymentRequest" /> class.
        /// </summary>
        public RollbackDeploymentRequest()
        {
        }

    }
}