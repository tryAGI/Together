
#nullable enable

namespace Together
{
    /// <summary>
    /// Optional cancel behavior. Absent defaults to freeze, which preserves the current traffic split. Revert is removed and rejected with FAILED_PRECONDITION; cancel with freeze, then run a reverse rollout back to the source.
    /// </summary>
    public enum DeCancelRolloutRequestDisposition
    {
        /// <summary>
        ///
        /// </summary>
        CancelDispositionFreeze,
        /// <summary>
        ///
        /// </summary>
        CancelDispositionRevert,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeCancelRolloutRequestDispositionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeCancelRolloutRequestDisposition value)
        {
            return value switch
            {
                DeCancelRolloutRequestDisposition.CancelDispositionFreeze => "CANCEL_DISPOSITION_FREEZE",
                DeCancelRolloutRequestDisposition.CancelDispositionRevert => "CANCEL_DISPOSITION_REVERT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeCancelRolloutRequestDisposition? ToEnum(string value)
        {
            return value switch
            {
                "CANCEL_DISPOSITION_FREEZE" => DeCancelRolloutRequestDisposition.CancelDispositionFreeze,
                "CANCEL_DISPOSITION_REVERT" => DeCancelRolloutRequestDisposition.CancelDispositionRevert,
                _ => null,
            };
        }
    }
}