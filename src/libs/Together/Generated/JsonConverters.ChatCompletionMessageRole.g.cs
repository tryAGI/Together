#nullable enable

namespace Together.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatCompletionMessageRoleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Together.ChatCompletionMessageRole>
    {
        /// <inheritdoc />
        public override global::Together.ChatCompletionMessageRole Read(
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
                        return global::Together.ChatCompletionMessageRoleExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Together.ChatCompletionMessageRole)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Together.ChatCompletionMessageRole);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Together.ChatCompletionMessageRole value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Together.ChatCompletionMessageRoleExtensions.ToValueString(value));
        }
    }
}
