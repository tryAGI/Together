#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Together.JsonConverters
{
    /// <inheritdoc />
    public class QuantizationJobJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Together.QuantizationJob>
    {
        /// <inheritdoc />
        public override global::Together.QuantizationJob Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::Together.BaseShapingJob? baseShaping = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.BaseShapingJob), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.BaseShapingJob> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.BaseShapingJob).Name}");
                baseShaping = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::Together.QuantizationJobVariant2? quantizationJobVariant2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.QuantizationJobVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.QuantizationJobVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.QuantizationJobVariant2).Name}");
                quantizationJobVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            var __value = new global::Together.QuantizationJob(
                baseShaping,

                quantizationJobVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Together.QuantizationJob value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsBaseShaping)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.BaseShapingJob), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.BaseShapingJob?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.BaseShapingJob).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.PickBaseShaping(), typeInfo);
                if (__element0.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element0.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            if (value.IsQuantizationJobVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.QuantizationJobVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.QuantizationJobVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.QuantizationJobVariant2).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.PickQuantizationJobVariant2(), typeInfo);
                if (__element1.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element1.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            writer.WriteEndObject();
        }
    }
}