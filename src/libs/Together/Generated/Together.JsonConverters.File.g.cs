#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Together.JsonConverters
{
    /// <inheritdoc />
    public class FileJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Together.File>
    {
        /// <inheritdoc />
        public override global::Together.File Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::Together.AudioFileBinary? audioBinary = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.AudioFileBinary), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.AudioFileBinary> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.AudioFileBinary).Name}");
                audioBinary = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Together.AudioFileUrl? audioUrl = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.AudioFileUrl), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.AudioFileUrl> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.AudioFileUrl).Name}");
                audioUrl = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::Together.File(
                audioBinary,
                audioUrl
                );

            if (audioBinary != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.AudioFileBinary), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.AudioFileBinary> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.AudioFileBinary).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (audioUrl != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.AudioFileUrl), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.AudioFileUrl> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.AudioFileUrl).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Together.File value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAudioBinary)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.AudioFileBinary), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.AudioFileBinary?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.AudioFileBinary).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AudioBinary, typeInfo);
            }
            else if (value.IsAudioUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.AudioFileUrl), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.AudioFileUrl?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.AudioFileUrl).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AudioUrl, typeInfo);
            }
        }
    }
}