
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrainingMethodSFT
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.TrainingMethodSFTMethodJsonConverter))]
        public global::Together.TrainingMethodSFTMethod Method { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingMethodSFT" /> class.
        /// </summary>
        /// <param name="method"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrainingMethodSFT(
            global::Together.TrainingMethodSFTMethod method)
        {
            this.Method = method;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingMethodSFT" /> class.
        /// </summary>
        public TrainingMethodSFT()
        {
        }
    }
}