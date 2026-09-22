#nullable enable

namespace Together.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateDeploymentRequestCapacityTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Together.UpdateDeploymentRequestCapacityType?>
    {
        /// <inheritdoc />
        public override global::Together.UpdateDeploymentRequestCapacityType? Read(
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
                        return global::Together.UpdateDeploymentRequestCapacityTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Together.UpdateDeploymentRequestCapacityType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Together.UpdateDeploymentRequestCapacityType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Together.UpdateDeploymentRequestCapacityType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Together.UpdateDeploymentRequestCapacityTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
