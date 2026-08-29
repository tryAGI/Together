
#nullable enable

namespace Together
{
    /// <summary>
    /// Current validation status for the revision.
    /// </summary>
    public enum DeListRevisionsResponseRevisionValidationStatus
    {
        /// <summary>
        ///
        /// </summary>
        RevisionValidationStatusError,
        /// <summary>
        ///
        /// </summary>
        RevisionValidationStatusFailed,
        /// <summary>
        ///
        /// </summary>
        RevisionValidationStatusPending,
        /// <summary>
        ///
        /// </summary>
        RevisionValidationStatusSuccess,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeListRevisionsResponseRevisionValidationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeListRevisionsResponseRevisionValidationStatus value)
        {
            return value switch
            {
                DeListRevisionsResponseRevisionValidationStatus.RevisionValidationStatusError => "REVISION_VALIDATION_STATUS_ERROR",
                DeListRevisionsResponseRevisionValidationStatus.RevisionValidationStatusFailed => "REVISION_VALIDATION_STATUS_FAILED",
                DeListRevisionsResponseRevisionValidationStatus.RevisionValidationStatusPending => "REVISION_VALIDATION_STATUS_PENDING",
                DeListRevisionsResponseRevisionValidationStatus.RevisionValidationStatusSuccess => "REVISION_VALIDATION_STATUS_SUCCESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeListRevisionsResponseRevisionValidationStatus? ToEnum(string value)
        {
            return value switch
            {
                "REVISION_VALIDATION_STATUS_ERROR" => DeListRevisionsResponseRevisionValidationStatus.RevisionValidationStatusError,
                "REVISION_VALIDATION_STATUS_FAILED" => DeListRevisionsResponseRevisionValidationStatus.RevisionValidationStatusFailed,
                "REVISION_VALIDATION_STATUS_PENDING" => DeListRevisionsResponseRevisionValidationStatus.RevisionValidationStatusPending,
                "REVISION_VALIDATION_STATUS_SUCCESS" => DeListRevisionsResponseRevisionValidationStatus.RevisionValidationStatusSuccess,
                _ => null,
            };
        }
    }
}