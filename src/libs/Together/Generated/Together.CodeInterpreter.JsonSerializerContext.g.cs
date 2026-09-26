
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.ExecuteRequestFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteRequestFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteRequestFileEncoding), TypeInfoPropertyName = "ExecuteRequestFileEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteRequestLanguage), TypeInfoPropertyName = "ExecuteRequestLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteResponse), TypeInfoPropertyName = "ExecuteResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteResponseSuccessfulExecution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteResponseSuccessfulExecutionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.OutputsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OutputsItem), TypeInfoPropertyName = "OutputsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputStreamOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputStreamOutputType), TypeInfoPropertyName = "ExecuteResponseSuccessfulExecutionDataOutputStreamOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputErrorOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputErrorOutputType), TypeInfoPropertyName = "ExecuteResponseSuccessfulExecutionDataOutputErrorOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutputData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutputType), TypeInfoPropertyName = "ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputDiscriminatorType), TypeInfoPropertyName = "ExecuteResponseSuccessfulExecutionDataOutputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteResponseSuccessfulExecutionDataStatus), TypeInfoPropertyName = "ExecuteResponseSuccessfulExecutionDataStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteResponseFailedExecution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.OneOf<string, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<string, object>), TypeInfoPropertyName = "OneOfStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.SessionListResponse), TypeInfoPropertyName = "SessionListResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.SessionListResponseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.SessionListResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.SessionListResponseVariant2Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.SessionListResponseVariant2DataSession>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.SessionListResponseVariant2DataSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteRequestFileEncoding?), TypeInfoPropertyName = "NullableExecuteRequestFileEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteRequestLanguage?), TypeInfoPropertyName = "NullableExecuteRequestLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteResponse?), TypeInfoPropertyName = "NullableExecuteResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OutputsItem?), TypeInfoPropertyName = "NullableOutputsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputStreamOutputType?), TypeInfoPropertyName = "NullableExecuteResponseSuccessfulExecutionDataOutputStreamOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputErrorOutputType?), TypeInfoPropertyName = "NullableExecuteResponseSuccessfulExecutionDataOutputErrorOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutputType?), TypeInfoPropertyName = "NullableExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputDiscriminatorType?), TypeInfoPropertyName = "NullableExecuteResponseSuccessfulExecutionDataOutputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteResponseSuccessfulExecutionDataStatus?), TypeInfoPropertyName = "NullableExecuteResponseSuccessfulExecutionDataStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<string, object>?), TypeInfoPropertyName = "NullableOneOfStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.SessionListResponse?), TypeInfoPropertyName = "NullableSessionListResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.ExecuteRequestFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.OutputsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.OneOf<string, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.SessionListResponseVariant2DataSession>))]
    internal sealed partial class CodeInterpreterSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CodeInterpreterSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static CodeInterpreterSourceGenerationContext Default { get; } = new(DefaultOptions);

        private CodeInterpreterSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Together.JsonConverters.ExecuteResponseJsonConverter());
            options.Converters.Add(new global::Together.JsonConverters.OutputsItemJsonConverter());
            options.Converters.Add(new global::Together.JsonConverters.SessionListResponseJsonConverter());
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
                    typeToConvert == typeof(global::Together.ExecuteRequestFileEncoding)

                    || typeToConvert == typeof(global::Together.ExecuteRequestFileEncoding?)

                    || typeToConvert == typeof(global::Together.ExecuteRequestLanguage)

                    || typeToConvert == typeof(global::Together.ExecuteRequestLanguage?)

                    || typeToConvert == typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputStreamOutputType)

                    || typeToConvert == typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputStreamOutputType?)

                    || typeToConvert == typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputErrorOutputType)

                    || typeToConvert == typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputErrorOutputType?)

                    || typeToConvert == typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutputType)

                    || typeToConvert == typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutputType?)

                    || typeToConvert == typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputDiscriminatorType)

                    || typeToConvert == typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputDiscriminatorType?)

                    || typeToConvert == typeof(global::Together.ExecuteResponseSuccessfulExecutionDataStatus)

                    || typeToConvert == typeof(global::Together.ExecuteResponseSuccessfulExecutionDataStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Together.ExecuteRequestFileEncoding))
                {
                    return new global::Together.JsonConverters.ExecuteRequestFileEncodingJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ExecuteRequestFileEncoding?))
                {
                    return new global::Together.JsonConverters.ExecuteRequestFileEncodingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ExecuteRequestLanguage))
                {
                    return new global::Together.JsonConverters.ExecuteRequestLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ExecuteRequestLanguage?))
                {
                    return new global::Together.JsonConverters.ExecuteRequestLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputStreamOutputType))
                {
                    return new global::Together.JsonConverters.ExecuteResponseSuccessfulExecutionDataOutputStreamOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputStreamOutputType?))
                {
                    return new global::Together.JsonConverters.ExecuteResponseSuccessfulExecutionDataOutputStreamOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputErrorOutputType))
                {
                    return new global::Together.JsonConverters.ExecuteResponseSuccessfulExecutionDataOutputErrorOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputErrorOutputType?))
                {
                    return new global::Together.JsonConverters.ExecuteResponseSuccessfulExecutionDataOutputErrorOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutputType))
                {
                    return new global::Together.JsonConverters.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutputType?))
                {
                    return new global::Together.JsonConverters.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputDiscriminatorType))
                {
                    return new global::Together.JsonConverters.ExecuteResponseSuccessfulExecutionDataOutputDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputDiscriminatorType?))
                {
                    return new global::Together.JsonConverters.ExecuteResponseSuccessfulExecutionDataOutputDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ExecuteResponseSuccessfulExecutionDataStatus))
                {
                    return new global::Together.JsonConverters.ExecuteResponseSuccessfulExecutionDataStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ExecuteResponseSuccessfulExecutionDataStatus?))
                {
                    return new global::Together.JsonConverters.ExecuteResponseSuccessfulExecutionDataStatusNullableJsonConverter();
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
                    0 => new CodeInterpreterSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}