
#nullable enable

namespace Together
{
    /// <summary>
    /// Inline placement parameters expanded into scheduling rules by the server.
    /// </summary>
    public sealed partial class DeInlinePlacement
    {
        /// <summary>
        /// Regions where the deployment is allowed to run. Multiple regions allow best-effort replica spreading.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regions")]
        public global::System.Collections.Generic.IList<string>? Regions { get; set; }

        /// <summary>
        /// How strictly the regions list is enforced.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("constraint")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeInlinePlacementConstraintJsonConverter))]
        public global::Together.DeInlinePlacementConstraint? Constraint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeInlinePlacement" /> class.
        /// </summary>
        /// <param name="regions">
        /// Regions where the deployment is allowed to run. Multiple regions allow best-effort replica spreading.
        /// </param>
        /// <param name="constraint">
        /// How strictly the regions list is enforced.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeInlinePlacement(
            global::System.Collections.Generic.IList<string>? regions,
            global::Together.DeInlinePlacementConstraint? constraint)
        {
            this.Regions = regions;
            this.Constraint = constraint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeInlinePlacement" /> class.
        /// </summary>
        public DeInlinePlacement()
        {
        }

    }
}