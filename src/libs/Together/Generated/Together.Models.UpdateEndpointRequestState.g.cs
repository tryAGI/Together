
#nullable enable

namespace Together
{
    /// <summary>
    /// The desired state of the endpoint<br/>
    /// Example: STARTED
    /// </summary>
    public enum UpdateEndpointRequestState
    {
        /// <summary>
        /// 
        /// </summary>
        Started,
        /// <summary>
        /// 
        /// </summary>
        Stopped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateEndpointRequestStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateEndpointRequestState value)
        {
            return value switch
            {
                UpdateEndpointRequestState.Started => "STARTED",
                UpdateEndpointRequestState.Stopped => "STOPPED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateEndpointRequestState? ToEnum(string value)
        {
            return value switch
            {
                "STARTED" => UpdateEndpointRequestState.Started,
                "STOPPED" => UpdateEndpointRequestState.Stopped,
                _ => null,
            };
        }
    }
}