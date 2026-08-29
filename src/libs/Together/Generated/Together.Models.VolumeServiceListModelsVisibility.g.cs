
#nullable enable

namespace Together
{
    /// <summary>
    /// Model visibility. Private means it is scoped to the project. Internal means it is scoped to the organization.
    /// </summary>
    public enum VolumeServiceListModelsVisibility
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
    public static class VolumeServiceListModelsVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VolumeServiceListModelsVisibility value)
        {
            return value switch
            {
                VolumeServiceListModelsVisibility.VisibilityInternal => "VISIBILITY_INTERNAL",
                VolumeServiceListModelsVisibility.VisibilityPrivate => "VISIBILITY_PRIVATE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VolumeServiceListModelsVisibility? ToEnum(string value)
        {
            return value switch
            {
                "VISIBILITY_INTERNAL" => VolumeServiceListModelsVisibility.VisibilityInternal,
                "VISIBILITY_PRIVATE" => VolumeServiceListModelsVisibility.VisibilityPrivate,
                _ => null,
            };
        }
    }
}