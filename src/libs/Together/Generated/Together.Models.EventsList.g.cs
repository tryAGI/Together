
#nullable enable

namespace Together
{
    /// <summary>
    /// List response containing shaping events.
    /// </summary>
    public sealed partial class EventsList
    {
        /// <summary>
        /// Shaping events.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.QuantizationEvent> Data { get; set; }

        /// <summary>
        /// Object type, always `list`.
        /// </summary>
        /// <default>"list"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "list";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EventsList" /> class.
        /// </summary>
        /// <param name="data">
        /// Shaping events.
        /// </param>
        /// <param name="object">
        /// Object type, always `list`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EventsList(
            global::System.Collections.Generic.IList<global::Together.QuantizationEvent> data,
            string @object = "list")
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventsList" /> class.
        /// </summary>
        public EventsList()
        {
        }

    }
}