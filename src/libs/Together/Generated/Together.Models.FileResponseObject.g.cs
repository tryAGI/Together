
#nullable enable

namespace Together
{
    /// <summary>
    /// The object type, which is always `file`.
    /// </summary>
    public enum FileResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        File,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileResponseObject value)
        {
            return value switch
            {
                FileResponseObject.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "file" => FileResponseObject.File,
                _ => null,
            };
        }
    }
}