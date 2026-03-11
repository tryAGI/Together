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
            global::Together.ExecuteResponseSuccessfulExecutionDataOutputStreamOutput? streamOutput = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputStreamOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ExecuteResponseSuccessfulExecutionDataOutputStreamOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputStreamOutput).Name}");
                streamOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Together.ExecuteResponseSuccessfulExecutionDataOutputErrorOutput? error = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputErrorOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ExecuteResponseSuccessfulExecutionDataOutputErrorOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputErrorOutput).Name}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Together.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutput? displayorExecuteOutput = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutput).Name}");
                displayorExecuteOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var __value = new global::Together.OutputsItem(
                streamOutput,

                error,

                displayorExecuteOutput
                );

            if (streamOutput != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputStreamOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ExecuteResponseSuccessfulExecutionDataOutputStreamOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputStreamOutput).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (error != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputErrorOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ExecuteResponseSuccessfulExecutionDataOutputErrorOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputErrorOutput).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (displayorExecuteOutput != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutput).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Together.OutputsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStreamOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputStreamOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ExecuteResponseSuccessfulExecutionDataOutputStreamOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputStreamOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamOutput, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputErrorOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ExecuteResponseSuccessfulExecutionDataOutputErrorOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputErrorOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error, typeInfo);
            }
            else if (value.IsDisplayorExecuteOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DisplayorExecuteOutput, typeInfo);
            }
        }
    }
}