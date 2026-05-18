
#nullable enable

namespace Together
{
    /// <summary>
    /// SlurmStartupScripts carries optional Slurm lifecycle scripts (prolog/epilog, init, extra conf).
    /// </summary>
    public sealed partial class SlurmStartupScripts
    {
        /// <summary>
        /// Slurm worker node prolog script.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("worker_prolog")]
        public string? WorkerProlog { get; set; }

        /// <summary>
        /// Slurm worker node epilog script.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("worker_epilog")]
        public string? WorkerEpilog { get; set; }

        /// <summary>
        /// Slurm controller prolog script.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("controller_prolog")]
        public string? ControllerProlog { get; set; }

        /// <summary>
        /// Slurm controller epilog script.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("controller_epilog")]
        public string? ControllerEpilog { get; set; }

        /// <summary>
        /// Script run on Slurm login node init.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("login_init_script")]
        public string? LoginInitScript { get; set; }

        /// <summary>
        /// Script run on Slurm nodeset init.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeset_init_script")]
        public string? NodesetInitScript { get; set; }

        /// <summary>
        /// Additional slurm.conf fragments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_slurm_conf")]
        public string? ExtraSlurmConf { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SlurmStartupScripts" /> class.
        /// </summary>
        /// <param name="workerProlog">
        /// Slurm worker node prolog script.
        /// </param>
        /// <param name="workerEpilog">
        /// Slurm worker node epilog script.
        /// </param>
        /// <param name="controllerProlog">
        /// Slurm controller prolog script.
        /// </param>
        /// <param name="controllerEpilog">
        /// Slurm controller epilog script.
        /// </param>
        /// <param name="loginInitScript">
        /// Script run on Slurm login node init.
        /// </param>
        /// <param name="nodesetInitScript">
        /// Script run on Slurm nodeset init.
        /// </param>
        /// <param name="extraSlurmConf">
        /// Additional slurm.conf fragments.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SlurmStartupScripts(
            string? workerProlog,
            string? workerEpilog,
            string? controllerProlog,
            string? controllerEpilog,
            string? loginInitScript,
            string? nodesetInitScript,
            string? extraSlurmConf)
        {
            this.WorkerProlog = workerProlog;
            this.WorkerEpilog = workerEpilog;
            this.ControllerProlog = controllerProlog;
            this.ControllerEpilog = controllerEpilog;
            this.LoginInitScript = loginInitScript;
            this.NodesetInitScript = nodesetInitScript;
            this.ExtraSlurmConf = extraSlurmConf;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlurmStartupScripts" /> class.
        /// </summary>
        public SlurmStartupScripts()
        {
        }

    }
}