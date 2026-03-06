#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Together.JsonConverters
{
    /// <inheritdoc />
    public class SessionListResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Together.SessionListResponse>
    {
        /// <inheritdoc />
        public override global::Together.SessionListResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::Together.SessionListResponseResponse? response = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.SessionListResponseResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.SessionListResponseResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.SessionListResponseResponse).Name}");
                response = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Together.SessionListResponseVariant2? value2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.SessionListResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.SessionListResponseVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.SessionListResponseVariant2).Name}");
                value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::Together.SessionListResponse(
                response,
                value2
                );

            if (response != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.SessionListResponseResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.SessionListResponseResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.SessionListResponseResponse).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value2 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.SessionListResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.SessionListResponseVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.SessionListResponseVariant2).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Together.SessionListResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.SessionListResponseResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.SessionListResponseResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.SessionListResponseResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Response, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.SessionListResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.SessionListResponseVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.SessionListResponseVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
        }
    }
}