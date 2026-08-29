
#nullable enable

namespace Together
{
    /// <summary>
    /// State for a cluster add-on.
    /// </summary>
    public sealed partial class AddOnState
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dashboard")]
        public global::Together.DashboardState? Dashboard { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ingress")]
        public global::Together.IngressState? Ingress { get; set; }

        /// <summary>
        /// State for the Model Aware TorchPass add-on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("torchpass")]
        public global::Together.TorchpassState? Torchpass { get; set; }

        /// <summary>
        /// State for the Slurm Web add-on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slurm_web")]
        public global::Together.SlurmWebState? SlurmWeb { get; set; }

        /// <summary>
        /// State for the Headlamp Kubernetes dashboard add-on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headlamp")]
        public global::Together.HeadlampState? Headlamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddOnState" /> class.
        /// </summary>
        /// <param name="dashboard"></param>
        /// <param name="ingress"></param>
        /// <param name="torchpass">
        /// State for the Model Aware TorchPass add-on.
        /// </param>
        /// <param name="slurmWeb">
        /// State for the Slurm Web add-on.
        /// </param>
        /// <param name="headlamp">
        /// State for the Headlamp Kubernetes dashboard add-on.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddOnState(
            global::Together.DashboardState? dashboard,
            global::Together.IngressState? ingress,
            global::Together.TorchpassState? torchpass,
            global::Together.SlurmWebState? slurmWeb,
            global::Together.HeadlampState? headlamp)
        {
            this.Dashboard = dashboard;
            this.Ingress = ingress;
            this.Torchpass = torchpass;
            this.SlurmWeb = slurmWeb;
            this.Headlamp = headlamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddOnState" /> class.
        /// </summary>
        public AddOnState()
        {
        }

    }
}