
#nullable enable

namespace Together
{
    /// <summary>
    /// Rate limits applied after stabilization and before replica bounds.<br/>
    /// Example: {"policies":[{"type":"SCALING_POLICY_TYPE_PERCENT","value":25,"periodSeconds":60},{"type":"SCALING_POLICY_TYPE_PODS","value":10,"periodSeconds":60}],"selectPolicy":"SCALING_POLICY_SELECT_MIN"}
    /// </summary>
    public sealed partial class DeScalingRules
    {
        /// <summary>
        /// Non-empty lists replace the existing policies. To clear policies, include<br/>
        /// `autoscaling.scaleDown.policies` or `autoscaling.scaleUp.policies` in the update mask<br/>
        /// and supply an empty scaling rules object or `policies: []`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policies")]
        public global::System.Collections.Generic.IList<global::Together.DeScalingPolicy>? Policies { get; set; }

        /// <summary>
        /// `SCALING_POLICY_SELECT_MIN` chooses the policy allowing the smallest replica change;<br/>
        /// `SCALING_POLICY_SELECT_MAX` chooses the largest. These are caps, not guaranteed changes.<br/>
        /// `SCALING_POLICY_SELECT_DISABLED` holds this direction steady while replica bounds still apply.<br/>
        /// Omitted preserves the existing selector on update. When no selector is configured,<br/>
        /// authored policies use MAX; with no policies configured, the platform defaults apply.<br/>
        /// To reset the selector, include `autoscaling.scaleDown.selectPolicy` or<br/>
        /// `autoscaling.scaleUp.selectPolicy` in the update mask and omit `selectPolicy`.<br/>
        /// Clear both policies and `selectPolicy` to restore inherited defaults.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selectPolicy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.DeScalingRulesSelectPolicyJsonConverter))]
        public global::Together.DeScalingRulesSelectPolicy? SelectPolicy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeScalingRules" /> class.
        /// </summary>
        /// <param name="policies">
        /// Non-empty lists replace the existing policies. To clear policies, include<br/>
        /// `autoscaling.scaleDown.policies` or `autoscaling.scaleUp.policies` in the update mask<br/>
        /// and supply an empty scaling rules object or `policies: []`.
        /// </param>
        /// <param name="selectPolicy">
        /// `SCALING_POLICY_SELECT_MIN` chooses the policy allowing the smallest replica change;<br/>
        /// `SCALING_POLICY_SELECT_MAX` chooses the largest. These are caps, not guaranteed changes.<br/>
        /// `SCALING_POLICY_SELECT_DISABLED` holds this direction steady while replica bounds still apply.<br/>
        /// Omitted preserves the existing selector on update. When no selector is configured,<br/>
        /// authored policies use MAX; with no policies configured, the platform defaults apply.<br/>
        /// To reset the selector, include `autoscaling.scaleDown.selectPolicy` or<br/>
        /// `autoscaling.scaleUp.selectPolicy` in the update mask and omit `selectPolicy`.<br/>
        /// Clear both policies and `selectPolicy` to restore inherited defaults.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeScalingRules(
            global::System.Collections.Generic.IList<global::Together.DeScalingPolicy>? policies,
            global::Together.DeScalingRulesSelectPolicy? selectPolicy)
        {
            this.Policies = policies;
            this.SelectPolicy = selectPolicy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeScalingRules" /> class.
        /// </summary>
        public DeScalingRules()
        {
        }

    }
}