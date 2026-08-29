
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DePlacementVariant1
    {
        /// <summary>
        /// Inline placement parameters evaluated at deploy time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inline")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.DeInlinePlacement Inline { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DePlacementVariant1" /> class.
        /// </summary>
        /// <param name="inline">
        /// Inline placement parameters evaluated at deploy time.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DePlacementVariant1(
            global::Together.DeInlinePlacement inline)
        {
            this.Inline = inline ?? throw new global::System.ArgumentNullException(nameof(inline));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DePlacementVariant1" /> class.
        /// </summary>
        public DePlacementVariant1()
        {
        }

    }
}