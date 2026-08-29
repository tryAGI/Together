
#nullable enable

namespace Together
{
    /// <summary>
    /// Finite machine-readable model resource lifecycle error code
    /// </summary>
    public enum RlModelResourcesErrorCode
    {
        /// <summary>
        ///
        /// </summary>
        ModelResourcesErrorCodeCapacityWaitTimeout,
        /// <summary>
        ///
        /// </summary>
        ModelResourcesErrorCodeProvisioningFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RlModelResourcesErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RlModelResourcesErrorCode value)
        {
            return value switch
            {
                RlModelResourcesErrorCode.ModelResourcesErrorCodeCapacityWaitTimeout => "MODEL_RESOURCES_ERROR_CODE_CAPACITY_WAIT_TIMEOUT",
                RlModelResourcesErrorCode.ModelResourcesErrorCodeProvisioningFailed => "MODEL_RESOURCES_ERROR_CODE_PROVISIONING_FAILED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RlModelResourcesErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "MODEL_RESOURCES_ERROR_CODE_CAPACITY_WAIT_TIMEOUT" => RlModelResourcesErrorCode.ModelResourcesErrorCodeCapacityWaitTimeout,
                "MODEL_RESOURCES_ERROR_CODE_PROVISIONING_FAILED" => RlModelResourcesErrorCode.ModelResourcesErrorCodeProvisioningFailed,
                _ => null,
            };
        }
    }
}