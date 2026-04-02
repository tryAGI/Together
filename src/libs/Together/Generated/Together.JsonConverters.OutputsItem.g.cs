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
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("data")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("data")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::Together.ExecuteResponseSuccessfulExecutionDataOutputStreamOutput? streamOutput = default;
            global::Together.ExecuteResponseSuccessfulExecutionDataOutputErrorOutput? error = default;
            global::Together.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutput? displayorExecuteOutput = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        streamOutput = global::System.Text.Json.JsonSerializer.Deserialize<global::Together.ExecuteResponseSuccessfulExecutionDataOutputStreamOutput>(__rawJson, options);
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
                        error = global::System.Text.Json.JsonSerializer.Deserialize<global::Together.ExecuteResponseSuccessfulExecutionDataOutputErrorOutput>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        displayorExecuteOutput = global::System.Text.Json.JsonSerializer.Deserialize<global::Together.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutput>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (streamOutput == null && error == null && displayorExecuteOutput == null)
            {
                try
                {
                    streamOutput = global::System.Text.Json.JsonSerializer.Deserialize<global::Together.ExecuteResponseSuccessfulExecutionDataOutputStreamOutput>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    error = global::System.Text.Json.JsonSerializer.Deserialize<global::Together.ExecuteResponseSuccessfulExecutionDataOutputErrorOutput>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    displayorExecuteOutput = global::System.Text.Json.JsonSerializer.Deserialize<global::Together.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutput>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Together.OutputsItem(
                streamOutput,

                error,

                displayorExecuteOutput
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Together.OutputsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsStreamOutput)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamOutput, typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputStreamOutput), options);
            }
            else if (value.IsError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error, typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputErrorOutput), options);
            }
            else if (value.IsDisplayorExecuteOutput)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DisplayorExecuteOutput, typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutput), options);
            }
        }
    }
}