
#nullable enable

namespace Together
{
    /// <summary>
    /// Whether the model and config combination passed certification.
    /// </summary>
    public enum DeCertificationCertificationType
    {
        /// <summary>
        ///
        /// </summary>
        CertificationTypeCertified,
        /// <summary>
        ///
        /// </summary>
        CertificationTypeUncertified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeCertificationCertificationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeCertificationCertificationType value)
        {
            return value switch
            {
                DeCertificationCertificationType.CertificationTypeCertified => "CERTIFICATION_TYPE_CERTIFIED",
                DeCertificationCertificationType.CertificationTypeUncertified => "CERTIFICATION_TYPE_UNCERTIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeCertificationCertificationType? ToEnum(string value)
        {
            return value switch
            {
                "CERTIFICATION_TYPE_CERTIFIED" => DeCertificationCertificationType.CertificationTypeCertified,
                "CERTIFICATION_TYPE_UNCERTIFIED" => DeCertificationCertificationType.CertificationTypeUncertified,
                _ => null,
            };
        }
    }
}