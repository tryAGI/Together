
#nullable enable

namespace Together
{
    /// <summary>
    /// Default Value: MUON_SCALING_STRATEGY_UNSPECIFIED
    /// </summary>
    public enum RlMuonScalingStrategy
    {
        /// <summary>
        ///
        /// </summary>
        MuonScalingStrategyMatchAdamw,
        /// <summary>
        ///
        /// </summary>
        MuonScalingStrategyOriginal,
        /// <summary>
        ///
        /// </summary>
        MuonScalingStrategyUnspecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RlMuonScalingStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RlMuonScalingStrategy value)
        {
            return value switch
            {
                RlMuonScalingStrategy.MuonScalingStrategyMatchAdamw => "MUON_SCALING_STRATEGY_MATCH_ADAMW",
                RlMuonScalingStrategy.MuonScalingStrategyOriginal => "MUON_SCALING_STRATEGY_ORIGINAL",
                RlMuonScalingStrategy.MuonScalingStrategyUnspecified => "MUON_SCALING_STRATEGY_UNSPECIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RlMuonScalingStrategy? ToEnum(string value)
        {
            return value switch
            {
                "MUON_SCALING_STRATEGY_MATCH_ADAMW" => RlMuonScalingStrategy.MuonScalingStrategyMatchAdamw,
                "MUON_SCALING_STRATEGY_ORIGINAL" => RlMuonScalingStrategy.MuonScalingStrategyOriginal,
                "MUON_SCALING_STRATEGY_UNSPECIFIED" => RlMuonScalingStrategy.MuonScalingStrategyUnspecified,
                _ => null,
            };
        }
    }
}