
#nullable enable

namespace Together
{
    /// <summary>
    /// Whether the model is a full model or an adapter<br/>
    /// Default Value: model<br/>
    /// Example: model
    /// </summary>
    public enum UploadModelRequestModelType
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
    public static class UploadModelRequestModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadModelRequestModelType value)
        {
            return value switch
            {
                UploadModelRequestModelType.Model => "model",
                UploadModelRequestModelType.Adapter => "adapter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadModelRequestModelType? ToEnum(string value)
        {
            return value switch
            {
                "model" => UploadModelRequestModelType.Model,
                "adapter" => UploadModelRequestModelType.Adapter,
                _ => null,
            };
        }
    }
}