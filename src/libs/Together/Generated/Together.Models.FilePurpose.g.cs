
#nullable enable

namespace Together
{
    /// <summary>
    /// The purpose of the file<br/>
    /// Example: fine-tune
    /// </summary>
    public enum FilePurpose
    {
        /// <summary>
        ///
        /// </summary>
        BatchApi,
        /// <summary>
        ///
        /// </summary>
        Calibration,
        /// <summary>
        ///
        /// </summary>
        Eval,
        /// <summary>
        ///
        /// </summary>
        FineTune,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilePurposeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilePurpose value)
        {
            return value switch
            {
                FilePurpose.BatchApi => "batch-api",
                FilePurpose.Calibration => "calibration",
                FilePurpose.Eval => "eval",
                FilePurpose.FineTune => "fine-tune",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilePurpose? ToEnum(string value)
        {
            return value switch
            {
                "batch-api" => FilePurpose.BatchApi,
                "calibration" => FilePurpose.Calibration,
                "eval" => FilePurpose.Eval,
                "fine-tune" => FilePurpose.FineTune,
                _ => null,
            };
        }
    }
}