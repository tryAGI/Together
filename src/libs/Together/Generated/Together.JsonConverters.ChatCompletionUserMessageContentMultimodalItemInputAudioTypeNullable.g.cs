#nullable enable

namespace Together.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatCompletionUserMessageContentMultimodalItemInputAudioTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudioType?>
    {
        /// <inheritdoc />
        public override global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudioType? Read(
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
                        return global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudioTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudioType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudioType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudioType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudioTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
