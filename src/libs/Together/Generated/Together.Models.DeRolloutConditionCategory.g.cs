
#nullable enable

namespace Together
{
    /// <summary>
    /// Category that classifies why the rollout stopped.
    /// </summary>
    public enum DeRolloutConditionCategory
    {
        /// <summary>
        ///
        /// </summary>
        RolloutFailureCategoryAbortedByOperator,
        /// <summary>
        ///
        /// </summary>
        RolloutFailureCategoryCapacityExhausted,
        /// <summary>
        ///
        /// </summary>
        RolloutFailureCategoryDependencyOutage,
        /// <summary>
        ///
        /// </summary>
        RolloutFailureCategoryEntitlementLapsed,
        /// <summary>
        ///
        /// </summary>
        RolloutFailureCategoryHealthRegression,
        /// <summary>
        ///
        /// </summary>
        RolloutFailureCategoryInternal,
        /// <summary>
        ///
        /// </summary>
        RolloutFailureCategoryMetricsUnavailable,
        /// <summary>
        ///
        /// </summary>
        RolloutFailureCategoryMetricRegression,
        /// <summary>
        ///
        /// </summary>
        RolloutFailureCategoryPolicyInfeasible,
        /// <summary>
        ///
        /// </summary>
        RolloutFailureCategoryRoutingError,
        /// <summary>
        ///
        /// </summary>
        RolloutFailureCategorySourceNotDrained,
        /// <summary>
        ///
        /// </summary>
        RolloutFailureCategoryTargetNotReady,
        /// <summary>
        ///
        /// </summary>
        RolloutFailureCategoryUnderServed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeRolloutConditionCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeRolloutConditionCategory value)
        {
            return value switch
            {
                DeRolloutConditionCategory.RolloutFailureCategoryAbortedByOperator => "ROLLOUT_FAILURE_CATEGORY_ABORTED_BY_OPERATOR",
                DeRolloutConditionCategory.RolloutFailureCategoryCapacityExhausted => "ROLLOUT_FAILURE_CATEGORY_CAPACITY_EXHAUSTED",
                DeRolloutConditionCategory.RolloutFailureCategoryDependencyOutage => "ROLLOUT_FAILURE_CATEGORY_DEPENDENCY_OUTAGE",
                DeRolloutConditionCategory.RolloutFailureCategoryEntitlementLapsed => "ROLLOUT_FAILURE_CATEGORY_ENTITLEMENT_LAPSED",
                DeRolloutConditionCategory.RolloutFailureCategoryHealthRegression => "ROLLOUT_FAILURE_CATEGORY_HEALTH_REGRESSION",
                DeRolloutConditionCategory.RolloutFailureCategoryInternal => "ROLLOUT_FAILURE_CATEGORY_INTERNAL",
                DeRolloutConditionCategory.RolloutFailureCategoryMetricsUnavailable => "ROLLOUT_FAILURE_CATEGORY_METRICS_UNAVAILABLE",
                DeRolloutConditionCategory.RolloutFailureCategoryMetricRegression => "ROLLOUT_FAILURE_CATEGORY_METRIC_REGRESSION",
                DeRolloutConditionCategory.RolloutFailureCategoryPolicyInfeasible => "ROLLOUT_FAILURE_CATEGORY_POLICY_INFEASIBLE",
                DeRolloutConditionCategory.RolloutFailureCategoryRoutingError => "ROLLOUT_FAILURE_CATEGORY_ROUTING_ERROR",
                DeRolloutConditionCategory.RolloutFailureCategorySourceNotDrained => "ROLLOUT_FAILURE_CATEGORY_SOURCE_NOT_DRAINED",
                DeRolloutConditionCategory.RolloutFailureCategoryTargetNotReady => "ROLLOUT_FAILURE_CATEGORY_TARGET_NOT_READY",
                DeRolloutConditionCategory.RolloutFailureCategoryUnderServed => "ROLLOUT_FAILURE_CATEGORY_UNDER_SERVED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeRolloutConditionCategory? ToEnum(string value)
        {
            return value switch
            {
                "ROLLOUT_FAILURE_CATEGORY_ABORTED_BY_OPERATOR" => DeRolloutConditionCategory.RolloutFailureCategoryAbortedByOperator,
                "ROLLOUT_FAILURE_CATEGORY_CAPACITY_EXHAUSTED" => DeRolloutConditionCategory.RolloutFailureCategoryCapacityExhausted,
                "ROLLOUT_FAILURE_CATEGORY_DEPENDENCY_OUTAGE" => DeRolloutConditionCategory.RolloutFailureCategoryDependencyOutage,
                "ROLLOUT_FAILURE_CATEGORY_ENTITLEMENT_LAPSED" => DeRolloutConditionCategory.RolloutFailureCategoryEntitlementLapsed,
                "ROLLOUT_FAILURE_CATEGORY_HEALTH_REGRESSION" => DeRolloutConditionCategory.RolloutFailureCategoryHealthRegression,
                "ROLLOUT_FAILURE_CATEGORY_INTERNAL" => DeRolloutConditionCategory.RolloutFailureCategoryInternal,
                "ROLLOUT_FAILURE_CATEGORY_METRICS_UNAVAILABLE" => DeRolloutConditionCategory.RolloutFailureCategoryMetricsUnavailable,
                "ROLLOUT_FAILURE_CATEGORY_METRIC_REGRESSION" => DeRolloutConditionCategory.RolloutFailureCategoryMetricRegression,
                "ROLLOUT_FAILURE_CATEGORY_POLICY_INFEASIBLE" => DeRolloutConditionCategory.RolloutFailureCategoryPolicyInfeasible,
                "ROLLOUT_FAILURE_CATEGORY_ROUTING_ERROR" => DeRolloutConditionCategory.RolloutFailureCategoryRoutingError,
                "ROLLOUT_FAILURE_CATEGORY_SOURCE_NOT_DRAINED" => DeRolloutConditionCategory.RolloutFailureCategorySourceNotDrained,
                "ROLLOUT_FAILURE_CATEGORY_TARGET_NOT_READY" => DeRolloutConditionCategory.RolloutFailureCategoryTargetNotReady,
                "ROLLOUT_FAILURE_CATEGORY_UNDER_SERVED" => DeRolloutConditionCategory.RolloutFailureCategoryUnderServed,
                _ => null,
            };
        }
    }
}