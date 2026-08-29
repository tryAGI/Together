
#nullable enable

namespace Together
{
    /// <summary>
    /// Product or serving environment for which the combination was evaluated.
    /// </summary>
    public enum DeCertificationTarget
    {
        /// <summary>
        ///
        /// </summary>
        CertificationTargetDeServerless,
        /// <summary>
        ///
        /// </summary>
        CertificationTargetMre,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeCertificationTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeCertificationTarget value)
        {
            return value switch
            {
                DeCertificationTarget.CertificationTargetDeServerless => "CERTIFICATION_TARGET_DE_SERVERLESS",
                DeCertificationTarget.CertificationTargetMre => "CERTIFICATION_TARGET_MRE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeCertificationTarget? ToEnum(string value)
        {
            return value switch
            {
                "CERTIFICATION_TARGET_DE_SERVERLESS" => DeCertificationTarget.CertificationTargetDeServerless,
                "CERTIFICATION_TARGET_MRE" => DeCertificationTarget.CertificationTargetMre,
                _ => null,
            };
        }
    }
}