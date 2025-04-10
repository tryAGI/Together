#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Together.JsonConverters
{
    /// <inheritdoc />
    public class InterpreterOutputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Together.InterpreterOutput>
    {
        /// <inheritdoc />
        public override global::Together.InterpreterOutput Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::Together.InterpreterOutputVariant1? value1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.InterpreterOutputVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.InterpreterOutputVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.InterpreterOutputVariant1).Name}");
                value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Together.InterpreterOutputVariant2? value2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.InterpreterOutputVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.InterpreterOutputVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.InterpreterOutputVariant2).Name}");
                value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Together.InterpreterOutputVariant3? value3 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.InterpreterOutputVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.InterpreterOutputVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.InterpreterOutputVariant3).Name}");
                value3 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::Together.InterpreterOutput(
                value1,
                value2,
                value3
                );

            if (value1 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.InterpreterOutputVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.InterpreterOutputVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.InterpreterOutputVariant1).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value2 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.InterpreterOutputVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.InterpreterOutputVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.InterpreterOutputVariant2).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value3 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.InterpreterOutputVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.InterpreterOutputVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.InterpreterOutputVariant3).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Together.InterpreterOutput value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.InterpreterOutputVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.InterpreterOutputVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.InterpreterOutputVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.InterpreterOutputVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.InterpreterOutputVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.InterpreterOutputVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
            else if (value.IsValue3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.InterpreterOutputVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.InterpreterOutputVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.InterpreterOutputVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value3, typeInfo);
            }
        }
    }
}