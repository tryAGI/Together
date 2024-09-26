
#nullable enable

namespace Together
{
    public partial class FineTuningClient
    {
        partial void PrepareCreateFineTunesArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Together.Request2 request);
        partial void PrepareCreateFineTunesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Together.Request2 request);
        partial void ProcessCreateFineTunesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateFineTunesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create job<br/>
        /// Use a model to create a fine-tuning job.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Together.FinetuneResponse> CreateFineTunesAsync(
            global::Together.Request2 request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateFineTunesArguments(
                httpClient: _httpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/fine-tunes",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, request.GetType(), JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateFineTunesRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCreateFineTunesResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateFineTunesResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::Together.FinetuneResponse), JsonSerializerContext) as global::Together.FinetuneResponse ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create job<br/>
        /// Use a model to create a fine-tuning job.
        /// </summary>
        /// <param name="trainingFile">
        /// File-ID of a training file uploaded to the Together API
        /// </param>
        /// <param name="validationFile">
        /// File-ID of a validation file uploaded to the Together API
        /// </param>
        /// <param name="model">
        /// Name of the base model to run fine-tune job on
        /// </param>
        /// <param name="nEpochs">
        /// Number of epochs for fine-tuning<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="nCheckpoints">
        /// Number of checkpoints to save during fine-tuning<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="nEvals">
        /// Number of evaluations to be run on a given validation set during training<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="batchSize">
        /// Batch size for fine-tuning<br/>
        /// Default Value: 32
        /// </param>
        /// <param name="learningRate">
        /// Learning rate multiplier to use for training<br/>
        /// Default Value: 1E-05F
        /// </param>
        /// <param name="suffix">
        /// Suffix that will be added to your fine-tuned model name
        /// </param>
        /// <param name="wandbApiKey">
        /// API key for Weights &amp; Biases integration
        /// </param>
        /// <param name="lora">
        /// Whether to enable LoRA training. If not provided, full fine-tuning will be applied.
        /// </param>
        /// <param name="loraR">
        /// Rank for LoRA adapter weights<br/>
        /// Default Value: 8
        /// </param>
        /// <param name="loraAlpha">
        /// The alpha value for LoRA adapter training.<br/>
        /// Default Value: 8
        /// </param>
        /// <param name="loraDropout">
        /// The dropout probability for Lora layers.<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="loraTrainableModules">
        /// A list of LoRA trainable modules, separated by a comma<br/>
        /// Default Value: all-linear
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Together.FinetuneResponse> CreateFineTunesAsync(
            string trainingFile,
            string model,
            string? validationFile = default,
            int? nEpochs = 1,
            int? nCheckpoints = 1,
            int? nEvals = 0,
            int? batchSize = 32,
            float? learningRate = 1E-05F,
            string? suffix = default,
            string? wandbApiKey = default,
            bool? lora = default,
            int? loraR = 8,
            int? loraAlpha = 8,
            float? loraDropout = 0F,
            string? loraTrainableModules = "all-linear",
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::Together.Request2
            {
                TrainingFile = trainingFile,
                ValidationFile = validationFile,
                Model = model,
                NEpochs = nEpochs,
                NCheckpoints = nCheckpoints,
                NEvals = nEvals,
                BatchSize = batchSize,
                LearningRate = learningRate,
                Suffix = suffix,
                WandbApiKey = wandbApiKey,
                Lora = lora,
                LoraR = loraR,
                LoraAlpha = loraAlpha,
                LoraDropout = loraDropout,
                LoraTrainableModules = loraTrainableModules,
            };

            return await CreateFineTunesAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}