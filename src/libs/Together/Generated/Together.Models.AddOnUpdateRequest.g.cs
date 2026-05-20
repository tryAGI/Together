
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddOnUpdateRequest
    {
        /// <summary>
        /// Name of the add-on to update. Must match an existing add-on on the cluster.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::Together.AddOnConfig? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddOnUpdateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the add-on to update. Must match an existing add-on on the cluster.
        /// </param>
        /// <param name="config"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddOnUpdateRequest(
            string name,
            global::Together.AddOnConfig? config)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddOnUpdateRequest" /> class.
        /// </summary>
        public AddOnUpdateRequest()
        {
        }

    }
}