#nullable enable

namespace Together.JsonConverters
{
    /// <inheritdoc />
    public sealed class DeploymentResponseItemCapacityTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Together.DeploymentResponseItemCapacityType?>
    {
        /// <inheritdoc />
        public override global::Together.DeploymentResponseItemCapacityType? Read(
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
                        return global::Together.DeploymentResponseItemCapacityTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Together.DeploymentResponseItemCapacityType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Together.DeploymentResponseItemCapacityType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Together.DeploymentResponseItemCapacityType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Together.DeploymentResponseItemCapacityTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
