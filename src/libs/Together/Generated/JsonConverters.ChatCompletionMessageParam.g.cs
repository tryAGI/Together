#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenApiGenerator.JsonConverters
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::Together.ChatCompletionSystemMessageParam? system = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ChatCompletionSystemMessageParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ChatCompletionSystemMessageParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ChatCompletionSystemMessageParam).Name}");
                system = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Together.ChatCompletionUserMessageParam? user = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ChatCompletionUserMessageParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ChatCompletionUserMessageParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ChatCompletionUserMessageParam).Name}");
                user = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Together.ChatCompletionAssistantMessageParam? assistant = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ChatCompletionAssistantMessageParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ChatCompletionAssistantMessageParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ChatCompletionAssistantMessageParam).Name}");
                assistant = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Together.ChatCompletionToolMessageParam? tool = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ChatCompletionToolMessageParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ChatCompletionToolMessageParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ChatCompletionToolMessageParam).Name}");
                tool = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Together.ChatCompletionFunctionMessageParam? function = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ChatCompletionFunctionMessageParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ChatCompletionFunctionMessageParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ChatCompletionFunctionMessageParam).Name}");
                function = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::Together.ChatCompletionMessageParam(
                system,
                user,
                assistant,
                tool,
                function
                );

            if (system != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ChatCompletionSystemMessageParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ChatCompletionSystemMessageParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ChatCompletionSystemMessageParam).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (user != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ChatCompletionUserMessageParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ChatCompletionUserMessageParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ChatCompletionUserMessageParam).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (assistant != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ChatCompletionAssistantMessageParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ChatCompletionAssistantMessageParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ChatCompletionAssistantMessageParam).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (tool != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ChatCompletionToolMessageParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ChatCompletionToolMessageParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ChatCompletionToolMessageParam).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (function != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ChatCompletionFunctionMessageParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ChatCompletionFunctionMessageParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ChatCompletionFunctionMessageParam).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Together.ChatCompletionMessageParam value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSystem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ChatCompletionSystemMessageParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ChatCompletionSystemMessageParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ChatCompletionSystemMessageParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.System, typeInfo);
            }
            else if (value.IsUser)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ChatCompletionUserMessageParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ChatCompletionUserMessageParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ChatCompletionUserMessageParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.User, typeInfo);
            }
            else if (value.IsAssistant)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ChatCompletionAssistantMessageParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ChatCompletionAssistantMessageParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ChatCompletionAssistantMessageParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Assistant, typeInfo);
            }
            else if (value.IsTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ChatCompletionToolMessageParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ChatCompletionToolMessageParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ChatCompletionToolMessageParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeInfo);
            }
            else if (value.IsFunction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ChatCompletionFunctionMessageParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ChatCompletionFunctionMessageParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ChatCompletionFunctionMessageParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function, typeInfo);
            }
        }
    }
}