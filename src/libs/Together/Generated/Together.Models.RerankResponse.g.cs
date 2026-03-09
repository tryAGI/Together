
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RerankResponse
    {
        /// <summary>
        /// The object type, which is always `rerank`.
        /// </summary>
        /// <default>"rerank"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Object { get; set; } = "rerank";

        /// <summary>
        /// Request ID<br/>
        /// Example: 9dfa1a09-5ebc-4a40-970f-586cb8f4ae47
        /// </summary>
        /// <example>9dfa1a09-5ebc-4a40-970f-586cb8f4ae47</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The model to be used for the rerank request.<br/>
        /// Example: salesforce/turboranker-0.8-3778-6328
        /// </summary>
        /// <example>salesforce/turboranker-0.8-3778-6328</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Example: [{"index":0,"relevance_score":0.29980177813003117,"document":{"text":"{\u0022title\u0022:\u0022Llama\u0022,\u0022text\u0022:\u0022The llama is a domesticated South American camelid, widely used as a meat and pack animal by Andean cultures since the pre-Columbian era.\u0022}"}}, {"index":2,"relevance_score":0.2752447527354349,"document":{"text":"{\u0022title\u0022:\u0022Guanaco\u0022,\u0022text\u0022:\u0022The guanaco is a camelid native to South America, closely related to the llama. Guanacos are one of two wild South American camelids; the other species is the vicu\u00F1a, which lives at higher elevations.\u0022}"}}]
        /// </summary>
        /// <example>[{"index":0,"relevance_score":0.29980177813003117,"document":{"text":"{\u0022title\u0022:\u0022Llama\u0022,\u0022text\u0022:\u0022The llama is a domesticated South American camelid, widely used as a meat and pack animal by Andean cultures since the pre-Columbian era.\u0022}"}}, {"index":2,"relevance_score":0.2752447527354349,"document":{"text":"{\u0022title\u0022:\u0022Guanaco\u0022,\u0022text\u0022:\u0022The guanaco is a camelid native to South America, closely related to the llama. Guanacos are one of two wild South American camelids; the other species is the vicu\u00F1a, which lives at higher elevations.\u0022}"}}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.RerankResponseResult> Results { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::Together.UsageData? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankResponse" /> class.
        /// </summary>
        /// <param name="object">
        /// The object type, which is always `rerank`.
        /// </param>
        /// <param name="id">
        /// Request ID<br/>
        /// Example: 9dfa1a09-5ebc-4a40-970f-586cb8f4ae47
        /// </param>
        /// <param name="model">
        /// The model to be used for the rerank request.<br/>
        /// Example: salesforce/turboranker-0.8-3778-6328
        /// </param>
        /// <param name="results">
        /// Example: [{"index":0,"relevance_score":0.29980177813003117,"document":{"text":"{\u0022title\u0022:\u0022Llama\u0022,\u0022text\u0022:\u0022The llama is a domesticated South American camelid, widely used as a meat and pack animal by Andean cultures since the pre-Columbian era.\u0022}"}}, {"index":2,"relevance_score":0.2752447527354349,"document":{"text":"{\u0022title\u0022:\u0022Guanaco\u0022,\u0022text\u0022:\u0022The guanaco is a camelid native to South America, closely related to the llama. Guanacos are one of two wild South American camelids; the other species is the vicu\u00F1a, which lives at higher elevations.\u0022}"}}]
        /// </param>
        /// <param name="usage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RerankResponse(
            string @object,
            string model,
            global::System.Collections.Generic.IList<global::Together.RerankResponseResult> results,
            string? id,
            global::Together.UsageData? usage)
        {
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Id = id;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankResponse" /> class.
        /// </summary>
        public RerankResponse()
        {
        }
    }
}