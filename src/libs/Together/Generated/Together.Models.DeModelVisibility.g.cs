
#nullable enable

namespace Together
{
    /// <summary>
    /// Who can discover the model. `VISIBILITY_PRIVATE` restricts it to the project; `VISIBILITY_INTERNAL` shares it with the organization.<br/>
    /// Default Value: VISIBILITY_PRIVATE
    /// </summary>
    public enum DeModelVisibility
    {
        /// <summary>
        ///
        /// </summary>
        VisibilityInternal,
        /// <summary>
        ///
        /// </summary>
        VisibilityPrivate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeModelVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeModelVisibility value)
        {
            return value switch
            {
                DeModelVisibility.VisibilityInternal => "VISIBILITY_INTERNAL",
                DeModelVisibility.VisibilityPrivate => "VISIBILITY_PRIVATE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeModelVisibility? ToEnum(string value)
        {
            return value switch
            {
                "VISIBILITY_INTERNAL" => DeModelVisibility.VisibilityInternal,
                "VISIBILITY_PRIVATE" => DeModelVisibility.VisibilityPrivate,
                _ => null,
            };
        }
    }
}