
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionListResponseVariant2DataSession
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execute_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ExecuteCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Session Identifier. Used to make follow-up calls.<br/>
        /// Example: ses_abcDEF123
        /// </summary>
        /// <example>ses_abcDEF123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_execute_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastExecuteAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionListResponseVariant2DataSession" /> class.
        /// </summary>
        /// <param name="executeCount"></param>
        /// <param name="expiresAt"></param>
        /// <param name="id">
        /// Session Identifier. Used to make follow-up calls.<br/>
        /// Example: ses_abcDEF123
        /// </param>
        /// <param name="lastExecuteAt"></param>
        /// <param name="startedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionListResponseVariant2DataSession(
            int executeCount,
            global::System.DateTime expiresAt,
            string id,
            global::System.DateTime lastExecuteAt,
            global::System.DateTime startedAt)
        {
            this.ExecuteCount = executeCount;
            this.ExpiresAt = expiresAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.LastExecuteAt = lastExecuteAt;
            this.StartedAt = startedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionListResponseVariant2DataSession" /> class.
        /// </summary>
        public SessionListResponseVariant2DataSession()
        {
        }
    }
}