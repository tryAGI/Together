
#nullable enable

namespace Together
{
    /// <summary>
    /// Current state of the endpoint<br/>
    /// Example: STARTED
    /// </summary>
    public enum DedicatedEndpointState
    {
        /// <summary>
        /// 
        /// </summary>
        PENDING,
        /// <summary>
        /// 
        /// </summary>
        STARTING,
        /// <summary>
        /// 
        /// </summary>
        STARTED,
        /// <summary>
        /// 
        /// </summary>
        STOPPING,
        /// <summary>
        /// 
        /// </summary>
        STOPPED,
        /// <summary>
        /// 
        /// </summary>
        ERROR,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DedicatedEndpointStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DedicatedEndpointState value)
        {
            return value switch
            {
                DedicatedEndpointState.PENDING => "PENDING",
                DedicatedEndpointState.STARTING => "STARTING",
                DedicatedEndpointState.STARTED => "STARTED",
                DedicatedEndpointState.STOPPING => "STOPPING",
                DedicatedEndpointState.STOPPED => "STOPPED",
                DedicatedEndpointState.ERROR => "ERROR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DedicatedEndpointState? ToEnum(string value)
        {
            return value switch
            {
                "PENDING" => DedicatedEndpointState.PENDING,
                "STARTING" => DedicatedEndpointState.STARTING,
                "STARTED" => DedicatedEndpointState.STARTED,
                "STOPPING" => DedicatedEndpointState.STOPPING,
                "STOPPED" => DedicatedEndpointState.STOPPED,
                "ERROR" => DedicatedEndpointState.ERROR,
                _ => null,
            };
        }
    }
}