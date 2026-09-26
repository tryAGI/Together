
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.UsageData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ErrorDataError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FinishReason), TypeInfoPropertyName = "FinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.LogprobsPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.PromptPartItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.PromptPartItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.CompletionChoicesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CompletionChoicesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AnyOf<global::Together.CompletionRequestModel?, string>), TypeInfoPropertyName = "AnyOfCompletionRequestModelString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CompletionRequestModel), TypeInfoPropertyName = "CompletionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AnyOf<global::Together.CompletionRequestSafetyModel?, string>), TypeInfoPropertyName = "AnyOfCompletionRequestSafetyModelString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CompletionRequestSafetyModel), TypeInfoPropertyName = "CompletionRequestSafetyModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CompletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CompletionStream), TypeInfoPropertyName = "CompletionStream2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CompletionEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.StreamSentinel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CompletionChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CompletionToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.CompletionChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CompletionChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AllOf<global::Together.UsageData, object>), TypeInfoPropertyName = "AllOfUsageDataObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AllOf<global::Together.FinishReason?, object>), TypeInfoPropertyName = "AllOfFinishReasonObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CompletionChoiceDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CompletionChoiceDeltaRole), TypeInfoPropertyName = "CompletionChoiceDeltaRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.ToolChoice2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ToolChoice2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CompletionChoiceDeltaFunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.StreamSentinelData), TypeInfoPropertyName = "StreamSentinelData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ToolChoiceType), TypeInfoPropertyName = "ToolChoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ToolChoiceFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FinishReason?), TypeInfoPropertyName = "NullableFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AnyOf<global::Together.CompletionRequestModel?, string>?), TypeInfoPropertyName = "NullableAnyOfCompletionRequestModelString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CompletionRequestModel?), TypeInfoPropertyName = "NullableCompletionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AnyOf<global::Together.CompletionRequestSafetyModel?, string>?), TypeInfoPropertyName = "NullableAnyOfCompletionRequestSafetyModelString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CompletionRequestSafetyModel?), TypeInfoPropertyName = "NullableCompletionRequestSafetyModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CompletionStream?), TypeInfoPropertyName = "NullableCompletionStream2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AllOf<global::Together.UsageData, object>?), TypeInfoPropertyName = "NullableAllOfUsageDataObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AllOf<global::Together.FinishReason?, object>?), TypeInfoPropertyName = "NullableAllOfFinishReasonObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CompletionChoiceDeltaRole?), TypeInfoPropertyName = "NullableCompletionChoiceDeltaRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.StreamSentinelData?), TypeInfoPropertyName = "NullableStreamSentinelData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ToolChoiceType?), TypeInfoPropertyName = "NullableToolChoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.PromptPartItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.CompletionChoicesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.CompletionChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.ToolChoice2>))]
    internal sealed partial class CompletionSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CompletionSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static CompletionSourceGenerationContext Default { get; } = new(DefaultOptions);

        private CompletionSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Together.JsonConverters.CompletionStreamJsonConverter());
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
            options.Converters.Add(new global::Together.JsonConverters.AnyOfJsonConverter<global::Together.CompletionRequestModel?, string>());
            options.Converters.Add(new global::Together.JsonConverters.AnyOfJsonConverter<global::Together.CompletionRequestSafetyModel?, string>());
            options.Converters.Add(new global::Together.JsonConverters.AllOfJsonConverter<global::Together.UsageData, object>());
            options.Converters.Add(new global::Together.JsonConverters.AllOfJsonConverter<global::Together.FinishReason?, object>());
            options.Converters.Add(new global::Together.JsonConverters.AllOfJsonConverter<object, global::Together.LogprobsPart>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, global::Together.ToolChoice2>());
            options.Converters.Add(new global::Together.JsonConverters.AllOfJsonConverter<global::Together.UsageData, object>());
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
                    typeToConvert == typeof(global::Together.FinishReason)

                    || typeToConvert == typeof(global::Together.FinishReason?)

                    || typeToConvert == typeof(global::Together.CompletionRequestModel)

                    || typeToConvert == typeof(global::Together.CompletionRequestModel?)

                    || typeToConvert == typeof(global::Together.CompletionRequestSafetyModel)

                    || typeToConvert == typeof(global::Together.CompletionRequestSafetyModel?)

                    || typeToConvert == typeof(global::Together.CompletionChoiceDeltaRole)

                    || typeToConvert == typeof(global::Together.CompletionChoiceDeltaRole?)

                    || typeToConvert == typeof(global::Together.StreamSentinelData)

                    || typeToConvert == typeof(global::Together.StreamSentinelData?)

                    || typeToConvert == typeof(global::Together.ToolChoiceType)

                    || typeToConvert == typeof(global::Together.ToolChoiceType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Together.FinishReason))
                {
                    return new global::Together.JsonConverters.FinishReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FinishReason?))
                {
                    return new global::Together.JsonConverters.FinishReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CompletionRequestModel))
                {
                    return new global::Together.JsonConverters.CompletionRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CompletionRequestModel?))
                {
                    return new global::Together.JsonConverters.CompletionRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CompletionRequestSafetyModel))
                {
                    return new global::Together.JsonConverters.CompletionRequestSafetyModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CompletionRequestSafetyModel?))
                {
                    return new global::Together.JsonConverters.CompletionRequestSafetyModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CompletionChoiceDeltaRole))
                {
                    return new global::Together.JsonConverters.CompletionChoiceDeltaRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CompletionChoiceDeltaRole?))
                {
                    return new global::Together.JsonConverters.CompletionChoiceDeltaRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.StreamSentinelData))
                {
                    return new global::Together.JsonConverters.StreamSentinelDataJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.StreamSentinelData?))
                {
                    return new global::Together.JsonConverters.StreamSentinelDataNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ToolChoiceType))
                {
                    return new global::Together.JsonConverters.ToolChoiceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ToolChoiceType?))
                {
                    return new global::Together.JsonConverters.ToolChoiceTypeNullableJsonConverter();
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
                    0 => new CompletionSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}