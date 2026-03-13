
#nullable enable

namespace Together
{
    /// <summary>
    /// Metric must be QueueBacklogPerWorker<br/>
    /// Example: QueueBacklogPerWorker
    /// </summary>
    public enum QueueAutoscalingConfigMetric
    {
        /// <summary>
        /// 
        /// </summary>
        QueueBacklogPerWorker,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueueAutoscalingConfigMetricExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueueAutoscalingConfigMetric value)
        {
            return value switch
            {
                QueueAutoscalingConfigMetric.QueueBacklogPerWorker => "QueueBacklogPerWorker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueueAutoscalingConfigMetric? ToEnum(string value)
        {
            return value switch
            {
                "QueueBacklogPerWorker" => QueueAutoscalingConfigMetric.QueueBacklogPerWorker,
                _ => null,
            };
        }
    }
}