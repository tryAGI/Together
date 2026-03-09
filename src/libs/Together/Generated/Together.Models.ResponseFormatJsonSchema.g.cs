
#nullable enable

namespace Together
{
    /// <summary>
    /// JSON Schema response format. Used to generate structured JSON responses.<br/>
    /// Learn more about [Structured Outputs](https://docs.together.ai/docs/json-mode).
    /// </summary>
    public sealed partial class ResponseFormatJsonSchema
    {
        /// <summary>
        /// Structured Outputs configuration options, including a JSON Schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Together.ResponseFormatJsonSchemaJsonSchema JsonSchema { get; set; } = default!;

        /// <summary>
        /// The type of response format being defined. Always `json_schema`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.ResponseFormatJsonSchemaTypeJsonConverter))]
        public global::Together.ResponseFormatJsonSchemaType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormatJsonSchema" /> class.
        /// </summary>
        /// <param name="jsonSchema">
        /// Structured Outputs configuration options, including a JSON Schema.
        /// </param>
        /// <param name="type">
        /// The type of response format being defined. Always `json_schema`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseFormatJsonSchema(
            global::Together.ResponseFormatJsonSchemaJsonSchema jsonSchema,
            global::Together.ResponseFormatJsonSchemaType type)
        {
            this.JsonSchema = jsonSchema ?? throw new global::System.ArgumentNullException(nameof(jsonSchema));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormatJsonSchema" /> class.
        /// </summary>
        public ResponseFormatJsonSchema()
        {
        }
    }
}