
#nullable enable

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    public enum InstanceClusterConfigLoadBalancer
    {
        /// <summary>
        ///
        /// </summary>
        Istio,
        /// <summary>
        ///
        /// </summary>
        Nginx,
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        Traefik,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InstanceClusterConfigLoadBalancerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InstanceClusterConfigLoadBalancer value)
        {
            return value switch
            {
                InstanceClusterConfigLoadBalancer.Istio => "ISTIO",
                InstanceClusterConfigLoadBalancer.Nginx => "NGINX",
                InstanceClusterConfigLoadBalancer.None => "NONE",
                InstanceClusterConfigLoadBalancer.Traefik => "TRAEFIK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InstanceClusterConfigLoadBalancer? ToEnum(string value)
        {
            return value switch
            {
                "ISTIO" => InstanceClusterConfigLoadBalancer.Istio,
                "NGINX" => InstanceClusterConfigLoadBalancer.Nginx,
                "NONE" => InstanceClusterConfigLoadBalancer.None,
                "TRAEFIK" => InstanceClusterConfigLoadBalancer.Traefik,
                _ => null,
            };
        }
    }
}