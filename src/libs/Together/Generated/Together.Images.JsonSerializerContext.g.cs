
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DataItem), TypeInfoPropertyName = "DataItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ImageResponseDataB64))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ImageResponseDataUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ImageResponseDataItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ImageResponseDataItemDiscriminatorType), TypeInfoPropertyName = "ImageResponseDataItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ImageResponseDataB64Type), TypeInfoPropertyName = "ImageResponseDataB64Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ImageResponseDataUrlType), TypeInfoPropertyName = "ImageResponseDataUrlType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateImagesGenerationsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AnyOf<global::Together.CreateImagesGenerationsRequestModel?, string>), TypeInfoPropertyName = "AnyOfCreateImagesGenerationsRequestModelString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateImagesGenerationsRequestModel), TypeInfoPropertyName = "CreateImagesGenerationsRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateImagesGenerationsRequestResponseFormat), TypeInfoPropertyName = "CreateImagesGenerationsRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateImagesGenerationsRequestOutputFormat), TypeInfoPropertyName = "CreateImagesGenerationsRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.CreateImagesGenerationsRequestImageLora>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateImagesGenerationsRequestImageLora))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DataItem?), TypeInfoPropertyName = "NullableDataItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ImageResponseDataItemDiscriminatorType?), TypeInfoPropertyName = "NullableImageResponseDataItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ImageResponseDataB64Type?), TypeInfoPropertyName = "NullableImageResponseDataB64Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ImageResponseDataUrlType?), TypeInfoPropertyName = "NullableImageResponseDataUrlType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AnyOf<global::Together.CreateImagesGenerationsRequestModel?, string>?), TypeInfoPropertyName = "NullableAnyOfCreateImagesGenerationsRequestModelString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateImagesGenerationsRequestModel?), TypeInfoPropertyName = "NullableCreateImagesGenerationsRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateImagesGenerationsRequestResponseFormat?), TypeInfoPropertyName = "NullableCreateImagesGenerationsRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateImagesGenerationsRequestOutputFormat?), TypeInfoPropertyName = "NullableCreateImagesGenerationsRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.CreateImagesGenerationsRequestImageLora>))]
    internal sealed partial class ImagesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ImagesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ImagesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ImagesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Together.JsonConverters.DataItemJsonConverter());
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
            options.Converters.Add(new global::Together.JsonConverters.AnyOfJsonConverter<global::Together.CreateImagesGenerationsRequestModel?, string>());
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
                    typeToConvert == typeof(global::Together.ImageResponseDataItemDiscriminatorType)

                    || typeToConvert == typeof(global::Together.ImageResponseDataItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Together.ImageResponseDataB64Type)

                    || typeToConvert == typeof(global::Together.ImageResponseDataB64Type?)

                    || typeToConvert == typeof(global::Together.ImageResponseDataUrlType)

                    || typeToConvert == typeof(global::Together.ImageResponseDataUrlType?)

                    || typeToConvert == typeof(global::Together.CreateImagesGenerationsRequestModel)

                    || typeToConvert == typeof(global::Together.CreateImagesGenerationsRequestModel?)

                    || typeToConvert == typeof(global::Together.CreateImagesGenerationsRequestResponseFormat)

                    || typeToConvert == typeof(global::Together.CreateImagesGenerationsRequestResponseFormat?)

                    || typeToConvert == typeof(global::Together.CreateImagesGenerationsRequestOutputFormat)

                    || typeToConvert == typeof(global::Together.CreateImagesGenerationsRequestOutputFormat?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Together.ImageResponseDataItemDiscriminatorType))
                {
                    return new global::Together.JsonConverters.ImageResponseDataItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ImageResponseDataItemDiscriminatorType?))
                {
                    return new global::Together.JsonConverters.ImageResponseDataItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ImageResponseDataB64Type))
                {
                    return new global::Together.JsonConverters.ImageResponseDataB64TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ImageResponseDataB64Type?))
                {
                    return new global::Together.JsonConverters.ImageResponseDataB64TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ImageResponseDataUrlType))
                {
                    return new global::Together.JsonConverters.ImageResponseDataUrlTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ImageResponseDataUrlType?))
                {
                    return new global::Together.JsonConverters.ImageResponseDataUrlTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CreateImagesGenerationsRequestModel))
                {
                    return new global::Together.JsonConverters.CreateImagesGenerationsRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CreateImagesGenerationsRequestModel?))
                {
                    return new global::Together.JsonConverters.CreateImagesGenerationsRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CreateImagesGenerationsRequestResponseFormat))
                {
                    return new global::Together.JsonConverters.CreateImagesGenerationsRequestResponseFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CreateImagesGenerationsRequestResponseFormat?))
                {
                    return new global::Together.JsonConverters.CreateImagesGenerationsRequestResponseFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CreateImagesGenerationsRequestOutputFormat))
                {
                    return new global::Together.JsonConverters.CreateImagesGenerationsRequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CreateImagesGenerationsRequestOutputFormat?))
                {
                    return new global::Together.JsonConverters.CreateImagesGenerationsRequestOutputFormatNullableJsonConverter();
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
                    0 => new ImagesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}