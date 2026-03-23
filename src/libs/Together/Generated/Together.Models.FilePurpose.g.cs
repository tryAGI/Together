
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
        BatchApi,
        /// <summary>
        /// 
        /// </summary>
        BatchGenerated,
        /// <summary>
        /// 
        /// </summary>
        Eval,
        /// <summary>
        /// 
        /// </summary>
        EvalOutput,
        /// <summary>
        /// 
        /// </summary>
        EvalSample,
        /// <summary>
        /// 
        /// </summary>
        EvalSummary,
        /// <summary>
        /// 
        /// </summary>
        FineTune,
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
                FilePurpose.BatchApi => "batch-api",
                FilePurpose.BatchGenerated => "batch-generated",
                FilePurpose.Eval => "eval",
                FilePurpose.EvalOutput => "eval-output",
                FilePurpose.EvalSample => "eval-sample",
                FilePurpose.EvalSummary => "eval-summary",
                FilePurpose.FineTune => "fine-tune",
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
                "batch-api" => FilePurpose.BatchApi,
                "batch-generated" => FilePurpose.BatchGenerated,
                "eval" => FilePurpose.Eval,
                "eval-output" => FilePurpose.EvalOutput,
                "eval-sample" => FilePurpose.EvalSample,
                "eval-summary" => FilePurpose.EvalSummary,
                "fine-tune" => FilePurpose.FineTune,
                _ => null,
            };
        }
    }
}