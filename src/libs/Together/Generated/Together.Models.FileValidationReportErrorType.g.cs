
#nullable enable

namespace Together
{
    /// <summary>
    /// Category of validation failure.
    /// </summary>
    public enum FileValidationReportErrorType
    {
        /// <summary>
        ///
        /// </summary>
        InvalidFormat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileValidationReportErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileValidationReportErrorType value)
        {
            return value switch
            {
                FileValidationReportErrorType.InvalidFormat => "INVALID_FORMAT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileValidationReportErrorType? ToEnum(string value)
        {
            return value switch
            {
                "INVALID_FORMAT" => FileValidationReportErrorType.InvalidFormat,
                _ => null,
            };
        }
    }
}