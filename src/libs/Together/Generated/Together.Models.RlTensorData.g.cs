
#nullable enable

namespace Together
{
    /// <summary>
    /// A tensor encoded as flattened row-major values, with an optional shape.
    /// </summary>
    public sealed partial class RlTensorData
    {
        /// <summary>
        /// Flattened one-dimensional values encoded as JSON numbers.<br/>
        /// Example: [1, 2, 3]
        /// </summary>
        /// <example>[1, 2, 3]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> Data { get; set; }

        /// <summary>
        /// Tensor element type, either `int64` or `float32`.<br/>
        /// Example: int64
        /// </summary>
        /// <example>int64</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dtype")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.RlTensorDataDtypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.RlTensorDataDtype Dtype { get; set; }

        /// <summary>
        /// Optional tensor shape; training operations accept one-dimensional tensors only, and the dimension must match the data length.<br/>
        /// Example: [3]
        /// </summary>
        /// <example>[3]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("shape")]
        public global::System.Collections.Generic.IList<int>? Shape { get; set; }

        /// <summary>
        /// Reserved for Tinker schema compatibility; current training operations reject sparse tensors.<br/>
        /// Example: [0, 2]
        /// </summary>
        /// <example>[0, 2]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sparse_crow_indices")]
        public global::System.Collections.Generic.IList<int>? SparseCrowIndices { get; set; }

        /// <summary>
        /// Reserved for Tinker schema compatibility; current training operations reject sparse tensors.<br/>
        /// Example: [0, 2]
        /// </summary>
        /// <example>[0, 2]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sparse_col_indices")]
        public global::System.Collections.Generic.IList<int>? SparseColIndices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RlTensorData" /> class.
        /// </summary>
        /// <param name="data">
        /// Flattened one-dimensional values encoded as JSON numbers.<br/>
        /// Example: [1, 2, 3]
        /// </param>
        /// <param name="dtype">
        /// Tensor element type, either `int64` or `float32`.<br/>
        /// Example: int64
        /// </param>
        /// <param name="shape">
        /// Optional tensor shape; training operations accept one-dimensional tensors only, and the dimension must match the data length.<br/>
        /// Example: [3]
        /// </param>
        /// <param name="sparseCrowIndices">
        /// Reserved for Tinker schema compatibility; current training operations reject sparse tensors.<br/>
        /// Example: [0, 2]
        /// </param>
        /// <param name="sparseColIndices">
        /// Reserved for Tinker schema compatibility; current training operations reject sparse tensors.<br/>
        /// Example: [0, 2]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RlTensorData(
            global::System.Collections.Generic.IList<double> data,
            global::Together.RlTensorDataDtype dtype,
            global::System.Collections.Generic.IList<int>? shape,
            global::System.Collections.Generic.IList<int>? sparseCrowIndices,
            global::System.Collections.Generic.IList<int>? sparseColIndices)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Dtype = dtype;
            this.Shape = shape;
            this.SparseCrowIndices = sparseCrowIndices;
            this.SparseColIndices = sparseColIndices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RlTensorData" /> class.
        /// </summary>
        public RlTensorData()
        {
        }

    }
}