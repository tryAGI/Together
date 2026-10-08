
#nullable enable

namespace Together
{
    /// <summary>
    /// List response containing shaping jobs.
    /// </summary>
    public sealed partial class ShapingJobsList
    {
        /// <summary>
        /// Shaping jobs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.QuantizationJob> Data { get; set; }

        /// <summary>
        /// Object type, always `list`.
        /// </summary>
        /// <default>"list"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "list";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShapingJobsList" /> class.
        /// </summary>
        /// <param name="data">
        /// Shaping jobs.
        /// </param>
        /// <param name="object">
        /// Object type, always `list`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ShapingJobsList(
            global::System.Collections.Generic.IList<global::Together.QuantizationJob> data,
            string @object = "list")
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShapingJobsList" /> class.
        /// </summary>
        public ShapingJobsList()
        {
        }

    }
}