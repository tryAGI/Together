
#nullable enable

namespace Together
{
    /// <summary>
    /// Role of this deployment within the A/B experiment.
    /// </summary>
    public enum DeABExperimentMemberRole
    {
        /// <summary>
        ///
        /// </summary>
        AbExperimentMemberRoleControl,
        /// <summary>
        ///
        /// </summary>
        AbExperimentMemberRoleVariant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeABExperimentMemberRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeABExperimentMemberRole value)
        {
            return value switch
            {
                DeABExperimentMemberRole.AbExperimentMemberRoleControl => "AB_EXPERIMENT_MEMBER_ROLE_CONTROL",
                DeABExperimentMemberRole.AbExperimentMemberRoleVariant => "AB_EXPERIMENT_MEMBER_ROLE_VARIANT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeABExperimentMemberRole? ToEnum(string value)
        {
            return value switch
            {
                "AB_EXPERIMENT_MEMBER_ROLE_CONTROL" => DeABExperimentMemberRole.AbExperimentMemberRoleControl,
                "AB_EXPERIMENT_MEMBER_ROLE_VARIANT" => DeABExperimentMemberRole.AbExperimentMemberRoleVariant,
                _ => null,
            };
        }
    }
}