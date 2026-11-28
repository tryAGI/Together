
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class EvaluationModelRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required string Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required int MaxTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required double Temperature { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_template")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required string SystemTemplate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_template")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required string InputTemplate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.EvaluationModelRequestModelSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required global::Together.EvaluationModelRequestModelSource ModelSource { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_api_token")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? ExternalApiToken { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_base_url")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? ExternalBaseUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_workers")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? NumWorkers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationModelRequest" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="maxTokens"></param>
        /// <param name="temperature"></param>
        /// <param name="systemTemplate"></param>
        /// <param name="inputTemplate"></param>
        /// <param name="modelSource"></param>
        /// <param name="externalApiToken"></param>
        /// <param name="externalBaseUrl"></param>
        /// <param name="numWorkers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationModelRequest(
            string model,
            int maxTokens,
            double temperature,
            string systemTemplate,
            string inputTemplate,
            global::Together.EvaluationModelRequestModelSource modelSource,
            string? externalApiToken,
            string? externalBaseUrl,
            int? numWorkers)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.MaxTokens = maxTokens;
            this.Temperature = temperature;
            this.SystemTemplate = systemTemplate ?? throw new global::System.ArgumentNullException(nameof(systemTemplate));
            this.InputTemplate = inputTemplate ?? throw new global::System.ArgumentNullException(nameof(inputTemplate));
            this.ModelSource = modelSource;
            this.ExternalApiToken = externalApiToken;
            this.ExternalBaseUrl = externalBaseUrl;
            this.NumWorkers = numWorkers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationModelRequest" /> class.
        /// </summary>
        public EvaluationModelRequest()
        {
        }

    }
}