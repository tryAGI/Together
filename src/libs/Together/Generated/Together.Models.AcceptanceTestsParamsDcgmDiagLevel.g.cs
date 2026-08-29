
#nullable enable

namespace Together
{
    /// <summary>
    /// DCGM diagnostic depth. SHORT = readiness; MEDIUM = default; LONG = system validation; EXTENDED = memtest. An omitted value selects MEDIUM when enabled.
    /// </summary>
    public enum AcceptanceTestsParamsDcgmDiagLevel
    {
        /// <summary>
        ///
        /// </summary>
        DcgmDiagLevelExtended,
        /// <summary>
        ///
        /// </summary>
        DcgmDiagLevelLong,
        /// <summary>
        ///
        /// </summary>
        DcgmDiagLevelMedium,
        /// <summary>
        ///
        /// </summary>
        DcgmDiagLevelShort,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AcceptanceTestsParamsDcgmDiagLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AcceptanceTestsParamsDcgmDiagLevel value)
        {
            return value switch
            {
                AcceptanceTestsParamsDcgmDiagLevel.DcgmDiagLevelExtended => "DCGM_DIAG_LEVEL_EXTENDED",
                AcceptanceTestsParamsDcgmDiagLevel.DcgmDiagLevelLong => "DCGM_DIAG_LEVEL_LONG",
                AcceptanceTestsParamsDcgmDiagLevel.DcgmDiagLevelMedium => "DCGM_DIAG_LEVEL_MEDIUM",
                AcceptanceTestsParamsDcgmDiagLevel.DcgmDiagLevelShort => "DCGM_DIAG_LEVEL_SHORT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AcceptanceTestsParamsDcgmDiagLevel? ToEnum(string value)
        {
            return value switch
            {
                "DCGM_DIAG_LEVEL_EXTENDED" => AcceptanceTestsParamsDcgmDiagLevel.DcgmDiagLevelExtended,
                "DCGM_DIAG_LEVEL_LONG" => AcceptanceTestsParamsDcgmDiagLevel.DcgmDiagLevelLong,
                "DCGM_DIAG_LEVEL_MEDIUM" => AcceptanceTestsParamsDcgmDiagLevel.DcgmDiagLevelMedium,
                "DCGM_DIAG_LEVEL_SHORT" => AcceptanceTestsParamsDcgmDiagLevel.DcgmDiagLevelShort,
                _ => null,
            };
        }
    }
}