
#nullable enable

namespace Together
{
    /// <summary>
    /// Whether the value is exact or a lower bound.
    /// </summary>
    public enum DeHeadroomRelation
    {
        /// <summary>
        ///
        /// </summary>
        RelationEq,
        /// <summary>
        ///
        /// </summary>
        RelationGte,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeHeadroomRelationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeHeadroomRelation value)
        {
            return value switch
            {
                DeHeadroomRelation.RelationEq => "RELATION_EQ",
                DeHeadroomRelation.RelationGte => "RELATION_GTE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeHeadroomRelation? ToEnum(string value)
        {
            return value switch
            {
                "RELATION_EQ" => DeHeadroomRelation.RelationEq,
                "RELATION_GTE" => DeHeadroomRelation.RelationGte,
                _ => null,
            };
        }
    }
}