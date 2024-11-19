#nullable enable

namespace Together.JsonConverters
{
    /// <inheritdoc />
    public sealed class FinetuneResponseTrainOnInputsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Together.FinetuneResponseTrainOnInputs>
    {
        /// <inheritdoc />
        public override global::Together.FinetuneResponseTrainOnInputs Read(
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
                        return global::Together.FinetuneResponseTrainOnInputsExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Together.FinetuneResponseTrainOnInputs)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Together.FinetuneResponseTrainOnInputs value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Together.FinetuneResponseTrainOnInputsExtensions.ToValueString(value));
        }
    }
}