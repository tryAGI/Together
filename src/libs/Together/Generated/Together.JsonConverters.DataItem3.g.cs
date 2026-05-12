#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Together.JsonConverters
{
    /// <inheritdoc />
    public class DataItem3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Together.DataItem3>
    {
        /// <inheritdoc />
        public override global::Together.DataItem3 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ImageResponseDataItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ImageResponseDataItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Together.ImageResponseDataItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Together.ImageResponseDataB64? b64Json = default;
            if (discriminator?.Type == global::Together.ImageResponseDataItemDiscriminatorType.B64Json)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ImageResponseDataB64), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ImageResponseDataB64> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Together.ImageResponseDataB64)}");
                b64Json = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Together.ImageResponseDataUrl? url = default;
            if (discriminator?.Type == global::Together.ImageResponseDataItemDiscriminatorType.Url)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ImageResponseDataUrl), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ImageResponseDataUrl> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Together.ImageResponseDataUrl)}");
                url = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Together.DataItem3(
                discriminator?.Type,
                b64Json,

                url
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Together.DataItem3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsB64Json)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ImageResponseDataB64), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ImageResponseDataB64?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ImageResponseDataB64).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.B64Json!, typeInfo);
            }
            else if (value.IsUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ImageResponseDataUrl), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ImageResponseDataUrl?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ImageResponseDataUrl).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Url!, typeInfo);
            }
        }
    }
}