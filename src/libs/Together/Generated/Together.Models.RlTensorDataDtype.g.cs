
#nullable enable

namespace Together
{
    /// <summary>
    /// Tensor element type, either `int64` or `float32`.<br/>
    /// Example: int64
    /// </summary>
    public enum RlTensorDataDtype
    {
        /// <summary>
        ///
        /// </summary>
        Float32,
        /// <summary>
        ///
        /// </summary>
        Int64,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RlTensorDataDtypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RlTensorDataDtype value)
        {
            return value switch
            {
                RlTensorDataDtype.Float32 => "float32",
                RlTensorDataDtype.Int64 => "int64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RlTensorDataDtype? ToEnum(string value)
        {
            return value switch
            {
                "float32" => RlTensorDataDtype.Float32,
                "int64" => RlTensorDataDtype.Int64,
                _ => null,
            };
        }
    }
}