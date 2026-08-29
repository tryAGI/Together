
#nullable enable

namespace Together
{
    /// <summary>
    /// Speculative decoding mechanism for speculator weights.
    /// </summary>
    public enum DeModelWeightsSpeculatorMechanism
    {
        /// <summary>
        ///
        /// </summary>
        SpeculatorMechanismDraft,
        /// <summary>
        ///
        /// </summary>
        SpeculatorMechanismLookahead,
        /// <summary>
        ///
        /// </summary>
        SpeculatorMechanismMtp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeModelWeightsSpeculatorMechanismExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeModelWeightsSpeculatorMechanism value)
        {
            return value switch
            {
                DeModelWeightsSpeculatorMechanism.SpeculatorMechanismDraft => "SPECULATOR_MECHANISM_DRAFT",
                DeModelWeightsSpeculatorMechanism.SpeculatorMechanismLookahead => "SPECULATOR_MECHANISM_LOOKAHEAD",
                DeModelWeightsSpeculatorMechanism.SpeculatorMechanismMtp => "SPECULATOR_MECHANISM_MTP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeModelWeightsSpeculatorMechanism? ToEnum(string value)
        {
            return value switch
            {
                "SPECULATOR_MECHANISM_DRAFT" => DeModelWeightsSpeculatorMechanism.SpeculatorMechanismDraft,
                "SPECULATOR_MECHANISM_LOOKAHEAD" => DeModelWeightsSpeculatorMechanism.SpeculatorMechanismLookahead,
                "SPECULATOR_MECHANISM_MTP" => DeModelWeightsSpeculatorMechanism.SpeculatorMechanismMtp,
                _ => null,
            };
        }
    }
}