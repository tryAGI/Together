#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Together.JsonConverters
{
    /// <inheritdoc />
    public class ChatCompletionRequestMessageContentVariant2ItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Together.ChatCompletionRequestMessageContentVariant2Item>
    {
        /// <inheritdoc />
        public override global::Together.ChatCompletionRequestMessageContentVariant2Item Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ChatCompletionRequestMessageContentVariant2ItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ChatCompletionRequestMessageContentVariant2ItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Together.ChatCompletionRequestMessageContentVariant2ItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Together.ChatCompletionRequestMessageContentVariant2ItemVariant1? text = default;
            if (discriminator?.Type == global::Together.ChatCompletionRequestMessageContentVariant2ItemDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ChatCompletionRequestMessageContentVariant2ItemVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ChatCompletionRequestMessageContentVariant2ItemVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Together.ChatCompletionRequestMessageContentVariant2ItemVariant1)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Together.ChatCompletionRequestMessageContentVariant2ItemVariant2? imageUrl = default;
            if (discriminator?.Type == global::Together.ChatCompletionRequestMessageContentVariant2ItemDiscriminatorType.ImageUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ChatCompletionRequestMessageContentVariant2ItemVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ChatCompletionRequestMessageContentVariant2ItemVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Together.ChatCompletionRequestMessageContentVariant2ItemVariant2)}");
                imageUrl = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Together.ChatCompletionRequestMessageContentVariant2Item(
                discriminator?.Type,
                text,
                imageUrl
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Together.ChatCompletionRequestMessageContentVariant2Item value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ChatCompletionRequestMessageContentVariant2ItemVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ChatCompletionRequestMessageContentVariant2ItemVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ChatCompletionRequestMessageContentVariant2ItemVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
            else if (value.IsImageUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ChatCompletionRequestMessageContentVariant2ItemVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ChatCompletionRequestMessageContentVariant2ItemVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ChatCompletionRequestMessageContentVariant2ItemVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageUrl, typeInfo);
            }
        }
    }
}