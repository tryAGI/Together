
#nullable enable

namespace Together
{
    /// <summary>
    /// S3 source configuration for volume sync.
    /// </summary>
    public sealed partial class S3Origin
    {
        /// <summary>
        /// IAM role ARN Together assumes to read the S3 bucket or prefix.<br/>
        /// Example: arn:aws:iam::123456789012:role/together-volumes
        /// </summary>
        /// <example>arn:aws:iam::123456789012:role/together-volumes</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_arn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoleArn { get; set; }

        /// <summary>
        /// S3 bucket or prefix to copy into the volume.<br/>
        /// Example: s3://my-bucket/models/custom-weights
        /// </summary>
        /// <example>s3://my-bucket/models/custom-weights</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="S3Origin" /> class.
        /// </summary>
        /// <param name="roleArn">
        /// IAM role ARN Together assumes to read the S3 bucket or prefix.<br/>
        /// Example: arn:aws:iam::123456789012:role/together-volumes
        /// </param>
        /// <param name="uri">
        /// S3 bucket or prefix to copy into the volume.<br/>
        /// Example: s3://my-bucket/models/custom-weights
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public S3Origin(
            string roleArn,
            string uri)
        {
            this.RoleArn = roleArn ?? throw new global::System.ArgumentNullException(nameof(roleArn));
            this.Uri = uri ?? throw new global::System.ArgumentNullException(nameof(uri));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="S3Origin" /> class.
        /// </summary>
        public S3Origin()
        {
        }

    }
}