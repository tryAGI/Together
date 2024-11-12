
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FinetuneListEvents
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.FineTuneEvent> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetuneListEvents" /> class.
        /// </summary>
        /// <param name="data"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public FinetuneListEvents(
            global::System.Collections.Generic.IList<global::Together.FineTuneEvent> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetuneListEvents" /> class.
        /// </summary>
        public FinetuneListEvents()
        {
        }
    }
}