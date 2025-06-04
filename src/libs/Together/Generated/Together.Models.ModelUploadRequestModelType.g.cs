
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
        Model,
        /// <summary>
        /// 
        /// </summary>
        Adapter,
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
                ModelUploadRequestModelType.Model => "model",
                ModelUploadRequestModelType.Adapter => "adapter",
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
                "model" => ModelUploadRequestModelType.Model,
                "adapter" => ModelUploadRequestModelType.Adapter,
                _ => null,
            };
        }
    }
}