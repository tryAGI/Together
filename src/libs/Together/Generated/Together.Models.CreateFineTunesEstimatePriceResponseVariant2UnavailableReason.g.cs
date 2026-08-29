
#nullable enable

namespace Together
{
    /// <summary>
    /// Reason price estimation is unavailable for the requested fine-tune job.<br/>
    /// Example: multimodal_dataset
    /// </summary>
    public enum CreateFineTunesEstimatePriceResponseVariant2UnavailableReason
    {
        /// <summary>
        ///
        /// </summary>
        EvalFileInvalid,
        /// <summary>
        ///
        /// </summary>
        EvalFileNotValidated,
        /// <summary>
        ///
        /// </summary>
        MultimodalDataset,
        /// <summary>
        ///
        /// </summary>
        TrainFileInvalid,
        /// <summary>
        ///
        /// </summary>
        TrainFileNotValidated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateFineTunesEstimatePriceResponseVariant2UnavailableReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFineTunesEstimatePriceResponseVariant2UnavailableReason value)
        {
            return value switch
            {
                CreateFineTunesEstimatePriceResponseVariant2UnavailableReason.EvalFileInvalid => "eval_file_invalid",
                CreateFineTunesEstimatePriceResponseVariant2UnavailableReason.EvalFileNotValidated => "eval_file_not_validated",
                CreateFineTunesEstimatePriceResponseVariant2UnavailableReason.MultimodalDataset => "multimodal_dataset",
                CreateFineTunesEstimatePriceResponseVariant2UnavailableReason.TrainFileInvalid => "train_file_invalid",
                CreateFineTunesEstimatePriceResponseVariant2UnavailableReason.TrainFileNotValidated => "train_file_not_validated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFineTunesEstimatePriceResponseVariant2UnavailableReason? ToEnum(string value)
        {
            return value switch
            {
                "eval_file_invalid" => CreateFineTunesEstimatePriceResponseVariant2UnavailableReason.EvalFileInvalid,
                "eval_file_not_validated" => CreateFineTunesEstimatePriceResponseVariant2UnavailableReason.EvalFileNotValidated,
                "multimodal_dataset" => CreateFineTunesEstimatePriceResponseVariant2UnavailableReason.MultimodalDataset,
                "train_file_invalid" => CreateFineTunesEstimatePriceResponseVariant2UnavailableReason.TrainFileInvalid,
                "train_file_not_validated" => CreateFineTunesEstimatePriceResponseVariant2UnavailableReason.TrainFileNotValidated,
                _ => null,
            };
        }
    }
}