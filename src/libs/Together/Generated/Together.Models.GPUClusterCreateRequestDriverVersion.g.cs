
#nullable enable

namespace Together
{
    /// <summary>
    /// NVIDIA driver version to use in the cluster.
    /// </summary>
    public enum GPUClusterCreateRequestDriverVersion
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
    public static class GPUClusterCreateRequestDriverVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GPUClusterCreateRequestDriverVersion value)
        {
            return value switch
            {
                GPUClusterCreateRequestDriverVersion.Cuda125555 => "CUDA_12_5_555",
                GPUClusterCreateRequestDriverVersion.Cuda126560 => "CUDA_12_6_560",
                GPUClusterCreateRequestDriverVersion.Cuda126565 => "CUDA_12_6_565",
                GPUClusterCreateRequestDriverVersion.Cuda128570 => "CUDA_12_8_570",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GPUClusterCreateRequestDriverVersion? ToEnum(string value)
        {
            return value switch
            {
                "CUDA_12_5_555" => GPUClusterCreateRequestDriverVersion.Cuda125555,
                "CUDA_12_6_560" => GPUClusterCreateRequestDriverVersion.Cuda126560,
                "CUDA_12_6_565" => GPUClusterCreateRequestDriverVersion.Cuda126565,
                "CUDA_12_8_570" => GPUClusterCreateRequestDriverVersion.Cuda128570,
                _ => null,
            };
        }
    }
}