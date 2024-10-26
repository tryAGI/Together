#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Together.JsonConverters
{
    /// <inheritdoc />
    public class FinetuneResponseTrainingTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Together.FinetuneResponseTrainingType>
    {
        /// <inheritdoc />
        public override global::Together.FinetuneResponseTrainingType Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.FinetuneResponseTrainingTypeDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.FinetuneResponseTrainingTypeDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Together.FinetuneResponseTrainingTypeDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Together.FullTrainingType? full = default;
            if (discriminator?.Type == global::Together.FinetuneResponseTrainingTypeDiscriminatorType.Full)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.FullTrainingType), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.FullTrainingType> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Together.FullTrainingType)}");
                full = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Together.LoRATrainingType? lora = default;
            if (discriminator?.Type == global::Together.FinetuneResponseTrainingTypeDiscriminatorType.Lora)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.LoRATrainingType), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.LoRATrainingType> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Together.LoRATrainingType)}");
                lora = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Together.FinetuneResponseTrainingType(
                discriminator?.Type,
                full,
                lora
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Together.FinetuneResponseTrainingType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsFull)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.FullTrainingType), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.FullTrainingType?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.FullTrainingType).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Full, typeInfo);
            }
            else if (value.IsLora)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.LoRATrainingType), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.LoRATrainingType?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.LoRATrainingType).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Lora, typeInfo);
            }
        }
    }
}