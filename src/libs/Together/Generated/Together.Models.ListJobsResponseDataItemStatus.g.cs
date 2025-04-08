
#nullable enable

namespace Together
{
    /// <summary>
    /// Example: Complete
    /// </summary>
    public enum ListJobsResponseDataItemStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Running,
        /// <summary>
        /// 
        /// </summary>
        Complete,
        /// <summary>
        /// 
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListJobsResponseDataItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListJobsResponseDataItemStatus value)
        {
            return value switch
            {
                ListJobsResponseDataItemStatus.Queued => "Queued",
                ListJobsResponseDataItemStatus.Running => "Running",
                ListJobsResponseDataItemStatus.Complete => "Complete",
                ListJobsResponseDataItemStatus.Failed => "Failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListJobsResponseDataItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "Queued" => ListJobsResponseDataItemStatus.Queued,
                "Running" => ListJobsResponseDataItemStatus.Running,
                "Complete" => ListJobsResponseDataItemStatus.Complete,
                "Failed" => ListJobsResponseDataItemStatus.Failed,
                _ => null,
            };
        }
    }
}