
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateDeploymentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.HTTPAutoscalingConfig, global::Together.QueueAutoscalingConfig, global::Together.CustomMetricAutoscalingConfig>), TypeInfoPropertyName = "OneOfHTTPAutoscalingConfigQueueAutoscalingConfigCustomMetricAutoscalingConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.HTTPAutoscalingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.QueueAutoscalingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CustomMetricAutoscalingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateDeploymentRequestCapacityType), TypeInfoPropertyName = "CreateDeploymentRequestCapacityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.EnvironmentVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EnvironmentVariable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateDeploymentRequestGpuType), TypeInfoPropertyName = "CreateDeploymentRequestGpuType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.VolumeMount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.VolumeMount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeploymentListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeploymentResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeploymentResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeploymentLogs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeploymentResponseItemCapacityType), TypeInfoPropertyName = "DeploymentResponseItemCapacityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeploymentResponseItemGpuType), TypeInfoPropertyName = "DeploymentResponseItemGpuType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Together.ReplicaEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ReplicaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeploymentStatus), TypeInfoPropertyName = "DeploymentStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.HTTPAutoscalingConfigMetric), TypeInfoPropertyName = "HTTPAutoscalingConfigMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.QueueAutoscalingConfigMetric), TypeInfoPropertyName = "QueueAutoscalingConfigMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CustomMetricAutoscalingConfigMetric), TypeInfoPropertyName = "CustomMetricAutoscalingConfigMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.UpdateDeploymentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.UpdateDeploymentRequestCapacityType), TypeInfoPropertyName = "UpdateDeploymentRequestCapacityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.UpdateDeploymentRequestGpuType), TypeInfoPropertyName = "UpdateDeploymentRequestGpuType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.HTTPAutoscalingConfig, global::Together.QueueAutoscalingConfig, global::Together.CustomMetricAutoscalingConfig>?), TypeInfoPropertyName = "NullableOneOfHTTPAutoscalingConfigQueueAutoscalingConfigCustomMetricAutoscalingConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateDeploymentRequestCapacityType?), TypeInfoPropertyName = "NullableCreateDeploymentRequestCapacityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateDeploymentRequestGpuType?), TypeInfoPropertyName = "NullableCreateDeploymentRequestGpuType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeploymentResponseItemCapacityType?), TypeInfoPropertyName = "NullableDeploymentResponseItemCapacityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeploymentResponseItemGpuType?), TypeInfoPropertyName = "NullableDeploymentResponseItemGpuType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeploymentStatus?), TypeInfoPropertyName = "NullableDeploymentStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.HTTPAutoscalingConfigMetric?), TypeInfoPropertyName = "NullableHTTPAutoscalingConfigMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.QueueAutoscalingConfigMetric?), TypeInfoPropertyName = "NullableQueueAutoscalingConfigMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CustomMetricAutoscalingConfigMetric?), TypeInfoPropertyName = "NullableCustomMetricAutoscalingConfigMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.UpdateDeploymentRequestCapacityType?), TypeInfoPropertyName = "NullableUpdateDeploymentRequestCapacityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.UpdateDeploymentRequestGpuType?), TypeInfoPropertyName = "NullableUpdateDeploymentRequestGpuType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.EnvironmentVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.VolumeMount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeploymentResponseItem>))]
    internal sealed partial class DeploymentsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeploymentsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static DeploymentsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private DeploymentsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, long?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<object>, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<byte[], string>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<byte[], string>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, object>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, object>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, object>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::Together.HTTPAutoscalingConfig, global::Together.QueueAutoscalingConfig, global::Together.CustomMetricAutoscalingConfig>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::Together.HTTPAutoscalingConfig, global::Together.QueueAutoscalingConfig, global::Together.CustomMetricAutoscalingConfig>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::Together.HTTPAutoscalingConfig, global::Together.QueueAutoscalingConfig, global::Together.CustomMetricAutoscalingConfig>());
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
                    typeToConvert == typeof(global::Together.CreateDeploymentRequestCapacityType)

                    || typeToConvert == typeof(global::Together.CreateDeploymentRequestCapacityType?)

                    || typeToConvert == typeof(global::Together.CreateDeploymentRequestGpuType)

                    || typeToConvert == typeof(global::Together.CreateDeploymentRequestGpuType?)

                    || typeToConvert == typeof(global::Together.DeploymentResponseItemCapacityType)

                    || typeToConvert == typeof(global::Together.DeploymentResponseItemCapacityType?)

                    || typeToConvert == typeof(global::Together.DeploymentResponseItemGpuType)

                    || typeToConvert == typeof(global::Together.DeploymentResponseItemGpuType?)

                    || typeToConvert == typeof(global::Together.DeploymentStatus)

                    || typeToConvert == typeof(global::Together.DeploymentStatus?)

                    || typeToConvert == typeof(global::Together.HTTPAutoscalingConfigMetric)

                    || typeToConvert == typeof(global::Together.HTTPAutoscalingConfigMetric?)

                    || typeToConvert == typeof(global::Together.QueueAutoscalingConfigMetric)

                    || typeToConvert == typeof(global::Together.QueueAutoscalingConfigMetric?)

                    || typeToConvert == typeof(global::Together.CustomMetricAutoscalingConfigMetric)

                    || typeToConvert == typeof(global::Together.CustomMetricAutoscalingConfigMetric?)

                    || typeToConvert == typeof(global::Together.UpdateDeploymentRequestCapacityType)

                    || typeToConvert == typeof(global::Together.UpdateDeploymentRequestCapacityType?)

                    || typeToConvert == typeof(global::Together.UpdateDeploymentRequestGpuType)

                    || typeToConvert == typeof(global::Together.UpdateDeploymentRequestGpuType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Together.CreateDeploymentRequestCapacityType))
                {
                    return new global::Together.JsonConverters.CreateDeploymentRequestCapacityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CreateDeploymentRequestCapacityType?))
                {
                    return new global::Together.JsonConverters.CreateDeploymentRequestCapacityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CreateDeploymentRequestGpuType))
                {
                    return new global::Together.JsonConverters.CreateDeploymentRequestGpuTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CreateDeploymentRequestGpuType?))
                {
                    return new global::Together.JsonConverters.CreateDeploymentRequestGpuTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeploymentResponseItemCapacityType))
                {
                    return new global::Together.JsonConverters.DeploymentResponseItemCapacityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeploymentResponseItemCapacityType?))
                {
                    return new global::Together.JsonConverters.DeploymentResponseItemCapacityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeploymentResponseItemGpuType))
                {
                    return new global::Together.JsonConverters.DeploymentResponseItemGpuTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeploymentResponseItemGpuType?))
                {
                    return new global::Together.JsonConverters.DeploymentResponseItemGpuTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeploymentStatus))
                {
                    return new global::Together.JsonConverters.DeploymentStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeploymentStatus?))
                {
                    return new global::Together.JsonConverters.DeploymentStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.HTTPAutoscalingConfigMetric))
                {
                    return new global::Together.JsonConverters.HTTPAutoscalingConfigMetricJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.HTTPAutoscalingConfigMetric?))
                {
                    return new global::Together.JsonConverters.HTTPAutoscalingConfigMetricNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.QueueAutoscalingConfigMetric))
                {
                    return new global::Together.JsonConverters.QueueAutoscalingConfigMetricJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.QueueAutoscalingConfigMetric?))
                {
                    return new global::Together.JsonConverters.QueueAutoscalingConfigMetricNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CustomMetricAutoscalingConfigMetric))
                {
                    return new global::Together.JsonConverters.CustomMetricAutoscalingConfigMetricJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CustomMetricAutoscalingConfigMetric?))
                {
                    return new global::Together.JsonConverters.CustomMetricAutoscalingConfigMetricNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.UpdateDeploymentRequestCapacityType))
                {
                    return new global::Together.JsonConverters.UpdateDeploymentRequestCapacityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.UpdateDeploymentRequestCapacityType?))
                {
                    return new global::Together.JsonConverters.UpdateDeploymentRequestCapacityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.UpdateDeploymentRequestGpuType))
                {
                    return new global::Together.JsonConverters.UpdateDeploymentRequestGpuTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.UpdateDeploymentRequestGpuType?))
                {
                    return new global::Together.JsonConverters.UpdateDeploymentRequestGpuTypeNullableJsonConverter();
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
                    0 => new DeploymentsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}