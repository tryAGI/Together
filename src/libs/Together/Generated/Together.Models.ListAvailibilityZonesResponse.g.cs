
#nullable enable

namespace Together
{
    /// <summary>
    /// List of unique availability zones
    /// </summary>
    public sealed partial class ListAvailibilityZonesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avzones")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Avzones { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAvailibilityZonesResponse" /> class.
        /// </summary>
        /// <param name="avzones"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAvailibilityZonesResponse(
            global::System.Collections.Generic.IList<string> avzones)
        {
            this.Avzones = avzones ?? throw new global::System.ArgumentNullException(nameof(avzones));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAvailibilityZonesResponse" /> class.
        /// </summary>
        public ListAvailibilityZonesResponse()
        {
        }
    }
}