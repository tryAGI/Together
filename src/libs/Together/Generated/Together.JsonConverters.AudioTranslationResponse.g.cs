#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Together.JsonConverters
{
    /// <inheritdoc />
    public class AudioTranslationResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Together.AudioTranslationResponse>
    {
        /// <inheritdoc />
        public override global::Together.AudioTranslationResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::Together.AudioTranslationJsonResponse? json = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.AudioTranslationJsonResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.AudioTranslationJsonResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.AudioTranslationJsonResponse).Name}");
                json = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Together.AudioTranslationVerboseJsonResponse? verboseJson = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.AudioTranslationVerboseJsonResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.AudioTranslationVerboseJsonResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.AudioTranslationVerboseJsonResponse).Name}");
                verboseJson = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::Together.AudioTranslationResponse(
                json,
                verboseJson
                );

            if (json != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.AudioTranslationJsonResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.AudioTranslationJsonResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.AudioTranslationJsonResponse).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (verboseJson != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.AudioTranslationVerboseJsonResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.AudioTranslationVerboseJsonResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.AudioTranslationVerboseJsonResponse).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Together.AudioTranslationResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsJson)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.AudioTranslationJsonResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.AudioTranslationJsonResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.AudioTranslationJsonResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Json, typeInfo);
            }
            else if (value.IsVerboseJson)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.AudioTranslationVerboseJsonResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.AudioTranslationVerboseJsonResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.AudioTranslationVerboseJsonResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VerboseJson, typeInfo);
            }
        }
    }
}