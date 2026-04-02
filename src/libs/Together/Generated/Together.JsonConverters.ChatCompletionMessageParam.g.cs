#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Together.JsonConverters
{
    /// <inheritdoc />
    public class ChatCompletionMessageParamJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Together.ChatCompletionMessageParam>
    {
        /// <inheritdoc />
        public override global::Together.ChatCompletionMessageParam Read(
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
            if (__jsonProps.Contains("content")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("role")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("content")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("role")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("content")) __score2++;
            if (__jsonProps.Contains("function_call")) __score2++;
            if (__jsonProps.Contains("name")) __score2++;
            if (__jsonProps.Contains("role")) __score2++;
            if (__jsonProps.Contains("tool_calls")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("content")) __score3++;
            if (__jsonProps.Contains("name")) __score3++;
            if (__jsonProps.Contains("role")) __score3++;
            if (__jsonProps.Contains("tool_call_id")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("content")) __score4++;
            if (__jsonProps.Contains("name")) __score4++;
            if (__jsonProps.Contains("role")) __score4++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::Together.ChatCompletionSystemMessageParam? system = default;
            global::Together.ChatCompletionUserMessageParam? user = default;
            global::Together.ChatCompletionAssistantMessageParam? assistant = default;
            global::Together.ChatCompletionToolMessageParam? tool = default;
            global::Together.ChatCompletionFunctionMessageParam? function = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        system = global::System.Text.Json.JsonSerializer.Deserialize<global::Together.ChatCompletionSystemMessageParam>(__rawJson, options);
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
                        user = global::System.Text.Json.JsonSerializer.Deserialize<global::Together.ChatCompletionUserMessageParam>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        assistant = global::System.Text.Json.JsonSerializer.Deserialize<global::Together.ChatCompletionAssistantMessageParam>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        tool = global::System.Text.Json.JsonSerializer.Deserialize<global::Together.ChatCompletionToolMessageParam>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        function = global::System.Text.Json.JsonSerializer.Deserialize<global::Together.ChatCompletionFunctionMessageParam>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (system == null && user == null && assistant == null && tool == null && function == null)
            {
                try
                {
                    system = global::System.Text.Json.JsonSerializer.Deserialize<global::Together.ChatCompletionSystemMessageParam>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    user = global::System.Text.Json.JsonSerializer.Deserialize<global::Together.ChatCompletionUserMessageParam>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    assistant = global::System.Text.Json.JsonSerializer.Deserialize<global::Together.ChatCompletionAssistantMessageParam>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    tool = global::System.Text.Json.JsonSerializer.Deserialize<global::Together.ChatCompletionToolMessageParam>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    function = global::System.Text.Json.JsonSerializer.Deserialize<global::Together.ChatCompletionFunctionMessageParam>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Together.ChatCompletionMessageParam(
                system,

                user,

                assistant,

                tool,

                function
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Together.ChatCompletionMessageParam value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsSystem)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.System, typeof(global::Together.ChatCompletionSystemMessageParam), options);
            }
            else if (value.IsUser)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.User, typeof(global::Together.ChatCompletionUserMessageParam), options);
            }
            else if (value.IsAssistant)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Assistant, typeof(global::Together.ChatCompletionAssistantMessageParam), options);
            }
            else if (value.IsTool)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeof(global::Together.ChatCompletionToolMessageParam), options);
            }
            else if (value.IsFunction)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function, typeof(global::Together.ChatCompletionFunctionMessageParam), options);
            }
        }
    }
}