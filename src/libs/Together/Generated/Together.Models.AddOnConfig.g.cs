
#nullable enable

namespace Together
{
    /// <summary>
    /// Configuration for a cluster add-on.
    /// </summary>
    public sealed partial class AddOnConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dashboard")]
        public global::Together.DashboardConfig? Dashboard { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ingress")]
        public global::Together.IngressConfig? Ingress { get; set; }

        /// <summary>
        /// Configuration for the Model Aware TorchPass add-on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("torchpass")]
        public global::Together.TorchpassConfig? Torchpass { get; set; }

        /// <summary>
        /// Configuration for the Slurm Web add-on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slurm_web")]
        public global::Together.SlurmWebConfig? SlurmWeb { get; set; }

        /// <summary>
        /// Configuration for the Headlamp Kubernetes dashboard add-on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headlamp")]
        public global::Together.HeadlampConfig? Headlamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddOnConfig" /> class.
        /// </summary>
        /// <param name="dashboard"></param>
        /// <param name="ingress"></param>
        /// <param name="torchpass">
        /// Configuration for the Model Aware TorchPass add-on.
        /// </param>
        /// <param name="slurmWeb">
        /// Configuration for the Slurm Web add-on.
        /// </param>
        /// <param name="headlamp">
        /// Configuration for the Headlamp Kubernetes dashboard add-on.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddOnConfig(
            global::Together.DashboardConfig? dashboard,
            global::Together.IngressConfig? ingress,
            global::Together.TorchpassConfig? torchpass,
            global::Together.SlurmWebConfig? slurmWeb,
            global::Together.HeadlampConfig? headlamp)
        {
            this.Dashboard = dashboard;
            this.Ingress = ingress;
            this.Torchpass = torchpass;
            this.SlurmWeb = slurmWeb;
            this.Headlamp = headlamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddOnConfig" /> class.
        /// </summary>
        public AddOnConfig()
        {
        }

    }
}