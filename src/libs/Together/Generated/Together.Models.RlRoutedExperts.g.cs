
#nullable enable

namespace Together
{
    /// <summary>
    /// Mixture-of-experts routing decisions captured while generating, so training can reuse the same expert selection. Exactly one source is set—legacy inline `data`, or a backend-owned `object_uri` that the manager hydrates before training. The contiguous int32 buffer is reshaped by `shape`, which is always `[num_tokens, num_layers, width]`; packed buffers carry fp32-bitcast routing weights in the trailing top-k columns.
    /// </summary>
    public sealed partial class RlRoutedExperts
    {
        /// <summary>
        /// Legacy base64-encoded contiguous int32 routing buffer, row-major over (token, layer, width).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public byte[]? Data { get; set; }

        /// <summary>
        /// Backend-owned S3/R2 object URI containing the contiguous int32 routing buffer. Clients relay this URI unchanged; the manager validates and downloads it before training.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_uri")]
        public string? ObjectUri { get; set; }

        /// <summary>
        /// Buffer shape as `[num_tokens, num_layers, width]`.<br/>
        /// Example: [512, 64, 8]
        /// </summary>
        /// <example>[512, 64, 8]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("shape")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.OneOf<string, int?>> Shape { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlRoutedExperts" /> class.
        /// </summary>
        /// <param name="shape">
        /// Buffer shape as `[num_tokens, num_layers, width]`.<br/>
        /// Example: [512, 64, 8]
        /// </param>
        /// <param name="data">
        /// Legacy base64-encoded contiguous int32 routing buffer, row-major over (token, layer, width).
        /// </param>
        /// <param name="objectUri">
        /// Backend-owned S3/R2 object URI containing the contiguous int32 routing buffer. Clients relay this URI unchanged; the manager validates and downloads it before training.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlRoutedExperts(
            global::System.Collections.Generic.IList<global::Together.OneOf<string, int?>> shape,
            byte[]? data,
            string? objectUri)
        {
            this.Data = data;
            this.ObjectUri = objectUri;
            this.Shape = shape ?? throw new global::System.ArgumentNullException(nameof(shape));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlRoutedExperts" /> class.
        /// </summary>
        public RlRoutedExperts()
        {
        }

    }
}