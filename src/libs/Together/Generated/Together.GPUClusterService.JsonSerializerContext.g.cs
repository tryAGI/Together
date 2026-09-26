
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterControlPlaneNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.NodePhaseTransition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.NodePhaseTransition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterCreateRequestClusterType), TypeInfoPropertyName = "GPUClusterCreateRequestClusterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterCreateRequestGpuType), TypeInfoPropertyName = "GPUClusterCreateRequestGpuType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClustersSharedVolumeCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterCreateRequestBillingType), TypeInfoPropertyName = "GPUClusterCreateRequestBillingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OIDCConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AcceptanceTestsParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.InstanceClusterConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.AddOnCreateRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AddOnCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterGPUWorkerNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.Remediation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterInfoClusterType), TypeInfoPropertyName = "GPUClusterInfoClusterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterInfoGpuType), TypeInfoPropertyName = "GPUClusterInfoGpuType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.GPUClusterVolume>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterVolume))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterInfoStatus), TypeInfoPropertyName = "GPUClusterInfoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.GPUClusterControlPlaneNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.GPUClusterGPUWorkerNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.ClusterPhaseTransition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ClusterPhaseTransition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterInfoBillingType), TypeInfoPropertyName = "GPUClusterInfoBillingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.AddOnInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AddOnInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.GPUClusterNodeLifecycleEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterNodeLifecycleEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterUpdateRequestClusterType), TypeInfoPropertyName = "GPUClusterUpdateRequestClusterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.AddOnUpdateRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AddOnUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.GPUClusterInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AcceptanceTestsParamsDcgmDiagLevel), TypeInfoPropertyName = "AcceptanceTestsParamsDcgmDiagLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AddOnConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DashboardConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.IngressConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.TorchpassConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.SlurmWebConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.HeadlampConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AddOnState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DashboardState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.IngressState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.TorchpassState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.SlurmWebState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.HeadlampState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ClusterIngressConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ClusterPhaseTransitionPhase), TypeInfoPropertyName = "ClusterPhaseTransitionPhase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.InstanceClusterConfigLoadBalancer), TypeInfoPropertyName = "InstanceClusterConfigLoadBalancer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.SlurmStartupScripts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ObservabilityConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.NodePhaseTransitionPhase), TypeInfoPropertyName = "NodePhaseTransitionPhase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.PassiveHealthCheckAlert>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.PassiveHealthCheckAlert))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.PHCAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.XidDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.SlurmNodeUnavailableDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.PassiveHealthCheckAlertSeverity), TypeInfoPropertyName = "PassiveHealthCheckAlertSeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RemediationMode), TypeInfoPropertyName = "RemediationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RemediationTrigger), TypeInfoPropertyName = "RemediationTrigger2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RemediationState), TypeInfoPropertyName = "RemediationState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.XidEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.XidEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterCreateRequestClusterType?), TypeInfoPropertyName = "NullableGPUClusterCreateRequestClusterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterCreateRequestGpuType?), TypeInfoPropertyName = "NullableGPUClusterCreateRequestGpuType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterCreateRequestBillingType?), TypeInfoPropertyName = "NullableGPUClusterCreateRequestBillingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterInfoClusterType?), TypeInfoPropertyName = "NullableGPUClusterInfoClusterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterInfoGpuType?), TypeInfoPropertyName = "NullableGPUClusterInfoGpuType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterInfoStatus?), TypeInfoPropertyName = "NullableGPUClusterInfoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterInfoBillingType?), TypeInfoPropertyName = "NullableGPUClusterInfoBillingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterUpdateRequestClusterType?), TypeInfoPropertyName = "NullableGPUClusterUpdateRequestClusterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AcceptanceTestsParamsDcgmDiagLevel?), TypeInfoPropertyName = "NullableAcceptanceTestsParamsDcgmDiagLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ClusterPhaseTransitionPhase?), TypeInfoPropertyName = "NullableClusterPhaseTransitionPhase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.InstanceClusterConfigLoadBalancer?), TypeInfoPropertyName = "NullableInstanceClusterConfigLoadBalancer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.NodePhaseTransitionPhase?), TypeInfoPropertyName = "NullableNodePhaseTransitionPhase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.PassiveHealthCheckAlertSeverity?), TypeInfoPropertyName = "NullablePassiveHealthCheckAlertSeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RemediationMode?), TypeInfoPropertyName = "NullableRemediationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RemediationTrigger?), TypeInfoPropertyName = "NullableRemediationTrigger2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RemediationState?), TypeInfoPropertyName = "NullableRemediationState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.NodePhaseTransition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.AddOnCreateRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.GPUClusterVolume>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.GPUClusterControlPlaneNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.GPUClusterGPUWorkerNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.ClusterPhaseTransition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.AddOnInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.GPUClusterNodeLifecycleEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.AddOnUpdateRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.GPUClusterInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.PassiveHealthCheckAlert>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.XidEvent>))]
    internal sealed partial class GPUClusterServiceSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GPUClusterServiceSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static GPUClusterServiceSourceGenerationContext Default { get; } = new(DefaultOptions);

        private GPUClusterServiceSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, long?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<object>, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<byte[], string>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<byte[], string>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, object>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, object>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, object>());
            options.Converters.Add(new global::Together.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Together.GPUClusterCreateRequestClusterType)

                    || typeToConvert == typeof(global::Together.GPUClusterCreateRequestClusterType?)

                    || typeToConvert == typeof(global::Together.GPUClusterCreateRequestGpuType)

                    || typeToConvert == typeof(global::Together.GPUClusterCreateRequestGpuType?)

                    || typeToConvert == typeof(global::Together.GPUClusterCreateRequestBillingType)

                    || typeToConvert == typeof(global::Together.GPUClusterCreateRequestBillingType?)

                    || typeToConvert == typeof(global::Together.GPUClusterInfoClusterType)

                    || typeToConvert == typeof(global::Together.GPUClusterInfoClusterType?)

                    || typeToConvert == typeof(global::Together.GPUClusterInfoGpuType)

                    || typeToConvert == typeof(global::Together.GPUClusterInfoGpuType?)

                    || typeToConvert == typeof(global::Together.GPUClusterInfoStatus)

                    || typeToConvert == typeof(global::Together.GPUClusterInfoStatus?)

                    || typeToConvert == typeof(global::Together.GPUClusterInfoBillingType)

                    || typeToConvert == typeof(global::Together.GPUClusterInfoBillingType?)

                    || typeToConvert == typeof(global::Together.GPUClusterUpdateRequestClusterType)

                    || typeToConvert == typeof(global::Together.GPUClusterUpdateRequestClusterType?)

                    || typeToConvert == typeof(global::Together.AcceptanceTestsParamsDcgmDiagLevel)

                    || typeToConvert == typeof(global::Together.AcceptanceTestsParamsDcgmDiagLevel?)

                    || typeToConvert == typeof(global::Together.ClusterPhaseTransitionPhase)

                    || typeToConvert == typeof(global::Together.ClusterPhaseTransitionPhase?)

                    || typeToConvert == typeof(global::Together.InstanceClusterConfigLoadBalancer)

                    || typeToConvert == typeof(global::Together.InstanceClusterConfigLoadBalancer?)

                    || typeToConvert == typeof(global::Together.NodePhaseTransitionPhase)

                    || typeToConvert == typeof(global::Together.NodePhaseTransitionPhase?)

                    || typeToConvert == typeof(global::Together.PassiveHealthCheckAlertSeverity)

                    || typeToConvert == typeof(global::Together.PassiveHealthCheckAlertSeverity?)

                    || typeToConvert == typeof(global::Together.RemediationMode)

                    || typeToConvert == typeof(global::Together.RemediationMode?)

                    || typeToConvert == typeof(global::Together.RemediationTrigger)

                    || typeToConvert == typeof(global::Together.RemediationTrigger?)

                    || typeToConvert == typeof(global::Together.RemediationState)

                    || typeToConvert == typeof(global::Together.RemediationState?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Together.GPUClusterCreateRequestClusterType))
                {
                    return new global::Together.JsonConverters.GPUClusterCreateRequestClusterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.GPUClusterCreateRequestClusterType?))
                {
                    return new global::Together.JsonConverters.GPUClusterCreateRequestClusterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.GPUClusterCreateRequestGpuType))
                {
                    return new global::Together.JsonConverters.GPUClusterCreateRequestGpuTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.GPUClusterCreateRequestGpuType?))
                {
                    return new global::Together.JsonConverters.GPUClusterCreateRequestGpuTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.GPUClusterCreateRequestBillingType))
                {
                    return new global::Together.JsonConverters.GPUClusterCreateRequestBillingTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.GPUClusterCreateRequestBillingType?))
                {
                    return new global::Together.JsonConverters.GPUClusterCreateRequestBillingTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.GPUClusterInfoClusterType))
                {
                    return new global::Together.JsonConverters.GPUClusterInfoClusterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.GPUClusterInfoClusterType?))
                {
                    return new global::Together.JsonConverters.GPUClusterInfoClusterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.GPUClusterInfoGpuType))
                {
                    return new global::Together.JsonConverters.GPUClusterInfoGpuTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.GPUClusterInfoGpuType?))
                {
                    return new global::Together.JsonConverters.GPUClusterInfoGpuTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.GPUClusterInfoStatus))
                {
                    return new global::Together.JsonConverters.GPUClusterInfoStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.GPUClusterInfoStatus?))
                {
                    return new global::Together.JsonConverters.GPUClusterInfoStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.GPUClusterInfoBillingType))
                {
                    return new global::Together.JsonConverters.GPUClusterInfoBillingTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.GPUClusterInfoBillingType?))
                {
                    return new global::Together.JsonConverters.GPUClusterInfoBillingTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.GPUClusterUpdateRequestClusterType))
                {
                    return new global::Together.JsonConverters.GPUClusterUpdateRequestClusterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.GPUClusterUpdateRequestClusterType?))
                {
                    return new global::Together.JsonConverters.GPUClusterUpdateRequestClusterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AcceptanceTestsParamsDcgmDiagLevel))
                {
                    return new global::Together.JsonConverters.AcceptanceTestsParamsDcgmDiagLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AcceptanceTestsParamsDcgmDiagLevel?))
                {
                    return new global::Together.JsonConverters.AcceptanceTestsParamsDcgmDiagLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ClusterPhaseTransitionPhase))
                {
                    return new global::Together.JsonConverters.ClusterPhaseTransitionPhaseJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ClusterPhaseTransitionPhase?))
                {
                    return new global::Together.JsonConverters.ClusterPhaseTransitionPhaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.InstanceClusterConfigLoadBalancer))
                {
                    return new global::Together.JsonConverters.InstanceClusterConfigLoadBalancerJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.InstanceClusterConfigLoadBalancer?))
                {
                    return new global::Together.JsonConverters.InstanceClusterConfigLoadBalancerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.NodePhaseTransitionPhase))
                {
                    return new global::Together.JsonConverters.NodePhaseTransitionPhaseJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.NodePhaseTransitionPhase?))
                {
                    return new global::Together.JsonConverters.NodePhaseTransitionPhaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.PassiveHealthCheckAlertSeverity))
                {
                    return new global::Together.JsonConverters.PassiveHealthCheckAlertSeverityJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.PassiveHealthCheckAlertSeverity?))
                {
                    return new global::Together.JsonConverters.PassiveHealthCheckAlertSeverityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RemediationMode))
                {
                    return new global::Together.JsonConverters.RemediationModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RemediationMode?))
                {
                    return new global::Together.JsonConverters.RemediationModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RemediationTrigger))
                {
                    return new global::Together.JsonConverters.RemediationTriggerJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RemediationTrigger?))
                {
                    return new global::Together.JsonConverters.RemediationTriggerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RemediationState))
                {
                    return new global::Together.JsonConverters.RemediationStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RemediationState?))
                {
                    return new global::Together.JsonConverters.RemediationStateNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new GPUClusterServiceSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}