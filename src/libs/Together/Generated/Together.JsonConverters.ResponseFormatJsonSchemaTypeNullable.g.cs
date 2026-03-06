#nullable enable

namespace Together.JsonConverters
{
    /// <inheritdoc />
    public sealed class ResponseFormatJsonSchemaTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Together.ResponseFormatJsonSchemaType?>
    {
        /// <inheritdoc />
        public override global::Together.ResponseFormatJsonSchemaType? Read(
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
                        return global::Together.ResponseFormatJsonSchemaTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Together.ResponseFormatJsonSchemaType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Together.ResponseFormatJsonSchemaType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Together.ResponseFormatJsonSchemaType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Together.ResponseFormatJsonSchemaTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
