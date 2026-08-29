
#nullable enable

namespace Together
{
    /// <summary>
    /// Mutable endpoint fields for update requests.
    /// </summary>
    public sealed partial class DeEndpointUpdate
    {
        /// <summary>
        /// Updated endpoint string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Current endpoint version. The update is rejected if this value no longer matches.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("etag")]
        public string? Etag { get; set; }

        /// <summary>
        /// Replacement live traffic split. Use an empty list to stop routing live traffic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trafficSplit")]
        public global::System.Collections.Generic.IList<global::Together.DeTrafficSplitEntry>? TrafficSplit { get; set; }

        /// <summary>
        /// Who can discover the endpoint. `VISIBILITY_PRIVATE` restricts it to the project; `VISIBILITY_INTERNAL` shares it with the organization.<br/>
        /// Default Value: VISIBILITY_PRIVATE
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeEndpointUpdateVisibilityJsonConverter))]
        public global::Together.DeEndpointUpdateVisibility? Visibility { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeEndpointUpdate" /> class.
        /// </summary>
        /// <param name="name">
        /// Updated endpoint string.
        /// </param>
        /// <param name="etag">
        /// Current endpoint version. The update is rejected if this value no longer matches.
        /// </param>
        /// <param name="trafficSplit">
        /// Replacement live traffic split. Use an empty list to stop routing live traffic.
        /// </param>
        /// <param name="visibility">
        /// Who can discover the endpoint. `VISIBILITY_PRIVATE` restricts it to the project; `VISIBILITY_INTERNAL` shares it with the organization.<br/>
        /// Default Value: VISIBILITY_PRIVATE
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeEndpointUpdate(
            string? name,
            string? etag,
            global::System.Collections.Generic.IList<global::Together.DeTrafficSplitEntry>? trafficSplit,
            global::Together.DeEndpointUpdateVisibility? visibility)
        {
            this.Name = name;
            this.Etag = etag;
            this.TrafficSplit = trafficSplit;
            this.Visibility = visibility;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeEndpointUpdate" /> class.
        /// </summary>
        public DeEndpointUpdate()
        {
        }

    }
}