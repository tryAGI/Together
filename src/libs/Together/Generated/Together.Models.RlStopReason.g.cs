
#nullable enable

namespace Together
{
    /// <summary>
    /// Reason generation stopped.
    /// </summary>
    public enum RlStopReason
    {
        /// <summary>
        ///
        /// </summary>
        StopReasonLength,
        /// <summary>
        ///
        /// </summary>
        StopReasonStop,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RlStopReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RlStopReason value)
        {
            return value switch
            {
                RlStopReason.StopReasonLength => "STOP_REASON_LENGTH",
                RlStopReason.StopReasonStop => "STOP_REASON_STOP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RlStopReason? ToEnum(string value)
        {
            return value switch
            {
                "STOP_REASON_LENGTH" => RlStopReason.StopReasonLength,
                "STOP_REASON_STOP" => RlStopReason.StopReasonStop,
                _ => null,
            };
        }
    }
}