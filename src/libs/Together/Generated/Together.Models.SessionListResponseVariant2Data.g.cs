
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionListResponseVariant2Data
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Together.SessionListResponseVariant2DataSession> Sessions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionListResponseVariant2Data" /> class.
        /// </summary>
        /// <param name="sessions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionListResponseVariant2Data(
            global::System.Collections.Generic.IList<global::Together.SessionListResponseVariant2DataSession> sessions)
        {
            this.Sessions = sessions ?? throw new global::System.ArgumentNullException(nameof(sessions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionListResponseVariant2Data" /> class.
        /// </summary>
        public SessionListResponseVariant2Data()
        {
        }
    }
}