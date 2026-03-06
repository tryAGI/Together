
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InstanceTypesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("types")]
        public global::System.Collections.Generic.IList<global::Together.InstanceTypesResponseType>? Types { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceTypesResponse" /> class.
        /// </summary>
        /// <param name="types"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InstanceTypesResponse(
            global::System.Collections.Generic.IList<global::Together.InstanceTypesResponseType>? types)
        {
            this.Types = types;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceTypesResponse" /> class.
        /// </summary>
        public InstanceTypesResponse()
        {
        }
    }
}