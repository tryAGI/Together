
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
        Error,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Started,
        /// <summary>
        /// 
        /// </summary>
        Starting,
        /// <summary>
        /// 
        /// </summary>
        Stopped,
        /// <summary>
        /// 
        /// </summary>
        Stopping,
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
                DedicatedEndpointState.Error => "ERROR",
                DedicatedEndpointState.Pending => "PENDING",
                DedicatedEndpointState.Started => "STARTED",
                DedicatedEndpointState.Starting => "STARTING",
                DedicatedEndpointState.Stopped => "STOPPED",
                DedicatedEndpointState.Stopping => "STOPPING",
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
                "ERROR" => DedicatedEndpointState.Error,
                "PENDING" => DedicatedEndpointState.Pending,
                "STARTED" => DedicatedEndpointState.Started,
                "STARTING" => DedicatedEndpointState.Starting,
                "STOPPED" => DedicatedEndpointState.Stopped,
                "STOPPING" => DedicatedEndpointState.Stopping,
                _ => null,
            };
        }
    }
}