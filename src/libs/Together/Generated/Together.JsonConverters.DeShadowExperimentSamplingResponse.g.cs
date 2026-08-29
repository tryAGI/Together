#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Together.JsonConverters
{
    /// <inheritdoc />
    public class DeShadowExperimentSamplingResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Together.DeShadowExperimentSamplingResponse>
    {
        /// <inheritdoc />
        public override global::Together.DeShadowExperimentSamplingResponse Read(
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
            if (__jsonProps.Contains("uniform")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("keyBased")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("adaptiveUniform")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("adaptiveKeyBased")) __score3++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::Together.DeShadowExperimentSamplingResponseVariant1? deShadowExperimentSamplingResponseVariant1 = default;
            global::Together.DeShadowExperimentSamplingResponseVariant2? deShadowExperimentSamplingResponseVariant2 = default;
            global::Together.DeShadowExperimentSamplingResponseVariant3? deShadowExperimentSamplingResponseVariant3 = default;
            global::Together.DeShadowExperimentSamplingResponseVariant4? deShadowExperimentSamplingResponseVariant4 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.DeShadowExperimentSamplingResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.DeShadowExperimentSamplingResponseVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.DeShadowExperimentSamplingResponseVariant1).Name}");
                        deShadowExperimentSamplingResponseVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.DeShadowExperimentSamplingResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.DeShadowExperimentSamplingResponseVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.DeShadowExperimentSamplingResponseVariant2).Name}");
                        deShadowExperimentSamplingResponseVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.DeShadowExperimentSamplingResponseVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.DeShadowExperimentSamplingResponseVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.DeShadowExperimentSamplingResponseVariant3).Name}");
                        deShadowExperimentSamplingResponseVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.DeShadowExperimentSamplingResponseVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.DeShadowExperimentSamplingResponseVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.DeShadowExperimentSamplingResponseVariant4).Name}");
                        deShadowExperimentSamplingResponseVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (deShadowExperimentSamplingResponseVariant1 == null && deShadowExperimentSamplingResponseVariant2 == null && deShadowExperimentSamplingResponseVariant3 == null && deShadowExperimentSamplingResponseVariant4 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.DeShadowExperimentSamplingResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.DeShadowExperimentSamplingResponseVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.DeShadowExperimentSamplingResponseVariant1).Name}");
                    deShadowExperimentSamplingResponseVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (deShadowExperimentSamplingResponseVariant1 == null && deShadowExperimentSamplingResponseVariant2 == null && deShadowExperimentSamplingResponseVariant3 == null && deShadowExperimentSamplingResponseVariant4 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.DeShadowExperimentSamplingResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.DeShadowExperimentSamplingResponseVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.DeShadowExperimentSamplingResponseVariant2).Name}");
                    deShadowExperimentSamplingResponseVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (deShadowExperimentSamplingResponseVariant1 == null && deShadowExperimentSamplingResponseVariant2 == null && deShadowExperimentSamplingResponseVariant3 == null && deShadowExperimentSamplingResponseVariant4 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.DeShadowExperimentSamplingResponseVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.DeShadowExperimentSamplingResponseVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.DeShadowExperimentSamplingResponseVariant3).Name}");
                    deShadowExperimentSamplingResponseVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (deShadowExperimentSamplingResponseVariant1 == null && deShadowExperimentSamplingResponseVariant2 == null && deShadowExperimentSamplingResponseVariant3 == null && deShadowExperimentSamplingResponseVariant4 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.DeShadowExperimentSamplingResponseVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.DeShadowExperimentSamplingResponseVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.DeShadowExperimentSamplingResponseVariant4).Name}");
                    deShadowExperimentSamplingResponseVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Together.DeShadowExperimentSamplingResponse(
                deShadowExperimentSamplingResponseVariant1,

                deShadowExperimentSamplingResponseVariant2,

                deShadowExperimentSamplingResponseVariant3,

                deShadowExperimentSamplingResponseVariant4
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Together.DeShadowExperimentSamplingResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsDeShadowExperimentSamplingResponseVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.DeShadowExperimentSamplingResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.DeShadowExperimentSamplingResponseVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.DeShadowExperimentSamplingResponseVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeShadowExperimentSamplingResponseVariant1!, typeInfo);
            }
            else if (value.IsDeShadowExperimentSamplingResponseVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.DeShadowExperimentSamplingResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.DeShadowExperimentSamplingResponseVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.DeShadowExperimentSamplingResponseVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeShadowExperimentSamplingResponseVariant2!, typeInfo);
            }
            else if (value.IsDeShadowExperimentSamplingResponseVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.DeShadowExperimentSamplingResponseVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.DeShadowExperimentSamplingResponseVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.DeShadowExperimentSamplingResponseVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeShadowExperimentSamplingResponseVariant3!, typeInfo);
            }
            else if (value.IsDeShadowExperimentSamplingResponseVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.DeShadowExperimentSamplingResponseVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.DeShadowExperimentSamplingResponseVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.DeShadowExperimentSamplingResponseVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeShadowExperimentSamplingResponseVariant4!, typeInfo);
            }
        }
    }
}