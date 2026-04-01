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

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("data")) __score0++;
            if (__jsonProps.Contains("errors")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("data")) __score1++;
            if (__jsonProps.Contains("errors")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Together.ExecuteResponseSuccessfulExecution? successfulExecution = default;
            global::Together.ExecuteResponseFailedExecution? failedExecution = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ExecuteResponseSuccessfulExecution), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ExecuteResponseSuccessfulExecution> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ExecuteResponseSuccessfulExecution).Name}");
                        successfulExecution = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ExecuteResponseFailedExecution), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ExecuteResponseFailedExecution> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ExecuteResponseFailedExecution).Name}");
                        failedExecution = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (successfulExecution == null && failedExecution == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ExecuteResponseSuccessfulExecution), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ExecuteResponseSuccessfulExecution> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ExecuteResponseSuccessfulExecution).Name}");
                    successfulExecution = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ExecuteResponseFailedExecution), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ExecuteResponseFailedExecution> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ExecuteResponseFailedExecution).Name}");
                    failedExecution = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Together.ExecuteResponse(
                successfulExecution,

                failedExecution
                );

            return __value;
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
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SuccessfulExecution!, typeInfo);
            }
            else if (value.IsFailedExecution)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ExecuteResponseFailedExecution), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ExecuteResponseFailedExecution?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ExecuteResponseFailedExecution).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FailedExecution!, typeInfo);
            }
        }
    }
}