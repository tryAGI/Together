
#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public enum CompletionChunkObject
    {
        /// <summary>
        /// 
        /// </summary>
        CompletionChunk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompletionChunkObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionChunkObject value)
        {
            return value switch
            {
                CompletionChunkObject.CompletionChunk => "completion.chunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionChunkObject? ToEnum(string value)
        {
            return value switch
            {
                "completion.chunk" => CompletionChunkObject.CompletionChunk,
                _ => null,
            };
        }
    }
}