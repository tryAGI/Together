
#nullable enable

namespace Together
{
    /// <summary>
    /// Stable inference entry point that groups deployments and routes requests among them.
    /// </summary>
    public sealed partial class DeEndpoint
    {
        /// <summary>
        /// Unique endpoint identifier.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// ID of the project that owns the endpoint.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// Project-qualified endpoint name in the form `&lt;project_slug&gt;/&lt;endpoint_name&gt;`.<br/>
        /// Pass this value as `model` in inference requests. Create and update requests<br/>
        /// may use either a bare endpoint name or the qualified form; a supplied project<br/>
        /// slug must match the project in the request path.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Timestamp when the endpoint was created.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Output only. Timestamp when the endpoint was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Opaque version tag for optimistic concurrency control.<br/>
        /// Supply on update/delete to ensure consistent read-modify-write.<br/>
        /// If not set, the write overwrites based on current state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("etag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Etag { get; set; }

        /// <summary>
        /// Deployments eligible for live traffic and their capacity weights. An empty list leaves the endpoint unrouted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trafficSplit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.DeTrafficSplitEntry> TrafficSplit { get; set; }

        /// <summary>
        /// Who can discover the endpoint. `VISIBILITY_PRIVATE` restricts it to the project; `VISIBILITY_INTERNAL` shares it with the organization.<br/>
        /// Default Value: VISIBILITY_PRIVATE
        /// </summary>
        /// <default>global::Together.DeEndpointVisibility.VisibilityPrivate</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeEndpointVisibilityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.DeEndpointVisibility Visibility { get; set; } = global::Together.DeEndpointVisibility.VisibilityPrivate;

        /// <summary>
        /// Serving class of the endpoint. Reserved endpoints use reserved capacity.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpointType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeEndpointEndpointTypeJsonConverter))]
        public global::Together.DeEndpointEndpointType EndpointType { get; set; } = default!;

        /// <summary>
        /// Lightweight summaries of deployments under this endpoint.<br/>
        /// Retrieve a deployment through the endpoint's deployment API for full details.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments")]
        public global::System.Collections.Generic.IList<global::Together.DeDeploymentSummary> Deployments { get; set; } = default!;

        /// <summary>
        /// ID of the currently active rollout in an in-flight state, including paused.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activeRolloutId")]
        public string? ActiveRolloutId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeEndpoint" /> class.
        /// </summary>
        /// <param name="name">
        /// Project-qualified endpoint name in the form `&lt;project_slug&gt;/&lt;endpoint_name&gt;`.<br/>
        /// Pass this value as `model` in inference requests. Create and update requests<br/>
        /// may use either a bare endpoint name or the qualified form; a supplied project<br/>
        /// slug must match the project in the request path.
        /// </param>
        /// <param name="updatedAt">
        /// Output only. Timestamp when the endpoint was last updated.
        /// </param>
        /// <param name="etag">
        /// Opaque version tag for optimistic concurrency control.<br/>
        /// Supply on update/delete to ensure consistent read-modify-write.<br/>
        /// If not set, the write overwrites based on current state.
        /// </param>
        /// <param name="trafficSplit">
        /// Deployments eligible for live traffic and their capacity weights. An empty list leaves the endpoint unrouted.
        /// </param>
        /// <param name="visibility">
        /// Who can discover the endpoint. `VISIBILITY_PRIVATE` restricts it to the project; `VISIBILITY_INTERNAL` shares it with the organization.<br/>
        /// Default Value: VISIBILITY_PRIVATE
        /// </param>
        /// <param name="activeRolloutId">
        /// ID of the currently active rollout in an in-flight state, including paused.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Unique endpoint identifier.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="projectId">
        /// ID of the project that owns the endpoint.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the endpoint was created.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="endpointType">
        /// Serving class of the endpoint. Reserved endpoints use reserved capacity.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="deployments">
        /// Lightweight summaries of deployments under this endpoint.<br/>
        /// Retrieve a deployment through the endpoint's deployment API for full details.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeEndpoint(
            string name,
            global::System.DateTime updatedAt,
            string etag,
            global::System.Collections.Generic.IList<global::Together.DeTrafficSplitEntry> trafficSplit,
            global::Together.DeEndpointVisibility visibility,
            string? activeRolloutId,
            string id = default!,
            string projectId = default!,
            global::System.DateTime createdAt = default!,
            global::Together.DeEndpointEndpointType endpointType = default!,
            global::System.Collections.Generic.IList<global::Together.DeDeploymentSummary> deployments = default!)
        {
            this.Id = id;
            this.ProjectId = projectId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Etag = etag ?? throw new global::System.ArgumentNullException(nameof(etag));
            this.TrafficSplit = trafficSplit ?? throw new global::System.ArgumentNullException(nameof(trafficSplit));
            this.Visibility = visibility;
            this.EndpointType = endpointType;
            this.Deployments = deployments;
            this.ActiveRolloutId = activeRolloutId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeEndpoint" /> class.
        /// </summary>
        public DeEndpoint()
        {
        }

    }
}