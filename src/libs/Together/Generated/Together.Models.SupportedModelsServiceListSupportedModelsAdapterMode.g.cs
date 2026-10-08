
#nullable enable

namespace Together
{
    /// <summary>
    /// Filter models to those with a deployment profile in the selected adapter serving mode.
    /// </summary>
    public enum SupportedModelsServiceListSupportedModelsAdapterMode
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
    public static class SupportedModelsServiceListSupportedModelsAdapterModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SupportedModelsServiceListSupportedModelsAdapterMode value)
        {
            return value switch
            {
                SupportedModelsServiceListSupportedModelsAdapterMode.AdapterModeDisabled => "ADAPTER_MODE_DISABLED",
                SupportedModelsServiceListSupportedModelsAdapterMode.AdapterModeDynamic => "ADAPTER_MODE_DYNAMIC",
                SupportedModelsServiceListSupportedModelsAdapterMode.AdapterModeFixed => "ADAPTER_MODE_FIXED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SupportedModelsServiceListSupportedModelsAdapterMode? ToEnum(string value)
        {
            return value switch
            {
                "ADAPTER_MODE_DISABLED" => SupportedModelsServiceListSupportedModelsAdapterMode.AdapterModeDisabled,
                "ADAPTER_MODE_DYNAMIC" => SupportedModelsServiceListSupportedModelsAdapterMode.AdapterModeDynamic,
                "ADAPTER_MODE_FIXED" => SupportedModelsServiceListSupportedModelsAdapterMode.AdapterModeFixed,
                _ => null,
            };
        }
    }
}