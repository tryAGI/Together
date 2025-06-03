
#nullable enable

namespace Together
{
    /// <summary>
    /// The purpose of the file<br/>
    /// Example: fine-tune
    /// </summary>
    public enum FilePurpose
    {
        /// <summary>
        /// 
        /// </summary>
        FineTune,
        /// <summary>
        /// 
        /// </summary>
        Eval,
        /// <summary>
        /// 
        /// </summary>
        EvalSample,
        /// <summary>
        /// 
        /// </summary>
        EvalOutput,
        /// <summary>
        /// 
        /// </summary>
        EvalSummary,
        /// <summary>
        /// 
        /// </summary>
        BatchGenerated,
        /// <summary>
        /// 
        /// </summary>
        BatchApi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilePurposeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilePurpose value)
        {
            return value switch
            {
                FilePurpose.FineTune => "fine-tune",
                FilePurpose.Eval => "eval",
                FilePurpose.EvalSample => "eval-sample",
                FilePurpose.EvalOutput => "eval-output",
                FilePurpose.EvalSummary => "eval-summary",
                FilePurpose.BatchGenerated => "batch-generated",
                FilePurpose.BatchApi => "batch-api",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilePurpose? ToEnum(string value)
        {
            return value switch
            {
                "fine-tune" => FilePurpose.FineTune,
                "eval" => FilePurpose.Eval,
                "eval-sample" => FilePurpose.EvalSample,
                "eval-output" => FilePurpose.EvalOutput,
                "eval-summary" => FilePurpose.EvalSummary,
                "batch-generated" => FilePurpose.BatchGenerated,
                "batch-api" => FilePurpose.BatchApi,
                _ => null,
            };
        }
    }
}