
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClusterAddOnCreateRequest
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
        /// Initializes a new instance of the <see cref="ClusterAddOnCreateRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="addOnType"></param>
        /// <param name="config"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClusterAddOnCreateRequest(
            string name,
            string addOnType,
            global::Together.AddOnConfig? config)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AddOnType = addOnType ?? throw new global::System.ArgumentNullException(nameof(addOnType));
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterAddOnCreateRequest" /> class.
        /// </summary>
        public ClusterAddOnCreateRequest()
        {
        }

    }
}