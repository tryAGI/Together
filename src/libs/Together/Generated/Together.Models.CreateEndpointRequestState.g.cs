
#nullable enable

namespace Together
{
    /// <summary>
    /// The desired state of the endpoint<br/>
    /// Default Value: STARTED<br/>
    /// Example: STARTED
    /// </summary>
    public enum CreateEndpointRequestState
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
    public static class CreateEndpointRequestStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEndpointRequestState value)
        {
            return value switch
            {
                CreateEndpointRequestState.Started => "STARTED",
                CreateEndpointRequestState.Stopped => "STOPPED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEndpointRequestState? ToEnum(string value)
        {
            return value switch
            {
                "STARTED" => CreateEndpointRequestState.Started,
                "STOPPED" => CreateEndpointRequestState.Stopped,
                _ => null,
            };
        }
    }
}