
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
    public static class ListEndpointStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListEndpointState value)
        {
            return value switch
            {
                ListEndpointState.PENDING => "PENDING",
                ListEndpointState.STARTING => "STARTING",
                ListEndpointState.STARTED => "STARTED",
                ListEndpointState.STOPPING => "STOPPING",
                ListEndpointState.STOPPED => "STOPPED",
                ListEndpointState.ERROR => "ERROR",
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
                "PENDING" => ListEndpointState.PENDING,
                "STARTING" => ListEndpointState.STARTING,
                "STARTED" => ListEndpointState.STARTED,
                "STOPPING" => ListEndpointState.STOPPING,
                "STOPPED" => ListEndpointState.STOPPED,
                "ERROR" => ListEndpointState.ERROR,
                _ => null,
            };
        }
    }
}