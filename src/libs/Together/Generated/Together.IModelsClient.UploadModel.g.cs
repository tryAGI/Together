#nullable enable

namespace Together
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Upload a custom model or adapter<br/>
        /// Upload a custom model or adapter from Hugging Face or S3
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// # Docs for v1 can be found by changing the above selector ^<br/>
        /// from together import Together<br/>
        /// import os<br/>
        /// client = Together(<br/>
        ///     api_key=os.environ.get("TOGETHER_API_KEY"),<br/>
        /// )<br/>
        /// response = client.models.upload(<br/>
        ///     model_name="My-Fine-Tuned-Model",<br/>
        ///     model_source="https://ml-models.s3.us-west-2.amazonaws.com/models/my-fine-tuned-model.tar.gz",<br/>
        /// )<br/>
        /// print(response.data.job_id)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.ModelUploadSuccessResponse> UploadModelAsync(

            global::Together.ModelUploadRequest request,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a custom model or adapter<br/>
        /// Upload a custom model or adapter from Hugging Face or S3
        /// </summary>
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
        /// <param name="hfToken">
        /// Hugging Face token (if uploading from Hugging Face)<br/>
        /// Example: hf_examplehuggingfacetoken
        /// </param>
        /// <param name="description">
        /// A description of your model<br/>
        /// Example: Finetuned Qwen2.5-72B-Instruct by Unsloth
        /// </param>
        /// <param name="baseModel">
        /// The base model to use for an adapter if setting it to run against a serverless pool.  Only used for model_type `adapter`.<br/>
        /// Example: Qwen/Qwen2.5-72B-Instruct
        /// </param>
        /// <param name="loraModel">
        /// The lora pool to use for an adapter if setting it to run against, say, a dedicated pool.  Only used for model_type `adapter`.<br/>
        /// Example: my_username/Qwen2.5-72B-Instruct-lora
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.ModelUploadSuccessResponse> UploadModelAsync(
            string modelName,
            string modelSource,
            global::Together.ModelUploadRequestModelType? modelType = default,
            string? hfToken = default,
            string? description = default,
            string? baseModel = default,
            string? loraModel = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}