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
            if (__jsonProps.Contains("speaker_segments")) __score1++;
            if (__jsonProps.Contains("task")) __score1++;
            if (__jsonProps.Contains("text")) __score1++;
            if (__jsonProps.Contains("words")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Together.AudioTranscriptionJsonResponse? json = default;
            global::Together.AudioTranscriptionVerboseJsonResponse? verboseJson = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        json = global::System.Text.Json.JsonSerializer.Deserialize<global::Together.AudioTranscriptionJsonResponse>(__rawJson, options);
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
                        verboseJson = global::System.Text.Json.JsonSerializer.Deserialize<global::Together.AudioTranscriptionVerboseJsonResponse>(__rawJson, options);
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
                    json = global::System.Text.Json.JsonSerializer.Deserialize<global::Together.AudioTranscriptionJsonResponse>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    verboseJson = global::System.Text.Json.JsonSerializer.Deserialize<global::Together.AudioTranscriptionVerboseJsonResponse>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Together.AudioTranscriptionResponse(
                json,

                verboseJson
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Together.AudioTranscriptionResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsJson)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Json, typeof(global::Together.AudioTranscriptionJsonResponse), options);
            }
            else if (value.IsVerboseJson)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VerboseJson, typeof(global::Together.AudioTranscriptionVerboseJsonResponse), options);
            }
        }
    }
}