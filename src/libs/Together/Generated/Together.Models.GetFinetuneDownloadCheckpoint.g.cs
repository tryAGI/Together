
#nullable enable

namespace Together
{
    /// <summary>
    /// Specifies checkpoint type to download - `merged` vs `adapter`. This field is required if the checkpoint_step is not set.
    /// </summary>
    public enum GetFinetuneDownloadCheckpoint
    {
        /// <summary>
        /// 
        /// </summary>
        Merged,
        /// <summary>
        /// 
        /// </summary>
        Adapter,
        /// <summary>
        /// 
        /// </summary>
        ModelOutputPath,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetFinetuneDownloadCheckpointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFinetuneDownloadCheckpoint value)
        {
            return value switch
            {
                GetFinetuneDownloadCheckpoint.Merged => "merged",
                GetFinetuneDownloadCheckpoint.Adapter => "adapter",
                GetFinetuneDownloadCheckpoint.ModelOutputPath => "model_output_path",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFinetuneDownloadCheckpoint? ToEnum(string value)
        {
            return value switch
            {
                "merged" => GetFinetuneDownloadCheckpoint.Merged,
                "adapter" => GetFinetuneDownloadCheckpoint.Adapter,
                "model_output_path" => GetFinetuneDownloadCheckpoint.ModelOutputPath,
                _ => null,
            };
        }
    }
}