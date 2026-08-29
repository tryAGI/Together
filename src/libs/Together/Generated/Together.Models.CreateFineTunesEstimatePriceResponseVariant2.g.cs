
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateFineTunesEstimatePriceResponseVariant2
    {
        /// <summary>
        /// Whether price estimation is available for the requested fine-tune job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimation_available")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool EstimationAvailable { get; set; }

        /// <summary>
        /// Reason price estimation is unavailable for the requested fine-tune job.<br/>
        /// Example: multimodal_dataset
        /// </summary>
        /// <example>multimodal_dataset</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("unavailable_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.CreateFineTunesEstimatePriceResponseVariant2UnavailableReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.CreateFineTunesEstimatePriceResponseVariant2UnavailableReason UnavailableReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFineTunesEstimatePriceResponseVariant2" /> class.
        /// </summary>
        /// <param name="estimationAvailable">
        /// Whether price estimation is available for the requested fine-tune job.
        /// </param>
        /// <param name="unavailableReason">
        /// Reason price estimation is unavailable for the requested fine-tune job.<br/>
        /// Example: multimodal_dataset
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateFineTunesEstimatePriceResponseVariant2(
            bool estimationAvailable,
            global::Together.CreateFineTunesEstimatePriceResponseVariant2UnavailableReason unavailableReason)
        {
            this.EstimationAvailable = estimationAvailable;
            this.UnavailableReason = unavailableReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFineTunesEstimatePriceResponseVariant2" /> class.
        /// </summary>
        public CreateFineTunesEstimatePriceResponseVariant2()
        {
        }

    }
}