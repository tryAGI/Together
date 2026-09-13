
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeCreateRemoteUploadSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeListFilesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeListFilesResponseFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeListFilesResponseFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeListRemoteUploadsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeRemoteUpload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRemoteUpload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeListRemoteUploadEventsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeRemoteUploadEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRemoteUploadEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeListModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeListRevisionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeListRevisionsResponseRevision>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeListRevisionsResponseRevision))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeUpdateModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeUpdateModelRequestVisibility), TypeInfoPropertyName = "DeUpdateModelRequestVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeCreateModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRemoteUploadStatus), TypeInfoPropertyName = "DeRemoteUploadStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeModelWeights))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeModelVisibility), TypeInfoPropertyName = "DeModelVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRemoteUploadEventLevel), TypeInfoPropertyName = "DeRemoteUploadEventLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeListRevisionsResponseRevisionValidationStatus), TypeInfoPropertyName = "DeListRevisionsResponseRevisionValidationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeRevisionValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRevisionValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeModelWeightsType), TypeInfoPropertyName = "DeModelWeightsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeModelWeightsSpeculatorMechanism), TypeInfoPropertyName = "DeModelWeightsSpeculatorMechanism2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeModelWeightsDraftSpeculatorType), TypeInfoPropertyName = "DeModelWeightsDraftSpeculatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeModelParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeModelDTypeCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeModelDTypeCount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ErrorDataError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.VolumeServiceListModelsVisibility), TypeInfoPropertyName = "VolumeServiceListModelsVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeUpdateModelRequestVisibility?), TypeInfoPropertyName = "NullableDeUpdateModelRequestVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRemoteUploadStatus?), TypeInfoPropertyName = "NullableDeRemoteUploadStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeModelVisibility?), TypeInfoPropertyName = "NullableDeModelVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRemoteUploadEventLevel?), TypeInfoPropertyName = "NullableDeRemoteUploadEventLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeListRevisionsResponseRevisionValidationStatus?), TypeInfoPropertyName = "NullableDeListRevisionsResponseRevisionValidationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeModelWeightsType?), TypeInfoPropertyName = "NullableDeModelWeightsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeModelWeightsSpeculatorMechanism?), TypeInfoPropertyName = "NullableDeModelWeightsSpeculatorMechanism2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeModelWeightsDraftSpeculatorType?), TypeInfoPropertyName = "NullableDeModelWeightsDraftSpeculatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.VolumeServiceListModelsVisibility?), TypeInfoPropertyName = "NullableVolumeServiceListModelsVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeListFilesResponseFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeRemoteUpload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeRemoteUploadEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeListRevisionsResponseRevision>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeRevisionValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeModelDTypeCount>))]
    internal sealed partial class VolumeServiceSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VolumeServiceSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static VolumeServiceSourceGenerationContext Default { get; } = new(DefaultOptions);

        private VolumeServiceSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Together.DeUpdateModelRequestVisibility)

                    || typeToConvert == typeof(global::Together.DeUpdateModelRequestVisibility?)

                    || typeToConvert == typeof(global::Together.DeRemoteUploadStatus)

                    || typeToConvert == typeof(global::Together.DeRemoteUploadStatus?)

                    || typeToConvert == typeof(global::Together.DeModelVisibility)

                    || typeToConvert == typeof(global::Together.DeModelVisibility?)

                    || typeToConvert == typeof(global::Together.DeRemoteUploadEventLevel)

                    || typeToConvert == typeof(global::Together.DeRemoteUploadEventLevel?)

                    || typeToConvert == typeof(global::Together.DeListRevisionsResponseRevisionValidationStatus)

                    || typeToConvert == typeof(global::Together.DeListRevisionsResponseRevisionValidationStatus?)

                    || typeToConvert == typeof(global::Together.DeModelWeightsType)

                    || typeToConvert == typeof(global::Together.DeModelWeightsType?)

                    || typeToConvert == typeof(global::Together.DeModelWeightsSpeculatorMechanism)

                    || typeToConvert == typeof(global::Together.DeModelWeightsSpeculatorMechanism?)

                    || typeToConvert == typeof(global::Together.DeModelWeightsDraftSpeculatorType)

                    || typeToConvert == typeof(global::Together.DeModelWeightsDraftSpeculatorType?)

                    || typeToConvert == typeof(global::Together.VolumeServiceListModelsVisibility)

                    || typeToConvert == typeof(global::Together.VolumeServiceListModelsVisibility?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Together.DeUpdateModelRequestVisibility))
                {
                    return new global::Together.JsonConverters.DeUpdateModelRequestVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeUpdateModelRequestVisibility?))
                {
                    return new global::Together.JsonConverters.DeUpdateModelRequestVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeRemoteUploadStatus))
                {
                    return new global::Together.JsonConverters.DeRemoteUploadStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeRemoteUploadStatus?))
                {
                    return new global::Together.JsonConverters.DeRemoteUploadStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeModelVisibility))
                {
                    return new global::Together.JsonConverters.DeModelVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeModelVisibility?))
                {
                    return new global::Together.JsonConverters.DeModelVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeRemoteUploadEventLevel))
                {
                    return new global::Together.JsonConverters.DeRemoteUploadEventLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeRemoteUploadEventLevel?))
                {
                    return new global::Together.JsonConverters.DeRemoteUploadEventLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeListRevisionsResponseRevisionValidationStatus))
                {
                    return new global::Together.JsonConverters.DeListRevisionsResponseRevisionValidationStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeListRevisionsResponseRevisionValidationStatus?))
                {
                    return new global::Together.JsonConverters.DeListRevisionsResponseRevisionValidationStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeModelWeightsType))
                {
                    return new global::Together.JsonConverters.DeModelWeightsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeModelWeightsType?))
                {
                    return new global::Together.JsonConverters.DeModelWeightsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeModelWeightsSpeculatorMechanism))
                {
                    return new global::Together.JsonConverters.DeModelWeightsSpeculatorMechanismJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeModelWeightsSpeculatorMechanism?))
                {
                    return new global::Together.JsonConverters.DeModelWeightsSpeculatorMechanismNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeModelWeightsDraftSpeculatorType))
                {
                    return new global::Together.JsonConverters.DeModelWeightsDraftSpeculatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeModelWeightsDraftSpeculatorType?))
                {
                    return new global::Together.JsonConverters.DeModelWeightsDraftSpeculatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.VolumeServiceListModelsVisibility))
                {
                    return new global::Together.JsonConverters.VolumeServiceListModelsVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.VolumeServiceListModelsVisibility?))
                {
                    return new global::Together.JsonConverters.VolumeServiceListModelsVisibilityNullableJsonConverter();
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
                    0 => new VolumeServiceSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}