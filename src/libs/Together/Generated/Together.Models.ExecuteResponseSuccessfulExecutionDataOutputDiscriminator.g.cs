
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExecuteResponseSuccessfulExecutionDataOutputDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.ExecuteResponseSuccessfulExecutionDataOutputDiscriminatorTypeJsonConverter))]
        public global::Together.ExecuteResponseSuccessfulExecutionDataOutputDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteResponseSuccessfulExecutionDataOutputDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecuteResponseSuccessfulExecutionDataOutputDiscriminator(
            global::Together.ExecuteResponseSuccessfulExecutionDataOutputDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteResponseSuccessfulExecutionDataOutputDiscriminator" /> class.
        /// </summary>
        public ExecuteResponseSuccessfulExecutionDataOutputDiscriminator()
        {
        }

    }
}