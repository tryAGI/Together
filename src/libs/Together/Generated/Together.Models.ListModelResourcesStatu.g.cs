
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public enum ListModelResourcesStatu
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
    public static class ListModelResourcesStatuExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListModelResourcesStatu value)
        {
            return value switch
            {
                ListModelResourcesStatu.ModelResourcesStatusCreating => "MODEL_RESOURCES_STATUS_CREATING",
                ListModelResourcesStatu.ModelResourcesStatusError => "MODEL_RESOURCES_STATUS_ERROR",
                ListModelResourcesStatu.ModelResourcesStatusPending => "MODEL_RESOURCES_STATUS_PENDING",
                ListModelResourcesStatu.ModelResourcesStatusReady => "MODEL_RESOURCES_STATUS_READY",
                ListModelResourcesStatu.ModelResourcesStatusStopped => "MODEL_RESOURCES_STATUS_STOPPED",
                ListModelResourcesStatu.ModelResourcesStatusStopping => "MODEL_RESOURCES_STATUS_STOPPING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListModelResourcesStatu? ToEnum(string value)
        {
            return value switch
            {
                "MODEL_RESOURCES_STATUS_CREATING" => ListModelResourcesStatu.ModelResourcesStatusCreating,
                "MODEL_RESOURCES_STATUS_ERROR" => ListModelResourcesStatu.ModelResourcesStatusError,
                "MODEL_RESOURCES_STATUS_PENDING" => ListModelResourcesStatu.ModelResourcesStatusPending,
                "MODEL_RESOURCES_STATUS_READY" => ListModelResourcesStatu.ModelResourcesStatusReady,
                "MODEL_RESOURCES_STATUS_STOPPED" => ListModelResourcesStatu.ModelResourcesStatusStopped,
                "MODEL_RESOURCES_STATUS_STOPPING" => ListModelResourcesStatu.ModelResourcesStatusStopping,
                _ => null,
            };
        }
    }
}