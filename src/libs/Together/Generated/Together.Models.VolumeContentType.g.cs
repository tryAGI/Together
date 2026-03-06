
#nullable enable

namespace Together
{
    /// <summary>
    /// Type is the content type (currently only "files" is supported which allows preloading files uploaded via Files API into the volume)<br/>
    /// Example: files
    /// </summary>
    public enum VolumeContentType
    {
        /// <summary>
        /// 
        /// </summary>
        Files,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VolumeContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VolumeContentType value)
        {
            return value switch
            {
                VolumeContentType.Files => "files",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VolumeContentType? ToEnum(string value)
        {
            return value switch
            {
                "files" => VolumeContentType.Files,
                _ => null,
            };
        }
    }
}