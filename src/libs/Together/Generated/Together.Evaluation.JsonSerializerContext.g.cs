
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ErrorDataError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationTypedRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationTypedRequestType), TypeInfoPropertyName = "EvaluationTypedRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.EvaluationClassifyParameters, global::Together.EvaluationScoreParameters, global::Together.EvaluationCompareParameters>), TypeInfoPropertyName = "OneOfEvaluationClassifyParametersEvaluationScoreParametersEvaluationCompareParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationClassifyParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationScoreParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationCompareParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationJudgeModelConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationModelOrString), TypeInfoPropertyName = "EvaluationModelOrString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.EvaluationModelRequest, string>), TypeInfoPropertyName = "OneOfEvaluationModelRequestString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationJudgeModelConfigModelSource), TypeInfoPropertyName = "EvaluationJudgeModelConfigModelSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationModelRequestModelSource), TypeInfoPropertyName = "EvaluationModelRequestModelSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationResponseStatus), TypeInfoPropertyName = "EvaluationResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationJobType), TypeInfoPropertyName = "EvaluationJobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationJobStatus), TypeInfoPropertyName = "EvaluationJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.EvaluationJobStatusUpdate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationJobStatusUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.EvaluationClassifyResults, global::Together.EvaluationScoreResults, global::Together.EvaluationCompareResults, global::Together.EvaluationJobResults>), TypeInfoPropertyName = "OneOfEvaluationClassifyResultsEvaluationScoreResultsEvaluationCompareResultsEvaluationJobResults2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationClassifyResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationScoreResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationCompareResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationJobResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationScoreResultsAggregatedScores))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.EvaluationJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GetModelListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GetEvaluationJobStatusAndResultsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GetEvaluationJobStatusAndResultsResponseStatus), TypeInfoPropertyName = "GetEvaluationJobStatusAndResultsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.EvaluationClassifyResults, global::Together.EvaluationScoreResults, global::Together.EvaluationCompareResults>), TypeInfoPropertyName = "OneOfEvaluationClassifyResultsEvaluationScoreResultsEvaluationCompareResults2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationTypedRequestType?), TypeInfoPropertyName = "NullableEvaluationTypedRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.EvaluationClassifyParameters, global::Together.EvaluationScoreParameters, global::Together.EvaluationCompareParameters>?), TypeInfoPropertyName = "NullableOneOfEvaluationClassifyParametersEvaluationScoreParametersEvaluationCompareParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationModelOrString?), TypeInfoPropertyName = "NullableEvaluationModelOrString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.EvaluationModelRequest, string>?), TypeInfoPropertyName = "NullableOneOfEvaluationModelRequestString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationJudgeModelConfigModelSource?), TypeInfoPropertyName = "NullableEvaluationJudgeModelConfigModelSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationModelRequestModelSource?), TypeInfoPropertyName = "NullableEvaluationModelRequestModelSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationResponseStatus?), TypeInfoPropertyName = "NullableEvaluationResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationJobType?), TypeInfoPropertyName = "NullableEvaluationJobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationJobStatus?), TypeInfoPropertyName = "NullableEvaluationJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.EvaluationClassifyResults, global::Together.EvaluationScoreResults, global::Together.EvaluationCompareResults, global::Together.EvaluationJobResults>?), TypeInfoPropertyName = "NullableOneOfEvaluationClassifyResultsEvaluationScoreResultsEvaluationCompareResultsEvaluationJobResults2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GetEvaluationJobStatusAndResultsResponseStatus?), TypeInfoPropertyName = "NullableGetEvaluationJobStatusAndResultsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.EvaluationClassifyResults, global::Together.EvaluationScoreResults, global::Together.EvaluationCompareResults>?), TypeInfoPropertyName = "NullableOneOfEvaluationClassifyResultsEvaluationScoreResultsEvaluationCompareResults2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.EvaluationJobStatusUpdate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.EvaluationJob>))]
    internal sealed partial class EvaluationSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EvaluationSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static EvaluationSourceGenerationContext Default { get; } = new(DefaultOptions);

        private EvaluationSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Together.JsonConverters.EvaluationModelOrStringJsonConverter());
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
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::Together.EvaluationClassifyParameters, global::Together.EvaluationScoreParameters, global::Together.EvaluationCompareParameters>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::Together.EvaluationModelRequest, string>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::Together.EvaluationModelRequest, string>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::Together.EvaluationClassifyResults, global::Together.EvaluationScoreResults, global::Together.EvaluationCompareResults, global::Together.EvaluationJobResults>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::Together.EvaluationClassifyResults, global::Together.EvaluationScoreResults, global::Together.EvaluationCompareResults>());
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
                    typeToConvert == typeof(global::Together.EvaluationTypedRequestType)

                    || typeToConvert == typeof(global::Together.EvaluationTypedRequestType?)

                    || typeToConvert == typeof(global::Together.EvaluationJudgeModelConfigModelSource)

                    || typeToConvert == typeof(global::Together.EvaluationJudgeModelConfigModelSource?)

                    || typeToConvert == typeof(global::Together.EvaluationModelRequestModelSource)

                    || typeToConvert == typeof(global::Together.EvaluationModelRequestModelSource?)

                    || typeToConvert == typeof(global::Together.EvaluationResponseStatus)

                    || typeToConvert == typeof(global::Together.EvaluationResponseStatus?)

                    || typeToConvert == typeof(global::Together.EvaluationJobType)

                    || typeToConvert == typeof(global::Together.EvaluationJobType?)

                    || typeToConvert == typeof(global::Together.EvaluationJobStatus)

                    || typeToConvert == typeof(global::Together.EvaluationJobStatus?)

                    || typeToConvert == typeof(global::Together.GetEvaluationJobStatusAndResultsResponseStatus)

                    || typeToConvert == typeof(global::Together.GetEvaluationJobStatusAndResultsResponseStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Together.EvaluationTypedRequestType))
                {
                    return new global::Together.JsonConverters.EvaluationTypedRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.EvaluationTypedRequestType?))
                {
                    return new global::Together.JsonConverters.EvaluationTypedRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.EvaluationJudgeModelConfigModelSource))
                {
                    return new global::Together.JsonConverters.EvaluationJudgeModelConfigModelSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.EvaluationJudgeModelConfigModelSource?))
                {
                    return new global::Together.JsonConverters.EvaluationJudgeModelConfigModelSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.EvaluationModelRequestModelSource))
                {
                    return new global::Together.JsonConverters.EvaluationModelRequestModelSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.EvaluationModelRequestModelSource?))
                {
                    return new global::Together.JsonConverters.EvaluationModelRequestModelSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.EvaluationResponseStatus))
                {
                    return new global::Together.JsonConverters.EvaluationResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.EvaluationResponseStatus?))
                {
                    return new global::Together.JsonConverters.EvaluationResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.EvaluationJobType))
                {
                    return new global::Together.JsonConverters.EvaluationJobTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.EvaluationJobType?))
                {
                    return new global::Together.JsonConverters.EvaluationJobTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.EvaluationJobStatus))
                {
                    return new global::Together.JsonConverters.EvaluationJobStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.EvaluationJobStatus?))
                {
                    return new global::Together.JsonConverters.EvaluationJobStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.GetEvaluationJobStatusAndResultsResponseStatus))
                {
                    return new global::Together.JsonConverters.GetEvaluationJobStatusAndResultsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.GetEvaluationJobStatusAndResultsResponseStatus?))
                {
                    return new global::Together.JsonConverters.GetEvaluationJobStatusAndResultsResponseStatusNullableJsonConverter();
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
                    0 => new EvaluationSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}