
#nullable enable

namespace Together
{
    /// <summary>
    /// Type of a training session. TRAINER_AND_GENERATOR provisions both trainer and generator; TRAINER_ONLY provisions only the trainer and rejects generator-dependent operations such as sample.<br/>
    /// Default Value: SESSION_TYPE_UNSPECIFIED
    /// </summary>
    public enum RlSessionType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionTypeTrainerAndGenerator,
        /// <summary>
        /// 
        /// </summary>
        SessionTypeTrainerOnly,
        /// <summary>
        /// 
        /// </summary>
        SessionTypeUnspecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RlSessionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RlSessionType value)
        {
            return value switch
            {
                RlSessionType.SessionTypeTrainerAndGenerator => "SESSION_TYPE_TRAINER_AND_GENERATOR",
                RlSessionType.SessionTypeTrainerOnly => "SESSION_TYPE_TRAINER_ONLY",
                RlSessionType.SessionTypeUnspecified => "SESSION_TYPE_UNSPECIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RlSessionType? ToEnum(string value)
        {
            return value switch
            {
                "SESSION_TYPE_TRAINER_AND_GENERATOR" => RlSessionType.SessionTypeTrainerAndGenerator,
                "SESSION_TYPE_TRAINER_ONLY" => RlSessionType.SessionTypeTrainerOnly,
                "SESSION_TYPE_UNSPECIFIED" => RlSessionType.SessionTypeUnspecified,
                _ => null,
            };
        }
    }
}