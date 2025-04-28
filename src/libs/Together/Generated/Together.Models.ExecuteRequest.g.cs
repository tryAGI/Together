
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExecuteRequest
    {
        /// <summary>
        /// Code snippet to execute.<br/>
        /// Example: print('Hello, world!')
        /// </summary>
        /// <example>print('Hello, world!')</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// Files to upload to the session. If present, files will be uploaded before executing the given code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<global::Together.ExecuteRequestFile>? Files { get; set; }

        /// <summary>
        /// Programming language for the code to execute. Currently only supports Python, but more will be added.<br/>
        /// Default Value: python
        /// </summary>
        /// <default>global::Together.ExecuteRequestLanguage.Python</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.ExecuteRequestLanguageJsonConverter))]
        public global::Together.ExecuteRequestLanguage Language { get; set; } = global::Together.ExecuteRequestLanguage.Python;

        /// <summary>
        /// Identifier of the current session. Used to make follow-up calls. Requests will return an error if the session does not belong to the caller or has expired.<br/>
        /// Example: ses_abcDEF123
        /// </summary>
        /// <example>ses_abcDEF123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteRequest" /> class.
        /// </summary>
        /// <param name="code">
        /// Code snippet to execute.<br/>
        /// Example: print('Hello, world!')
        /// </param>
        /// <param name="files">
        /// Files to upload to the session. If present, files will be uploaded before executing the given code.
        /// </param>
        /// <param name="language">
        /// Programming language for the code to execute. Currently only supports Python, but more will be added.<br/>
        /// Default Value: python
        /// </param>
        /// <param name="sessionId">
        /// Identifier of the current session. Used to make follow-up calls. Requests will return an error if the session does not belong to the caller or has expired.<br/>
        /// Example: ses_abcDEF123
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecuteRequest(
            string code,
            global::System.Collections.Generic.IList<global::Together.ExecuteRequestFile>? files,
            string? sessionId,
            global::Together.ExecuteRequestLanguage language = global::Together.ExecuteRequestLanguage.Python)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Files = files;
            this.Language = language;
            this.SessionId = sessionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteRequest" /> class.
        /// </summary>
        public ExecuteRequest()
        {
        }
    }
}