
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
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Starting,
        /// <summary>
        /// 
        /// </summary>
        Started,
        /// <summary>
        /// 
        /// </summary>
        Stopping,
        /// <summary>
        /// 
        /// </summary>
        Stopped,
        /// <summary>
        /// 
        /// </summary>
        Error,
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
                DedicatedEndpointState.Pending => "PENDING",
                DedicatedEndpointState.Starting => "STARTING",
                DedicatedEndpointState.Started => "STARTED",
                DedicatedEndpointState.Stopping => "STOPPING",
                DedicatedEndpointState.Stopped => "STOPPED",
                DedicatedEndpointState.Error => "ERROR",
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
                "PENDING" => DedicatedEndpointState.Pending,
                "STARTING" => DedicatedEndpointState.Starting,
                "STARTED" => DedicatedEndpointState.Started,
                "STOPPING" => DedicatedEndpointState.Stopping,
                "STOPPED" => DedicatedEndpointState.Stopped,
                "ERROR" => DedicatedEndpointState.Error,
                _ => null,
            };
        }
    }
}