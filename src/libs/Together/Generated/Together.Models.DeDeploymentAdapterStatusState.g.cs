
#nullable enable

namespace Together
{
    /// <summary>
    /// Current adapter load state in this cluster.
    /// </summary>
    public enum DeDeploymentAdapterStatusState
    {
        /// <summary>
        ///
        /// </summary>
        AdapterLoadStateFailed,
        /// <summary>
        ///
        /// </summary>
        AdapterLoadStateLoading,
        /// <summary>
        ///
        /// </summary>
        AdapterLoadStatePending,
        /// <summary>
        ///
        /// </summary>
        AdapterLoadStateReady,
        /// <summary>
        ///
        /// </summary>
        AdapterLoadStateRemoving,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeDeploymentAdapterStatusStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeDeploymentAdapterStatusState value)
        {
            return value switch
            {
                DeDeploymentAdapterStatusState.AdapterLoadStateFailed => "ADAPTER_LOAD_STATE_FAILED",
                DeDeploymentAdapterStatusState.AdapterLoadStateLoading => "ADAPTER_LOAD_STATE_LOADING",
                DeDeploymentAdapterStatusState.AdapterLoadStatePending => "ADAPTER_LOAD_STATE_PENDING",
                DeDeploymentAdapterStatusState.AdapterLoadStateReady => "ADAPTER_LOAD_STATE_READY",
                DeDeploymentAdapterStatusState.AdapterLoadStateRemoving => "ADAPTER_LOAD_STATE_REMOVING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeDeploymentAdapterStatusState? ToEnum(string value)
        {
            return value switch
            {
                "ADAPTER_LOAD_STATE_FAILED" => DeDeploymentAdapterStatusState.AdapterLoadStateFailed,
                "ADAPTER_LOAD_STATE_LOADING" => DeDeploymentAdapterStatusState.AdapterLoadStateLoading,
                "ADAPTER_LOAD_STATE_PENDING" => DeDeploymentAdapterStatusState.AdapterLoadStatePending,
                "ADAPTER_LOAD_STATE_READY" => DeDeploymentAdapterStatusState.AdapterLoadStateReady,
                "ADAPTER_LOAD_STATE_REMOVING" => DeDeploymentAdapterStatusState.AdapterLoadStateRemoving,
                _ => null,
            };
        }
    }
}