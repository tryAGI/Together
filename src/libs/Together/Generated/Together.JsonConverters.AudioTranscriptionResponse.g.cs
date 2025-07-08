#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Together.JsonConverters
{
    /// <inheritdoc />
    public class AudioTranscriptionResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Together.AudioTranscriptionResponse>
    {
        /// <inheritdoc />
        public override global::Together.AudioTranscriptionResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::Together.AudioTranscriptionJsonResponse? json = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.AudioTranscriptionJsonResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.AudioTranscriptionJsonResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.AudioTranscriptionJsonResponse).Name}");
                json = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Together.AudioTranscriptionVerboseJsonResponse? verboseJson = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.AudioTranscriptionVerboseJsonResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.AudioTranscriptionVerboseJsonResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.AudioTranscriptionVerboseJsonResponse).Name}");
                verboseJson = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::Together.AudioTranscriptionResponse(
                json,
                verboseJson
                );

            if (json != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.AudioTranscriptionJsonResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.AudioTranscriptionJsonResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.AudioTranscriptionJsonResponse).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (verboseJson != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.AudioTranscriptionVerboseJsonResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.AudioTranscriptionVerboseJsonResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.AudioTranscriptionVerboseJsonResponse).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Together.AudioTranscriptionResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsJson)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.AudioTranscriptionJsonResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.AudioTranscriptionJsonResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.AudioTranscriptionJsonResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Json, typeInfo);
            }
            else if (value.IsVerboseJson)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.AudioTranscriptionVerboseJsonResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.AudioTranscriptionVerboseJsonResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.AudioTranscriptionVerboseJsonResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VerboseJson, typeInfo);
            }
        }
    }
}