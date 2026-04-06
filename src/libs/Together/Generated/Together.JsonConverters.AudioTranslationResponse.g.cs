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

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("text")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("duration")) __score1++;
            if (__jsonProps.Contains("language")) __score1++;
            if (__jsonProps.Contains("segments")) __score1++;
            if (__jsonProps.Contains("task")) __score1++;
            if (__jsonProps.Contains("text")) __score1++;
            if (__jsonProps.Contains("words")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Together.AudioTranslationJsonResponse? json = default;
            global::Together.AudioTranslationVerboseJsonResponse? verboseJson = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.AudioTranslationJsonResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.AudioTranslationJsonResponse> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.AudioTranslationJsonResponse).Name}");
                        json = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.AudioTranslationVerboseJsonResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.AudioTranslationVerboseJsonResponse> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.AudioTranslationVerboseJsonResponse).Name}");
                        verboseJson = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (json == null && verboseJson == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.AudioTranslationJsonResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.AudioTranslationJsonResponse> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.AudioTranslationJsonResponse).Name}");
                    json = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.AudioTranslationVerboseJsonResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.AudioTranslationVerboseJsonResponse> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.AudioTranslationVerboseJsonResponse).Name}");
                    verboseJson = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Together.AudioTranslationResponse(
                json,

                verboseJson
                );

            return __value;
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
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Json!, typeInfo);
            }
            else if (value.IsVerboseJson)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.AudioTranslationVerboseJsonResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.AudioTranslationVerboseJsonResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.AudioTranslationVerboseJsonResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VerboseJson!, typeInfo);
            }
        }
    }
}