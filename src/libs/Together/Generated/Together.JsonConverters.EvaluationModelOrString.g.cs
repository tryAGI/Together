#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Together.JsonConverters
{
    /// <inheritdoc />
    public class EvaluationModelOrStringJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Together.EvaluationModelOrString>
    {
        /// <inheritdoc />
        public override global::Together.EvaluationModelOrString Read(
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
            var __score1 = 0;
            if (__jsonProps.Contains("external_api_token")) __score1++;
            if (__jsonProps.Contains("external_base_url")) __score1++;
            if (__jsonProps.Contains("input_template")) __score1++;
            if (__jsonProps.Contains("max_tokens")) __score1++;
            if (__jsonProps.Contains("model")) __score1++;
            if (__jsonProps.Contains("model_source")) __score1++;
            if (__jsonProps.Contains("num_workers")) __score1++;
            if (__jsonProps.Contains("system_template")) __score1++;
            if (__jsonProps.Contains("temperature")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            string? evaluationModelOrStringVariant1 = default;
            global::Together.EvaluationModelRequest? request = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                        evaluationModelOrStringVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.EvaluationModelRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.EvaluationModelRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.EvaluationModelRequest).Name}");
                        request = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (evaluationModelOrStringVariant1 == null && request == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                    evaluationModelOrStringVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.EvaluationModelRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.EvaluationModelRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.EvaluationModelRequest).Name}");
                    request = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Together.EvaluationModelOrString(
                evaluationModelOrStringVariant1,

                request
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Together.EvaluationModelOrString value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsEvaluationModelOrStringVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EvaluationModelOrStringVariant1!, typeInfo);
            }
            else if (value.IsRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.EvaluationModelRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.EvaluationModelRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.EvaluationModelRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Request!, typeInfo);
            }
        }
    }
}