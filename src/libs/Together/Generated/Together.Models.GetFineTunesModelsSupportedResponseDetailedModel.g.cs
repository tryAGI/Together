
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetFineTunesModelsSupportedResponseDetailedModel
    {
        /// <summary>
        /// Supported model name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Parent model used for fine-tuning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ParentModel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFineTunesModelsSupportedResponseDetailedModel" /> class.
        /// </summary>
        /// <param name="name">
        /// Supported model name.
        /// </param>
        /// <param name="parentModel">
        /// Parent model used for fine-tuning.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetFineTunesModelsSupportedResponseDetailedModel(
            string name,
            string parentModel)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ParentModel = parentModel ?? throw new global::System.ArgumentNullException(nameof(parentModel));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFineTunesModelsSupportedResponseDetailedModel" /> class.
        /// </summary>
        public GetFineTunesModelsSupportedResponseDetailedModel()
        {
        }

    }
}