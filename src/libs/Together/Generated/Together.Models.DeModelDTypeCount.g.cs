
#nullable enable

namespace Together
{
    /// <summary>
    /// Number of model parameters stored in one numerical data type.
    /// </summary>
    public sealed partial class DeModelDTypeCount
    {
        /// <summary>
        /// Numerical data type, such as `float16`, `bfloat16`, or `int8`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dtype")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Dtype { get; set; }

        /// <summary>
        /// Number of model parameters stored with this data type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeModelDTypeCount" /> class.
        /// </summary>
        /// <param name="dtype">
        /// Numerical data type, such as `float16`, `bfloat16`, or `int8`.
        /// </param>
        /// <param name="count">
        /// Number of model parameters stored with this data type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeModelDTypeCount(
            string dtype,
            string count)
        {
            this.Dtype = dtype ?? throw new global::System.ArgumentNullException(nameof(dtype));
            this.Count = count ?? throw new global::System.ArgumentNullException(nameof(count));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeModelDTypeCount" /> class.
        /// </summary>
        public DeModelDTypeCount()
        {
        }

    }
}