
#nullable enable

namespace Together
{
    /// <summary>
    /// Region where an instance type is offered.
    /// </summary>
    public sealed partial class DeRegion
    {
        /// <summary>
        /// Region name where an instance type is offered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Best-effort replica headroom for this region. Omitted when unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headroom")]
        public global::Together.DeHeadroom? Headroom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeRegion" /> class.
        /// </summary>
        /// <param name="name">
        /// Region name where an instance type is offered.
        /// </param>
        /// <param name="headroom">
        /// Best-effort replica headroom for this region. Omitted when unavailable.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeRegion(
            string name,
            global::Together.DeHeadroom? headroom)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Headroom = headroom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeRegion" /> class.
        /// </summary>
        public DeRegion()
        {
        }

    }
}