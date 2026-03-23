
#nullable enable

namespace Together
{
    /// <summary>
    /// Whether the model is a full model or an adapter<br/>
    /// Default Value: model<br/>
    /// Example: model
    /// </summary>
    public enum ModelUploadRequestModelType
    {
        /// <summary>
        /// 
        /// </summary>
        Adapter,
        /// <summary>
        /// 
        /// </summary>
        Model,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelUploadRequestModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelUploadRequestModelType value)
        {
            return value switch
            {
                ModelUploadRequestModelType.Adapter => "adapter",
                ModelUploadRequestModelType.Model => "model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelUploadRequestModelType? ToEnum(string value)
        {
            return value switch
            {
                "adapter" => ModelUploadRequestModelType.Adapter,
                "model" => ModelUploadRequestModelType.Model,
                _ => null,
            };
        }
    }
}