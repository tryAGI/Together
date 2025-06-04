
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelUploadRequest
    {
        /// <summary>
        /// The base model to use for an adapter if setting it to run against a serverless pool.  Only used for model_type `adapter`.<br/>
        /// Example: Qwen/Qwen2.5-72B-Instruct
        /// </summary>
        /// <example>Qwen/Qwen2.5-72B-Instruct</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_model")]
        public string? BaseModel { get; set; }

        /// <summary>
        /// A description of your model<br/>
        /// Example: Finetuned Qwen2.5-72B-Instruct by Unsloth
        /// </summary>
        /// <example>Finetuned Qwen2.5-72B-Instruct by Unsloth</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Hugging Face token (if uploading from Hugging Face)<br/>
        /// Example: hf_examplehuggingfacetoken
        /// </summary>
        /// <example>hf_examplehuggingfacetoken</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hf_token")]
        public string? HfToken { get; set; }

        /// <summary>
        /// The lora pool to use for an adapter if setting it to run against, say, a dedicated pool.  Only used for model_type `adapter`.<br/>
        /// Example: my_username/Qwen2.5-72B-Instruct-lora
        /// </summary>
        /// <example>my_username/Qwen2.5-72B-Instruct-lora</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora_model")]
        public string? LoraModel { get; set; }

        /// <summary>
        /// The name to give to your uploaded model<br/>
        /// Example: Qwen2.5-72B-Instruct
        /// </summary>
        /// <example>Qwen2.5-72B-Instruct</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// The source location of the model (Hugging Face repo or S3 path)<br/>
        /// Example: unsloth/Qwen2.5-72B-Instruct
        /// </summary>
        /// <example>unsloth/Qwen2.5-72B-Instruct</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelSource { get; set; }

        /// <summary>
        /// Whether the model is a full model or an adapter<br/>
        /// Default Value: model<br/>
        /// Example: model
        /// </summary>
        /// <example>model</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.ModelUploadRequestModelTypeJsonConverter))]
        public global::Together.ModelUploadRequestModelType? ModelType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelUploadRequest" /> class.
        /// </summary>
        /// <param name="baseModel">
        /// The base model to use for an adapter if setting it to run against a serverless pool.  Only used for model_type `adapter`.<br/>
        /// Example: Qwen/Qwen2.5-72B-Instruct
        /// </param>
        /// <param name="description">
        /// A description of your model<br/>
        /// Example: Finetuned Qwen2.5-72B-Instruct by Unsloth
        /// </param>
        /// <param name="hfToken">
        /// Hugging Face token (if uploading from Hugging Face)<br/>
        /// Example: hf_examplehuggingfacetoken
        /// </param>
        /// <param name="loraModel">
        /// The lora pool to use for an adapter if setting it to run against, say, a dedicated pool.  Only used for model_type `adapter`.<br/>
        /// Example: my_username/Qwen2.5-72B-Instruct-lora
        /// </param>
        /// <param name="modelName">
        /// The name to give to your uploaded model<br/>
        /// Example: Qwen2.5-72B-Instruct
        /// </param>
        /// <param name="modelSource">
        /// The source location of the model (Hugging Face repo or S3 path)<br/>
        /// Example: unsloth/Qwen2.5-72B-Instruct
        /// </param>
        /// <param name="modelType">
        /// Whether the model is a full model or an adapter<br/>
        /// Default Value: model<br/>
        /// Example: model
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelUploadRequest(
            string modelName,
            string modelSource,
            string? baseModel,
            string? description,
            string? hfToken,
            string? loraModel,
            global::Together.ModelUploadRequestModelType? modelType)
        {
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.ModelSource = modelSource ?? throw new global::System.ArgumentNullException(nameof(modelSource));
            this.BaseModel = baseModel;
            this.Description = description;
            this.HfToken = hfToken;
            this.LoraModel = loraModel;
            this.ModelType = modelType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelUploadRequest" /> class.
        /// </summary>
        public ModelUploadRequest()
        {
        }
    }
}