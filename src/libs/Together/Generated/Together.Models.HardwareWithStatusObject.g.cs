
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum HardwareWithStatusObject
    {
        /// <summary>
        /// 
        /// </summary>
        Hardware,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HardwareWithStatusObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HardwareWithStatusObject value)
        {
            return value switch
            {
                HardwareWithStatusObject.Hardware => "hardware",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HardwareWithStatusObject? ToEnum(string value)
        {
            return value switch
            {
                "hardware" => HardwareWithStatusObject.Hardware,
                _ => null,
            };
        }
    }
}