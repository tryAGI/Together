#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Together.JsonConverters
{
    /// <inheritdoc />
    public class DataItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Together.DataItem>
    {
        /// <inheritdoc />
        public override global::Together.DataItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::Together.ImageResponseDataB64? b64Json = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ImageResponseDataB64), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ImageResponseDataB64> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ImageResponseDataB64).Name}");
                b64Json = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Together.ImageResponseDataUrl? url = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ImageResponseDataUrl), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ImageResponseDataUrl> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ImageResponseDataUrl).Name}");
                url = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::Together.DataItem(
                b64Json,
                url
                );

            if (b64Json != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ImageResponseDataB64), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ImageResponseDataB64> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ImageResponseDataB64).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (url != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ImageResponseDataUrl), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ImageResponseDataUrl> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ImageResponseDataUrl).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Together.DataItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsB64Json)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ImageResponseDataB64), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ImageResponseDataB64?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ImageResponseDataB64).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.B64Json, typeInfo);
            }
            else if (value.IsUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ImageResponseDataUrl), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ImageResponseDataUrl?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ImageResponseDataUrl).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Url, typeInfo);
            }
        }
    }
}