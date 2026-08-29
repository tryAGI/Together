
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DePlacementVariant2
    {
        /// <summary>
        /// UID of a saved placement profile.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Profile { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DePlacementVariant2" /> class.
        /// </summary>
        /// <param name="profile">
        /// UID of a saved placement profile.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DePlacementVariant2(
            string profile)
        {
            this.Profile = profile ?? throw new global::System.ArgumentNullException(nameof(profile));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DePlacementVariant2" /> class.
        /// </summary>
        public DePlacementVariant2()
        {
        }

    }
}