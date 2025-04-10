
#nullable enable

namespace Together
{
    /// <summary>
    /// Errors and exceptions that occurred. If this output type is present, your code did not execute successfully.
    /// </summary>
    public sealed partial class ExecuteResponseVariant1DataOutputVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.ExecuteResponseVariant1DataOutputVariant2TypeJsonConverter))]
        public global::Together.ExecuteResponseVariant1DataOutputVariant2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteResponseVariant1DataOutputVariant2" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecuteResponseVariant1DataOutputVariant2(
            string data,
            global::Together.ExecuteResponseVariant1DataOutputVariant2Type type)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteResponseVariant1DataOutputVariant2" /> class.
        /// </summary>
        public ExecuteResponseVariant1DataOutputVariant2()
        {
        }
    }
}