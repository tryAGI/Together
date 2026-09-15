
#nullable enable

namespace Together
{
    /// <summary>
    /// Regression criteria that fail when the target regresses against the source beyond a limit.
    /// </summary>
    public sealed partial class DeRegressionCheck
    {
        /// <summary>
        /// Finite maximum allowed regression percentage, greater than or equal to 0. Omitting this value is read as 0. A value of 0 is the strictest budget; any regression fails, and exactly-at-budget passes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxRegressionPercent")]
        public double? MaxRegressionPercent { get; set; }

        /// <summary>
        /// Required direction that indicates whether higher or lower metric values are worse.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeRegressionCheckDirectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.DeRegressionCheckDirection Direction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeRegressionCheck" /> class.
        /// </summary>
        /// <param name="direction">
        /// Required direction that indicates whether higher or lower metric values are worse.
        /// </param>
        /// <param name="maxRegressionPercent">
        /// Finite maximum allowed regression percentage, greater than or equal to 0. Omitting this value is read as 0. A value of 0 is the strictest budget; any regression fails, and exactly-at-budget passes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeRegressionCheck(
            global::Together.DeRegressionCheckDirection direction,
            double? maxRegressionPercent)
        {
            this.MaxRegressionPercent = maxRegressionPercent;
            this.Direction = direction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeRegressionCheck" /> class.
        /// </summary>
        public DeRegressionCheck()
        {
        }

    }
}