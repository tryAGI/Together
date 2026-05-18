
#nullable enable

namespace Together
{
    /// <summary>
    /// 
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddOnState" /> class.
        /// </summary>
        /// <param name="dashboard"></param>
        /// <param name="ingress"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddOnState(
            global::Together.DashboardState? dashboard,
            global::Together.IngressState? ingress)
        {
            this.Dashboard = dashboard;
            this.Ingress = ingress;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddOnState" /> class.
        /// </summary>
        public AddOnState()
        {
        }

    }
}