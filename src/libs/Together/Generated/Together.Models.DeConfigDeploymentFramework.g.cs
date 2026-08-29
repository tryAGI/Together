
#nullable enable

namespace Together
{
    /// <summary>
    /// Orchestration framework used to run replicas for this config.
    /// </summary>
    public enum DeConfigDeploymentFramework
    {
        /// <summary>
        ///
        /// </summary>
        DeploymentFrameworkDefault,
        /// <summary>
        ///
        /// </summary>
        DeploymentFrameworkDynamo,
        /// <summary>
        ///
        /// </summary>
        DeploymentFrameworkGrove,
        /// <summary>
        ///
        /// </summary>
        DeploymentFrameworkLws,
        /// <summary>
        ///
        /// </summary>
        DeploymentFrameworkRollouts,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeConfigDeploymentFrameworkExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeConfigDeploymentFramework value)
        {
            return value switch
            {
                DeConfigDeploymentFramework.DeploymentFrameworkDefault => "DEPLOYMENT_FRAMEWORK_DEFAULT",
                DeConfigDeploymentFramework.DeploymentFrameworkDynamo => "DEPLOYMENT_FRAMEWORK_DYNAMO",
                DeConfigDeploymentFramework.DeploymentFrameworkGrove => "DEPLOYMENT_FRAMEWORK_GROVE",
                DeConfigDeploymentFramework.DeploymentFrameworkLws => "DEPLOYMENT_FRAMEWORK_LWS",
                DeConfigDeploymentFramework.DeploymentFrameworkRollouts => "DEPLOYMENT_FRAMEWORK_ROLLOUTS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeConfigDeploymentFramework? ToEnum(string value)
        {
            return value switch
            {
                "DEPLOYMENT_FRAMEWORK_DEFAULT" => DeConfigDeploymentFramework.DeploymentFrameworkDefault,
                "DEPLOYMENT_FRAMEWORK_DYNAMO" => DeConfigDeploymentFramework.DeploymentFrameworkDynamo,
                "DEPLOYMENT_FRAMEWORK_GROVE" => DeConfigDeploymentFramework.DeploymentFrameworkGrove,
                "DEPLOYMENT_FRAMEWORK_LWS" => DeConfigDeploymentFramework.DeploymentFrameworkLws,
                "DEPLOYMENT_FRAMEWORK_ROLLOUTS" => DeConfigDeploymentFramework.DeploymentFrameworkRollouts,
                _ => null,
            };
        }
    }
}