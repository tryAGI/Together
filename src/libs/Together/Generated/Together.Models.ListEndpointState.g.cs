
#nullable enable

namespace Together
{
    /// <summary>
    /// Current state of the endpoint<br/>
    /// Example: STARTED
    /// </summary>
    public enum ListEndpointState
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
    public static class ListEndpointStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListEndpointState value)
        {
            return value switch
            {
                ListEndpointState.Pending => "PENDING",
                ListEndpointState.Starting => "STARTING",
                ListEndpointState.Started => "STARTED",
                ListEndpointState.Stopping => "STOPPING",
                ListEndpointState.Stopped => "STOPPED",
                ListEndpointState.Error => "ERROR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListEndpointState? ToEnum(string value)
        {
            return value switch
            {
                "PENDING" => ListEndpointState.Pending,
                "STARTING" => ListEndpointState.Starting,
                "STARTED" => ListEndpointState.Started,
                "STOPPING" => ListEndpointState.Stopping,
                "STOPPED" => ListEndpointState.Stopped,
                "ERROR" => ListEndpointState.Error,
                _ => null,
            };
        }
    }
}