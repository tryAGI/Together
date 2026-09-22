
#nullable enable

namespace Together
{
    /// <summary>
    /// Serverless token pricing for a supported model.
    /// </summary>
    public sealed partial class DeSupportedModelPricing
    {
        /// <summary>
        /// Price in USD per one million input tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public double? Input { get; set; }

        /// <summary>
        /// Price in USD per one million output tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public double? Output { get; set; }

        /// <summary>
        /// Price in USD per one million cached input tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cachedInput")]
        public double? CachedInput { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeSupportedModelPricing" /> class.
        /// </summary>
        /// <param name="input">
        /// Price in USD per one million input tokens.
        /// </param>
        /// <param name="output">
        /// Price in USD per one million output tokens.
        /// </param>
        /// <param name="cachedInput">
        /// Price in USD per one million cached input tokens.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeSupportedModelPricing(
            double? input,
            double? output,
            double? cachedInput)
        {
            this.Input = input;
            this.Output = output;
            this.CachedInput = cachedInput;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeSupportedModelPricing" /> class.
        /// </summary>
        public DeSupportedModelPricing()
        {
        }

    }
}