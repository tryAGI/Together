
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WhoamiProject
    {
        /// <summary>
        /// Project identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Project display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// DNS-friendly project identifier. Used with an endpoint slug as `&lt;project_slug&gt;/&lt;endpoint_slug&gt;` to form the `model` value in dedicated endpoint inference calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WhoamiProject" /> class.
        /// </summary>
        /// <param name="id">
        /// Project identifier.
        /// </param>
        /// <param name="name">
        /// Project display name.
        /// </param>
        /// <param name="slug">
        /// DNS-friendly project identifier. Used with an endpoint slug as `&lt;project_slug&gt;/&lt;endpoint_slug&gt;` to form the `model` value in dedicated endpoint inference calls.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WhoamiProject(
            string id,
            string name,
            string slug)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WhoamiProject" /> class.
        /// </summary>
        public WhoamiProject()
        {
        }

    }
}