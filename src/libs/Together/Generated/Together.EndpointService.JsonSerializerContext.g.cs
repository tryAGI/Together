
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeListPublicEndpointsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DePublicEndpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DePublicEndpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeListEndpointsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeEndpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeEndpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeTrafficSplitEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeTrafficSplitEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeEndpointVisibility), TypeInfoPropertyName = "DeEndpointVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeEndpointEndpointType), TypeInfoPropertyName = "DeEndpointEndpointType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeDeploymentSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeDeploymentSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeDeploymentSummaryTrafficMode), TypeInfoPropertyName = "DeDeploymentSummaryTrafficMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeDeploymentSummaryState), TypeInfoPropertyName = "DeDeploymentSummaryState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeAutoscalingResponse), TypeInfoPropertyName = "DeAutoscalingResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeCreateEndpointRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeCreateEndpointRequestVisibility), TypeInfoPropertyName = "DeCreateEndpointRequestVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeEndpointUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeEndpointUpdateVisibility), TypeInfoPropertyName = "DeEndpointUpdateVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeAutoscaling))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeListEndpointEventsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeEndpointEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeEndpointEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeAnalyticsData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeMetricsTimeRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeEndpointMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeTimeSeriesDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeTimeSeriesDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeDeploymentAnalyticsData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeDeploymentAnalyticsData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeScalingMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeScalingMetric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeScalingRules))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeEndpointEventLevel), TypeInfoPropertyName = "DeEndpointEventLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeEndpointEventSourceKind), TypeInfoPropertyName = "DeEndpointEventSourceKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeDeploymentMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRequestMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeLatencyMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeThroughputMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeErrorMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeResourceUtilization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeTokenMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeDeploymentMetrics>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeScalingPolicy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeScalingPolicyType), TypeInfoPropertyName = "DeScalingPolicyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeScalingPolicy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeScalingRulesSelectPolicy), TypeInfoPropertyName = "DeScalingRulesSelectPolicy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeScalingMetricName), TypeInfoPropertyName = "DeScalingMetricName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeScalingMetricType), TypeInfoPropertyName = "DeScalingMetricType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ErrorDataError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EndpointServiceListEndpointEventsMinLevel), TypeInfoPropertyName = "EndpointServiceListEndpointEventsMinLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.EndpointServiceListEndpointEventsSourceKind>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EndpointServiceListEndpointEventsSourceKind), TypeInfoPropertyName = "EndpointServiceListEndpointEventsSourceKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeEndpointVisibility?), TypeInfoPropertyName = "NullableDeEndpointVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeEndpointEndpointType?), TypeInfoPropertyName = "NullableDeEndpointEndpointType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeDeploymentSummaryTrafficMode?), TypeInfoPropertyName = "NullableDeDeploymentSummaryTrafficMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeDeploymentSummaryState?), TypeInfoPropertyName = "NullableDeDeploymentSummaryState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeAutoscalingResponse?), TypeInfoPropertyName = "NullableDeAutoscalingResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeCreateEndpointRequestVisibility?), TypeInfoPropertyName = "NullableDeCreateEndpointRequestVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeEndpointUpdateVisibility?), TypeInfoPropertyName = "NullableDeEndpointUpdateVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeEndpointEventLevel?), TypeInfoPropertyName = "NullableDeEndpointEventLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeEndpointEventSourceKind?), TypeInfoPropertyName = "NullableDeEndpointEventSourceKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeScalingPolicyType?), TypeInfoPropertyName = "NullableDeScalingPolicyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeScalingRulesSelectPolicy?), TypeInfoPropertyName = "NullableDeScalingRulesSelectPolicy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeScalingMetricName?), TypeInfoPropertyName = "NullableDeScalingMetricName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeScalingMetricType?), TypeInfoPropertyName = "NullableDeScalingMetricType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EndpointServiceListEndpointEventsMinLevel?), TypeInfoPropertyName = "NullableEndpointServiceListEndpointEventsMinLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EndpointServiceListEndpointEventsSourceKind?), TypeInfoPropertyName = "NullableEndpointServiceListEndpointEventsSourceKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DePublicEndpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeEndpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeTrafficSplitEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeDeploymentSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeEndpointEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeTimeSeriesDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeDeploymentAnalyticsData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeScalingMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeDeploymentMetrics>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeScalingPolicy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.EndpointServiceListEndpointEventsSourceKind>))]
    internal sealed partial class EndpointServiceSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EndpointServiceSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static EndpointServiceSourceGenerationContext Default { get; } = new(DefaultOptions);

        private EndpointServiceSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Together.JsonConverters.DeAutoscalingResponseJsonConverter());
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
                    typeToConvert == typeof(global::Together.DeEndpointVisibility)

                    || typeToConvert == typeof(global::Together.DeEndpointVisibility?)

                    || typeToConvert == typeof(global::Together.DeEndpointEndpointType)

                    || typeToConvert == typeof(global::Together.DeEndpointEndpointType?)

                    || typeToConvert == typeof(global::Together.DeDeploymentSummaryTrafficMode)

                    || typeToConvert == typeof(global::Together.DeDeploymentSummaryTrafficMode?)

                    || typeToConvert == typeof(global::Together.DeDeploymentSummaryState)

                    || typeToConvert == typeof(global::Together.DeDeploymentSummaryState?)

                    || typeToConvert == typeof(global::Together.DeCreateEndpointRequestVisibility)

                    || typeToConvert == typeof(global::Together.DeCreateEndpointRequestVisibility?)

                    || typeToConvert == typeof(global::Together.DeEndpointUpdateVisibility)

                    || typeToConvert == typeof(global::Together.DeEndpointUpdateVisibility?)

                    || typeToConvert == typeof(global::Together.DeEndpointEventLevel)

                    || typeToConvert == typeof(global::Together.DeEndpointEventLevel?)

                    || typeToConvert == typeof(global::Together.DeEndpointEventSourceKind)

                    || typeToConvert == typeof(global::Together.DeEndpointEventSourceKind?)

                    || typeToConvert == typeof(global::Together.DeScalingPolicyType)

                    || typeToConvert == typeof(global::Together.DeScalingPolicyType?)

                    || typeToConvert == typeof(global::Together.DeScalingRulesSelectPolicy)

                    || typeToConvert == typeof(global::Together.DeScalingRulesSelectPolicy?)

                    || typeToConvert == typeof(global::Together.DeScalingMetricName)

                    || typeToConvert == typeof(global::Together.DeScalingMetricName?)

                    || typeToConvert == typeof(global::Together.DeScalingMetricType)

                    || typeToConvert == typeof(global::Together.DeScalingMetricType?)

                    || typeToConvert == typeof(global::Together.EndpointServiceListEndpointEventsMinLevel)

                    || typeToConvert == typeof(global::Together.EndpointServiceListEndpointEventsMinLevel?)

                    || typeToConvert == typeof(global::Together.EndpointServiceListEndpointEventsSourceKind)

                    || typeToConvert == typeof(global::Together.EndpointServiceListEndpointEventsSourceKind?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Together.DeEndpointVisibility))
                {
                    return new global::Together.JsonConverters.DeEndpointVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeEndpointVisibility?))
                {
                    return new global::Together.JsonConverters.DeEndpointVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeEndpointEndpointType))
                {
                    return new global::Together.JsonConverters.DeEndpointEndpointTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeEndpointEndpointType?))
                {
                    return new global::Together.JsonConverters.DeEndpointEndpointTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeDeploymentSummaryTrafficMode))
                {
                    return new global::Together.JsonConverters.DeDeploymentSummaryTrafficModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeDeploymentSummaryTrafficMode?))
                {
                    return new global::Together.JsonConverters.DeDeploymentSummaryTrafficModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeDeploymentSummaryState))
                {
                    return new global::Together.JsonConverters.DeDeploymentSummaryStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeDeploymentSummaryState?))
                {
                    return new global::Together.JsonConverters.DeDeploymentSummaryStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeCreateEndpointRequestVisibility))
                {
                    return new global::Together.JsonConverters.DeCreateEndpointRequestVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeCreateEndpointRequestVisibility?))
                {
                    return new global::Together.JsonConverters.DeCreateEndpointRequestVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeEndpointUpdateVisibility))
                {
                    return new global::Together.JsonConverters.DeEndpointUpdateVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeEndpointUpdateVisibility?))
                {
                    return new global::Together.JsonConverters.DeEndpointUpdateVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeEndpointEventLevel))
                {
                    return new global::Together.JsonConverters.DeEndpointEventLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeEndpointEventLevel?))
                {
                    return new global::Together.JsonConverters.DeEndpointEventLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeEndpointEventSourceKind))
                {
                    return new global::Together.JsonConverters.DeEndpointEventSourceKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeEndpointEventSourceKind?))
                {
                    return new global::Together.JsonConverters.DeEndpointEventSourceKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeScalingPolicyType))
                {
                    return new global::Together.JsonConverters.DeScalingPolicyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeScalingPolicyType?))
                {
                    return new global::Together.JsonConverters.DeScalingPolicyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeScalingRulesSelectPolicy))
                {
                    return new global::Together.JsonConverters.DeScalingRulesSelectPolicyJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeScalingRulesSelectPolicy?))
                {
                    return new global::Together.JsonConverters.DeScalingRulesSelectPolicyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeScalingMetricName))
                {
                    return new global::Together.JsonConverters.DeScalingMetricNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeScalingMetricName?))
                {
                    return new global::Together.JsonConverters.DeScalingMetricNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeScalingMetricType))
                {
                    return new global::Together.JsonConverters.DeScalingMetricTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeScalingMetricType?))
                {
                    return new global::Together.JsonConverters.DeScalingMetricTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.EndpointServiceListEndpointEventsMinLevel))
                {
                    return new global::Together.JsonConverters.EndpointServiceListEndpointEventsMinLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.EndpointServiceListEndpointEventsMinLevel?))
                {
                    return new global::Together.JsonConverters.EndpointServiceListEndpointEventsMinLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.EndpointServiceListEndpointEventsSourceKind))
                {
                    return new global::Together.JsonConverters.EndpointServiceListEndpointEventsSourceKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.EndpointServiceListEndpointEventsSourceKind?))
                {
                    return new global::Together.JsonConverters.EndpointServiceListEndpointEventsSourceKindNullableJsonConverter();
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
                    0 => new EndpointServiceSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}