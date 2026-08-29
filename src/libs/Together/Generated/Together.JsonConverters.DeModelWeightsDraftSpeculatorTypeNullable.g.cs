#nullable enable

namespace Together.JsonConverters
{
    /// <inheritdoc />
    public sealed class DeModelWeightsDraftSpeculatorTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Together.DeModelWeightsDraftSpeculatorType?>
    {
        /// <inheritdoc />
        public override global::Together.DeModelWeightsDraftSpeculatorType? Read(
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
                        return global::Together.DeModelWeightsDraftSpeculatorTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Together.DeModelWeightsDraftSpeculatorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Together.DeModelWeightsDraftSpeculatorType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Together.DeModelWeightsDraftSpeculatorType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Together.DeModelWeightsDraftSpeculatorTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
