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
            global::Together.InterpreterOutputStreamOutput? streamOutput = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.InterpreterOutputStreamOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.InterpreterOutputStreamOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.InterpreterOutputStreamOutput).Name}");
                streamOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Together.InterpreterOutputErrorOutput? error = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.InterpreterOutputErrorOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.InterpreterOutputErrorOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.InterpreterOutputErrorOutput).Name}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Together.InterpreterOutputDisplayorExecuteOutput? displayorExecuteOutput = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.InterpreterOutputDisplayorExecuteOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.InterpreterOutputDisplayorExecuteOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.InterpreterOutputDisplayorExecuteOutput).Name}");
                displayorExecuteOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::Together.InterpreterOutput(
                streamOutput,
                error,
                displayorExecuteOutput
                );

            if (streamOutput != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.InterpreterOutputStreamOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.InterpreterOutputStreamOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.InterpreterOutputStreamOutput).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (error != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.InterpreterOutputErrorOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.InterpreterOutputErrorOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.InterpreterOutputErrorOutput).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (displayorExecuteOutput != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.InterpreterOutputDisplayorExecuteOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.InterpreterOutputDisplayorExecuteOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.InterpreterOutputDisplayorExecuteOutput).Name}");
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

            if (value.IsStreamOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.InterpreterOutputStreamOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.InterpreterOutputStreamOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.InterpreterOutputStreamOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamOutput, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.InterpreterOutputErrorOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.InterpreterOutputErrorOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.InterpreterOutputErrorOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error, typeInfo);
            }
            else if (value.IsDisplayorExecuteOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.InterpreterOutputDisplayorExecuteOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.InterpreterOutputDisplayorExecuteOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.InterpreterOutputDisplayorExecuteOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DisplayorExecuteOutput, typeInfo);
            }
        }
    }
}