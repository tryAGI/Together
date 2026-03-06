
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProtobufAny
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("@type")]
        public string? x_type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProtobufAny" /> class.
        /// </summary>
        /// <param name="x_type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProtobufAny(
            string? x_type)
        {
            this.x_type = x_type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProtobufAny" /> class.
        /// </summary>
        public ProtobufAny()
        {
        }
    }
}