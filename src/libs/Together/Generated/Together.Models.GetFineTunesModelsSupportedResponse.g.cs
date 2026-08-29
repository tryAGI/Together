
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetFineTunesModelsSupportedResponse
    {
        /// <summary>
        /// List of supported model names.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Models { get; set; }

        /// <summary>
        /// Supported models with parent model details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detailed_models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.GetFineTunesModelsSupportedResponseDetailedModel> DetailedModels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFineTunesModelsSupportedResponse" /> class.
        /// </summary>
        /// <param name="models">
        /// List of supported model names.
        /// </param>
        /// <param name="detailedModels">
        /// Supported models with parent model details.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetFineTunesModelsSupportedResponse(
            global::System.Collections.Generic.IList<string> models,
            global::System.Collections.Generic.IList<global::Together.GetFineTunesModelsSupportedResponseDetailedModel> detailedModels)
        {
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
            this.DetailedModels = detailedModels ?? throw new global::System.ArgumentNullException(nameof(detailedModels));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFineTunesModelsSupportedResponse" /> class.
        /// </summary>
        public GetFineTunesModelsSupportedResponse()
        {
        }

    }
}