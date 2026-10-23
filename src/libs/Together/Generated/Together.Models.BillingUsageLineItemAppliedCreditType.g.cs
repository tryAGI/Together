
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public enum BillingUsageLineItemAppliedCreditType
    {
        /// <summary>
        ///
        /// </summary>
        Credit,
        /// <summary>
        ///
        /// </summary>
        Postpaid,
        /// <summary>
        ///
        /// </summary>
        Prepaid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BillingUsageLineItemAppliedCreditTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BillingUsageLineItemAppliedCreditType value)
        {
            return value switch
            {
                BillingUsageLineItemAppliedCreditType.Credit => "CREDIT",
                BillingUsageLineItemAppliedCreditType.Postpaid => "POSTPAID",
                BillingUsageLineItemAppliedCreditType.Prepaid => "PREPAID",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BillingUsageLineItemAppliedCreditType? ToEnum(string value)
        {
            return value switch
            {
                "CREDIT" => BillingUsageLineItemAppliedCreditType.Credit,
                "POSTPAID" => BillingUsageLineItemAppliedCreditType.Postpaid,
                "PREPAID" => BillingUsageLineItemAppliedCreditType.Prepaid,
                _ => null,
            };
        }
    }
}