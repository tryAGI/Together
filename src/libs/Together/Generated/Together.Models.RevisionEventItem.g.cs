
#nullable enable

namespace Together
{
    /// <summary>
    /// One entry in a deployment's revision history.
    /// </summary>
    public sealed partial class RevisionEventItem
    {
        /// <summary>
        /// The object type, which is always `revision_event`.
        /// </summary>
        /// <default>"revision_event"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "revision_event";

        /// <summary>
        /// Monotonic event number in the deployment's revision history.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EventNumber { get; set; }

        /// <summary>
        /// Revision ID activated by this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RevisionId { get; set; }

        /// <summary>
        /// Human-readable per-deployment revision counter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RevisionNumber { get; set; }

        /// <summary>
        /// Container image of the revision activated by this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Image { get; set; }

        /// <summary>
        /// How this revision became active.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.RevisionEventItemActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.RevisionEventItemAction Action { get; set; }

        /// <summary>
        /// Time when this revision became active.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ActivatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RevisionEventItem" /> class.
        /// </summary>
        /// <param name="eventNumber">
        /// Monotonic event number in the deployment's revision history.
        /// </param>
        /// <param name="revisionId">
        /// Revision ID activated by this event.
        /// </param>
        /// <param name="revisionNumber">
        /// Human-readable per-deployment revision counter.
        /// </param>
        /// <param name="image">
        /// Container image of the revision activated by this event.
        /// </param>
        /// <param name="action">
        /// How this revision became active.
        /// </param>
        /// <param name="activatedAt">
        /// Time when this revision became active.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `revision_event`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RevisionEventItem(
            int eventNumber,
            string revisionId,
            int revisionNumber,
            string image,
            global::Together.RevisionEventItemAction action,
            global::System.DateTime activatedAt,
            string @object = "revision_event")
        {
            this.Object = @object;
            this.EventNumber = eventNumber;
            this.RevisionId = revisionId ?? throw new global::System.ArgumentNullException(nameof(revisionId));
            this.RevisionNumber = revisionNumber;
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Action = action;
            this.ActivatedAt = activatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RevisionEventItem" /> class.
        /// </summary>
        public RevisionEventItem()
        {
        }

    }
}