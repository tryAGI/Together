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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ChatCompletionMessageParamDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ChatCompletionMessageParamDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Together.ChatCompletionMessageParamDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Together.ChatCompletionSystemMessageParam? system = default;
            if (discriminator?.Role == global::Together.ChatCompletionMessageParamDiscriminatorRole.System)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ChatCompletionSystemMessageParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ChatCompletionSystemMessageParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Together.ChatCompletionSystemMessageParam)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Together.ChatCompletionUserMessageParam? user = default;
            if (discriminator?.Role == global::Together.ChatCompletionMessageParamDiscriminatorRole.User)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ChatCompletionUserMessageParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ChatCompletionUserMessageParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Together.ChatCompletionUserMessageParam)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Together.ChatCompletionAssistantMessageParam? assistant = default;
            if (discriminator?.Role == global::Together.ChatCompletionMessageParamDiscriminatorRole.Assistant)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ChatCompletionAssistantMessageParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ChatCompletionAssistantMessageParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Together.ChatCompletionAssistantMessageParam)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Together.ChatCompletionToolMessageParam? tool = default;
            if (discriminator?.Role == global::Together.ChatCompletionMessageParamDiscriminatorRole.Tool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ChatCompletionToolMessageParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ChatCompletionToolMessageParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Together.ChatCompletionToolMessageParam)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Together.ChatCompletionFunctionMessageParam? function = default;
            if (discriminator?.Role == global::Together.ChatCompletionMessageParamDiscriminatorRole.Function)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ChatCompletionFunctionMessageParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ChatCompletionFunctionMessageParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Together.ChatCompletionFunctionMessageParam)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Together.ChatCompletionMessageParam(
                discriminator?.Role,
                system,
                user,
                assistant,
                tool,
                function
                );

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