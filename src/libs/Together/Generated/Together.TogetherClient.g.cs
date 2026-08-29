
#nullable enable

namespace Together
{
    /// <summary>
    /// The Together REST API. See https://docs.together.ai for more details.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class TogetherClient : global::Together.ITogetherClient, global::System.IDisposable
    {
        /// <summary>
        /// Default environment for APIs
        /// </summary>
        public const string DefaultBaseUrl = "https://api.together.ai/v1";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => ResolveDisplayedBaseUri();

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::Together.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif

        /// <inheritdoc/>
        public global::Together.AutoSDKClientOptions Options { get; }


        internal global::Together.AutoSDKServerConfiguration AutoSDKServerConfiguration { get; set; } = new global::Together.AutoSDKServerConfiguration();

        internal global::System.Lazy<global::System.Text.Json.Serialization.JsonSerializerContext> JsonSerializerContextProvider { get; set; } = new(() => global::Together.SourceGenerationContext.Default);

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext
        {
            get => JsonSerializerContextProvider.Value;
            set => JsonSerializerContextProvider = new(() => value);
        }


        /// <summary>
        ///
        /// </summary>
        public ABExperimentServiceClient ABExperimentService => new ABExperimentServiceClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public AccountClient Account => new AccountClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public AudioClient Audio => new AudioClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public BatchesClient Batches => new BatchesClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public BillingClient Billing => new BillingClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public ChatClient Chat => new ChatClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public CodeInterpreterClient CodeInterpreter => new CodeInterpreterClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public CompletionClient Completion => new CompletionClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public ConfigServiceClient ConfigService => new ConfigServiceClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public DeploymentServiceClient DeploymentService => new DeploymentServiceClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public DeploymentsClient Deployments => new DeploymentsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public DeploymentsStorageClient DeploymentsStorage => new DeploymentsStorageClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public DeploymentsVolumesClient DeploymentsVolumes => new DeploymentsVolumesClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public EmbeddingsClient Embeddings => new EmbeddingsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public EndpointServiceClient EndpointService => new EndpointServiceClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public EndpointsClient Endpoints => new EndpointsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public Endpoints2Client Endpoints2 => new Endpoints2Client(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public EvaluationClient Evaluation => new EvaluationClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public FilesClient Files => new FilesClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public FineTuningClient FineTuning => new FineTuningClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public GPUClusterServiceClient GPUClusterService => new GPUClusterServiceClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public HardwareClient Hardware => new HardwareClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public HealthCheckServiceClient HealthCheckService => new HealthCheckServiceClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public ImagesClient Images => new ImagesClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public InstanceClusterAddOnServiceClient InstanceClusterAddOnService => new InstanceClusterAddOnServiceClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public InstanceTypeServiceClient InstanceTypeService => new InstanceTypeServiceClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public JobsClient Jobs => new JobsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public ModelsClient Models => new ModelsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public PlacementProfileServiceClient PlacementProfileService => new PlacementProfileServiceClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public QueueClient Queue => new QueueClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public RegionServiceClient RegionService => new RegionServiceClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public RemediationServiceClient RemediationService => new RemediationServiceClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public RerankClient Rerank => new RerankClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public RlClient Rl => new RlClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public RolloutServiceClient RolloutService => new RolloutServiceClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public SecretsClient Secrets => new SecretsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public ShadowExperimentServiceClient ShadowExperimentService => new ShadowExperimentServiceClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public SharedVolumeServiceClient SharedVolumeService => new SharedVolumeServiceClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public SupportedModelsServiceClient SupportedModelsService => new SupportedModelsServiceClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public VideoClient Video => new VideoClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public VoicesClient Voices => new VoicesClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public VolumeServiceClient VolumeService => new VolumeServiceClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        ///
        /// </summary>
        public VolumesClient Volumes => new VolumesClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };


        private static readonly global::Together.AutoSDKServer[] s_availableServers = new global::Together.AutoSDKServer[]
        {            new global::Together.AutoSDKServer(
                id: "https-api-together-ai-v1",
                name: "Default environment for APIs",
                url: "https://api.together.ai/v1",
                description: "Default environment for APIs"),
            new global::Together.AutoSDKServer(
                id: "https-api-inference-together-ai-v2",
                name: "Optimized environment for inference",
                url: "https://api-inference.together.ai/v2",
                description: "Optimized environment for inference"),
            new global::Together.AutoSDKServer(
                id: "https-api-together-ai-v2",
                name: "api.together.ai v2",
                url: "https://api.together.ai/v2",
                description: ""),
        };

        /// <summary>
        /// The server options available for this client.
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<global::Together.AutoSDKServer> AvailableServers => s_availableServers;

        /// <summary>
        /// The currently selected server for this client, if any.
        /// </summary>
        public global::Together.AutoSDKServer? SelectedServer
        {
            get => ResolveSelectedServer();
            set => SelectServer(value);
        }

        /// <summary>
        /// Creates a new instance of the TogetherClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public TogetherClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Together.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri,
                authorizations,
                options: null,
                disposeHttpClient: disposeHttpClient)
        {
        }

