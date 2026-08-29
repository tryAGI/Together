#nullable enable

namespace Together.JsonConverters
{
    /// <inheritdoc />
    public sealed class DeSupportedModelProductJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Together.DeSupportedModelProduct>
    {
        /// <inheritdoc />
        public override global::Together.DeSupportedModelProduct Read(
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
                        return global::Together.DeSupportedModelProductExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Together.DeSupportedModelProduct)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Together.DeSupportedModelProduct);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Together.DeSupportedModelProduct value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Together.DeSupportedModelProductExtensions.ToValueString(value));
        }
    }
}
