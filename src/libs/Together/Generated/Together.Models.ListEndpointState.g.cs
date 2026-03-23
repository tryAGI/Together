
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
    public static class ListEndpointStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListEndpointState value)
        {
            return value switch
            {
                ListEndpointState.Error => "ERROR",
                ListEndpointState.Pending => "PENDING",
                ListEndpointState.Started => "STARTED",
                ListEndpointState.Starting => "STARTING",
                ListEndpointState.Stopped => "STOPPED",
                ListEndpointState.Stopping => "STOPPING",
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
                "ERROR" => ListEndpointState.Error,
                "PENDING" => ListEndpointState.Pending,
                "STARTED" => ListEndpointState.Started,
                "STARTING" => ListEndpointState.Starting,
                "STOPPED" => ListEndpointState.Stopped,
                "STOPPING" => ListEndpointState.Stopping,
                _ => null,
            };
        }
    }
}