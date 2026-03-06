
#nullable enable

namespace Together
{
    /// <summary>
    /// The object type, which is always `model`.
    /// </summary>
    public enum ModelInfoObject
    {
        /// <summary>
        /// 
        /// </summary>
        Model,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelInfoObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelInfoObject value)
        {
            return value switch
            {
                ModelInfoObject.Model => "model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelInfoObject? ToEnum(string value)
        {
            return value switch
            {
                "model" => ModelInfoObject.Model,
                _ => null,
            };
        }
    }
}