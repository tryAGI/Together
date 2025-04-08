#nullable enable

namespace Together
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Upload a custom model<br/>
        /// Upload a custom model from Hugging Face or S3
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Together.UploadModelResponse> UploadModelAsync(
            global::Together.UploadModelRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload a custom model<br/>
        /// Upload a custom model from Hugging Face or S3
        /// </summary>
        /// <param name="description">
        /// A description of your model<br/>
        /// Example: Finetuned Qwen2.5-72B-Instruct by Unsloth
        /// </param>
        /// <param name="hfToken">
        /// Hugging Face token (if uploading from Hugging Face)<br/>
        /// Example: hf_examplehuggingfacetoken
        /// </param>
        /// <param name="modelName">
        /// The name to give to your uploaded model<br/>
        /// Example: Qwen2.5-72B-Instruct
        /// </param>
        /// <param name="modelSource">
        /// The source location of the model (Hugging Face repo or S3 path)<br/>
        /// Example: unsloth/Qwen2.5-72B-Instruct
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.UploadModelResponse> UploadModelAsync(
            string modelName,
            string modelSource,
            string? description = default,
            string? hfToken = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}