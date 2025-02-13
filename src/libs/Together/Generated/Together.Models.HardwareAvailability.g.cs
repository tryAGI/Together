
#nullable enable

namespace Together
{
    /// <summary>
    /// Indicates the current availability status of a hardware configuration
    /// </summary>
    public sealed partial class HardwareAvailability
    {
        /// <summary>
        /// The availability status of the hardware configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.HardwareAvailabilityStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Together.HardwareAvailabilityStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HardwareAvailability" /> class.
        /// </summary>
        /// <param name="status">
        /// The availability status of the hardware configuration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HardwareAvailability(
            global::Together.HardwareAvailabilityStatus status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HardwareAvailability" /> class.
        /// </summary>
        public HardwareAvailability()
        {
        }
    }
}