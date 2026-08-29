
#nullable enable

namespace Together
{
    /// <summary>
    /// Mutable metadata for a custom model resource.
    /// </summary>
    public sealed partial class DeUpdateModelRequest
    {
        /// <summary>
        /// Updated inference-addressable model name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Updated user-facing model description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Who can discover the model. `VISIBILITY_PRIVATE` restricts it to the project; `VISIBILITY_INTERNAL` shares it with the organization.<br/>
        /// Default Value: VISIBILITY_PRIVATE
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeUpdateModelRequestVisibilityJsonConverter))]
        public global::Together.DeUpdateModelRequestVisibility? Visibility { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeUpdateModelRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Updated inference-addressable model name.
        /// </param>
        /// <param name="description">
        /// Updated user-facing model description.
        /// </param>
        /// <param name="visibility">
        /// Who can discover the model. `VISIBILITY_PRIVATE` restricts it to the project; `VISIBILITY_INTERNAL` shares it with the organization.<br/>
        /// Default Value: VISIBILITY_PRIVATE
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeUpdateModelRequest(
            string? name,
            string? description,
            global::Together.DeUpdateModelRequestVisibility? visibility)
        {
            this.Name = name;
            this.Description = description;
            this.Visibility = visibility;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeUpdateModelRequest" /> class.
        /// </summary>
        public DeUpdateModelRequest()
        {
        }

    }
}