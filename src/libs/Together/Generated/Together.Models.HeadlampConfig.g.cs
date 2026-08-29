
#nullable enable

namespace Together
{
    /// <summary>
    /// Configuration for the Headlamp Kubernetes dashboard cluster add-on.
    /// </summary>
    public sealed partial class HeadlampConfig
    {
        /// <summary>
        /// Whether to enable the Headlamp Kubernetes dashboard add-on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HeadlampConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether to enable the Headlamp Kubernetes dashboard add-on.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HeadlampConfig(
            bool? enabled)
        {
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeadlampConfig" /> class.
        /// </summary>
        public HeadlampConfig()
        {
        }

    }
}