#nullable enable

namespace Together.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateFineTunesRequestTrainOnInputsNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Together.CreateFineTunesRequestTrainOnInputs?>
    {
        /// <inheritdoc />
        public override global::Together.CreateFineTunesRequestTrainOnInputs? Read(
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
                        return global::Together.CreateFineTunesRequestTrainOnInputsExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Together.CreateFineTunesRequestTrainOnInputs)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Together.CreateFineTunesRequestTrainOnInputs?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Together.CreateFineTunesRequestTrainOnInputs? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Together.CreateFineTunesRequestTrainOnInputsExtensions.ToValueString(value.Value));
            }
        }
    }
}
