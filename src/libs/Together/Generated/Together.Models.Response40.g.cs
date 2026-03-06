
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Response40
    {
        /// <summary>
        /// Whether the user is allowed to proceed with the fine-tuning job<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_to_proceed")]
        public bool? AllowedToProceed { get; set; }

        /// <summary>
        /// The estimated number of tokens for evaluation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_eval_token_count")]
        public double? EstimatedEvalTokenCount { get; set; }

        /// <summary>
        /// The price of the fine-tuning job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_total_price")]
        public double? EstimatedTotalPrice { get; set; }

        /// <summary>
        /// The estimated number of tokens to be trained
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_train_token_count")]
        public double? EstimatedTrainTokenCount { get; set; }

        /// <summary>
        /// The user's credit limit in dollars
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_limit")]
        public double? UserLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Response40" /> class.
        /// </summary>
        /// <param name="allowedToProceed">
        /// Whether the user is allowed to proceed with the fine-tuning job<br/>
        /// Example: true
        /// </param>
        /// <param name="estimatedEvalTokenCount">
        /// The estimated number of tokens for evaluation
        /// </param>
        /// <param name="estimatedTotalPrice">
        /// The price of the fine-tuning job
        /// </param>
        /// <param name="estimatedTrainTokenCount">
        /// The estimated number of tokens to be trained
        /// </param>
        /// <param name="userLimit">
        /// The user's credit limit in dollars
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Response40(
            bool? allowedToProceed,
            double? estimatedEvalTokenCount,
            double? estimatedTotalPrice,
            double? estimatedTrainTokenCount,
            double? userLimit)
        {
            this.AllowedToProceed = allowedToProceed;
            this.EstimatedEvalTokenCount = estimatedEvalTokenCount;
            this.EstimatedTotalPrice = estimatedTotalPrice;
            this.EstimatedTrainTokenCount = estimatedTrainTokenCount;
            this.UserLimit = userLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Response40" /> class.
        /// </summary>
        public Response40()
        {
        }
    }
}