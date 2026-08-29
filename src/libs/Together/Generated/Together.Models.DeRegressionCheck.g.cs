
#nullable enable

namespace Together
{
    /// <summary>
    /// Regression criteria that fail when the target regresses against the source beyond a limit.
    /// </summary>
    public sealed partial class DeRegressionCheck
    {
        /// <summary>
        /// Required maximum allowed regression percentage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxRegressionPercent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaxRegressionPercent { get; set; }

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
        /// <param name="maxRegressionPercent">
        /// Required maximum allowed regression percentage.
        /// </param>
        /// <param name="direction">
        /// Required direction that indicates whether higher or lower metric values are worse.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeRegressionCheck(
            double maxRegressionPercent,
            global::Together.DeRegressionCheckDirection direction)
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