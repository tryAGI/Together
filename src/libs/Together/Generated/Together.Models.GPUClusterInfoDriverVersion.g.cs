
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum GPUClusterInfoDriverVersion
    {
        /// <summary>
        /// 
        /// </summary>
        Cuda125555,
        /// <summary>
        /// 
        /// </summary>
        Cuda126560,
        /// <summary>
        /// 
        /// </summary>
        Cuda126565,
        /// <summary>
        /// 
        /// </summary>
        Cuda128570,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GPUClusterInfoDriverVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GPUClusterInfoDriverVersion value)
        {
            return value switch
            {
                GPUClusterInfoDriverVersion.Cuda125555 => "CUDA_12_5_555",
                GPUClusterInfoDriverVersion.Cuda126560 => "CUDA_12_6_560",
                GPUClusterInfoDriverVersion.Cuda126565 => "CUDA_12_6_565",
                GPUClusterInfoDriverVersion.Cuda128570 => "CUDA_12_8_570",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GPUClusterInfoDriverVersion? ToEnum(string value)
        {
            return value switch
            {
                "CUDA_12_5_555" => GPUClusterInfoDriverVersion.Cuda125555,
                "CUDA_12_6_560" => GPUClusterInfoDriverVersion.Cuda126560,
                "CUDA_12_6_565" => GPUClusterInfoDriverVersion.Cuda126565,
                "CUDA_12_8_570" => GPUClusterInfoDriverVersion.Cuda128570,
                _ => null,
            };
        }
    }
}