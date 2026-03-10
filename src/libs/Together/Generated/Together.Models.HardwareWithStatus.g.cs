
#nullable enable

namespace Together
{
    /// <summary>
    /// Hardware configuration details with optional availability status
    /// </summary>
    public sealed partial class HardwareWithStatus
    {
        /// <summary>
        /// The object type, which is always `hardware`.
        /// </summary>
        /// <default>"hardware"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "hardware";

        /// <summary>
        /// Unique identifier for the hardware configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Pricing details for using an endpoint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.EndpointPricing Pricing { get; set; }

        /// <summary>
        /// Detailed specifications of a hardware configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("specs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.HardwareSpec Specs { get; set; }

        /// <summary>
        /// Indicates the current availability status of a hardware configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("availability")]
        public global::Together.HardwareAvailability? Availability { get; set; }

        /// <summary>
        /// Timestamp of when the hardware status was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HardwareWithStatus" /> class.
        /// </summary>
        /// <param name="object">
        /// The object type, which is always `hardware`.
        /// </param>
        /// <param name="id">
        /// Unique identifier for the hardware configuration
        /// </param>
        /// <param name="pricing">
        /// Pricing details for using an endpoint
        /// </param>
        /// <param name="specs">
        /// Detailed specifications of a hardware configuration
        /// </param>
        /// <param name="availability">
        /// Indicates the current availability status of a hardware configuration
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp of when the hardware status was last updated
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HardwareWithStatus(
            string id,
            global::Together.EndpointPricing pricing,
            global::Together.HardwareSpec specs,
            global::System.DateTime updatedAt,
            global::Together.HardwareAvailability? availability,
            string @object = "hardware")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Pricing = pricing ?? throw new global::System.ArgumentNullException(nameof(pricing));
            this.Specs = specs ?? throw new global::System.ArgumentNullException(nameof(specs));
            this.UpdatedAt = updatedAt;
            this.Object = @object;
            this.Availability = availability;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HardwareWithStatus" /> class.
        /// </summary>
        public HardwareWithStatus()
        {
        }
    }
}