
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ErrorDataError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ShapingJobType), TypeInfoPropertyName = "ShapingJobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ShapingJobStatus), TypeInfoPropertyName = "ShapingJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EventLevel), TypeInfoPropertyName = "EventLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.BaseShapingJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.QuantizationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.QuantizationPipelineInputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.QuantizationEstimate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.QuantizationPipelineConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.QuantizationPipelineSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.QuantizationResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.QuantizationJob), TypeInfoPropertyName = "QuantizationJob2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.QuantizationJobVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.QuantizationEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.QuantizationEvent), TypeInfoPropertyName = "QuantizationEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.BaseShapingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.QuantizationEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.QuantizationEventVariant2Type), TypeInfoPropertyName = "QuantizationEventVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EventsList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ShapingJobsList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.QuantizationJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ShapingJobType?), TypeInfoPropertyName = "NullableShapingJobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ShapingJobStatus?), TypeInfoPropertyName = "NullableShapingJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EventLevel?), TypeInfoPropertyName = "NullableEventLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.QuantizationJob?), TypeInfoPropertyName = "NullableQuantizationJob2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.QuantizationEvent?), TypeInfoPropertyName = "NullableQuantizationEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.QuantizationEventVariant2Type?), TypeInfoPropertyName = "NullableQuantizationEventVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.QuantizationEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.QuantizationJob>))]
    internal sealed partial class ShapingSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ShapingSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ShapingSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ShapingSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Together.JsonConverters.QuantizationJobJsonConverter());
            options.Converters.Add(new global::Together.JsonConverters.QuantizationEventJsonConverter());
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
                    typeToConvert == typeof(global::Together.ShapingJobType)

                    || typeToConvert == typeof(global::Together.ShapingJobType?)

                    || typeToConvert == typeof(global::Together.ShapingJobStatus)

                    || typeToConvert == typeof(global::Together.ShapingJobStatus?)

                    || typeToConvert == typeof(global::Together.EventLevel)

                    || typeToConvert == typeof(global::Together.EventLevel?)

                    || typeToConvert == typeof(global::Together.QuantizationEventVariant2Type)

                    || typeToConvert == typeof(global::Together.QuantizationEventVariant2Type?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Together.ShapingJobType))
                {
                    return new global::Together.JsonConverters.ShapingJobTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ShapingJobType?))
                {
                    return new global::Together.JsonConverters.ShapingJobTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ShapingJobStatus))
                {
                    return new global::Together.JsonConverters.ShapingJobStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ShapingJobStatus?))
                {
                    return new global::Together.JsonConverters.ShapingJobStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.EventLevel))
                {
                    return new global::Together.JsonConverters.EventLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.EventLevel?))
                {
                    return new global::Together.JsonConverters.EventLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.QuantizationEventVariant2Type))
                {
                    return new global::Together.JsonConverters.QuantizationEventVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.QuantizationEventVariant2Type?))
                {
                    return new global::Together.JsonConverters.QuantizationEventVariant2TypeNullableJsonConverter();
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
                    0 => new ShapingSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}