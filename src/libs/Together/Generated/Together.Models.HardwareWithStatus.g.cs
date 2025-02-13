
#nullable enable

namespace Together
{
    /// <summary>
    /// Hardware configuration details with optional availability status
    /// </summary>
    public sealed partial class HardwareWithStatus
    {
        /// <summary>
        /// Indicates the current availability status of a hardware configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("availability")]
        public global::Together.HardwareAvailability? Availability { get; set; }

        /// <summary>
        /// Unique identifier for the hardware configuration<br/>
        /// Example: 2x_nvidia_a100_80gb_sxm
        /// </summary>
        /// <example>2x_nvidia_a100_80gb_sxm</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.HardwareWithStatusObjectJsonConverter))]
        public global::Together.HardwareWithStatusObject Object { get; set; }

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
        /// <param name="availability">
        /// Indicates the current availability status of a hardware configuration
        /// </param>
        /// <param name="id">
        /// Unique identifier for the hardware configuration<br/>
        /// Example: 2x_nvidia_a100_80gb_sxm
        /// </param>
        /// <param name="object"></param>
        /// <param name="pricing">
        /// Pricing details for using an endpoint
        /// </param>
        /// <param name="specs">
        /// Detailed specifications of a hardware configuration
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
            global::Together.HardwareWithStatusObject @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Pricing = pricing ?? throw new global::System.ArgumentNullException(nameof(pricing));
            this.Specs = specs ?? throw new global::System.ArgumentNullException(nameof(specs));
            this.UpdatedAt = updatedAt;
            this.Availability = availability;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HardwareWithStatus" /> class.
        /// </summary>
        public HardwareWithStatus()
        {
        }
    }
}