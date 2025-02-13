
#nullable enable

namespace Together
{
    /// <summary>
    /// The type of endpoint<br/>
    /// Example: dedicated
    /// </summary>
    public enum DedicatedEndpointType
    {
        /// <summary>
        /// 
        /// </summary>
        Dedicated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DedicatedEndpointTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DedicatedEndpointType value)
        {
            return value switch
            {
                DedicatedEndpointType.Dedicated => "dedicated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DedicatedEndpointType? ToEnum(string value)
        {
            return value switch
            {
                "dedicated" => DedicatedEndpointType.Dedicated,
                _ => null,
            };
        }
    }
}