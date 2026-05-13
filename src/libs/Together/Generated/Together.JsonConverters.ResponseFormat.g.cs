#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Together.JsonConverters
{
    /// <inheritdoc />
    public class ResponseFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Together.ResponseFormat>
    {
        /// <inheritdoc />
        public override global::Together.ResponseFormat Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ChatCompletionRequestResponseFormatDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ChatCompletionRequestResponseFormatDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Together.ChatCompletionRequestResponseFormatDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Together.ResponseFormatText? text = default;
            if (discriminator?.Type == global::Together.ChatCompletionRequestResponseFormatDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ResponseFormatText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ResponseFormatText> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Together.ResponseFormatText)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Together.ResponseFormatJsonSchema? jsonSchema = default;
            if (discriminator?.Type == global::Together.ChatCompletionRequestResponseFormatDiscriminatorType.JsonSchema)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ResponseFormatJsonSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ResponseFormatJsonSchema> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Together.ResponseFormatJsonSchema)}");
                jsonSchema = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Together.ResponseFormatJsonObject? jsonObject = default;
            if (discriminator?.Type == global::Together.ChatCompletionRequestResponseFormatDiscriminatorType.JsonObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ResponseFormatJsonObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ResponseFormatJsonObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Together.ResponseFormatJsonObject)}");
                jsonObject = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Together.ResponseFormat(
                discriminator?.Type,
                text,

                jsonSchema,

                jsonObject
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Together.ResponseFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ResponseFormatText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ResponseFormatText?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ResponseFormatText).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
            else if (value.IsJsonSchema)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ResponseFormatJsonSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ResponseFormatJsonSchema?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ResponseFormatJsonSchema).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JsonSchema!, typeInfo);
            }
            else if (value.IsJsonObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ResponseFormatJsonObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ResponseFormatJsonObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ResponseFormatJsonObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JsonObject!, typeInfo);
            }
        }
    }
}