
#nullable enable

namespace Together
{
    /// <summary>
    /// Price and duration estimate for a quantization job.
    /// </summary>
    public sealed partial class QuantizationEstimate
    {
        /// <summary>
        /// Expected total run cost in US dollars.<br/>
        /// Example: 28.76
        /// </summary>
        /// <example>28.76</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("price_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PriceUsd { get; set; }

        /// <summary>
        /// Expected wall-clock run time in hours, excluding queue time.<br/>
        /// Example: 4
        /// </summary>
        /// <example>4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_hours")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TimeHours { get; set; }

        /// <summary>
        /// Project credit limit in US dollars.<br/>
        /// Example: 500
        /// </summary>
        /// <example>500</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("credit_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreditLimit { get; set; }

        /// <summary>
        /// Whether a create request at this price would be accepted.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_to_proceed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AllowedToProceed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QuantizationEstimate" /> class.
        /// </summary>
        /// <param name="priceUsd">
        /// Expected total run cost in US dollars.<br/>
        /// Example: 28.76
        /// </param>
        /// <param name="timeHours">
        /// Expected wall-clock run time in hours, excluding queue time.<br/>
        /// Example: 4
        /// </param>
        /// <param name="creditLimit">
        /// Project credit limit in US dollars.<br/>
        /// Example: 500
        /// </param>
        /// <param name="allowedToProceed">
        /// Whether a create request at this price would be accepted.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QuantizationEstimate(
            double priceUsd,
            double timeHours,
            double creditLimit,
            bool allowedToProceed)
        {
            this.PriceUsd = priceUsd;
            this.TimeHours = timeHours;
            this.CreditLimit = creditLimit;
            this.AllowedToProceed = allowedToProceed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuantizationEstimate" /> class.
        /// </summary>
        public QuantizationEstimate()
        {
        }

    }
}