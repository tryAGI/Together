#nullable enable

namespace Together.JsonConverters
{
    /// <inheritdoc />
    public sealed class DeSupportedModelUnitPriceTierNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Together.DeSupportedModelUnitPriceTier?>
    {
        /// <inheritdoc />
        public override global::Together.DeSupportedModelUnitPriceTier? Read(
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
                        return global::Together.DeSupportedModelUnitPriceTierExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Together.DeSupportedModelUnitPriceTier)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Together.DeSupportedModelUnitPriceTier?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Together.DeSupportedModelUnitPriceTier? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Together.DeSupportedModelUnitPriceTierExtensions.ToValueString(value.Value));
            }
        }
    }
}
