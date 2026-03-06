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
            global::Together.ExecuteResponseSuccessfulExecution? successfulExecution = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ExecuteResponseSuccessfulExecution), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ExecuteResponseSuccessfulExecution> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ExecuteResponseSuccessfulExecution).Name}");
                successfulExecution = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Together.ExecuteResponseFailedExecution? failedExecution = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ExecuteResponseFailedExecution), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ExecuteResponseFailedExecution> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ExecuteResponseFailedExecution).Name}");
                failedExecution = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::Together.ExecuteResponse(
                successfulExecution,
                failedExecution
                );

            if (successfulExecution != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ExecuteResponseSuccessfulExecution), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ExecuteResponseSuccessfulExecution> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ExecuteResponseSuccessfulExecution).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (failedExecution != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ExecuteResponseFailedExecution), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ExecuteResponseFailedExecution> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ExecuteResponseFailedExecution).Name}");
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

            if (value.IsSuccessfulExecution)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ExecuteResponseSuccessfulExecution), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ExecuteResponseSuccessfulExecution?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ExecuteResponseSuccessfulExecution).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SuccessfulExecution, typeInfo);
            }
            else if (value.IsFailedExecution)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ExecuteResponseFailedExecution), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ExecuteResponseFailedExecution?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ExecuteResponseFailedExecution).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FailedExecution, typeInfo);
            }
        }
    }
}