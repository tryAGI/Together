#nullable enable

namespace Together.JsonConverters
{
    /// <inheritdoc />
    public sealed class AudioTranscriptionRequestTimestampGranularitieNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Together.AudioTranscriptionRequestTimestampGranularitie?>
    {
        /// <inheritdoc />
        public override global::Together.AudioTranscriptionRequestTimestampGranularitie? Read(
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
                        return global::Together.AudioTranscriptionRequestTimestampGranularitieExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Together.AudioTranscriptionRequestTimestampGranularitie)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Together.AudioTranscriptionRequestTimestampGranularitie?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Together.AudioTranscriptionRequestTimestampGranularitie? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Together.AudioTranscriptionRequestTimestampGranularitieExtensions.ToValueString(value.Value));
            }
        }
    }
}
