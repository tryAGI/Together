
#nullable enable

namespace Together
{
    /// <summary>
    /// How updated policy parameters are made available for sampling. SYNCHRONOUS waits for the policy update before returning; BACKGROUND_PUBLISH returns after scheduling the update; PIPELINE overlaps the update with in-flight sampling when possible.
    /// </summary>
    public enum RlWeightSyncType
    {
        /// <summary>
        ///
        /// </summary>
        WeightSyncTypeBackgroundPublish,
        /// <summary>
        ///
        /// </summary>
        WeightSyncTypePipeline,
        /// <summary>
        ///
        /// </summary>
        WeightSyncTypeSynchronous,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RlWeightSyncTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RlWeightSyncType value)
        {
            return value switch
            {
                RlWeightSyncType.WeightSyncTypeBackgroundPublish => "WEIGHT_SYNC_TYPE_BACKGROUND_PUBLISH",
                RlWeightSyncType.WeightSyncTypePipeline => "WEIGHT_SYNC_TYPE_PIPELINE",
                RlWeightSyncType.WeightSyncTypeSynchronous => "WEIGHT_SYNC_TYPE_SYNCHRONOUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RlWeightSyncType? ToEnum(string value)
        {
            return value switch
            {
                "WEIGHT_SYNC_TYPE_BACKGROUND_PUBLISH" => RlWeightSyncType.WeightSyncTypeBackgroundPublish,
                "WEIGHT_SYNC_TYPE_PIPELINE" => RlWeightSyncType.WeightSyncTypePipeline,
                "WEIGHT_SYNC_TYPE_SYNCHRONOUS" => RlWeightSyncType.WeightSyncTypeSynchronous,
                _ => null,
            };
        }
    }
}