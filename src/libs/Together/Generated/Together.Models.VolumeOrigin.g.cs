
#nullable enable

namespace Together
{
    /// <summary>
    /// External source Together copies into a new volume version.
    /// </summary>
    public sealed partial class VolumeOrigin
    {
        /// <summary>
        /// S3 bucket or prefix source for the volume sync.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("s3")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.S3Origin S3 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeOrigin" /> class.
        /// </summary>
        /// <param name="s3">
        /// S3 bucket or prefix source for the volume sync.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VolumeOrigin(
            global::Together.S3Origin s3)
        {
            this.S3 = s3 ?? throw new global::System.ArgumentNullException(nameof(s3));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeOrigin" /> class.
        /// </summary>
        public VolumeOrigin()
        {
        }

    }
}