#nullable enable

namespace Together.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatCompletionRequestFunctionCallEnumJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Together.ChatCompletionRequestFunctionCallEnum>
    {
        /// <inheritdoc />
        public override global::Together.ChatCompletionRequestFunctionCallEnum Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Together.ChatCompletionRequestFunctionCallEnumExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Together.ChatCompletionRequestFunctionCallEnum)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Together.ChatCompletionRequestFunctionCallEnum);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Together.ChatCompletionRequestFunctionCallEnum value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Together.ChatCompletionRequestFunctionCallEnumExtensions.ToValueString(value));
        }
    }
}
