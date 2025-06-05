#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Together.JsonConverters
{
    /// <inheritdoc />
    public class CompletionStreamJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Together.CompletionStream>
    {
        /// <inheritdoc />
        public override global::Together.CompletionStream Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::Together.CompletionEvent? @event = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.CompletionEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.CompletionEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.CompletionEvent).Name}");
                @event = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Together.StreamSentinel? sentinel = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.StreamSentinel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.StreamSentinel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.StreamSentinel).Name}");
                sentinel = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::Together.CompletionStream(
                @event,
                sentinel
                );

            if (@event != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.CompletionEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.CompletionEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.CompletionEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (sentinel != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.StreamSentinel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.StreamSentinel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.StreamSentinel).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Together.CompletionStream value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.CompletionEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.CompletionEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.CompletionEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Event, typeInfo);
            }
            else if (value.IsSentinel)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.StreamSentinel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.StreamSentinel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.StreamSentinel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sentinel, typeInfo);
            }
        }
    }
}