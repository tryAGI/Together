#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Together.JsonConverters
{
    /// <inheritdoc />
    public class SessionListResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Together.SessionListResponse>
    {
        /// <inheritdoc />
        public override global::Together.SessionListResponse Read(
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
            if (__jsonProps.Contains("errors")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("data")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Together.SessionListResponseResponse? response = default;
            global::Together.SessionListResponseVariant2? sessionListResponseVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        response = global::System.Text.Json.JsonSerializer.Deserialize<global::Together.SessionListResponseResponse>(__rawJson, options);
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
                        sessionListResponseVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Together.SessionListResponseVariant2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (response == null && sessionListResponseVariant2 == null)
            {
                try
                {
                    response = global::System.Text.Json.JsonSerializer.Deserialize<global::Together.SessionListResponseResponse>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    sessionListResponseVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Together.SessionListResponseVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Together.SessionListResponse(
                response,

                sessionListResponseVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Together.SessionListResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsResponse)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Response, typeof(global::Together.SessionListResponseResponse), options);
            }
            else if (value.IsSessionListResponseVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionListResponseVariant2, typeof(global::Together.SessionListResponseVariant2), options);
            }
        }
    }
}