
#nullable enable

namespace Together
{
    /// <summary>
    /// Adapter serving mode for deployments created from this profile; omitted when no certified config is pinned.
    /// </summary>
    public enum DeSupportedModelDeploymentProfileAdapterMode
    {
        /// <summary>
        ///
        /// </summary>
        AdapterModeDisabled,
        /// <summary>
        ///
        /// </summary>
        AdapterModeDynamic,
        /// <summary>
        ///
        /// </summary>
        AdapterModeFixed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeSupportedModelDeploymentProfileAdapterModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeSupportedModelDeploymentProfileAdapterMode value)
        {
            return value switch
            {
                DeSupportedModelDeploymentProfileAdapterMode.AdapterModeDisabled => "ADAPTER_MODE_DISABLED",
                DeSupportedModelDeploymentProfileAdapterMode.AdapterModeDynamic => "ADAPTER_MODE_DYNAMIC",
                DeSupportedModelDeploymentProfileAdapterMode.AdapterModeFixed => "ADAPTER_MODE_FIXED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeSupportedModelDeploymentProfileAdapterMode? ToEnum(string value)
        {
            return value switch
            {
                "ADAPTER_MODE_DISABLED" => DeSupportedModelDeploymentProfileAdapterMode.AdapterModeDisabled,
                "ADAPTER_MODE_DYNAMIC" => DeSupportedModelDeploymentProfileAdapterMode.AdapterModeDynamic,
                "ADAPTER_MODE_FIXED" => DeSupportedModelDeploymentProfileAdapterMode.AdapterModeFixed,
                _ => null,
            };
        }
    }
}