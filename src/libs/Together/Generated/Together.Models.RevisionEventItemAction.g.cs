
#nullable enable

namespace Together
{
    /// <summary>
    /// How this revision became active.
    /// </summary>
    public enum RevisionEventItemAction
    {
        /// <summary>
        ///
        /// </summary>
        Create,
        /// <summary>
        ///
        /// </summary>
        Rollback,
        /// <summary>
        ///
        /// </summary>
        System,
        /// <summary>
        ///
        /// </summary>
        Update,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RevisionEventItemActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RevisionEventItemAction value)
        {
            return value switch
            {
                RevisionEventItemAction.Create => "create",
                RevisionEventItemAction.Rollback => "rollback",
                RevisionEventItemAction.System => "system",
                RevisionEventItemAction.Update => "update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RevisionEventItemAction? ToEnum(string value)
        {
            return value switch
            {
                "create" => RevisionEventItemAction.Create,
                "rollback" => RevisionEventItemAction.Rollback,
                "system" => RevisionEventItemAction.System,
                "update" => RevisionEventItemAction.Update,
                _ => null,
            };
        }
    }
}