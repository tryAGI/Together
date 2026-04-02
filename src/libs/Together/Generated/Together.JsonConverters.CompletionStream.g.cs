#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Together.JsonConverters
{
    /// <inheritdoc />
    public class CompletionStreamJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Together.CompletionStream>
    {
        /// <inheritdoc />
        public override global::Together.CompletionStream Read(
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
            if (__jsonProps.Contains("data")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("data")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Together.CompletionEvent? @event = default;
            global::Together.StreamSentinel? sentinel = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        @event = global::System.Text.Json.JsonSerializer.Deserialize<global::Together.CompletionEvent>(__rawJson, options);
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
                        sentinel = global::System.Text.Json.JsonSerializer.Deserialize<global::Together.StreamSentinel>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (@event == null && sentinel == null)
            {
                try
                {
                    @event = global::System.Text.Json.JsonSerializer.Deserialize<global::Together.CompletionEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    sentinel = global::System.Text.Json.JsonSerializer.Deserialize<global::Together.StreamSentinel>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Together.CompletionStream(
                @event,

                sentinel
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Together.CompletionStream value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Event, typeof(global::Together.CompletionEvent), options);
            }
            else if (value.IsSentinel)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sentinel, typeof(global::Together.StreamSentinel), options);
            }
        }
    }
}