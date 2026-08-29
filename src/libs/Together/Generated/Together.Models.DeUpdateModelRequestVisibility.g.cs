
#nullable enable

namespace Together
{
    /// <summary>
    /// Who can discover the model. `VISIBILITY_PRIVATE` restricts it to the project; `VISIBILITY_INTERNAL` shares it with the organization.<br/>
    /// Default Value: VISIBILITY_PRIVATE
    /// </summary>
    public enum DeUpdateModelRequestVisibility
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
    public static class DeUpdateModelRequestVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeUpdateModelRequestVisibility value)
        {
            return value switch
            {
                DeUpdateModelRequestVisibility.VisibilityInternal => "VISIBILITY_INTERNAL",
                DeUpdateModelRequestVisibility.VisibilityPrivate => "VISIBILITY_PRIVATE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeUpdateModelRequestVisibility? ToEnum(string value)
        {
            return value switch
            {
                "VISIBILITY_INTERNAL" => DeUpdateModelRequestVisibility.VisibilityInternal,
                "VISIBILITY_PRIVATE" => DeUpdateModelRequestVisibility.VisibilityPrivate,
                _ => null,
            };
        }
    }
}