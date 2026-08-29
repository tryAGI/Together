
#nullable enable

namespace Together
{
    /// <summary>
    /// Adapter attached to a deployment with desired revision and observed load state.
    /// </summary>
    public sealed partial class DeAdapterEntry
    {
        /// <summary>
        /// Adapter model identifier attached to the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adapterModelId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AdapterModelId { get; set; }

        /// <summary>
        /// Adapter revision pinned on the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("desiredRevisionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DesiredRevisionId { get; set; }

        /// <summary>
        /// Per-cluster adapter load state reported by the controller.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("perCluster")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.DeDeploymentAdapterStatus> PerCluster { get; set; }

        /// <summary>
        /// Row-level etag required for UpdateAdapter and RemoveAdapter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("etag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Etag { get; set; }

        /// <summary>
        /// Resource name of the adapter model, using projects/{projectId}/models/{adapterModelId}.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adapterModel")]
        public string? AdapterModel { get; set; }

        /// <summary>
        /// Resource name of the adapter model revision pinned on the deployment, using projects/{projectId}/models/{adapterModelId}/revisions/{revisionId}.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("desiredRevision")]
        public string? DesiredRevision { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeAdapterEntry" /> class.
        /// </summary>
        /// <param name="adapterModelId">
        /// Adapter model identifier attached to the deployment.
        /// </param>
        /// <param name="desiredRevisionId">
        /// Adapter revision pinned on the deployment.
        /// </param>
        /// <param name="perCluster">
        /// Per-cluster adapter load state reported by the controller.
        /// </param>
        /// <param name="etag">
        /// Row-level etag required for UpdateAdapter and RemoveAdapter.
        /// </param>
        /// <param name="adapterModel">
        /// Resource name of the adapter model, using projects/{projectId}/models/{adapterModelId}.
        /// </param>
        /// <param name="desiredRevision">
        /// Resource name of the adapter model revision pinned on the deployment, using projects/{projectId}/models/{adapterModelId}/revisions/{revisionId}.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeAdapterEntry(
            string adapterModelId,
            string desiredRevisionId,
            global::System.Collections.Generic.IList<global::Together.DeDeploymentAdapterStatus> perCluster,
            string etag,
            string? adapterModel,
            string? desiredRevision)
        {
            this.AdapterModelId = adapterModelId ?? throw new global::System.ArgumentNullException(nameof(adapterModelId));
            this.DesiredRevisionId = desiredRevisionId ?? throw new global::System.ArgumentNullException(nameof(desiredRevisionId));
            this.PerCluster = perCluster ?? throw new global::System.ArgumentNullException(nameof(perCluster));
            this.Etag = etag ?? throw new global::System.ArgumentNullException(nameof(etag));
            this.AdapterModel = adapterModel;
            this.DesiredRevision = desiredRevision;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeAdapterEntry" /> class.
        /// </summary>
        public DeAdapterEntry()
        {
        }

    }
}