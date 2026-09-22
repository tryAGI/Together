
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeListSupportedModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeSupportedModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeSupportedModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeSupportedModelDeploymentProfile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeSupportedModelPerformanceBenchmarks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeSupportedModelPricing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeSupportedModelInputModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeSupportedModelInputModalitie), TypeInfoPropertyName = "DeSupportedModelInputModalitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeSupportedModelOutputModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeSupportedModelOutputModalitie), TypeInfoPropertyName = "DeSupportedModelOutputModalitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeSupportedModelProduct>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeSupportedModelProduct), TypeInfoPropertyName = "DeSupportedModelProduct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeSupportedModelFeature>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeSupportedModelFeature), TypeInfoPropertyName = "DeSupportedModelFeature2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeSupportedModelCapabilitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeSupportedModelCapabilitie), TypeInfoPropertyName = "DeSupportedModelCapabilitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeSupportedModelStatus), TypeInfoPropertyName = "DeSupportedModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeSupportedModelDeploymentProfile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ErrorDataError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.SupportedModelsServiceListSupportedModelsModality), TypeInfoPropertyName = "SupportedModelsServiceListSupportedModelsModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.SupportedModelsServiceListSupportedModelsProduct), TypeInfoPropertyName = "SupportedModelsServiceListSupportedModelsProduct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeSupportedModelInputModalitie?), TypeInfoPropertyName = "NullableDeSupportedModelInputModalitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeSupportedModelOutputModalitie?), TypeInfoPropertyName = "NullableDeSupportedModelOutputModalitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeSupportedModelProduct?), TypeInfoPropertyName = "NullableDeSupportedModelProduct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeSupportedModelFeature?), TypeInfoPropertyName = "NullableDeSupportedModelFeature2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeSupportedModelCapabilitie?), TypeInfoPropertyName = "NullableDeSupportedModelCapabilitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeSupportedModelStatus?), TypeInfoPropertyName = "NullableDeSupportedModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.SupportedModelsServiceListSupportedModelsModality?), TypeInfoPropertyName = "NullableSupportedModelsServiceListSupportedModelsModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.SupportedModelsServiceListSupportedModelsProduct?), TypeInfoPropertyName = "NullableSupportedModelsServiceListSupportedModelsProduct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeSupportedModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeSupportedModelInputModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeSupportedModelOutputModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeSupportedModelProduct>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeSupportedModelFeature>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeSupportedModelCapabilitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeSupportedModelDeploymentProfile>))]
    internal sealed partial class SupportedModelsServiceSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SupportedModelsServiceSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SupportedModelsServiceSourceGenerationContext Default { get; } = new(DefaultOptions);

        private SupportedModelsServiceSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Together.DeSupportedModelInputModalitie)

                    || typeToConvert == typeof(global::Together.DeSupportedModelInputModalitie?)

                    || typeToConvert == typeof(global::Together.DeSupportedModelOutputModalitie)

                    || typeToConvert == typeof(global::Together.DeSupportedModelOutputModalitie?)

                    || typeToConvert == typeof(global::Together.DeSupportedModelProduct)

                    || typeToConvert == typeof(global::Together.DeSupportedModelProduct?)

                    || typeToConvert == typeof(global::Together.DeSupportedModelFeature)

                    || typeToConvert == typeof(global::Together.DeSupportedModelFeature?)

                    || typeToConvert == typeof(global::Together.DeSupportedModelCapabilitie)

                    || typeToConvert == typeof(global::Together.DeSupportedModelCapabilitie?)

                    || typeToConvert == typeof(global::Together.DeSupportedModelStatus)

                    || typeToConvert == typeof(global::Together.DeSupportedModelStatus?)

                    || typeToConvert == typeof(global::Together.SupportedModelsServiceListSupportedModelsModality)

                    || typeToConvert == typeof(global::Together.SupportedModelsServiceListSupportedModelsModality?)

                    || typeToConvert == typeof(global::Together.SupportedModelsServiceListSupportedModelsProduct)

                    || typeToConvert == typeof(global::Together.SupportedModelsServiceListSupportedModelsProduct?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Together.DeSupportedModelInputModalitie))
                {
                    return new global::Together.JsonConverters.DeSupportedModelInputModalitieJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeSupportedModelInputModalitie?))
                {
                    return new global::Together.JsonConverters.DeSupportedModelInputModalitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeSupportedModelOutputModalitie))
                {
                    return new global::Together.JsonConverters.DeSupportedModelOutputModalitieJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeSupportedModelOutputModalitie?))
                {
                    return new global::Together.JsonConverters.DeSupportedModelOutputModalitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeSupportedModelProduct))
                {
                    return new global::Together.JsonConverters.DeSupportedModelProductJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeSupportedModelProduct?))
                {
                    return new global::Together.JsonConverters.DeSupportedModelProductNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeSupportedModelFeature))
                {
                    return new global::Together.JsonConverters.DeSupportedModelFeatureJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeSupportedModelFeature?))
                {
                    return new global::Together.JsonConverters.DeSupportedModelFeatureNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeSupportedModelCapabilitie))
                {
                    return new global::Together.JsonConverters.DeSupportedModelCapabilitieJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeSupportedModelCapabilitie?))
                {
                    return new global::Together.JsonConverters.DeSupportedModelCapabilitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeSupportedModelStatus))
                {
                    return new global::Together.JsonConverters.DeSupportedModelStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeSupportedModelStatus?))
                {
                    return new global::Together.JsonConverters.DeSupportedModelStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.SupportedModelsServiceListSupportedModelsModality))
                {
                    return new global::Together.JsonConverters.SupportedModelsServiceListSupportedModelsModalityJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.SupportedModelsServiceListSupportedModelsModality?))
                {
                    return new global::Together.JsonConverters.SupportedModelsServiceListSupportedModelsModalityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.SupportedModelsServiceListSupportedModelsProduct))
                {
                    return new global::Together.JsonConverters.SupportedModelsServiceListSupportedModelsProductJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.SupportedModelsServiceListSupportedModelsProduct?))
                {
                    return new global::Together.JsonConverters.SupportedModelsServiceListSupportedModelsProductNullableJsonConverter();
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
                    0 => new SupportedModelsServiceSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}