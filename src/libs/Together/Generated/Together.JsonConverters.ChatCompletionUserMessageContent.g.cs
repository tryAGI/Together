#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Together.JsonConverters
{
    /// <inheritdoc />
    public class ChatCompletionUserMessageContentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Together.ChatCompletionUserMessageContent>
    {
        /// <inheritdoc />
        public override global::Together.ChatCompletionUserMessageContent Read(
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
            var __score1 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            string? @string = default;
            global::System.Collections.Generic.IList<global::Together.OneOf<global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2, global::Together.ChatCompletionUserMessageContentMultimodalItemVideo, global::Together.ChatCompletionUserMessageContentMultimodalItemAudio, global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudio>>? multimodal = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        @string = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
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

                        multimodal = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::Together.OneOf<global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2, global::Together.ChatCompletionUserMessageContentMultimodalItemVideo, global::Together.ChatCompletionUserMessageContentMultimodalItemAudio, global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudio>>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (@string == null && multimodal == null)
            {
                try
                {

                    @string = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    multimodal = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::Together.OneOf<global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2, global::Together.ChatCompletionUserMessageContentMultimodalItemVideo, global::Together.ChatCompletionUserMessageContentMultimodalItemAudio, global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudio>>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Together.ChatCompletionUserMessageContent(
                @string,

                multimodal
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Together.ChatCompletionUserMessageContent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsString)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.String, typeof(string), options);
            }
            else if (value.IsMultimodal)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Multimodal, typeof(global::System.Collections.Generic.IList<global::Together.OneOf<global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2, global::Together.ChatCompletionUserMessageContentMultimodalItemVideo, global::Together.ChatCompletionUserMessageContentMultimodalItemAudio, global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudio>>), options);
            }
        }
    }
}