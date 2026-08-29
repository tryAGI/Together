
#nullable enable

namespace Together
{
    /// <summary>
    /// AddOnInfo is returned in cluster responses and add-on CRUD operations.
    /// </summary>
    public sealed partial class AddOnInfo
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add_on_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AddOnType { get; set; }

        /// <summary>
        /// Configuration for a cluster add-on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.AddOnConfig Config { get; set; }

        /// <summary>
        /// State for a cluster add-on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.AddOnState State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddOnInfo" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="addOnType"></param>
        /// <param name="config">
        /// Configuration for a cluster add-on.
        /// </param>
        /// <param name="state">
        /// State for a cluster add-on.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddOnInfo(
            string name,
            string addOnType,
            global::Together.AddOnConfig config,
            global::Together.AddOnState state)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AddOnType = addOnType ?? throw new global::System.ArgumentNullException(nameof(addOnType));
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddOnInfo" /> class.
        /// </summary>
        public AddOnInfo()
        {
        }

    }
}