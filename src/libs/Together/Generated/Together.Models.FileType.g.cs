
#nullable enable

namespace Together
{
    /// <summary>
    /// The type of the file<br/>
    /// Default Value: jsonl<br/>
    /// Example: jsonl
    /// </summary>
    public enum FileType
    {
        /// <summary>
        /// 
        /// </summary>
        Csv,
        /// <summary>
        /// 
        /// </summary>
        Jsonl,
        /// <summary>
        /// 
        /// </summary>
        Parquet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileType value)
        {
            return value switch
            {
                FileType.Csv => "csv",
                FileType.Jsonl => "jsonl",
                FileType.Parquet => "parquet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileType? ToEnum(string value)
        {
            return value switch
            {
                "csv" => FileType.Csv,
                "jsonl" => FileType.Jsonl,
                "parquet" => FileType.Parquet,
                _ => null,
            };
        }
    }
}