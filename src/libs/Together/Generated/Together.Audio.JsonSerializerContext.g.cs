
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ErrorDataError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.StreamSentinel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioSpeechRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AnyOf<global::Together.AudioSpeechRequestModel?, string>), TypeInfoPropertyName = "AnyOfAudioSpeechRequestModelString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioSpeechRequestModel), TypeInfoPropertyName = "AudioSpeechRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioSpeechRequestResponseFormat), TypeInfoPropertyName = "AudioSpeechRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioSpeechRequestResponseEncoding), TypeInfoPropertyName = "AudioSpeechRequestResponseEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioSpeechRequestExtraParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranscriptionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<byte[], string>), TypeInfoPropertyName = "OneOfByteArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranscriptionRequestModel), TypeInfoPropertyName = "AudioTranscriptionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranscriptionRequestResponseFormat), TypeInfoPropertyName = "AudioTranscriptionRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.AudioTranscriptionRequestTimestampGranularities?, global::System.Collections.Generic.IList<global::Together.AudioTranscriptionRequestTimestampGranularitie>>), TypeInfoPropertyName = "OneOfAudioTranscriptionRequestTimestampGranularitiesIListAudioTranscriptionRequestTimestampGranularitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranscriptionRequestTimestampGranularities), TypeInfoPropertyName = "AudioTranscriptionRequestTimestampGranularities2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.AudioTranscriptionRequestTimestampGranularitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranscriptionRequestTimestampGranularitie), TypeInfoPropertyName = "AudioTranscriptionRequestTimestampGranularitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranscriptionResponse), TypeInfoPropertyName = "AudioTranscriptionResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranscriptionJsonResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranscriptionVerboseJsonResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.AudioTranscriptionSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranscriptionSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.AudioTranscriptionWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranscriptionWord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.AudioTranscriptionSpeakerSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranscriptionSpeakerSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranslationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranslationRequestModel), TypeInfoPropertyName = "AudioTranslationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranslationRequestResponseFormat), TypeInfoPropertyName = "AudioTranslationRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.AudioTranslationRequestTimestampGranularities?, global::System.Collections.Generic.IList<global::Together.AudioTranslationRequestTimestampGranularitie>>), TypeInfoPropertyName = "OneOfAudioTranslationRequestTimestampGranularitiesIListAudioTranslationRequestTimestampGranularitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranslationRequestTimestampGranularities), TypeInfoPropertyName = "AudioTranslationRequestTimestampGranularities2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.AudioTranslationRequestTimestampGranularitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranslationRequestTimestampGranularitie), TypeInfoPropertyName = "AudioTranslationRequestTimestampGranularitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranslationResponse), TypeInfoPropertyName = "AudioTranslationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranslationJsonResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranslationVerboseJsonResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioSpeechStreamResponse), TypeInfoPropertyName = "AudioSpeechStreamResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioSpeechStreamEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioSpeechStreamChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.StreamSentinelData), TypeInfoPropertyName = "StreamSentinelData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RealtimeTtsModel), TypeInfoPropertyName = "RealtimeTtsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RealtimeTranscriptionInputAudioFormat), TypeInfoPropertyName = "RealtimeTranscriptionInputAudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AnyOf<global::Together.AudioSpeechRequestModel?, string>?), TypeInfoPropertyName = "NullableAnyOfAudioSpeechRequestModelString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioSpeechRequestModel?), TypeInfoPropertyName = "NullableAudioSpeechRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioSpeechRequestResponseFormat?), TypeInfoPropertyName = "NullableAudioSpeechRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioSpeechRequestResponseEncoding?), TypeInfoPropertyName = "NullableAudioSpeechRequestResponseEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<byte[], string>?), TypeInfoPropertyName = "NullableOneOfByteArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranscriptionRequestModel?), TypeInfoPropertyName = "NullableAudioTranscriptionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranscriptionRequestResponseFormat?), TypeInfoPropertyName = "NullableAudioTranscriptionRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.AudioTranscriptionRequestTimestampGranularities?, global::System.Collections.Generic.IList<global::Together.AudioTranscriptionRequestTimestampGranularitie>>?), TypeInfoPropertyName = "NullableOneOfAudioTranscriptionRequestTimestampGranularitiesIListAudioTranscriptionRequestTimestampGranularitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranscriptionRequestTimestampGranularities?), TypeInfoPropertyName = "NullableAudioTranscriptionRequestTimestampGranularities2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranscriptionRequestTimestampGranularitie?), TypeInfoPropertyName = "NullableAudioTranscriptionRequestTimestampGranularitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranscriptionResponse?), TypeInfoPropertyName = "NullableAudioTranscriptionResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranslationRequestModel?), TypeInfoPropertyName = "NullableAudioTranslationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranslationRequestResponseFormat?), TypeInfoPropertyName = "NullableAudioTranslationRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.AudioTranslationRequestTimestampGranularities?, global::System.Collections.Generic.IList<global::Together.AudioTranslationRequestTimestampGranularitie>>?), TypeInfoPropertyName = "NullableOneOfAudioTranslationRequestTimestampGranularitiesIListAudioTranslationRequestTimestampGranularitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranslationRequestTimestampGranularities?), TypeInfoPropertyName = "NullableAudioTranslationRequestTimestampGranularities2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranslationRequestTimestampGranularitie?), TypeInfoPropertyName = "NullableAudioTranslationRequestTimestampGranularitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranslationResponse?), TypeInfoPropertyName = "NullableAudioTranslationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioSpeechStreamResponse?), TypeInfoPropertyName = "NullableAudioSpeechStreamResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.StreamSentinelData?), TypeInfoPropertyName = "NullableStreamSentinelData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RealtimeTtsModel?), TypeInfoPropertyName = "NullableRealtimeTtsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RealtimeTranscriptionInputAudioFormat?), TypeInfoPropertyName = "NullableRealtimeTranscriptionInputAudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.AudioTranscriptionRequestTimestampGranularities?, global::System.Collections.Generic.List<global::Together.AudioTranscriptionRequestTimestampGranularitie>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.AudioTranscriptionRequestTimestampGranularitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.AudioTranscriptionSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.AudioTranscriptionWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.AudioTranscriptionSpeakerSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.AudioTranslationRequestTimestampGranularities?, global::System.Collections.Generic.List<global::Together.AudioTranslationRequestTimestampGranularitie>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.AudioTranslationRequestTimestampGranularitie>))]
    internal sealed partial class AudioSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AudioSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AudioSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AudioSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Together.JsonConverters.AudioTranscriptionResponseJsonConverter());
            options.Converters.Add(new global::Together.JsonConverters.AudioTranslationResponseJsonConverter());
            options.Converters.Add(new global::Together.JsonConverters.AudioSpeechStreamResponseJsonConverter());
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
            options.Converters.Add(new global::Together.JsonConverters.AnyOfJsonConverter<global::Together.AudioSpeechRequestModel?, string>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<byte[], string>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::Together.AudioTranscriptionRequestTimestampGranularities?, global::System.Collections.Generic.IList<global::Together.AudioTranscriptionRequestTimestampGranularitie>>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<byte[], string>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::Together.AudioTranslationRequestTimestampGranularities?, global::System.Collections.Generic.IList<global::Together.AudioTranslationRequestTimestampGranularitie>>());
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
                    typeToConvert == typeof(global::Together.AudioSpeechRequestModel)

                    || typeToConvert == typeof(global::Together.AudioSpeechRequestModel?)

                    || typeToConvert == typeof(global::Together.AudioSpeechRequestResponseFormat)

                    || typeToConvert == typeof(global::Together.AudioSpeechRequestResponseFormat?)

                    || typeToConvert == typeof(global::Together.AudioSpeechRequestResponseEncoding)

                    || typeToConvert == typeof(global::Together.AudioSpeechRequestResponseEncoding?)

                    || typeToConvert == typeof(global::Together.AudioTranscriptionRequestModel)

                    || typeToConvert == typeof(global::Together.AudioTranscriptionRequestModel?)

                    || typeToConvert == typeof(global::Together.AudioTranscriptionRequestResponseFormat)

                    || typeToConvert == typeof(global::Together.AudioTranscriptionRequestResponseFormat?)

                    || typeToConvert == typeof(global::Together.AudioTranscriptionRequestTimestampGranularities)

                    || typeToConvert == typeof(global::Together.AudioTranscriptionRequestTimestampGranularities?)

                    || typeToConvert == typeof(global::Together.AudioTranscriptionRequestTimestampGranularitie)

                    || typeToConvert == typeof(global::Together.AudioTranscriptionRequestTimestampGranularitie?)

                    || typeToConvert == typeof(global::Together.AudioTranslationRequestModel)

                    || typeToConvert == typeof(global::Together.AudioTranslationRequestModel?)

                    || typeToConvert == typeof(global::Together.AudioTranslationRequestResponseFormat)

                    || typeToConvert == typeof(global::Together.AudioTranslationRequestResponseFormat?)

                    || typeToConvert == typeof(global::Together.AudioTranslationRequestTimestampGranularities)

                    || typeToConvert == typeof(global::Together.AudioTranslationRequestTimestampGranularities?)

                    || typeToConvert == typeof(global::Together.AudioTranslationRequestTimestampGranularitie)

                    || typeToConvert == typeof(global::Together.AudioTranslationRequestTimestampGranularitie?)

                    || typeToConvert == typeof(global::Together.StreamSentinelData)

                    || typeToConvert == typeof(global::Together.StreamSentinelData?)

                    || typeToConvert == typeof(global::Together.RealtimeTtsModel)

                    || typeToConvert == typeof(global::Together.RealtimeTtsModel?)

                    || typeToConvert == typeof(global::Together.RealtimeTranscriptionInputAudioFormat)

                    || typeToConvert == typeof(global::Together.RealtimeTranscriptionInputAudioFormat?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Together.AudioSpeechRequestModel))
                {
                    return new global::Together.JsonConverters.AudioSpeechRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AudioSpeechRequestModel?))
                {
                    return new global::Together.JsonConverters.AudioSpeechRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AudioSpeechRequestResponseFormat))
                {
                    return new global::Together.JsonConverters.AudioSpeechRequestResponseFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AudioSpeechRequestResponseFormat?))
                {
                    return new global::Together.JsonConverters.AudioSpeechRequestResponseFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AudioSpeechRequestResponseEncoding))
                {
                    return new global::Together.JsonConverters.AudioSpeechRequestResponseEncodingJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AudioSpeechRequestResponseEncoding?))
                {
                    return new global::Together.JsonConverters.AudioSpeechRequestResponseEncodingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AudioTranscriptionRequestModel))
                {
                    return new global::Together.JsonConverters.AudioTranscriptionRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AudioTranscriptionRequestModel?))
                {
                    return new global::Together.JsonConverters.AudioTranscriptionRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AudioTranscriptionRequestResponseFormat))
                {
                    return new global::Together.JsonConverters.AudioTranscriptionRequestResponseFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AudioTranscriptionRequestResponseFormat?))
                {
                    return new global::Together.JsonConverters.AudioTranscriptionRequestResponseFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AudioTranscriptionRequestTimestampGranularities))
                {
                    return new global::Together.JsonConverters.AudioTranscriptionRequestTimestampGranularitiesJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AudioTranscriptionRequestTimestampGranularities?))
                {
                    return new global::Together.JsonConverters.AudioTranscriptionRequestTimestampGranularitiesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AudioTranscriptionRequestTimestampGranularitie))
                {
                    return new global::Together.JsonConverters.AudioTranscriptionRequestTimestampGranularitieJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AudioTranscriptionRequestTimestampGranularitie?))
                {
                    return new global::Together.JsonConverters.AudioTranscriptionRequestTimestampGranularitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AudioTranslationRequestModel))
                {
                    return new global::Together.JsonConverters.AudioTranslationRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AudioTranslationRequestModel?))
                {
                    return new global::Together.JsonConverters.AudioTranslationRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AudioTranslationRequestResponseFormat))
                {
                    return new global::Together.JsonConverters.AudioTranslationRequestResponseFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AudioTranslationRequestResponseFormat?))
                {
                    return new global::Together.JsonConverters.AudioTranslationRequestResponseFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AudioTranslationRequestTimestampGranularities))
                {
                    return new global::Together.JsonConverters.AudioTranslationRequestTimestampGranularitiesJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AudioTranslationRequestTimestampGranularities?))
                {
                    return new global::Together.JsonConverters.AudioTranslationRequestTimestampGranularitiesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AudioTranslationRequestTimestampGranularitie))
                {
                    return new global::Together.JsonConverters.AudioTranslationRequestTimestampGranularitieJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AudioTranslationRequestTimestampGranularitie?))
                {
                    return new global::Together.JsonConverters.AudioTranslationRequestTimestampGranularitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.StreamSentinelData))
                {
                    return new global::Together.JsonConverters.StreamSentinelDataJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.StreamSentinelData?))
                {
                    return new global::Together.JsonConverters.StreamSentinelDataNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RealtimeTtsModel))
                {
                    return new global::Together.JsonConverters.RealtimeTtsModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RealtimeTtsModel?))
                {
                    return new global::Together.JsonConverters.RealtimeTtsModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RealtimeTranscriptionInputAudioFormat))
                {
                    return new global::Together.JsonConverters.RealtimeTranscriptionInputAudioFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RealtimeTranscriptionInputAudioFormat?))
                {
                    return new global::Together.JsonConverters.RealtimeTranscriptionInputAudioFormatNullableJsonConverter();
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
                    0 => new AudioSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}