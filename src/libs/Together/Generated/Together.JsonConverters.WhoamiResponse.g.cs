#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Together.JsonConverters
{
    /// <inheritdoc />
    public class WhoamiResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Together.WhoamiResponse>
    {
        /// <inheritdoc />
        public override global::Together.WhoamiResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.WhoamiResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.WhoamiResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Together.WhoamiResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Together.WhoamiProjectApiKey? projectApiKey = default;
            if (discriminator?.Type == global::Together.WhoamiResponseDiscriminatorType.ProjectApiKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.WhoamiProjectApiKey), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.WhoamiProjectApiKey> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Together.WhoamiProjectApiKey)}");
                projectApiKey = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Together.WhoamiOrgApiKey? orgApiKey = default;
            if (discriminator?.Type == global::Together.WhoamiResponseDiscriminatorType.OrgApiKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.WhoamiOrgApiKey), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.WhoamiOrgApiKey> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Together.WhoamiOrgApiKey)}");
                orgApiKey = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Together.WhoamiUserJwt? userJwt = default;
            if (discriminator?.Type == global::Together.WhoamiResponseDiscriminatorType.UserJwt)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.WhoamiUserJwt), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.WhoamiUserJwt> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Together.WhoamiUserJwt)}");
                userJwt = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Together.WhoamiUserOrgJwt? userOrgJwt = default;
            if (discriminator?.Type == global::Together.WhoamiResponseDiscriminatorType.UserOrgJwt)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.WhoamiUserOrgJwt), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.WhoamiUserOrgJwt> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Together.WhoamiUserOrgJwt)}");
                userOrgJwt = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Together.WhoamiUserOrgProjectJwt? userOrgProjectJwt = default;
            if (discriminator?.Type == global::Together.WhoamiResponseDiscriminatorType.UserOrgProjectJwt)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.WhoamiUserOrgProjectJwt), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.WhoamiUserOrgProjectJwt> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Together.WhoamiUserOrgProjectJwt)}");
                userOrgProjectJwt = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Together.WhoamiResponse(
                discriminator?.Type,
                projectApiKey,

                orgApiKey,

                userJwt,

                userOrgJwt,

                userOrgProjectJwt
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Together.WhoamiResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsProjectApiKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.WhoamiProjectApiKey), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.WhoamiProjectApiKey?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.WhoamiProjectApiKey).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickProjectApiKey(), typeInfo);
            }
            else if (value.IsOrgApiKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.WhoamiOrgApiKey), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.WhoamiOrgApiKey?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.WhoamiOrgApiKey).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOrgApiKey(), typeInfo);
            }
            else if (value.IsUserJwt)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.WhoamiUserJwt), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.WhoamiUserJwt?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.WhoamiUserJwt).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickUserJwt(), typeInfo);
            }
            else if (value.IsUserOrgJwt)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.WhoamiUserOrgJwt), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.WhoamiUserOrgJwt?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.WhoamiUserOrgJwt).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickUserOrgJwt(), typeInfo);
            }
            else if (value.IsUserOrgProjectJwt)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Together.WhoamiUserOrgProjectJwt), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Together.WhoamiUserOrgProjectJwt?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Together.WhoamiUserOrgProjectJwt).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickUserOrgProjectJwt(), typeInfo);
            }
        }
    }
}