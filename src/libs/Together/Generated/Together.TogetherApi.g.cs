
#nullable enable

namespace Together
{
    /// <summary>
    /// The Together REST API. Please see https://docs.together.ai for more details.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class TogetherApi : global::Together.ITogetherApi, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string BaseUrl = "https://api.together.xyz/v1";

        private readonly global::System.Net.Http.HttpClient _httpClient;
        private global::System.Collections.Generic.List<global::Together.EndPointAuthorization> _authorizations;

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; } = global::Together.SourceGenerationContext.Default;


        /// <summary>
        /// 
        /// </summary>
        public ChatClient Chat => new ChatClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public CompletionClient Completion => new CompletionClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsClient Embeddings => new EmbeddingsClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public FilesClient Files => new FilesClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public FineTuningClient FineTuning => new FineTuningClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public ImagesClient Images => new ImagesClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public ModelsClient Models => new ModelsClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public RerankClient Rerank => new RerankClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Creates a new instance of the TogetherApi.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="baseUri"></param>
        /// <param name="authorizations"></param>
        public TogetherApi(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Together.EndPointAuthorization>? authorizations = null)
        {
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri(BaseUrl);
            _authorizations = authorizations ?? new global::System.Collections.Generic.List<global::Together.EndPointAuthorization>();

            Initialized(_httpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _httpClient.Dispose();
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}