
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
        /// Per-cluster adapter load state reported by the controller for the clusters the deployment is placed on. Empty while the deployment is stopped or being torn down, and briefly after AddAdapter.
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
        /// Adapter attachment `dad_` id used by get, update, and remove; stale ids never address a replacement after remove and re-add.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Whether the adapter can serve requests right now. INACTIVE means the deployment is stopped, scaled to zero, or being torn down; LOADING means a placed cluster has not finished loading it; READY means every placed cluster serves it; FAILED means a placed cluster failed to load it.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("servingState")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeAdapterEntryServingStateJsonConverter))]
        public global::Together.DeAdapterEntryServingState ServingState { get; set; } = default!;

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
        /// Per-cluster adapter load state reported by the controller for the clusters the deployment is placed on. Empty while the deployment is stopped or being torn down, and briefly after AddAdapter.
        /// </param>
        /// <param name="etag">
        /// Row-level etag required for UpdateAdapter and RemoveAdapter.
        /// </param>
        /// <param name="id">
        /// Adapter attachment `dad_` id used by get, update, and remove; stale ids never address a replacement after remove and re-add.
        /// </param>
        /// <param name="adapterModel">
        /// Resource name of the adapter model, using projects/{projectId}/models/{adapterModelId}.
        /// </param>
        /// <param name="desiredRevision">
        /// Resource name of the adapter model revision pinned on the deployment, using projects/{projectId}/models/{adapterModelId}/revisions/{revisionId}.
        /// </param>
        /// <param name="servingState">
        /// Whether the adapter can serve requests right now. INACTIVE means the deployment is stopped, scaled to zero, or being torn down; LOADING means a placed cluster has not finished loading it; READY means every placed cluster serves it; FAILED means a placed cluster failed to load it.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeAdapterEntry(
            string adapterModelId,
            string desiredRevisionId,
            global::System.Collections.Generic.IList<global::Together.DeDeploymentAdapterStatus> perCluster,
            string etag,
            string id,
            string? adapterModel,
            string? desiredRevision,
            global::Together.DeAdapterEntryServingState servingState = default!)
        {
            this.AdapterModelId = adapterModelId ?? throw new global::System.ArgumentNullException(nameof(adapterModelId));
            this.DesiredRevisionId = desiredRevisionId ?? throw new global::System.ArgumentNullException(nameof(desiredRevisionId));
            this.PerCluster = perCluster ?? throw new global::System.ArgumentNullException(nameof(perCluster));
            this.Etag = etag ?? throw new global::System.ArgumentNullException(nameof(etag));
            this.AdapterModel = adapterModel;
            this.DesiredRevision = desiredRevision;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ServingState = servingState;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeAdapterEntry" /> class.
        /// </summary>
        public DeAdapterEntry()
        {
        }

    }
}