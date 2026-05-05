#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Together.JsonConverters
{
    /// <inheritdoc />
    public class DataItem3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Together.DataItem3>
    {
        /// <inheritdoc />
        public override global::Together.DataItem3 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("b64_json")) __score0++;
            if (__jsonProps.Contains("index")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("index")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("url")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Together.ImageResponseDataB64? b64Json = default;
            global::Together.ImageResponseDataUrl? url = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ImageResponseDataB64), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ImageResponseDataB64> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ImageResponseDataB64).Name}");
                        b64Json = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ImageResponseDataUrl), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ImageResponseDataUrl> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ImageResponseDataUrl).Name}");
                        url = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (b64Json == null && url == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ImageResponseDataB64), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ImageResponseDataB64> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ImageResponseDataB64).Name}");
                    b64Json = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ImageResponseDataUrl), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ImageResponseDataUrl> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ImageResponseDataUrl).Name}");
                    url = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Together.DataItem3(
                b64Json,

                url
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Together.DataItem3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsB64Json)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ImageResponseDataB64), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ImageResponseDataB64?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ImageResponseDataB64).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.B64Json!, typeInfo);
            }
            else if (value.IsUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.ImageResponseDataUrl), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.ImageResponseDataUrl?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.ImageResponseDataUrl).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Url!, typeInfo);
            }
        }
    }
}