#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Together.JsonConverters
{
    /// <inheritdoc />
    public class ExecuteResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Together.ExecuteResponse>
    {
        /// <inheritdoc />
        public override global::Together.ExecuteResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::Together.ExecuteResponseVariant1? value1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ExecuteResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ExecuteResponseVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ExecuteResponseVariant1).Name}");
                value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Together.ExecuteResponseVariant2? value2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ExecuteResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ExecuteResponseVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ExecuteResponseVariant2).Name}");
                value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::Together.ExecuteResponse(
                value1,
                value2
                );

            if (value1 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ExecuteResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ExecuteResponseVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ExecuteResponseVariant1).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value2 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ExecuteResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ExecuteResponseVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ExecuteResponseVariant2).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Together.ExecuteResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ExecuteResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ExecuteResponseVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ExecuteResponseVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ExecuteResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ExecuteResponseVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ExecuteResponseVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
        }
    }
}