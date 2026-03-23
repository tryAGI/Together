
#nullable enable

namespace Together
{
    /// <summary>
    /// Encoding of the file content. Use `string` for text files such as code, and `base64` for binary files, such as images.
    /// </summary>
    public enum ExecuteRequestFileEncoding
    {
        /// <summary>
        /// 
        /// </summary>
        Base64,
        /// <summary>
        /// 
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExecuteRequestFileEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExecuteRequestFileEncoding value)
        {
            return value switch
            {
                ExecuteRequestFileEncoding.Base64 => "base64",
                ExecuteRequestFileEncoding.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExecuteRequestFileEncoding? ToEnum(string value)
        {
            return value switch
            {
                "base64" => ExecuteRequestFileEncoding.Base64,
                "string" => ExecuteRequestFileEncoding.String,
                _ => null,
            };
        }
    }
}