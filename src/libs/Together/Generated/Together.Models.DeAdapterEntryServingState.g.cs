
#nullable enable

namespace Together
{
    /// <summary>
    /// Whether the adapter can serve requests right now. INACTIVE means the deployment is stopped, scaled to zero, or being torn down; LOADING means a placed cluster has not finished loading it; READY means every placed cluster serves it; FAILED means a placed cluster failed to load it.<br/>
    /// Included only in responses
    /// </summary>
    public enum DeAdapterEntryServingState
    {
        /// <summary>
        ///
        /// </summary>
        AdapterServingStateFailed,
        /// <summary>
        ///
        /// </summary>
        AdapterServingStateInactive,
        /// <summary>
        ///
        /// </summary>
        AdapterServingStateLoading,
        /// <summary>
        ///
        /// </summary>
        AdapterServingStateReady,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeAdapterEntryServingStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeAdapterEntryServingState value)
        {
            return value switch
            {
                DeAdapterEntryServingState.AdapterServingStateFailed => "ADAPTER_SERVING_STATE_FAILED",
                DeAdapterEntryServingState.AdapterServingStateInactive => "ADAPTER_SERVING_STATE_INACTIVE",
                DeAdapterEntryServingState.AdapterServingStateLoading => "ADAPTER_SERVING_STATE_LOADING",
                DeAdapterEntryServingState.AdapterServingStateReady => "ADAPTER_SERVING_STATE_READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeAdapterEntryServingState? ToEnum(string value)
        {
            return value switch
            {
                "ADAPTER_SERVING_STATE_FAILED" => DeAdapterEntryServingState.AdapterServingStateFailed,
                "ADAPTER_SERVING_STATE_INACTIVE" => DeAdapterEntryServingState.AdapterServingStateInactive,
                "ADAPTER_SERVING_STATE_LOADING" => DeAdapterEntryServingState.AdapterServingStateLoading,
                "ADAPTER_SERVING_STATE_READY" => DeAdapterEntryServingState.AdapterServingStateReady,
                _ => null,
            };
        }
    }
}