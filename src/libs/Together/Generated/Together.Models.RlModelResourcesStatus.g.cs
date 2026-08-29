
#nullable enable

namespace Together
{
    /// <summary>
    /// Lifecycle status of a model resource
    /// </summary>
    public enum RlModelResourcesStatus
    {
        /// <summary>
        ///
        /// </summary>
        ModelResourcesStatusCreating,
        /// <summary>
        ///
        /// </summary>
        ModelResourcesStatusError,
        /// <summary>
        ///
        /// </summary>
        ModelResourcesStatusPending,
        /// <summary>
        ///
        /// </summary>
        ModelResourcesStatusReady,
        /// <summary>
        ///
        /// </summary>
        ModelResourcesStatusStopped,
        /// <summary>
        ///
        /// </summary>
        ModelResourcesStatusStopping,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RlModelResourcesStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RlModelResourcesStatus value)
        {
            return value switch
            {
                RlModelResourcesStatus.ModelResourcesStatusCreating => "MODEL_RESOURCES_STATUS_CREATING",
                RlModelResourcesStatus.ModelResourcesStatusError => "MODEL_RESOURCES_STATUS_ERROR",
                RlModelResourcesStatus.ModelResourcesStatusPending => "MODEL_RESOURCES_STATUS_PENDING",
                RlModelResourcesStatus.ModelResourcesStatusReady => "MODEL_RESOURCES_STATUS_READY",
                RlModelResourcesStatus.ModelResourcesStatusStopped => "MODEL_RESOURCES_STATUS_STOPPED",
                RlModelResourcesStatus.ModelResourcesStatusStopping => "MODEL_RESOURCES_STATUS_STOPPING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RlModelResourcesStatus? ToEnum(string value)
        {
            return value switch
            {
                "MODEL_RESOURCES_STATUS_CREATING" => RlModelResourcesStatus.ModelResourcesStatusCreating,
                "MODEL_RESOURCES_STATUS_ERROR" => RlModelResourcesStatus.ModelResourcesStatusError,
                "MODEL_RESOURCES_STATUS_PENDING" => RlModelResourcesStatus.ModelResourcesStatusPending,
                "MODEL_RESOURCES_STATUS_READY" => RlModelResourcesStatus.ModelResourcesStatusReady,
                "MODEL_RESOURCES_STATUS_STOPPED" => RlModelResourcesStatus.ModelResourcesStatusStopped,
                "MODEL_RESOURCES_STATUS_STOPPING" => RlModelResourcesStatus.ModelResourcesStatusStopping,
                _ => null,
            };
        }
    }
}