        /// <summary>
        /// Creates a new instance of the TogetherClient with explicit options but no base URL override.
        /// Skips passing <c>baseUri</c> so the default base URL from the OpenAPI spec applies.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public TogetherClient(
            global::System.Net.Http.HttpClient? httpClient,
            global::System.Collections.Generic.List<global::Together.EndPointAuthorization>? authorizations,
            global::Together.AutoSDKClientOptions? options,
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri: null,
                authorizations,
                options,
                disposeHttpClient: disposeHttpClient)
        {
        }

        /// <summary>
        /// Creates a new instance of the TogetherClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public TogetherClient(
            global::System.Net.Http.HttpClient? httpClient,
            global::System.Uri? baseUri,
            global::System.Collections.Generic.List<global::Together.EndPointAuthorization>? authorizations,
            global::Together.AutoSDKClientOptions? options,
            bool disposeHttpClient = true)
        {

            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            if (baseUri is not null)
            {
                HttpClient.BaseAddress ??= baseUri;
            }
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::Together.EndPointAuthorization>();
            Options = options ?? new global::Together.AutoSDKClientOptions();
            _disposeHttpClient = disposeHttpClient;

            AutoSDKServerConfiguration.ExplicitBaseUri = baseUri ?? httpClient?.BaseAddress;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
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


        /// <summary>
        /// Selects one of the generated server options by id.
        /// </summary>
        public bool TrySelectServer(string serverId)
        {
            if (string.IsNullOrWhiteSpace(serverId))
            {
                return false;
            }

            foreach (var server in s_availableServers)
            {
                if (string.Equals(server.Id, serverId, global::System.StringComparison.OrdinalIgnoreCase))
                {
                    AutoSDKServerConfiguration.SelectedServer = server;
                    AutoSDKServerConfiguration.ExplicitBaseUri = null;
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Clears the currently selected server.
        /// </summary>
        public void ClearSelectedServer()
        {
            AutoSDKServerConfiguration.SelectedServer = null;
        }

        private global::Together.AutoSDKServer? ResolveSelectedServer()
        {
            var selectedServer = AutoSDKServerConfiguration.SelectedServer;
            if (selectedServer is null)
            {
                return null;
            }

            foreach (var server in s_availableServers)
            {
                if (string.Equals(server.Id, selectedServer.Id, global::System.StringComparison.Ordinal))
                {
                    return server;
                }
            }

            return null;
        }

        private void SelectServer(global::Together.AutoSDKServer? server)
        {
            if (server is null)
            {
                AutoSDKServerConfiguration.SelectedServer = null;
                return;
            }

            foreach (var candidate in s_availableServers)
            {
                if (string.Equals(candidate.Id, server.Id, global::System.StringComparison.Ordinal))
                {
                    AutoSDKServerConfiguration.SelectedServer = candidate;
                    AutoSDKServerConfiguration.ExplicitBaseUri = null;
                    return;
                }
            }

            throw new global::System.ArgumentException("The provided server is not available for this client.", nameof(server));
        }

        private global::System.Uri? ResolveDisplayedBaseUri()
        {
            if (AutoSDKServerConfiguration.ExplicitBaseUri is global::System.Uri explicitBaseUri)
            {
                return explicitBaseUri;
            }

            return ResolveSelectedServer()?.Uri ?? (s_availableServers.Length > 0 ? s_availableServers[0].Uri : HttpClient.BaseAddress);
        }

        private global::System.Uri? ResolveBaseUri(
            global::Together.AutoSDKServer[] servers,
            string defaultBaseUrl)
        {
            if (AutoSDKServerConfiguration.ExplicitBaseUri is global::System.Uri explicitBaseUri)
            {
                return explicitBaseUri;
            }

            if (AutoSDKServerConfiguration.SelectedServer is global::Together.AutoSDKServer selectedServer)
            {
                foreach (var server in servers)
                {
                    if (string.Equals(server.Id, selectedServer.Id, global::System.StringComparison.Ordinal))
                    {
                        return server.Uri;
                    }
                }
            }

            if (servers.Length > 0)
            {
                return servers[0].Uri;
            }

            return string.IsNullOrWhiteSpace(defaultBaseUrl)
                ? HttpClient.BaseAddress
                : new global::System.Uri(defaultBaseUrl, global::System.UriKind.RelativeOrAbsolute);
        }
    }
}