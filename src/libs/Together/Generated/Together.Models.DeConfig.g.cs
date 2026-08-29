
#nullable enable

namespace Together
{
    /// <summary>
    /// Resolved inference engine, orchestration framework, and selectors for one config revision.
    /// </summary>
    public sealed partial class DeConfig
    {
        /// <summary>
        /// Unique config revision identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Inference engine used to serve the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("engineType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeConfigEngineTypeJsonConverter))]
        public global::Together.DeConfigEngineType? EngineType { get; set; }

        /// <summary>
        /// Orchestration framework used to run replicas for this config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentFramework")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeConfigDeploymentFrameworkJsonConverter))]
        public global::Together.DeConfigDeploymentFramework? DeploymentFramework { get; set; }

        /// <summary>
        /// Hardware and runtime selectors resolved by the config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selectors")]
        public global::System.Collections.Generic.IList<global::Together.DeConfigSelector>? Selectors { get; set; }

        /// <summary>
        /// Stable hash of the resolved selectors, used to identify equivalent configs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selectorsHash")]
        public string? SelectorsHash { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeConfig" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique config revision identifier.
        /// </param>
        /// <param name="engineType">
        /// Inference engine used to serve the model.
        /// </param>
        /// <param name="deploymentFramework">
        /// Orchestration framework used to run replicas for this config.
        /// </param>
        /// <param name="selectors">
        /// Hardware and runtime selectors resolved by the config.
        /// </param>
        /// <param name="selectorsHash">
        /// Stable hash of the resolved selectors, used to identify equivalent configs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeConfig(
            string? id,
            global::Together.DeConfigEngineType? engineType,
            global::Together.DeConfigDeploymentFramework? deploymentFramework,
            global::System.Collections.Generic.IList<global::Together.DeConfigSelector>? selectors,
            string? selectorsHash)
        {
            this.Id = id;
            this.EngineType = engineType;
            this.DeploymentFramework = deploymentFramework;
            this.Selectors = selectors;
            this.SelectorsHash = selectorsHash;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeConfig" /> class.
        /// </summary>
        public DeConfig()
        {
        }

    }
}