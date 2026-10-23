
#nullable enable

namespace Together
{
    /// <summary>
    /// Credit covering this usage. Omitted for uncovered usage.
    /// </summary>
    public sealed partial class BillingUsageLineItemAppliedCredit
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.BillingUsageLineItemAppliedCreditTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.BillingUsageLineItemAppliedCreditType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingUsageLineItemAppliedCredit" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingUsageLineItemAppliedCredit(
            global::Together.BillingUsageLineItemAppliedCreditType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingUsageLineItemAppliedCredit" /> class.
        /// </summary>
        public BillingUsageLineItemAppliedCredit()
        {
        }

    }
}