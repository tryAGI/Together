#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Together.JsonConverters
{
    /// <inheritdoc />
    public class OutputsItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Together.OutputsItem>
    {
        /// <inheritdoc />
        public override global::Together.OutputsItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::Together.ExecuteResponseVariant1DataOutputVariant1? value1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ExecuteResponseVariant1DataOutputVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ExecuteResponseVariant1DataOutputVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ExecuteResponseVariant1DataOutputVariant1).Name}");
                value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Together.ExecuteResponseVariant1DataOutputVariant2? value2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ExecuteResponseVariant1DataOutputVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ExecuteResponseVariant1DataOutputVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ExecuteResponseVariant1DataOutputVariant2).Name}");
                value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Together.ExecuteResponseVariant1DataOutputVariant3? value3 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ExecuteResponseVariant1DataOutputVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ExecuteResponseVariant1DataOutputVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ExecuteResponseVariant1DataOutputVariant3).Name}");
                value3 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::Together.OutputsItem(
                value1,
                value2,
                value3
                );

            if (value1 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ExecuteResponseVariant1DataOutputVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ExecuteResponseVariant1DataOutputVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ExecuteResponseVariant1DataOutputVariant1).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value2 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ExecuteResponseVariant1DataOutputVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ExecuteResponseVariant1DataOutputVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ExecuteResponseVariant1DataOutputVariant2).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value3 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ExecuteResponseVariant1DataOutputVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ExecuteResponseVariant1DataOutputVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ExecuteResponseVariant1DataOutputVariant3).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Together.OutputsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ExecuteResponseVariant1DataOutputVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ExecuteResponseVariant1DataOutputVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ExecuteResponseVariant1DataOutputVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ExecuteResponseVariant1DataOutputVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ExecuteResponseVariant1DataOutputVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ExecuteResponseVariant1DataOutputVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
            else if (value.IsValue3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ExecuteResponseVariant1DataOutputVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ExecuteResponseVariant1DataOutputVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ExecuteResponseVariant1DataOutputVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value3, typeInfo);
            }
        }
    }
}