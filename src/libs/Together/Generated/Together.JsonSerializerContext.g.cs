
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.OneOf<global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2, global::Together.ChatCompletionUserMessageContentMultimodalItemVideo, global::Together.ChatCompletionUserMessageContentMultimodalItemAudio, global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudio>>), TypeInfoPropertyName = "ChatCompletionUserMessageContentMultimodalItemInputAudio_9a6c1a339fc4e5a1")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2, global::Together.ChatCompletionUserMessageContentMultimodalItemVideo, global::Together.ChatCompletionUserMessageContentMultimodalItemAudio, global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudio>), TypeInfoPropertyName = "ChatCompletionUserMessageContentMultimodalItemInputAudio_e050a39467d446fd")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2, global::Together.ChatCompletionUserMessageContentMultimodalItemVideo, global::Together.ChatCompletionUserMessageContentMultimodalItemAudio, global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudio>?), TypeInfoPropertyName = "ChatCompletionUserMessageContentMultimodalItemInputAudio_f38c2c0c365e74fc")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.OneOf<global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2, global::Together.ChatCompletionUserMessageContentMultimodalItemVideo, global::Together.ChatCompletionUserMessageContentMultimodalItemAudio, global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudio>>), TypeInfoPropertyName = "ChatCompletionUserMessageContentMultimodalItemInputAudio_6724b54fa98b04fd")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeListPublicEndpointsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DePublicEndpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DePublicEndpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeListEndpointsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeEndpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeEndpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeTrafficSplitEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeTrafficSplitEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeEndpointVisibility), TypeInfoPropertyName = "DeEndpointVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeEndpointEndpointType), TypeInfoPropertyName = "DeEndpointEndpointType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeDeploymentSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeDeploymentSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeDeploymentSummaryTrafficMode), TypeInfoPropertyName = "DeDeploymentSummaryTrafficMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeDeploymentSummaryState), TypeInfoPropertyName = "DeDeploymentSummaryState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeAutoscalingResponse), TypeInfoPropertyName = "DeAutoscalingResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeCreateEndpointRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeCreateEndpointRequestVisibility), TypeInfoPropertyName = "DeCreateEndpointRequestVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeEndpointUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeEndpointUpdateVisibility), TypeInfoPropertyName = "DeEndpointUpdateVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeCreateDeploymentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeAutoscaling))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DePlacement), TypeInfoPropertyName = "DePlacement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeUpdateDeploymentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeCreateABExperimentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeABExperimentMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeABExperimentMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeUpdateABExperimentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeCreateRemoteUploadSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeListFilesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeListFilesResponseFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeListFilesResponseFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeListEndpointAccessResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeAccessEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeAccessEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeListInferenceInstanceTypesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeInferenceInstanceType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeInferenceInstanceType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRevokeEndpointAccessResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeListRemoteUploadsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeRemoteUpload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRemoteUpload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeListPlacementProfilesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DePlacementProfile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DePlacementProfile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeListRemoteUploadEventsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeRemoteUploadEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRemoteUploadEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRevokeEndpointAccessRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeGrantEndpointAccessRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeDeployment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeDeploymentTrafficMode), TypeInfoPropertyName = "DeDeploymentTrafficMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRuntimeInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeDeploymentStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeAdapterEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeDeploymentAdapterStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeDeploymentAdapterStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeDeploymentAdapterStatusState), TypeInfoPropertyName = "DeDeploymentAdapterStatusState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeListAdaptersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeAdapterEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeAddAdapterRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeUpdateAdapterRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeListRolloutsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeRollout>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRollout))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeCreateRolloutRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeCanaryConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeBlueGreenConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRollingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeMetricRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeMetricRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeRolloutStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRolloutStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeMetricRuleName), TypeInfoPropertyName = "DeMetricRuleName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeMetricRuleStat), TypeInfoPropertyName = "DeMetricRuleStat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeThresholdCheck))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRegressionCheck))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeThresholdCheckOperator), TypeInfoPropertyName = "DeThresholdCheckOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRegressionCheckDirection), TypeInfoPropertyName = "DeRegressionCheckDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DePauseRolloutRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeResumeRolloutRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeCancelRolloutRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeCancelRolloutRequestDisposition), TypeInfoPropertyName = "DeCancelRolloutRequestDisposition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DePromoteRolloutRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRolloutDefaultsPreview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DePreviewWarning>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DePreviewWarning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DePauseInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRolloutStrategy), TypeInfoPropertyName = "DeRolloutStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRolloutState), TypeInfoPropertyName = "DeRolloutState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRolloutStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRolloutCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeRolloutStepStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRolloutStepStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeRolloutCondition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRolloutConditionCategory), TypeInfoPropertyName = "DeRolloutConditionCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeMetricResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeMetricResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRolloutConditionType), TypeInfoPropertyName = "DeRolloutConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRolloutStepStatusState), TypeInfoPropertyName = "DeRolloutStepStatusState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeMetricResultStat), TypeInfoPropertyName = "DeMetricResultStat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeMetricResultCheck), TypeInfoPropertyName = "DeMetricResultCheck2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeMetricResultOperator), TypeInfoPropertyName = "DeMetricResultOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeMetricResultDirection), TypeInfoPropertyName = "DeMetricResultDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeMetricResultVerdict), TypeInfoPropertyName = "DeMetricResultVerdict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeABExperiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeABExperimentMemberRole), TypeInfoPropertyName = "DeABExperimentMemberRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DePlacementVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeInlinePlacement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DePlacementVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeInlinePlacementConstraint), TypeInfoPropertyName = "DeInlinePlacementConstraint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeListModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeListSupportedModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeSupportedModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeSupportedModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeSupportedModelDeploymentProfile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeSupportedModelPerformanceBenchmarks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeSupportedModelInputModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeSupportedModelInputModalitie), TypeInfoPropertyName = "DeSupportedModelInputModalitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeSupportedModelOutputModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeSupportedModelOutputModalitie), TypeInfoPropertyName = "DeSupportedModelOutputModalitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeSupportedModelProduct>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeSupportedModelProduct), TypeInfoPropertyName = "DeSupportedModelProduct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeSupportedModelFeature>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeSupportedModelFeature), TypeInfoPropertyName = "DeSupportedModelFeature2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeSupportedModelCapabilitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeSupportedModelCapabilitie), TypeInfoPropertyName = "DeSupportedModelCapabilitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeSupportedModelStatus), TypeInfoPropertyName = "DeSupportedModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeSupportedModelDeploymentProfile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeListEndpointEventsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeEndpointEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeEndpointEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeListRevisionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeListRevisionsResponseRevision>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeListRevisionsResponseRevision))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeListProjectConfigsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeModelConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeModelConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeListDeploymentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeDeployment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeListABExperimentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeABExperiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeCreateShadowExperimentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeShadowExperimentSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeCreateShadowExperimentTargetRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeCreateShadowExperimentTargetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeUpdateShadowExperimentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeUpdateShadowExperimentTargetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeListShadowExperimentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeShadowExperiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeShadowExperiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeListShadowExperimentTargetsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeShadowExperimentTarget>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeShadowExperimentTarget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeShadowExperimentSourceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeShadowExperimentState), TypeInfoPropertyName = "DeShadowExperimentState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeShadowExperimentEndpointSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeShadowExperimentSampling), TypeInfoPropertyName = "DeShadowExperimentSampling2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeShadowExperimentEndpointSourceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeShadowExperimentSamplingResponse), TypeInfoPropertyName = "DeShadowExperimentSamplingResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeShadowExperimentSamplingResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeShadowExperimentUniformSamplingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeShadowExperimentSamplingResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeShadowExperimentKeyBasedSamplingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeShadowExperimentSamplingResponseVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeShadowExperimentAdaptiveUniformSamplingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeShadowExperimentSamplingResponseVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeShadowExperimentAdaptiveKeyBasedSamplingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeShadowExperimentSamplingVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeShadowExperimentUniformSampling))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeShadowExperimentSamplingVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeShadowExperimentKeyBasedSampling))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeShadowExperimentSamplingVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeShadowExperimentAdaptiveUniformSampling))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeShadowExperimentSamplingVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeShadowExperimentAdaptiveKeyBasedSampling))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeUpdateModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeUpdateModelRequestVisibility), TypeInfoPropertyName = "DeUpdateModelRequestVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeCreateModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRegion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeHeadroom))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeHeadroomRelation), TypeInfoPropertyName = "DeHeadroomRelation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeAnalyticsData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeMetricsTimeRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeEndpointMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeTimeSeriesDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeTimeSeriesDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeDeploymentAnalyticsData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeDeploymentAnalyticsData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRemoteUploadStatus), TypeInfoPropertyName = "DeRemoteUploadStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeCertification>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeCertification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeSelector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeSelector))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeModelWeights))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeModelVisibility), TypeInfoPropertyName = "DeModelVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRemoteUploadEventLevel), TypeInfoPropertyName = "DeRemoteUploadEventLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeScalingMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeScalingMetric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeDeploymentStatusState), TypeInfoPropertyName = "DeDeploymentStatusState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeEndpointEventLevel), TypeInfoPropertyName = "DeEndpointEventLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeEndpointEventSourceKind), TypeInfoPropertyName = "DeEndpointEventSourceKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeListRevisionsResponseRevisionValidationStatus), TypeInfoPropertyName = "DeListRevisionsResponseRevisionValidationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeRevisionValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRevisionValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeDeploymentMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRequestMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeLatencyMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeThroughputMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeErrorMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeResourceUtilization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeTokenMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeDeploymentMetrics>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeConfigEngineType), TypeInfoPropertyName = "DeConfigEngineType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeConfigDeploymentFramework), TypeInfoPropertyName = "DeConfigDeploymentFramework2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeConfigSelector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeConfigSelector))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeCertificationTarget), TypeInfoPropertyName = "DeCertificationTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeCertificationCertificationType), TypeInfoPropertyName = "DeCertificationCertificationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeModelExternal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeModelLicense))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeModelWeightsType), TypeInfoPropertyName = "DeModelWeightsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeModelWeightsSpeculatorMechanism), TypeInfoPropertyName = "DeModelWeightsSpeculatorMechanism2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeModelWeightsDraftSpeculatorType), TypeInfoPropertyName = "DeModelWeightsDraftSpeculatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeModelParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeScalingMetricType), TypeInfoPropertyName = "DeScalingMetricType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeModelDTypeCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeModelDTypeCount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlOptimStepBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlAdamParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlMuonParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlWeightsSyncBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlWeightSyncType), TypeInfoPropertyName = "RlWeightSyncType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlSampleBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.RlModelInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlSamplingParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlForwardBackwardBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.RlTrainingSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTrainingSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlLossConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.RlModelInputChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlModelInputChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<string, int?>), TypeInfoPropertyName = "OneOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlEncodedTextChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlListMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlModelFullModeConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlModelLoraModeConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlComputeConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlComputeConfigCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlModelResourcesStatus), TypeInfoPropertyName = "RlModelResourcesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlModelResources))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlModelResourcesError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlOptimizerConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlModelResourcesErrorCode), TypeInfoPropertyName = "RlModelResourcesErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlCreateModelResourcesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlModelResourcesEstimateCostResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlModelResourcesListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.RlModelResources>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlModelTrainerConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlModelSamplingDefaults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlModelGeneratorConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlSupportedModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.OneOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlDType), TypeInfoPropertyName = "RlDType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlLossType), TypeInfoPropertyName = "RlLossType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlCrossEntropyLossParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlGRPOLossParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlGRPOLossAggregationType), TypeInfoPropertyName = "RlGRPOLossAggregationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlGRPOLossRatioType), TypeInfoPropertyName = "RlGRPOLossRatioType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlPPOLossParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlCISPOLossParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlDROLossParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTensorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTensorDataDtype), TypeInfoPropertyName = "RlTensorDataDtype2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Together.RlTensorData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlRoutedExperts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlPolicyVersionSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlPromptTopLogprobs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlOptimStepOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTrainingOperationStatus), TypeInfoPropertyName = "RlTrainingOperationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlOptimStepResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTrainingOperationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlWeightsSyncOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlWeightsSyncResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlSampleOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlSampleBatchResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.RlSampleResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlSampleResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.RlSampledSequence>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlSampledSequence))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.RlPromptTopLogprobs>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.RlPolicyVersionSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlStopReason), TypeInfoPropertyName = "RlStopReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlForwardBackwardOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlForwardBackwardResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlCustomForwardBackwardBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.RlTargetLogprobGradients>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTargetLogprobGradients))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlCustomForwardBackwardOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlCustomForwardBackwardResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlForwardBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlForwardOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlForwardResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.RlTargetLogprobs>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTargetLogprobs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTrainingOperationErrorCode), TypeInfoPropertyName = "RlTrainingOperationErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlStartTrainingSessionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlLoraConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTrainingSessionMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlUpdateTrainingSessionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTrainingSessionStatus), TypeInfoPropertyName = "RlTrainingSessionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTrainingSessionError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTrainingSessionErrorCode), TypeInfoPropertyName = "RlTrainingSessionErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlWandbMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTrainingSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.RlInferenceCheckpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlInferenceCheckpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.RlTrainingCheckpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTrainingCheckpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTrainingSessionsListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.RlTrainingSession>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlSupportedModelsListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.RlSupportedModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlAdamWOptimizerConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlMuonOptimizerConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlMuonScalingStrategy), TypeInfoPropertyName = "RlMuonScalingStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlInferenceCheckpointOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlInferenceCheckpointResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlInferenceCheckpointRegistration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTrainingCheckpointRegistration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTrainingCheckpointResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTrainingCheckpointOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlCheckpointType), TypeInfoPropertyName = "RlCheckpointType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlCheckpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlCheckpointVariant), TypeInfoPropertyName = "RlCheckpointVariant2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlCheckpointFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<string, long?>), TypeInfoPropertyName = "OneOfStringInt642")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlCheckpointDownloadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.RlCheckpointFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterControlPlaneNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.NodePhaseTransition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.NodePhaseTransition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterCreateRequestClusterType), TypeInfoPropertyName = "GPUClusterCreateRequestClusterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterCreateRequestGpuType), TypeInfoPropertyName = "GPUClusterCreateRequestGpuType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClustersSharedVolumeCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterCreateRequestBillingType), TypeInfoPropertyName = "GPUClusterCreateRequestBillingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OIDCConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AcceptanceTestsParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.InstanceClusterConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.AddOnCreateRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AddOnCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterGPUWorkerNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.Remediation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterInfoClusterType), TypeInfoPropertyName = "GPUClusterInfoClusterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterInfoGpuType), TypeInfoPropertyName = "GPUClusterInfoGpuType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.GPUClusterVolume>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterVolume))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterInfoStatus), TypeInfoPropertyName = "GPUClusterInfoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.GPUClusterControlPlaneNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.GPUClusterGPUWorkerNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.ClusterPhaseTransition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ClusterPhaseTransition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterInfoBillingType), TypeInfoPropertyName = "GPUClusterInfoBillingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.AddOnInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AddOnInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.GPUClusterNodeLifecycleEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterNodeLifecycleEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterUpdateRequestClusterType), TypeInfoPropertyName = "GPUClusterUpdateRequestClusterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.AddOnUpdateRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AddOnUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.GPUClusterInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.InstanceTypesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.InstanceTypesResponseType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.InstanceTypesResponseType), TypeInfoPropertyName = "InstanceTypesResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RegionListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.RegionListResponseRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RegionListResponseRegion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.ClusterDriverVersionInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ClusterDriverVersionInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AcceptanceTestsParamsDcgmDiagLevel), TypeInfoPropertyName = "AcceptanceTestsParamsDcgmDiagLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AddOnConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DashboardConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.IngressConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.TorchpassConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.SlurmWebConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.HeadlampConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AddOnState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DashboardState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.IngressState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.TorchpassState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.SlurmWebState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.HeadlampState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CommentBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ApproveRemediationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ApproveRemediationRequestMode), TypeInfoPropertyName = "ApproveRemediationRequestMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ClusterAddOnCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ClusterAddOnDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ClusterAddOnUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ClusterAddOnsListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ClusterIngressConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ClusterPhaseTransitionPhase), TypeInfoPropertyName = "ClusterPhaseTransitionPhase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.InstanceClusterConfigLoadBalancer), TypeInfoPropertyName = "InstanceClusterConfigLoadBalancer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.SlurmStartupScripts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ObservabilityConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ListRemediationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.Remediation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.NodePhaseTransitionPhase), TypeInfoPropertyName = "NodePhaseTransitionPhase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ListPassiveHealthCheckAlertsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.PassiveHealthCheckAlert>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.PassiveHealthCheckAlert))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.PHCAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.XidDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.SlurmNodeUnavailableDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.PassiveHealthCheckAlertSeverity), TypeInfoPropertyName = "PassiveHealthCheckAlertSeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RemediationMode), TypeInfoPropertyName = "RemediationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RemediationTrigger), TypeInfoPropertyName = "RemediationTrigger2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RemediationState), TypeInfoPropertyName = "RemediationState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClustersSharedVolumeDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClustersSharedVolume))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClustersSharedVolumeStatus), TypeInfoPropertyName = "GPUClustersSharedVolumeStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClustersSharedVolumeUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClustersSharedVolumes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.GPUClustersSharedVolume>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.XidEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.XidEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ListVoicesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.ModelVoices>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ModelVoices))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.ModelVoicesVoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ModelVoicesVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ListAvailibilityZonesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RerankRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AnyOf<global::Together.RerankRequestModel?, string>), TypeInfoPropertyName = "AnyOfRerankRequestModelString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RerankRequestModel), TypeInfoPropertyName = "RerankRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::System.Collections.Generic.IList<object>, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "OneOfIListObjectIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RerankResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.RerankResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RerankResponseResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RerankResponseResultDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.UsageData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ErrorDataError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FinishReason), TypeInfoPropertyName = "FinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.LogprobsPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.PromptPartItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.PromptPartItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.InferenceWarning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.CompletionChoicesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CompletionChoicesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AnyOf<global::Together.CompletionRequestModel?, string>), TypeInfoPropertyName = "AnyOfCompletionRequestModelString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CompletionRequestModel), TypeInfoPropertyName = "CompletionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AnyOf<global::Together.CompletionRequestSafetyModel?, string>), TypeInfoPropertyName = "AnyOfCompletionRequestSafetyModelString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CompletionRequestSafetyModel), TypeInfoPropertyName = "CompletionRequestSafetyModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CompletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CompletionStream), TypeInfoPropertyName = "CompletionStream2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CompletionEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.StreamSentinel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CompletionChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CompletionToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.CompletionChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CompletionChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AllOf<global::Together.UsageData, object>), TypeInfoPropertyName = "AllOfUsageDataObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AllOf<global::Together.FinishReason?, object>), TypeInfoPropertyName = "AllOfFinishReasonObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CompletionChoiceDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CompletionChoiceDeltaRole), TypeInfoPropertyName = "CompletionChoiceDeltaRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.ToolChoice2>))]
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.OneOf<global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2, global::Together.ChatCompletionUserMessageContentMultimodalItemVideo, global::Together.ChatCompletionUserMessageContentMultimodalItemAudio, global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudio>>), TypeInfoPropertyName = "ChatCompletionUserMessageContentMultimodalItemInputAudio_9a6c1a339fc4e5a1")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2, global::Together.ChatCompletionUserMessageContentMultimodalItemVideo, global::Together.ChatCompletionUserMessageContentMultimodalItemAudio, global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudio>), TypeInfoPropertyName = "ChatCompletionUserMessageContentMultimodalItemInputAudio_e050a39467d446fd")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2, global::Together.ChatCompletionUserMessageContentMultimodalItemVideo, global::Together.ChatCompletionUserMessageContentMultimodalItemAudio, global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudio>?), TypeInfoPropertyName = "ChatCompletionUserMessageContentMultimodalItemInputAudio_f38c2c0c365e74fc")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.OneOf<global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2, global::Together.ChatCompletionUserMessageContentMultimodalItemVideo, global::Together.ChatCompletionUserMessageContentMultimodalItemAudio, global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudio>>), TypeInfoPropertyName = "ChatCompletionUserMessageContentMultimodalItemInputAudio_6724b54fa98b04fd")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ToolChoice2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CompletionChoiceDeltaFunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.ChatCompletionChoicesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionChoicesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AllOf<object, global::Together.LogprobsPart>), TypeInfoPropertyName = "AllOfObjectLogprobsPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionMessageRole), TypeInfoPropertyName = "ChatCompletionMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionMessageFunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionToolType), TypeInfoPropertyName = "ChatCompletionToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionToolFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.ChatCompletionMessageParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionMessageParam), TypeInfoPropertyName = "ChatCompletionMessageParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionRequestContextLengthExceededBehavior), TypeInfoPropertyName = "ChatCompletionRequestContextLengthExceededBehavior2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.ChatCompletionRequestFunctionCallEnum?, global::Together.ChatCompletionRequestFunctionCallEnum2>), TypeInfoPropertyName = "OneOfChatCompletionRequestFunctionCallEnumChatCompletionRequestFunctionCallEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionRequestFunctionCallEnum), TypeInfoPropertyName = "ChatCompletionRequestFunctionCallEnum2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionRequestFunctionCallEnum2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ResponseFormat), TypeInfoPropertyName = "ResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ResponseFormatText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ResponseFormatJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ResponseFormatJsonObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionRequestResponseFormatDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionRequestResponseFormatDiscriminatorType), TypeInfoPropertyName = "ChatCompletionRequestResponseFormatDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.ToolsPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ToolsPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<string, global::Together.ToolChoice2>), TypeInfoPropertyName = "OneOfStringToolChoice22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionRequestReasoningEffort), TypeInfoPropertyName = "ChatCompletionRequestReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionRequestReasoning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ResponseFormatTextType), TypeInfoPropertyName = "ResponseFormatTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ResponseFormatJsonObjectType), TypeInfoPropertyName = "ResponseFormatJsonObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ResponseFormatJsonSchemaType), TypeInfoPropertyName = "ResponseFormatJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ResponseFormatJsonSchemaJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ResponseFormatJsonSchemaSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionSystemMessageParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionUserMessageParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionAssistantMessageParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionToolMessageParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionFunctionMessageParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionSystemMessageParamRole), TypeInfoPropertyName = "ChatCompletionSystemMessageParamRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionUserMessageContent), TypeInfoPropertyName = "ChatCompletionUserMessageContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionUserMessageParamRole), TypeInfoPropertyName = "ChatCompletionUserMessageParamRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1Type), TypeInfoPropertyName = "ChatCompletionUserMessageContentMultimodalItemVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2Type), TypeInfoPropertyName = "ChatCompletionUserMessageContentMultimodalItemVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2ImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemVideoType), TypeInfoPropertyName = "ChatCompletionUserMessageContentMultimodalItemVideoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemVideoVideoUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemAudioType), TypeInfoPropertyName = "ChatCompletionUserMessageContentMultimodalItemAudioType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemAudioAudioUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudioType), TypeInfoPropertyName = "ChatCompletionUserMessageContentMultimodalItemInputAudioType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudioInputAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudioInputAudioFormat), TypeInfoPropertyName = "ChatCompletionUserMessageContentMultimodalItemInputAudioInputAudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionAssistantMessageParamRole), TypeInfoPropertyName = "ChatCompletionAssistantMessageParamRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionAssistantMessageParamFunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionFunctionMessageParamRole), TypeInfoPropertyName = "ChatCompletionFunctionMessageParamRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionToolMessageParamRole), TypeInfoPropertyName = "ChatCompletionToolMessageParamRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.InferenceWarning>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionStream), TypeInfoPropertyName = "ChatCompletionStream2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.ChatCompletionChunkChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionChunkChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionChunkChoiceDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionChunkChoiceDeltaRole), TypeInfoPropertyName = "ChatCompletionChunkChoiceDeltaRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionChunkChoiceDeltaFunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioSpeechRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AnyOf<global::Together.AudioSpeechRequestModel?, string>), TypeInfoPropertyName = "AnyOfAudioSpeechRequestModelString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioSpeechRequestModel), TypeInfoPropertyName = "AudioSpeechRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioSpeechRequestResponseFormat), TypeInfoPropertyName = "AudioSpeechRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioSpeechRequestResponseEncoding), TypeInfoPropertyName = "AudioSpeechRequestResponseEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioSpeechRequestExtraParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranscriptionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<byte[], string>), TypeInfoPropertyName = "OneOfByteArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranscriptionRequestModel), TypeInfoPropertyName = "AudioTranscriptionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranscriptionRequestResponseFormat), TypeInfoPropertyName = "AudioTranscriptionRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.AudioTranscriptionRequestTimestampGranularities?, global::System.Collections.Generic.IList<global::Together.AudioTranscriptionRequestTimestampGranularitie>>), TypeInfoPropertyName = "OneOfAudioTranscriptionRequestTimestampGranularitiesIListAudioTranscriptionRequestTimestampGranularitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranscriptionRequestTimestampGranularities), TypeInfoPropertyName = "AudioTranscriptionRequestTimestampGranularities2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.AudioTranscriptionRequestTimestampGranularitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranscriptionRequestTimestampGranularitie), TypeInfoPropertyName = "AudioTranscriptionRequestTimestampGranularitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranscriptionResponse), TypeInfoPropertyName = "AudioTranscriptionResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranscriptionJsonResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranscriptionVerboseJsonResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.AudioTranscriptionSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranscriptionSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.AudioTranscriptionWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranscriptionWord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.AudioTranscriptionSpeakerSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranscriptionSpeakerSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranslationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranslationRequestModel), TypeInfoPropertyName = "AudioTranslationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranslationRequestResponseFormat), TypeInfoPropertyName = "AudioTranslationRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.AudioTranslationRequestTimestampGranularities?, global::System.Collections.Generic.IList<global::Together.AudioTranslationRequestTimestampGranularitie>>), TypeInfoPropertyName = "OneOfAudioTranslationRequestTimestampGranularitiesIListAudioTranslationRequestTimestampGranularitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranslationRequestTimestampGranularities), TypeInfoPropertyName = "AudioTranslationRequestTimestampGranularities2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.AudioTranslationRequestTimestampGranularitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranslationRequestTimestampGranularitie), TypeInfoPropertyName = "AudioTranslationRequestTimestampGranularitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranslationResponse), TypeInfoPropertyName = "AudioTranslationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranslationJsonResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranslationVerboseJsonResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioSpeechStreamResponse), TypeInfoPropertyName = "AudioSpeechStreamResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioSpeechStreamEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioSpeechStreamChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.StreamSentinelData), TypeInfoPropertyName = "StreamSentinelData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionChoiceDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionChoiceDeltaRole), TypeInfoPropertyName = "ChatCompletionChoiceDeltaRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionChoiceDeltaFunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EmbeddingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AnyOf<global::Together.EmbeddingsRequestModel?, string>), TypeInfoPropertyName = "AnyOfEmbeddingsRequestModelString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EmbeddingsRequestModel), TypeInfoPropertyName = "EmbeddingsRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "OneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EmbeddingsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.EmbeddingsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EmbeddingsResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.ModelInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ModelInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ModelInfoType), TypeInfoPropertyName = "ModelInfoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.Pricing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ModelUploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ModelUploadRequestModelType), TypeInfoPropertyName = "ModelUploadRequestModelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ModelUploadSuccessResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ModelUploadSuccessResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DataItem), TypeInfoPropertyName = "DataItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ImageResponseDataB64))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ImageResponseDataUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ImageResponseDataItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ImageResponseDataItemDiscriminatorType), TypeInfoPropertyName = "ImageResponseDataItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ImageResponseDataB64Type), TypeInfoPropertyName = "ImageResponseDataB64Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ImageResponseDataUrlType), TypeInfoPropertyName = "ImageResponseDataUrlType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.JobInfoSuccessResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.JobInfoSuccessResponseStatus), TypeInfoPropertyName = "JobInfoSuccessResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.JobInfoSuccessResponseStatusUpdate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.JobInfoSuccessResponseStatusUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.JobInfoSuccessResponseArgs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.JobsInfoSuccessResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.JobInfoSuccessResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ToolsPartFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ToolChoiceType), TypeInfoPropertyName = "ToolChoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ToolChoiceFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FilePurpose), TypeInfoPropertyName = "FilePurpose2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FileType), TypeInfoPropertyName = "FileType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FileProcessingStatus), TypeInfoPropertyName = "FileProcessingStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FileValidationReport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FileValidationReportErrorType), TypeInfoPropertyName = "FileValidationReportErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FileList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.FileResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FileDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FinetuneResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<int?, global::Together.FinetuneResponseBatchSize?>), TypeInfoPropertyName = "OneOfInt32FinetuneResponseBatchSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FinetuneResponseBatchSize), TypeInfoPropertyName = "FinetuneResponseBatchSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.LRScheduler))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<bool?, global::Together.FinetuneResponseTrainOnInputs?>), TypeInfoPropertyName = "OneOfBooleanFinetuneResponseTrainOnInputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FinetuneResponseTrainOnInputs), TypeInfoPropertyName = "FinetuneResponseTrainOnInputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.TrainingMethodSFT, global::Together.TrainingMethodDPO>), TypeInfoPropertyName = "OneOfTrainingMethodSFTTrainingMethodDPO2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.TrainingMethodSFT))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.TrainingMethodDPO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.FullTrainingType, global::Together.LoRATrainingType>), TypeInfoPropertyName = "OneOfFullTrainingTypeLoRATrainingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FullTrainingType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.LoRATrainingType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.MultimodalParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FinetuneJobStatus), TypeInfoPropertyName = "FinetuneJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.FineTuneEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FineTuneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FineTuneProgress))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FinetuneResponseTruncated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FinetuneDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FineTunePreviewRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FineTunePreviewRequestTrainingMethod), TypeInfoPropertyName = "FineTunePreviewRequestTrainingMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FineTunePreviewResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FineTunePreviewResponseDatasetFormat), TypeInfoPropertyName = "FineTunePreviewResponseDatasetFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.FineTunePreviewRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FineTunePreviewRow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FineTunePreviewMessageError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FineTunePreviewDetailError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FineTuneModelLimits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FineTuneModelLimitsFullTraining))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FineTuneModelLimitsLoraTraining))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FinetuneEventLevels), TypeInfoPropertyName = "FinetuneEventLevels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FinetuneEventType), TypeInfoPropertyName = "FinetuneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FinetuneTruncatedList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.FinetuneResponseTruncated>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FinetuneListEvents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FineTuneTokenizedDatasetRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FinetuneListCheckpoints))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.FineTuneCheckpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FineTuneCheckpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FineTuneCheckpointCheckpoint), TypeInfoPropertyName = "FineTuneCheckpointCheckpoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FullTrainingTypeType), TypeInfoPropertyName = "FullTrainingTypeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.LoRATrainingTypeType), TypeInfoPropertyName = "LoRATrainingTypeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.TrainingMethodSFTMethod), TypeInfoPropertyName = "TrainingMethodSFTMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<bool?, global::Together.TrainingMethodSFTTrainOnInputs?>), TypeInfoPropertyName = "OneOfBooleanTrainingMethodSFTTrainOnInputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.TrainingMethodSFTTrainOnInputs), TypeInfoPropertyName = "TrainingMethodSFTTrainOnInputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.TrainingMethodDPOMethod), TypeInfoPropertyName = "TrainingMethodDPOMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.LRSchedulerLrSchedulerType), TypeInfoPropertyName = "LRSchedulerLrSchedulerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.LinearLRSchedulerArgs, global::Together.CosineLRSchedulerArgs>), TypeInfoPropertyName = "OneOfLinearLRSchedulerArgsCosineLRSchedulerArgs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.LinearLRSchedulerArgs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CosineLRSchedulerArgs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.Autoscaling))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.HardwareSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EndpointPricing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.HardwareAvailability))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.HardwareAvailabilityStatus), TypeInfoPropertyName = "HardwareAvailabilityStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.HardwareWithStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateEndpointRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateEndpointRequestState), TypeInfoPropertyName = "CreateEndpointRequestState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DedicatedEndpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DedicatedEndpointType), TypeInfoPropertyName = "DedicatedEndpointType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DedicatedEndpointState), TypeInfoPropertyName = "DedicatedEndpointState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ListEndpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ListEndpointType), TypeInfoPropertyName = "ListEndpointType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ListEndpointState), TypeInfoPropertyName = "ListEndpointState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DisplayorExecuteOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DisplayorExecuteOutputData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DisplayorExecuteOutputType), TypeInfoPropertyName = "DisplayorExecuteOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.Error), TypeInfoPropertyName = "Error2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ErrorOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ErrorOutputType), TypeInfoPropertyName = "ErrorOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.ExecuteRequestFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteRequestFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteRequestFileEncoding), TypeInfoPropertyName = "ExecuteRequestFileEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteRequestLanguage), TypeInfoPropertyName = "ExecuteRequestLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteResponse), TypeInfoPropertyName = "ExecuteResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteResponseSuccessfulExecution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteResponseSuccessfulExecutionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.OutputsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OutputsItem), TypeInfoPropertyName = "OutputsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputStreamOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputStreamOutputType), TypeInfoPropertyName = "ExecuteResponseSuccessfulExecutionDataOutputStreamOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputErrorOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputErrorOutputType), TypeInfoPropertyName = "ExecuteResponseSuccessfulExecutionDataOutputErrorOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutputData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutputType), TypeInfoPropertyName = "ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputDiscriminatorType), TypeInfoPropertyName = "ExecuteResponseSuccessfulExecutionDataOutputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteResponseSuccessfulExecutionDataStatus), TypeInfoPropertyName = "ExecuteResponseSuccessfulExecutionDataStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteResponseFailedExecution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.OneOf<string, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<string, object>), TypeInfoPropertyName = "OneOfStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.InterpreterOutput), TypeInfoPropertyName = "InterpreterOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.InterpreterOutputStreamOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.InterpreterOutputStreamOutputType), TypeInfoPropertyName = "InterpreterOutputStreamOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.InterpreterOutputErrorOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.InterpreterOutputErrorOutputType), TypeInfoPropertyName = "InterpreterOutputErrorOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.InterpreterOutputDisplayorExecuteOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.InterpreterOutputDisplayorExecuteOutputData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.InterpreterOutputDisplayorExecuteOutputType), TypeInfoPropertyName = "InterpreterOutputDisplayorExecuteOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.InterpreterOutputDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.InterpreterOutputDiscriminatorType), TypeInfoPropertyName = "InterpreterOutputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.SessionListResponse), TypeInfoPropertyName = "SessionListResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.SessionListResponseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.SessionListResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.SessionListResponseVariant2Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.SessionListResponseVariant2DataSession>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.SessionListResponseVariant2DataSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.StreamOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.StreamOutputType), TypeInfoPropertyName = "StreamOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateBatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateBatchRequestEndpoint), TypeInfoPropertyName = "CreateBatchRequestEndpoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.BatchErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.BatchJobWithWarning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.BatchJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.BatchJobStatus), TypeInfoPropertyName = "BatchJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationTypedRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationTypedRequestType), TypeInfoPropertyName = "EvaluationTypedRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.EvaluationClassifyParameters, global::Together.EvaluationScoreParameters, global::Together.EvaluationCompareParameters>), TypeInfoPropertyName = "OneOfEvaluationClassifyParametersEvaluationScoreParametersEvaluationCompareParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationClassifyParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationScoreParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationCompareParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationJudgeModelConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationModelOrString), TypeInfoPropertyName = "EvaluationModelOrString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.EvaluationModelRequest, string>), TypeInfoPropertyName = "OneOfEvaluationModelRequestString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationJudgeModelConfigModelSource), TypeInfoPropertyName = "EvaluationJudgeModelConfigModelSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationModelRequestModelSource), TypeInfoPropertyName = "EvaluationModelRequestModelSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationResponseStatus), TypeInfoPropertyName = "EvaluationResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationJobType), TypeInfoPropertyName = "EvaluationJobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationJobStatus), TypeInfoPropertyName = "EvaluationJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.EvaluationJobStatusUpdate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationJobStatusUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.EvaluationClassifyResults, global::Together.EvaluationScoreResults, global::Together.EvaluationCompareResults, global::Together.EvaluationJobResults>), TypeInfoPropertyName = "OneOfEvaluationClassifyResultsEvaluationScoreResultsEvaluationCompareResultsEvaluationJobResults2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationClassifyResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationScoreResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationCompareResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationJobResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationScoreResultsAggregatedScores))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateVideoBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.VideoOutputFormat), TypeInfoPropertyName = "VideoOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.VideoMedia))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.VideoFrameImageInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.VideoFrameImageInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.VideoStatus), TypeInfoPropertyName = "VideoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AnyOf<double?, global::Together.VideoFrameImageInputFrame?>), TypeInfoPropertyName = "AnyOfDoubleVideoFrameImageInputFrame2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.VideoFrameImageInputFrame), TypeInfoPropertyName = "VideoFrameImageInputFrame2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.VideoRef>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.VideoRef))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<string, global::Together.VideoRef>), TypeInfoPropertyName = "OneOfStringVideoRef2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.OneOf<string, global::Together.AudioRef>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<string, global::Together.AudioRef>), TypeInfoPropertyName = "OneOfStringAudioRef2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioRef))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.VideoJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.VideoJobError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.VideoJobOutputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ContainerStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.SignedURLResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateDeploymentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.HTTPAutoscalingConfig, global::Together.QueueAutoscalingConfig, global::Together.CustomMetricAutoscalingConfig>), TypeInfoPropertyName = "OneOfHTTPAutoscalingConfigQueueAutoscalingConfigCustomMetricAutoscalingConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.HTTPAutoscalingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.QueueAutoscalingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CustomMetricAutoscalingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.EnvironmentVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EnvironmentVariable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateDeploymentRequestGpuType), TypeInfoPropertyName = "CreateDeploymentRequestGpuType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.VolumeMount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.VolumeMount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateSecretRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateVolumeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.VolumeContentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.VolumeType), TypeInfoPropertyName = "VolumeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeploymentListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeploymentResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeploymentResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeploymentLogs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeploymentResponseItemGpuType), TypeInfoPropertyName = "DeploymentResponseItemGpuType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Together.ReplicaEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ReplicaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeploymentStatus), TypeInfoPropertyName = "DeploymentStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.HTTPAutoscalingConfigMetric), TypeInfoPropertyName = "HTTPAutoscalingConfigMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.QueueAutoscalingConfigMetric), TypeInfoPropertyName = "QueueAutoscalingConfigMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CustomMetricAutoscalingConfigMetric), TypeInfoPropertyName = "CustomMetricAutoscalingConfigMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.KubernetesEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ListSecretsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.SecretResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.SecretResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ListVolumesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.VolumeResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.VolumeResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.UpdateDeploymentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.UpdateDeploymentRequestGpuType), TypeInfoPropertyName = "UpdateDeploymentRequestGpuType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.UpdateSecretRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.UpdateVolumeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.VolumeContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Together.VersionHistoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.VersionHistoryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.VolumeContentRequestType), TypeInfoPropertyName = "VolumeContentRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.FileInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FileInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.VolumeContentType), TypeInfoPropertyName = "VolumeContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.QueueError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.QueueMetricsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.QueueCancelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.QueueCancelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.QueueCancelResponseStatus), TypeInfoPropertyName = "QueueCancelResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.QueueClearRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.QueueClearResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.QueueJobRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.QueueJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.QueueJobStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.QueueJobStatusResponseStatus), TypeInfoPropertyName = "QueueJobStatusResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.WhoamiResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.BillingUsageReport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.BillingUsageWindow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.BillingUsageWindow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.BillingUsageLineItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.BillingUsageLineItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateImagesGenerationsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AnyOf<global::Together.CreateImagesGenerationsRequestModel?, string>), TypeInfoPropertyName = "AnyOfCreateImagesGenerationsRequestModelString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateImagesGenerationsRequestModel), TypeInfoPropertyName = "CreateImagesGenerationsRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateImagesGenerationsRequestResponseFormat), TypeInfoPropertyName = "CreateImagesGenerationsRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateImagesGenerationsRequestOutputFormat), TypeInfoPropertyName = "CreateImagesGenerationsRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.CreateImagesGenerationsRequestImageLora>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateImagesGenerationsRequestImageLora))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateFilesUploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateFineTunesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<int?, global::Together.CreateFineTunesRequestBatchSize?>), TypeInfoPropertyName = "OneOfInt32CreateFineTunesRequestBatchSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateFineTunesRequestBatchSize), TypeInfoPropertyName = "CreateFineTunesRequestBatchSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<bool?, global::Together.CreateFineTunesRequestTrainOnInputs?>), TypeInfoPropertyName = "OneOfBooleanCreateFineTunesRequestTrainOnInputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateFineTunesRequestTrainOnInputs), TypeInfoPropertyName = "CreateFineTunesRequestTrainOnInputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AnyOf<global::Together.FullTrainingType, global::Together.LoRATrainingType>), TypeInfoPropertyName = "AnyOfFullTrainingTypeLoRATrainingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateFineTunesEstimatePriceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.UpdateEndpointRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.UpdateEndpointRequestState), TypeInfoPropertyName = "UpdateEndpointRequestState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AddAdapterRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RemoveAdapterRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RolloutServiceListRolloutsFilter), TypeInfoPropertyName = "RolloutServiceListRolloutsFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EndpointServiceListEndpointEventsMinLevel), TypeInfoPropertyName = "EndpointServiceListEndpointEventsMinLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.EndpointServiceListEndpointEventsSourceKind>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EndpointServiceListEndpointEventsSourceKind), TypeInfoPropertyName = "EndpointServiceListEndpointEventsSourceKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.VolumeServiceListModelsVisibility), TypeInfoPropertyName = "VolumeServiceListModelsVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.SupportedModelsServiceListSupportedModelsModality), TypeInfoPropertyName = "SupportedModelsServiceListSupportedModelsModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.SupportedModelsServiceListSupportedModelsProduct), TypeInfoPropertyName = "SupportedModelsServiceListSupportedModelsProduct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GetFinetuneDownloadCheckpoint), TypeInfoPropertyName = "GetFinetuneDownloadCheckpoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RealtimeTtsModel), TypeInfoPropertyName = "RealtimeTtsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ListEndpointsType), TypeInfoPropertyName = "ListEndpointsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ListEndpointsUsageType), TypeInfoPropertyName = "ListEndpointsUsageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RealtimeTranscriptionInputAudioFormat), TypeInfoPropertyName = "RealtimeTranscriptionInputAudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.ListModelResourcesStatu>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ListModelResourcesStatu), TypeInfoPropertyName = "ListModelResourcesStatu2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.ListTrainingSessionsStatu>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ListTrainingSessionsStatu), TypeInfoPropertyName = "ListTrainingSessionsStatu2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.RemediationServiceListRemediationsStateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RemediationServiceListRemediationsStateItem), TypeInfoPropertyName = "RemediationServiceListRemediationsStateItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.RemediationServiceListRemediationsTriggerItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RemediationServiceListRemediationsTriggerItem), TypeInfoPropertyName = "RemediationServiceListRemediationsTriggerItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.RemediationServiceListRemediationsModeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RemediationServiceListRemediationsModeItem), TypeInfoPropertyName = "RemediationServiceListRemediationsModeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.HealthCheckServiceListPassiveHealthCheckAlertsStatus), TypeInfoPropertyName = "HealthCheckServiceListPassiveHealthCheckAlertsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.HealthCheckServiceListPassiveHealthCheckAlertsSeverityFilterItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.HealthCheckServiceListPassiveHealthCheckAlertsSeverityFilterItem), TypeInfoPropertyName = "HealthCheckServiceListPassiveHealthCheckAlertsSeverityFilterItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.HealthCheckServiceListPassiveHealthCheckAlertsOrderBy), TypeInfoPropertyName = "HealthCheckServiceListPassiveHealthCheckAlertsOrderBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GetBillingUsageGranularity), TypeInfoPropertyName = "GetBillingUsageGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.CreateFineTunesEstimatePriceResponseVariant1, global::Together.CreateFineTunesEstimatePriceResponseVariant2>), TypeInfoPropertyName = "OneOfCreateFineTunesEstimatePriceResponseVariant1CreateFineTunesEstimatePriceResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateFineTunesEstimatePriceResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateFineTunesEstimatePriceResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateFineTunesEstimatePriceResponseVariant2UnavailableReason), TypeInfoPropertyName = "CreateFineTunesEstimatePriceResponseVariant2UnavailableReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.FineTunePreviewMessageError, global::Together.FineTunePreviewDetailError>), TypeInfoPropertyName = "OneOfFineTunePreviewMessageErrorFineTunePreviewDetailError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GetFineTunesMetricsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GetFineTunesModelsSupportedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.GetFineTunesModelsSupportedResponseDetailedModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GetFineTunesModelsSupportedResponseDetailedModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GetFineTunesModelsLimitsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ListEndpointsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.ListEndpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AddAdapterResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ListAdaptersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.ListAdaptersResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ListAdaptersResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RemoveAdapterResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ListHardwareResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.HardwareWithStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.BatchJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.EvaluationJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GetModelListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GetEvaluationJobStatusAndResultsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GetEvaluationJobStatusAndResultsResponseStatus), TypeInfoPropertyName = "GetEvaluationJobStatusAndResultsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.EvaluationClassifyResults, global::Together.EvaluationScoreResults, global::Together.EvaluationCompareResults>), TypeInfoPropertyName = "OneOfEvaluationClassifyResultsEvaluationScoreResultsEvaluationCompareResults2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeEndpointVisibility?), TypeInfoPropertyName = "NullableDeEndpointVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeEndpointEndpointType?), TypeInfoPropertyName = "NullableDeEndpointEndpointType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeDeploymentSummaryTrafficMode?), TypeInfoPropertyName = "NullableDeDeploymentSummaryTrafficMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeDeploymentSummaryState?), TypeInfoPropertyName = "NullableDeDeploymentSummaryState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeAutoscalingResponse?), TypeInfoPropertyName = "NullableDeAutoscalingResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeCreateEndpointRequestVisibility?), TypeInfoPropertyName = "NullableDeCreateEndpointRequestVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeEndpointUpdateVisibility?), TypeInfoPropertyName = "NullableDeEndpointUpdateVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DePlacement?), TypeInfoPropertyName = "NullableDePlacement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeDeploymentTrafficMode?), TypeInfoPropertyName = "NullableDeDeploymentTrafficMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeDeploymentAdapterStatusState?), TypeInfoPropertyName = "NullableDeDeploymentAdapterStatusState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeMetricRuleName?), TypeInfoPropertyName = "NullableDeMetricRuleName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeMetricRuleStat?), TypeInfoPropertyName = "NullableDeMetricRuleStat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeThresholdCheckOperator?), TypeInfoPropertyName = "NullableDeThresholdCheckOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRegressionCheckDirection?), TypeInfoPropertyName = "NullableDeRegressionCheckDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeCancelRolloutRequestDisposition?), TypeInfoPropertyName = "NullableDeCancelRolloutRequestDisposition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRolloutStrategy?), TypeInfoPropertyName = "NullableDeRolloutStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRolloutState?), TypeInfoPropertyName = "NullableDeRolloutState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRolloutConditionCategory?), TypeInfoPropertyName = "NullableDeRolloutConditionCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRolloutConditionType?), TypeInfoPropertyName = "NullableDeRolloutConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRolloutStepStatusState?), TypeInfoPropertyName = "NullableDeRolloutStepStatusState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeMetricResultStat?), TypeInfoPropertyName = "NullableDeMetricResultStat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeMetricResultCheck?), TypeInfoPropertyName = "NullableDeMetricResultCheck2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeMetricResultOperator?), TypeInfoPropertyName = "NullableDeMetricResultOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeMetricResultDirection?), TypeInfoPropertyName = "NullableDeMetricResultDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeMetricResultVerdict?), TypeInfoPropertyName = "NullableDeMetricResultVerdict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeABExperimentMemberRole?), TypeInfoPropertyName = "NullableDeABExperimentMemberRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeInlinePlacementConstraint?), TypeInfoPropertyName = "NullableDeInlinePlacementConstraint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeSupportedModelInputModalitie?), TypeInfoPropertyName = "NullableDeSupportedModelInputModalitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeSupportedModelOutputModalitie?), TypeInfoPropertyName = "NullableDeSupportedModelOutputModalitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeSupportedModelProduct?), TypeInfoPropertyName = "NullableDeSupportedModelProduct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeSupportedModelFeature?), TypeInfoPropertyName = "NullableDeSupportedModelFeature2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeSupportedModelCapabilitie?), TypeInfoPropertyName = "NullableDeSupportedModelCapabilitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeSupportedModelStatus?), TypeInfoPropertyName = "NullableDeSupportedModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeShadowExperimentState?), TypeInfoPropertyName = "NullableDeShadowExperimentState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeShadowExperimentSampling?), TypeInfoPropertyName = "NullableDeShadowExperimentSampling2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeShadowExperimentSamplingResponse?), TypeInfoPropertyName = "NullableDeShadowExperimentSamplingResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeUpdateModelRequestVisibility?), TypeInfoPropertyName = "NullableDeUpdateModelRequestVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeHeadroomRelation?), TypeInfoPropertyName = "NullableDeHeadroomRelation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRemoteUploadStatus?), TypeInfoPropertyName = "NullableDeRemoteUploadStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeModelVisibility?), TypeInfoPropertyName = "NullableDeModelVisibility2")]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.OneOf<global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2, global::Together.ChatCompletionUserMessageContentMultimodalItemVideo, global::Together.ChatCompletionUserMessageContentMultimodalItemAudio, global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudio>>), TypeInfoPropertyName = "ChatCompletionUserMessageContentMultimodalItemInputAudio_9a6c1a339fc4e5a1")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2, global::Together.ChatCompletionUserMessageContentMultimodalItemVideo, global::Together.ChatCompletionUserMessageContentMultimodalItemAudio, global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudio>), TypeInfoPropertyName = "ChatCompletionUserMessageContentMultimodalItemInputAudio_e050a39467d446fd")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2, global::Together.ChatCompletionUserMessageContentMultimodalItemVideo, global::Together.ChatCompletionUserMessageContentMultimodalItemAudio, global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudio>?), TypeInfoPropertyName = "ChatCompletionUserMessageContentMultimodalItemInputAudio_f38c2c0c365e74fc")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.OneOf<global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2, global::Together.ChatCompletionUserMessageContentMultimodalItemVideo, global::Together.ChatCompletionUserMessageContentMultimodalItemAudio, global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudio>>), TypeInfoPropertyName = "ChatCompletionUserMessageContentMultimodalItemInputAudio_6724b54fa98b04fd")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRemoteUploadEventLevel?), TypeInfoPropertyName = "NullableDeRemoteUploadEventLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeDeploymentStatusState?), TypeInfoPropertyName = "NullableDeDeploymentStatusState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeEndpointEventLevel?), TypeInfoPropertyName = "NullableDeEndpointEventLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeEndpointEventSourceKind?), TypeInfoPropertyName = "NullableDeEndpointEventSourceKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeListRevisionsResponseRevisionValidationStatus?), TypeInfoPropertyName = "NullableDeListRevisionsResponseRevisionValidationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeConfigEngineType?), TypeInfoPropertyName = "NullableDeConfigEngineType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeConfigDeploymentFramework?), TypeInfoPropertyName = "NullableDeConfigDeploymentFramework2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeCertificationTarget?), TypeInfoPropertyName = "NullableDeCertificationTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeCertificationCertificationType?), TypeInfoPropertyName = "NullableDeCertificationCertificationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeModelWeightsType?), TypeInfoPropertyName = "NullableDeModelWeightsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeModelWeightsSpeculatorMechanism?), TypeInfoPropertyName = "NullableDeModelWeightsSpeculatorMechanism2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeModelWeightsDraftSpeculatorType?), TypeInfoPropertyName = "NullableDeModelWeightsDraftSpeculatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeScalingMetricType?), TypeInfoPropertyName = "NullableDeScalingMetricType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlWeightSyncType?), TypeInfoPropertyName = "NullableRlWeightSyncType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<string, int?>?), TypeInfoPropertyName = "NullableOneOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlModelResourcesStatus?), TypeInfoPropertyName = "NullableRlModelResourcesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlModelResourcesErrorCode?), TypeInfoPropertyName = "NullableRlModelResourcesErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlDType?), TypeInfoPropertyName = "NullableRlDType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlLossType?), TypeInfoPropertyName = "NullableRlLossType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlGRPOLossAggregationType?), TypeInfoPropertyName = "NullableRlGRPOLossAggregationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlGRPOLossRatioType?), TypeInfoPropertyName = "NullableRlGRPOLossRatioType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTensorDataDtype?), TypeInfoPropertyName = "NullableRlTensorDataDtype2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTrainingOperationStatus?), TypeInfoPropertyName = "NullableRlTrainingOperationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlStopReason?), TypeInfoPropertyName = "NullableRlStopReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTrainingOperationErrorCode?), TypeInfoPropertyName = "NullableRlTrainingOperationErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTrainingSessionStatus?), TypeInfoPropertyName = "NullableRlTrainingSessionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTrainingSessionErrorCode?), TypeInfoPropertyName = "NullableRlTrainingSessionErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlMuonScalingStrategy?), TypeInfoPropertyName = "NullableRlMuonScalingStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlCheckpointType?), TypeInfoPropertyName = "NullableRlCheckpointType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlCheckpointVariant?), TypeInfoPropertyName = "NullableRlCheckpointVariant2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<string, long?>?), TypeInfoPropertyName = "NullableOneOfStringInt642")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterCreateRequestClusterType?), TypeInfoPropertyName = "NullableGPUClusterCreateRequestClusterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterCreateRequestGpuType?), TypeInfoPropertyName = "NullableGPUClusterCreateRequestGpuType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterCreateRequestBillingType?), TypeInfoPropertyName = "NullableGPUClusterCreateRequestBillingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterInfoClusterType?), TypeInfoPropertyName = "NullableGPUClusterInfoClusterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterInfoGpuType?), TypeInfoPropertyName = "NullableGPUClusterInfoGpuType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterInfoStatus?), TypeInfoPropertyName = "NullableGPUClusterInfoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterInfoBillingType?), TypeInfoPropertyName = "NullableGPUClusterInfoBillingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterUpdateRequestClusterType?), TypeInfoPropertyName = "NullableGPUClusterUpdateRequestClusterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.InstanceTypesResponseType?), TypeInfoPropertyName = "NullableInstanceTypesResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AcceptanceTestsParamsDcgmDiagLevel?), TypeInfoPropertyName = "NullableAcceptanceTestsParamsDcgmDiagLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ApproveRemediationRequestMode?), TypeInfoPropertyName = "NullableApproveRemediationRequestMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ClusterPhaseTransitionPhase?), TypeInfoPropertyName = "NullableClusterPhaseTransitionPhase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.InstanceClusterConfigLoadBalancer?), TypeInfoPropertyName = "NullableInstanceClusterConfigLoadBalancer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.NodePhaseTransitionPhase?), TypeInfoPropertyName = "NullableNodePhaseTransitionPhase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.PassiveHealthCheckAlertSeverity?), TypeInfoPropertyName = "NullablePassiveHealthCheckAlertSeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RemediationMode?), TypeInfoPropertyName = "NullableRemediationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RemediationTrigger?), TypeInfoPropertyName = "NullableRemediationTrigger2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RemediationState?), TypeInfoPropertyName = "NullableRemediationState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClustersSharedVolumeStatus?), TypeInfoPropertyName = "NullableGPUClustersSharedVolumeStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AnyOf<global::Together.RerankRequestModel?, string>?), TypeInfoPropertyName = "NullableAnyOfRerankRequestModelString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RerankRequestModel?), TypeInfoPropertyName = "NullableRerankRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::System.Collections.Generic.IList<object>, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableOneOfIListObjectIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FinishReason?), TypeInfoPropertyName = "NullableFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AnyOf<global::Together.CompletionRequestModel?, string>?), TypeInfoPropertyName = "NullableAnyOfCompletionRequestModelString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CompletionRequestModel?), TypeInfoPropertyName = "NullableCompletionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AnyOf<global::Together.CompletionRequestSafetyModel?, string>?), TypeInfoPropertyName = "NullableAnyOfCompletionRequestSafetyModelString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CompletionRequestSafetyModel?), TypeInfoPropertyName = "NullableCompletionRequestSafetyModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CompletionStream?), TypeInfoPropertyName = "NullableCompletionStream2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AllOf<global::Together.UsageData, object>?), TypeInfoPropertyName = "NullableAllOfUsageDataObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AllOf<global::Together.FinishReason?, object>?), TypeInfoPropertyName = "NullableAllOfFinishReasonObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CompletionChoiceDeltaRole?), TypeInfoPropertyName = "NullableCompletionChoiceDeltaRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AllOf<object, global::Together.LogprobsPart>?), TypeInfoPropertyName = "NullableAllOfObjectLogprobsPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionMessageRole?), TypeInfoPropertyName = "NullableChatCompletionMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionToolType?), TypeInfoPropertyName = "NullableChatCompletionToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionMessageParam?), TypeInfoPropertyName = "NullableChatCompletionMessageParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionRequestContextLengthExceededBehavior?), TypeInfoPropertyName = "NullableChatCompletionRequestContextLengthExceededBehavior2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.ChatCompletionRequestFunctionCallEnum?, global::Together.ChatCompletionRequestFunctionCallEnum2>?), TypeInfoPropertyName = "NullableOneOfChatCompletionRequestFunctionCallEnumChatCompletionRequestFunctionCallEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionRequestFunctionCallEnum?), TypeInfoPropertyName = "NullableChatCompletionRequestFunctionCallEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ResponseFormat?), TypeInfoPropertyName = "NullableResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionRequestResponseFormatDiscriminatorType?), TypeInfoPropertyName = "NullableChatCompletionRequestResponseFormatDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<string, global::Together.ToolChoice2>?), TypeInfoPropertyName = "NullableOneOfStringToolChoice22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionRequestReasoningEffort?), TypeInfoPropertyName = "NullableChatCompletionRequestReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ResponseFormatTextType?), TypeInfoPropertyName = "NullableResponseFormatTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ResponseFormatJsonObjectType?), TypeInfoPropertyName = "NullableResponseFormatJsonObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ResponseFormatJsonSchemaType?), TypeInfoPropertyName = "NullableResponseFormatJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionSystemMessageParamRole?), TypeInfoPropertyName = "NullableChatCompletionSystemMessageParamRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionUserMessageContent?), TypeInfoPropertyName = "NullableChatCompletionUserMessageContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionUserMessageParamRole?), TypeInfoPropertyName = "NullableChatCompletionUserMessageParamRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1Type?), TypeInfoPropertyName = "NullableChatCompletionUserMessageContentMultimodalItemVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2Type?), TypeInfoPropertyName = "NullableChatCompletionUserMessageContentMultimodalItemVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemVideoType?), TypeInfoPropertyName = "NullableChatCompletionUserMessageContentMultimodalItemVideoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemAudioType?), TypeInfoPropertyName = "NullableChatCompletionUserMessageContentMultimodalItemAudioType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudioType?), TypeInfoPropertyName = "NullableChatCompletionUserMessageContentMultimodalItemInputAudioType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudioInputAudioFormat?), TypeInfoPropertyName = "NullableChatCompletionUserMessageContentMultimodalItemInputAudioInputAudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionAssistantMessageParamRole?), TypeInfoPropertyName = "NullableChatCompletionAssistantMessageParamRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionFunctionMessageParamRole?), TypeInfoPropertyName = "NullableChatCompletionFunctionMessageParamRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionToolMessageParamRole?), TypeInfoPropertyName = "NullableChatCompletionToolMessageParamRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionStream?), TypeInfoPropertyName = "NullableChatCompletionStream2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionChunkChoiceDeltaRole?), TypeInfoPropertyName = "NullableChatCompletionChunkChoiceDeltaRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AnyOf<global::Together.AudioSpeechRequestModel?, string>?), TypeInfoPropertyName = "NullableAnyOfAudioSpeechRequestModelString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioSpeechRequestModel?), TypeInfoPropertyName = "NullableAudioSpeechRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioSpeechRequestResponseFormat?), TypeInfoPropertyName = "NullableAudioSpeechRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioSpeechRequestResponseEncoding?), TypeInfoPropertyName = "NullableAudioSpeechRequestResponseEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<byte[], string>?), TypeInfoPropertyName = "NullableOneOfByteArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranscriptionRequestModel?), TypeInfoPropertyName = "NullableAudioTranscriptionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranscriptionRequestResponseFormat?), TypeInfoPropertyName = "NullableAudioTranscriptionRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.AudioTranscriptionRequestTimestampGranularities?, global::System.Collections.Generic.IList<global::Together.AudioTranscriptionRequestTimestampGranularitie>>?), TypeInfoPropertyName = "NullableOneOfAudioTranscriptionRequestTimestampGranularitiesIListAudioTranscriptionRequestTimestampGranularitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranscriptionRequestTimestampGranularities?), TypeInfoPropertyName = "NullableAudioTranscriptionRequestTimestampGranularities2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranscriptionRequestTimestampGranularitie?), TypeInfoPropertyName = "NullableAudioTranscriptionRequestTimestampGranularitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranscriptionResponse?), TypeInfoPropertyName = "NullableAudioTranscriptionResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranslationRequestModel?), TypeInfoPropertyName = "NullableAudioTranslationRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranslationRequestResponseFormat?), TypeInfoPropertyName = "NullableAudioTranslationRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.AudioTranslationRequestTimestampGranularities?, global::System.Collections.Generic.IList<global::Together.AudioTranslationRequestTimestampGranularitie>>?), TypeInfoPropertyName = "NullableOneOfAudioTranslationRequestTimestampGranularitiesIListAudioTranslationRequestTimestampGranularitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranslationRequestTimestampGranularities?), TypeInfoPropertyName = "NullableAudioTranslationRequestTimestampGranularities2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranslationRequestTimestampGranularitie?), TypeInfoPropertyName = "NullableAudioTranslationRequestTimestampGranularitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranslationResponse?), TypeInfoPropertyName = "NullableAudioTranslationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioSpeechStreamResponse?), TypeInfoPropertyName = "NullableAudioSpeechStreamResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.StreamSentinelData?), TypeInfoPropertyName = "NullableStreamSentinelData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionChoiceDeltaRole?), TypeInfoPropertyName = "NullableChatCompletionChoiceDeltaRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AnyOf<global::Together.EmbeddingsRequestModel?, string>?), TypeInfoPropertyName = "NullableAnyOfEmbeddingsRequestModelString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EmbeddingsRequestModel?), TypeInfoPropertyName = "NullableEmbeddingsRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableOneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ModelInfoType?), TypeInfoPropertyName = "NullableModelInfoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ModelUploadRequestModelType?), TypeInfoPropertyName = "NullableModelUploadRequestModelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DataItem?), TypeInfoPropertyName = "NullableDataItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ImageResponseDataItemDiscriminatorType?), TypeInfoPropertyName = "NullableImageResponseDataItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ImageResponseDataB64Type?), TypeInfoPropertyName = "NullableImageResponseDataB64Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ImageResponseDataUrlType?), TypeInfoPropertyName = "NullableImageResponseDataUrlType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.JobInfoSuccessResponseStatus?), TypeInfoPropertyName = "NullableJobInfoSuccessResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ToolChoiceType?), TypeInfoPropertyName = "NullableToolChoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FilePurpose?), TypeInfoPropertyName = "NullableFilePurpose2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FileType?), TypeInfoPropertyName = "NullableFileType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FileProcessingStatus?), TypeInfoPropertyName = "NullableFileProcessingStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FileValidationReportErrorType?), TypeInfoPropertyName = "NullableFileValidationReportErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<int?, global::Together.FinetuneResponseBatchSize?>?), TypeInfoPropertyName = "NullableOneOfInt32FinetuneResponseBatchSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FinetuneResponseBatchSize?), TypeInfoPropertyName = "NullableFinetuneResponseBatchSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<bool?, global::Together.FinetuneResponseTrainOnInputs?>?), TypeInfoPropertyName = "NullableOneOfBooleanFinetuneResponseTrainOnInputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FinetuneResponseTrainOnInputs?), TypeInfoPropertyName = "NullableFinetuneResponseTrainOnInputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.TrainingMethodSFT, global::Together.TrainingMethodDPO>?), TypeInfoPropertyName = "NullableOneOfTrainingMethodSFTTrainingMethodDPO2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.FullTrainingType, global::Together.LoRATrainingType>?), TypeInfoPropertyName = "NullableOneOfFullTrainingTypeLoRATrainingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FinetuneJobStatus?), TypeInfoPropertyName = "NullableFinetuneJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FineTunePreviewRequestTrainingMethod?), TypeInfoPropertyName = "NullableFineTunePreviewRequestTrainingMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FineTunePreviewResponseDatasetFormat?), TypeInfoPropertyName = "NullableFineTunePreviewResponseDatasetFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FinetuneEventLevels?), TypeInfoPropertyName = "NullableFinetuneEventLevels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FinetuneEventType?), TypeInfoPropertyName = "NullableFinetuneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FineTuneCheckpointCheckpoint?), TypeInfoPropertyName = "NullableFineTuneCheckpointCheckpoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FullTrainingTypeType?), TypeInfoPropertyName = "NullableFullTrainingTypeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.LoRATrainingTypeType?), TypeInfoPropertyName = "NullableLoRATrainingTypeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.TrainingMethodSFTMethod?), TypeInfoPropertyName = "NullableTrainingMethodSFTMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<bool?, global::Together.TrainingMethodSFTTrainOnInputs?>?), TypeInfoPropertyName = "NullableOneOfBooleanTrainingMethodSFTTrainOnInputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.TrainingMethodSFTTrainOnInputs?), TypeInfoPropertyName = "NullableTrainingMethodSFTTrainOnInputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.TrainingMethodDPOMethod?), TypeInfoPropertyName = "NullableTrainingMethodDPOMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.LRSchedulerLrSchedulerType?), TypeInfoPropertyName = "NullableLRSchedulerLrSchedulerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.LinearLRSchedulerArgs, global::Together.CosineLRSchedulerArgs>?), TypeInfoPropertyName = "NullableOneOfLinearLRSchedulerArgsCosineLRSchedulerArgs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.HardwareAvailabilityStatus?), TypeInfoPropertyName = "NullableHardwareAvailabilityStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateEndpointRequestState?), TypeInfoPropertyName = "NullableCreateEndpointRequestState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DedicatedEndpointType?), TypeInfoPropertyName = "NullableDedicatedEndpointType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DedicatedEndpointState?), TypeInfoPropertyName = "NullableDedicatedEndpointState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ListEndpointType?), TypeInfoPropertyName = "NullableListEndpointType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ListEndpointState?), TypeInfoPropertyName = "NullableListEndpointState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DisplayorExecuteOutputType?), TypeInfoPropertyName = "NullableDisplayorExecuteOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.Error?), TypeInfoPropertyName = "NullableError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ErrorOutputType?), TypeInfoPropertyName = "NullableErrorOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteRequestFileEncoding?), TypeInfoPropertyName = "NullableExecuteRequestFileEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteRequestLanguage?), TypeInfoPropertyName = "NullableExecuteRequestLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteResponse?), TypeInfoPropertyName = "NullableExecuteResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OutputsItem?), TypeInfoPropertyName = "NullableOutputsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputStreamOutputType?), TypeInfoPropertyName = "NullableExecuteResponseSuccessfulExecutionDataOutputStreamOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputErrorOutputType?), TypeInfoPropertyName = "NullableExecuteResponseSuccessfulExecutionDataOutputErrorOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutputType?), TypeInfoPropertyName = "NullableExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputDiscriminatorType?), TypeInfoPropertyName = "NullableExecuteResponseSuccessfulExecutionDataOutputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ExecuteResponseSuccessfulExecutionDataStatus?), TypeInfoPropertyName = "NullableExecuteResponseSuccessfulExecutionDataStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<string, object>?), TypeInfoPropertyName = "NullableOneOfStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.InterpreterOutput?), TypeInfoPropertyName = "NullableInterpreterOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.InterpreterOutputStreamOutputType?), TypeInfoPropertyName = "NullableInterpreterOutputStreamOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.InterpreterOutputErrorOutputType?), TypeInfoPropertyName = "NullableInterpreterOutputErrorOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.InterpreterOutputDisplayorExecuteOutputType?), TypeInfoPropertyName = "NullableInterpreterOutputDisplayorExecuteOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.InterpreterOutputDiscriminatorType?), TypeInfoPropertyName = "NullableInterpreterOutputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.SessionListResponse?), TypeInfoPropertyName = "NullableSessionListResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.StreamOutputType?), TypeInfoPropertyName = "NullableStreamOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateBatchRequestEndpoint?), TypeInfoPropertyName = "NullableCreateBatchRequestEndpoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.BatchJobStatus?), TypeInfoPropertyName = "NullableBatchJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationTypedRequestType?), TypeInfoPropertyName = "NullableEvaluationTypedRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.EvaluationClassifyParameters, global::Together.EvaluationScoreParameters, global::Together.EvaluationCompareParameters>?), TypeInfoPropertyName = "NullableOneOfEvaluationClassifyParametersEvaluationScoreParametersEvaluationCompareParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationModelOrString?), TypeInfoPropertyName = "NullableEvaluationModelOrString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.EvaluationModelRequest, string>?), TypeInfoPropertyName = "NullableOneOfEvaluationModelRequestString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationJudgeModelConfigModelSource?), TypeInfoPropertyName = "NullableEvaluationJudgeModelConfigModelSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationModelRequestModelSource?), TypeInfoPropertyName = "NullableEvaluationModelRequestModelSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationResponseStatus?), TypeInfoPropertyName = "NullableEvaluationResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationJobType?), TypeInfoPropertyName = "NullableEvaluationJobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationJobStatus?), TypeInfoPropertyName = "NullableEvaluationJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.EvaluationClassifyResults, global::Together.EvaluationScoreResults, global::Together.EvaluationCompareResults, global::Together.EvaluationJobResults>?), TypeInfoPropertyName = "NullableOneOfEvaluationClassifyResultsEvaluationScoreResultsEvaluationCompareResultsEvaluationJobResults2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.VideoOutputFormat?), TypeInfoPropertyName = "NullableVideoOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.VideoStatus?), TypeInfoPropertyName = "NullableVideoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AnyOf<double?, global::Together.VideoFrameImageInputFrame?>?), TypeInfoPropertyName = "NullableAnyOfDoubleVideoFrameImageInputFrame2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.VideoFrameImageInputFrame?), TypeInfoPropertyName = "NullableVideoFrameImageInputFrame2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<string, global::Together.VideoRef>?), TypeInfoPropertyName = "NullableOneOfStringVideoRef2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<string, global::Together.AudioRef>?), TypeInfoPropertyName = "NullableOneOfStringAudioRef2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.HTTPAutoscalingConfig, global::Together.QueueAutoscalingConfig, global::Together.CustomMetricAutoscalingConfig>?), TypeInfoPropertyName = "NullableOneOfHTTPAutoscalingConfigQueueAutoscalingConfigCustomMetricAutoscalingConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateDeploymentRequestGpuType?), TypeInfoPropertyName = "NullableCreateDeploymentRequestGpuType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.VolumeType?), TypeInfoPropertyName = "NullableVolumeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeploymentResponseItemGpuType?), TypeInfoPropertyName = "NullableDeploymentResponseItemGpuType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeploymentStatus?), TypeInfoPropertyName = "NullableDeploymentStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.HTTPAutoscalingConfigMetric?), TypeInfoPropertyName = "NullableHTTPAutoscalingConfigMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.QueueAutoscalingConfigMetric?), TypeInfoPropertyName = "NullableQueueAutoscalingConfigMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CustomMetricAutoscalingConfigMetric?), TypeInfoPropertyName = "NullableCustomMetricAutoscalingConfigMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.UpdateDeploymentRequestGpuType?), TypeInfoPropertyName = "NullableUpdateDeploymentRequestGpuType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.VolumeContentRequestType?), TypeInfoPropertyName = "NullableVolumeContentRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.VolumeContentType?), TypeInfoPropertyName = "NullableVolumeContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.QueueCancelResponseStatus?), TypeInfoPropertyName = "NullableQueueCancelResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.QueueJobStatusResponseStatus?), TypeInfoPropertyName = "NullableQueueJobStatusResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AnyOf<global::Together.CreateImagesGenerationsRequestModel?, string>?), TypeInfoPropertyName = "NullableAnyOfCreateImagesGenerationsRequestModelString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateImagesGenerationsRequestModel?), TypeInfoPropertyName = "NullableCreateImagesGenerationsRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateImagesGenerationsRequestResponseFormat?), TypeInfoPropertyName = "NullableCreateImagesGenerationsRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateImagesGenerationsRequestOutputFormat?), TypeInfoPropertyName = "NullableCreateImagesGenerationsRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<int?, global::Together.CreateFineTunesRequestBatchSize?>?), TypeInfoPropertyName = "NullableOneOfInt32CreateFineTunesRequestBatchSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateFineTunesRequestBatchSize?), TypeInfoPropertyName = "NullableCreateFineTunesRequestBatchSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<bool?, global::Together.CreateFineTunesRequestTrainOnInputs?>?), TypeInfoPropertyName = "NullableOneOfBooleanCreateFineTunesRequestTrainOnInputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateFineTunesRequestTrainOnInputs?), TypeInfoPropertyName = "NullableCreateFineTunesRequestTrainOnInputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AnyOf<global::Together.FullTrainingType, global::Together.LoRATrainingType>?), TypeInfoPropertyName = "NullableAnyOfFullTrainingTypeLoRATrainingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.UpdateEndpointRequestState?), TypeInfoPropertyName = "NullableUpdateEndpointRequestState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RolloutServiceListRolloutsFilter?), TypeInfoPropertyName = "NullableRolloutServiceListRolloutsFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EndpointServiceListEndpointEventsMinLevel?), TypeInfoPropertyName = "NullableEndpointServiceListEndpointEventsMinLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EndpointServiceListEndpointEventsSourceKind?), TypeInfoPropertyName = "NullableEndpointServiceListEndpointEventsSourceKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.VolumeServiceListModelsVisibility?), TypeInfoPropertyName = "NullableVolumeServiceListModelsVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.SupportedModelsServiceListSupportedModelsModality?), TypeInfoPropertyName = "NullableSupportedModelsServiceListSupportedModelsModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.SupportedModelsServiceListSupportedModelsProduct?), TypeInfoPropertyName = "NullableSupportedModelsServiceListSupportedModelsProduct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GetFinetuneDownloadCheckpoint?), TypeInfoPropertyName = "NullableGetFinetuneDownloadCheckpoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RealtimeTtsModel?), TypeInfoPropertyName = "NullableRealtimeTtsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ListEndpointsType?), TypeInfoPropertyName = "NullableListEndpointsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ListEndpointsUsageType?), TypeInfoPropertyName = "NullableListEndpointsUsageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RealtimeTranscriptionInputAudioFormat?), TypeInfoPropertyName = "NullableRealtimeTranscriptionInputAudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ListModelResourcesStatu?), TypeInfoPropertyName = "NullableListModelResourcesStatu2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ListTrainingSessionsStatu?), TypeInfoPropertyName = "NullableListTrainingSessionsStatu2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RemediationServiceListRemediationsStateItem?), TypeInfoPropertyName = "NullableRemediationServiceListRemediationsStateItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RemediationServiceListRemediationsTriggerItem?), TypeInfoPropertyName = "NullableRemediationServiceListRemediationsTriggerItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RemediationServiceListRemediationsModeItem?), TypeInfoPropertyName = "NullableRemediationServiceListRemediationsModeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.HealthCheckServiceListPassiveHealthCheckAlertsStatus?), TypeInfoPropertyName = "NullableHealthCheckServiceListPassiveHealthCheckAlertsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.HealthCheckServiceListPassiveHealthCheckAlertsSeverityFilterItem?), TypeInfoPropertyName = "NullableHealthCheckServiceListPassiveHealthCheckAlertsSeverityFilterItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.HealthCheckServiceListPassiveHealthCheckAlertsOrderBy?), TypeInfoPropertyName = "NullableHealthCheckServiceListPassiveHealthCheckAlertsOrderBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GetBillingUsageGranularity?), TypeInfoPropertyName = "NullableGetBillingUsageGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.CreateFineTunesEstimatePriceResponseVariant1, global::Together.CreateFineTunesEstimatePriceResponseVariant2>?), TypeInfoPropertyName = "NullableOneOfCreateFineTunesEstimatePriceResponseVariant1CreateFineTunesEstimatePriceResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateFineTunesEstimatePriceResponseVariant2UnavailableReason?), TypeInfoPropertyName = "NullableCreateFineTunesEstimatePriceResponseVariant2UnavailableReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.FineTunePreviewMessageError, global::Together.FineTunePreviewDetailError>?), TypeInfoPropertyName = "NullableOneOfFineTunePreviewMessageErrorFineTunePreviewDetailError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GetEvaluationJobStatusAndResultsResponseStatus?), TypeInfoPropertyName = "NullableGetEvaluationJobStatusAndResultsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.EvaluationClassifyResults, global::Together.EvaluationScoreResults, global::Together.EvaluationCompareResults>?), TypeInfoPropertyName = "NullableOneOfEvaluationClassifyResultsEvaluationScoreResultsEvaluationCompareResults2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DePublicEndpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeEndpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeTrafficSplitEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeDeploymentSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeABExperimentMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeListFilesResponseFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeAccessEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeInferenceInstanceType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeRemoteUpload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DePlacementProfile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeRemoteUploadEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeDeploymentAdapterStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeAdapterEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeRollout>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeMetricRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeRolloutStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DePreviewWarning>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeRolloutStepStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeRolloutCondition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeMetricResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeSupportedModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeSupportedModelInputModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeSupportedModelOutputModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeSupportedModelProduct>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeSupportedModelFeature>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeSupportedModelCapabilitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeSupportedModelDeploymentProfile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeEndpointEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeListRevisionsResponseRevision>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeModelConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeDeployment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeABExperiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeCreateShadowExperimentTargetRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeShadowExperiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeShadowExperimentTarget>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeTimeSeriesDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeDeploymentAnalyticsData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeCertification>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeSelector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeScalingMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeRevisionValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeDeploymentMetrics>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeConfigSelector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeModelDTypeCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RlModelInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RlTrainingSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RlModelInputChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RlModelResources>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.OneOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RlSampleResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RlSampledSequence>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RlPromptTopLogprobs>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RlPolicyVersionSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RlTargetLogprobGradients>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RlTargetLogprobs>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RlInferenceCheckpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RlTrainingCheckpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RlTrainingSession>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RlSupportedModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RlCheckpointFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.NodePhaseTransition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.AddOnCreateRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.GPUClusterVolume>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.GPUClusterControlPlaneNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.GPUClusterGPUWorkerNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.ClusterPhaseTransition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.AddOnInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.GPUClusterNodeLifecycleEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.AddOnUpdateRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.GPUClusterInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.InstanceTypesResponseType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RegionListResponseRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.ClusterDriverVersionInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.Remediation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.PassiveHealthCheckAlert>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.GPUClustersSharedVolume>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.XidEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.ModelVoices>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.ModelVoicesVoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::System.Collections.Generic.List<object>, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RerankResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.PromptPartItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.CompletionChoicesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.CompletionChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.ToolChoice2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.ChatCompletionChoicesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.ChatCompletionMessageParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.ToolsPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.InferenceWarning>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.ChatCompletionChunkChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.AudioTranscriptionRequestTimestampGranularities?, global::System.Collections.Generic.List<global::Together.AudioTranscriptionRequestTimestampGranularitie>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.AudioTranscriptionRequestTimestampGranularitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.AudioTranscriptionSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.AudioTranscriptionWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.AudioTranscriptionSpeakerSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.AudioTranslationRequestTimestampGranularities?, global::System.Collections.Generic.List<global::Together.AudioTranslationRequestTimestampGranularitie>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.AudioTranslationRequestTimestampGranularitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.EmbeddingsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.ModelInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.JobInfoSuccessResponseStatusUpdate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.JobInfoSuccessResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.FileResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.FineTuneEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.FineTunePreviewRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.FinetuneResponseTruncated>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.FineTuneCheckpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.ExecuteRequestFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.OutputsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.OneOf<string, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.SessionListResponseVariant2DataSession>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.EvaluationJobStatusUpdate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.VideoFrameImageInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.VideoRef>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.OneOf<string, global::Together.AudioRef>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.EnvironmentVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.VolumeMount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeploymentResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.SecretResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.VolumeResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.FileInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.BillingUsageWindow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.BillingUsageLineItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.CreateImagesGenerationsRequestImageLora>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.EndpointServiceListEndpointEventsSourceKind>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.ListModelResourcesStatu>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.ListTrainingSessionsStatu>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RemediationServiceListRemediationsStateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RemediationServiceListRemediationsTriggerItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RemediationServiceListRemediationsModeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.HealthCheckServiceListPassiveHealthCheckAlertsSeverityFilterItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.GetFineTunesModelsSupportedResponseDetailedModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.ListEndpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.ListAdaptersResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.HardwareWithStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.BatchJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.EvaluationJob>))]
    internal sealed partial class SourceGenerationContextChunk2 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContext Default { get; } = new(DefaultOptions);

        private SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            options.Converters.Add(new global::Together.JsonConverters.DePlacementJsonConverter());
            options.Converters.Add(new global::Together.JsonConverters.DeShadowExperimentSamplingResponseJsonConverter());
            options.Converters.Add(new global::Together.JsonConverters.DeShadowExperimentSamplingJsonConverter());
            options.Converters.Add(new global::Together.JsonConverters.DeAutoscalingResponseJsonConverter());
            options.Converters.Add(new global::Together.JsonConverters.CompletionStreamJsonConverter());
            options.Converters.Add(new global::Together.JsonConverters.ResponseFormatJsonConverter());
            options.Converters.Add(new global::Together.JsonConverters.ChatCompletionMessageParamJsonConverter());
            options.Converters.Add(new global::Together.JsonConverters.ChatCompletionUserMessageContentJsonConverter());
            options.Converters.Add(new global::Together.JsonConverters.ChatCompletionStreamJsonConverter());
            options.Converters.Add(new global::Together.JsonConverters.AudioTranscriptionResponseJsonConverter());
            options.Converters.Add(new global::Together.JsonConverters.AudioTranslationResponseJsonConverter());
            options.Converters.Add(new global::Together.JsonConverters.AudioSpeechStreamResponseJsonConverter());
            options.Converters.Add(new global::Together.JsonConverters.DataItemJsonConverter());
            options.Converters.Add(new global::Together.JsonConverters.ErrorJsonConverter());
            options.Converters.Add(new global::Together.JsonConverters.ExecuteResponseJsonConverter());
            options.Converters.Add(new global::Together.JsonConverters.OutputsItemJsonConverter());
            options.Converters.Add(new global::Together.JsonConverters.InterpreterOutputJsonConverter());
            options.Converters.Add(new global::Together.JsonConverters.SessionListResponseJsonConverter());
            options.Converters.Add(new global::Together.JsonConverters.EvaluationModelOrStringJsonConverter());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, long?>());
            options.Converters.Add(new global::Together.JsonConverters.AnyOfJsonConverter<global::Together.RerankRequestModel?, string>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<object>, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Together.JsonConverters.AnyOfJsonConverter<global::Together.CompletionRequestModel?, string>());
            options.Converters.Add(new global::Together.JsonConverters.AnyOfJsonConverter<global::Together.CompletionRequestSafetyModel?, string>());
            options.Converters.Add(new global::Together.JsonConverters.AllOfJsonConverter<global::Together.UsageData, object>());
            options.Converters.Add(new global::Together.JsonConverters.AllOfJsonConverter<global::Together.FinishReason?, object>());
            options.Converters.Add(new global::Together.JsonConverters.AllOfJsonConverter<object, global::Together.LogprobsPart>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::Together.ChatCompletionRequestFunctionCallEnum?, global::Together.ChatCompletionRequestFunctionCallEnum2>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, global::Together.ToolChoice2>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2, global::Together.ChatCompletionUserMessageContentMultimodalItemVideo, global::Together.ChatCompletionUserMessageContentMultimodalItemAudio, global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudio>());
            options.Converters.Add(new global::Together.JsonConverters.AllOfJsonConverter<global::Together.UsageData, object>());
            options.Converters.Add(new global::Together.JsonConverters.AnyOfJsonConverter<global::Together.AudioSpeechRequestModel?, string>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<byte[], string>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::Together.AudioTranscriptionRequestTimestampGranularities?, global::System.Collections.Generic.IList<global::Together.AudioTranscriptionRequestTimestampGranularitie>>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<byte[], string>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::Together.AudioTranslationRequestTimestampGranularities?, global::System.Collections.Generic.IList<global::Together.AudioTranslationRequestTimestampGranularitie>>());
            options.Converters.Add(new global::Together.JsonConverters.AnyOfJsonConverter<global::Together.EmbeddingsRequestModel?, string>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<int?, global::Together.FinetuneResponseBatchSize?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<bool?, global::Together.FinetuneResponseTrainOnInputs?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::Together.TrainingMethodSFT, global::Together.TrainingMethodDPO>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::Together.FullTrainingType, global::Together.LoRATrainingType>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::Together.FullTrainingType, global::Together.LoRATrainingType>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::Together.TrainingMethodSFT, global::Together.TrainingMethodDPO>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<bool?, global::Together.TrainingMethodSFTTrainOnInputs?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::Together.LinearLRSchedulerArgs, global::Together.CosineLRSchedulerArgs>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, object>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, object>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, object>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::Together.EvaluationClassifyParameters, global::Together.EvaluationScoreParameters, global::Together.EvaluationCompareParameters>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::Together.EvaluationModelRequest, string>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::Together.EvaluationModelRequest, string>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::Together.EvaluationClassifyResults, global::Together.EvaluationScoreResults, global::Together.EvaluationCompareResults, global::Together.EvaluationJobResults>());
            options.Converters.Add(new global::Together.JsonConverters.AnyOfJsonConverter<double?, global::Together.VideoFrameImageInputFrame?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, global::Together.VideoRef>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, global::Together.AudioRef>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::Together.HTTPAutoscalingConfig, global::Together.QueueAutoscalingConfig, global::Together.CustomMetricAutoscalingConfig>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::Together.HTTPAutoscalingConfig, global::Together.QueueAutoscalingConfig, global::Together.CustomMetricAutoscalingConfig>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::Together.HTTPAutoscalingConfig, global::Together.QueueAutoscalingConfig, global::Together.CustomMetricAutoscalingConfig>());
            options.Converters.Add(new global::Together.JsonConverters.AnyOfJsonConverter<global::Together.CreateImagesGenerationsRequestModel?, string>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<int?, global::Together.CreateFineTunesRequestBatchSize?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<bool?, global::Together.CreateFineTunesRequestTrainOnInputs?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::Together.TrainingMethodSFT, global::Together.TrainingMethodDPO>());
            options.Converters.Add(new global::Together.JsonConverters.AnyOfJsonConverter<global::Together.FullTrainingType, global::Together.LoRATrainingType>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::Together.TrainingMethodSFT, global::Together.TrainingMethodDPO>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::Together.FullTrainingType, global::Together.LoRATrainingType>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::Together.CreateFineTunesEstimatePriceResponseVariant1, global::Together.CreateFineTunesEstimatePriceResponseVariant2>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::Together.FineTunePreviewMessageError, global::Together.FineTunePreviewDetailError>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::Together.EvaluationClassifyResults, global::Together.EvaluationScoreResults, global::Together.EvaluationCompareResults>());
            options.Converters.Add(new global::Together.JsonConverters.UnixTimestampJsonConverter());

            options.Converters.Add(new LazyEnumJsonConverterFactory());

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Together.DeEndpointVisibility)

                    || typeToConvert == typeof(global::Together.DeEndpointVisibility?)

                    || typeToConvert == typeof(global::Together.DeEndpointEndpointType)

                    || typeToConvert == typeof(global::Together.DeEndpointEndpointType?)

                    || typeToConvert == typeof(global::Together.DeDeploymentSummaryTrafficMode)

                    || typeToConvert == typeof(global::Together.DeDeploymentSummaryTrafficMode?)

                    || typeToConvert == typeof(global::Together.DeDeploymentSummaryState)

                    || typeToConvert == typeof(global::Together.DeDeploymentSummaryState?)

                    || typeToConvert == typeof(global::Together.DeCreateEndpointRequestVisibility)

                    || typeToConvert == typeof(global::Together.DeCreateEndpointRequestVisibility?)

                    || typeToConvert == typeof(global::Together.DeEndpointUpdateVisibility)

                    || typeToConvert == typeof(global::Together.DeEndpointUpdateVisibility?)

                    || typeToConvert == typeof(global::Together.DeDeploymentTrafficMode)

                    || typeToConvert == typeof(global::Together.DeDeploymentTrafficMode?)

                    || typeToConvert == typeof(global::Together.DeDeploymentAdapterStatusState)

                    || typeToConvert == typeof(global::Together.DeDeploymentAdapterStatusState?)

                    || typeToConvert == typeof(global::Together.DeMetricRuleName)

                    || typeToConvert == typeof(global::Together.DeMetricRuleName?)

                    || typeToConvert == typeof(global::Together.DeMetricRuleStat)

                    || typeToConvert == typeof(global::Together.DeMetricRuleStat?)

                    || typeToConvert == typeof(global::Together.DeThresholdCheckOperator)

                    || typeToConvert == typeof(global::Together.DeThresholdCheckOperator?)

                    || typeToConvert == typeof(global::Together.DeRegressionCheckDirection)

                    || typeToConvert == typeof(global::Together.DeRegressionCheckDirection?)

                    || typeToConvert == typeof(global::Together.DeCancelRolloutRequestDisposition)

                    || typeToConvert == typeof(global::Together.DeCancelRolloutRequestDisposition?)

                    || typeToConvert == typeof(global::Together.DeRolloutStrategy)

                    || typeToConvert == typeof(global::Together.DeRolloutStrategy?)

                    || typeToConvert == typeof(global::Together.DeRolloutState)

                    || typeToConvert == typeof(global::Together.DeRolloutState?)

                    || typeToConvert == typeof(global::Together.DeRolloutConditionCategory)

                    || typeToConvert == typeof(global::Together.DeRolloutConditionCategory?)

                    || typeToConvert == typeof(global::Together.DeRolloutConditionType)

                    || typeToConvert == typeof(global::Together.DeRolloutConditionType?)

                    || typeToConvert == typeof(global::Together.DeRolloutStepStatusState)

                    || typeToConvert == typeof(global::Together.DeRolloutStepStatusState?)

                    || typeToConvert == typeof(global::Together.DeMetricResultStat)

                    || typeToConvert == typeof(global::Together.DeMetricResultStat?)

                    || typeToConvert == typeof(global::Together.DeMetricResultCheck)

                    || typeToConvert == typeof(global::Together.DeMetricResultCheck?)

                    || typeToConvert == typeof(global::Together.DeMetricResultOperator)

                    || typeToConvert == typeof(global::Together.DeMetricResultOperator?)

                    || typeToConvert == typeof(global::Together.DeMetricResultDirection)

                    || typeToConvert == typeof(global::Together.DeMetricResultDirection?)

                    || typeToConvert == typeof(global::Together.DeMetricResultVerdict)

                    || typeToConvert == typeof(global::Together.DeMetricResultVerdict?)

                    || typeToConvert == typeof(global::Together.DeABExperimentMemberRole)

                    || typeToConvert == typeof(global::Together.DeABExperimentMemberRole?)

                    || typeToConvert == typeof(global::Together.DeInlinePlacementConstraint)

                    || typeToConvert == typeof(global::Together.DeInlinePlacementConstraint?)

                    || typeToConvert == typeof(global::Together.DeSupportedModelInputModalitie)

                    || typeToConvert == typeof(global::Together.DeSupportedModelInputModalitie?)

                    || typeToConvert == typeof(global::Together.DeSupportedModelOutputModalitie)

                    || typeToConvert == typeof(global::Together.DeSupportedModelOutputModalitie?)

                    || typeToConvert == typeof(global::Together.DeSupportedModelProduct)

                    || typeToConvert == typeof(global::Together.DeSupportedModelProduct?)

                    || typeToConvert == typeof(global::Together.DeSupportedModelFeature)

                    || typeToConvert == typeof(global::Together.DeSupportedModelFeature?)

                    || typeToConvert == typeof(global::Together.DeSupportedModelCapabilitie)

                    || typeToConvert == typeof(global::Together.DeSupportedModelCapabilitie?)

                    || typeToConvert == typeof(global::Together.DeSupportedModelStatus)

                    || typeToConvert == typeof(global::Together.DeSupportedModelStatus?)

                    || typeToConvert == typeof(global::Together.DeShadowExperimentState)

                    || typeToConvert == typeof(global::Together.DeShadowExperimentState?)

                    || typeToConvert == typeof(global::Together.DeUpdateModelRequestVisibility)

                    || typeToConvert == typeof(global::Together.DeUpdateModelRequestVisibility?)

                    || typeToConvert == typeof(global::Together.DeHeadroomRelation)

                    || typeToConvert == typeof(global::Together.DeHeadroomRelation?)

                    || typeToConvert == typeof(global::Together.DeRemoteUploadStatus)

                    || typeToConvert == typeof(global::Together.DeRemoteUploadStatus?)

                    || typeToConvert == typeof(global::Together.DeModelVisibility)

                    || typeToConvert == typeof(global::Together.DeModelVisibility?)

                    || typeToConvert == typeof(global::Together.DeRemoteUploadEventLevel)

                    || typeToConvert == typeof(global::Together.DeRemoteUploadEventLevel?)

                    || typeToConvert == typeof(global::Together.DeDeploymentStatusState)

                    || typeToConvert == typeof(global::Together.DeDeploymentStatusState?)

                    || typeToConvert == typeof(global::Together.DeEndpointEventLevel)

                    || typeToConvert == typeof(global::Together.DeEndpointEventLevel?)

                    || typeToConvert == typeof(global::Together.DeEndpointEventSourceKind)

                    || typeToConvert == typeof(global::Together.DeEndpointEventSourceKind?)

                    || typeToConvert == typeof(global::Together.DeListRevisionsResponseRevisionValidationStatus)

                    || typeToConvert == typeof(global::Together.DeListRevisionsResponseRevisionValidationStatus?)

                    || typeToConvert == typeof(global::Together.DeConfigEngineType)

                    || typeToConvert == typeof(global::Together.DeConfigEngineType?)

                    || typeToConvert == typeof(global::Together.DeConfigDeploymentFramework)

                    || typeToConvert == typeof(global::Together.DeConfigDeploymentFramework?)

                    || typeToConvert == typeof(global::Together.DeCertificationTarget)

                    || typeToConvert == typeof(global::Together.DeCertificationTarget?)

                    || typeToConvert == typeof(global::Together.DeCertificationCertificationType)

                    || typeToConvert == typeof(global::Together.DeCertificationCertificationType?)

                    || typeToConvert == typeof(global::Together.DeModelWeightsType)

                    || typeToConvert == typeof(global::Together.DeModelWeightsType?)

                    || typeToConvert == typeof(global::Together.DeModelWeightsSpeculatorMechanism)

                    || typeToConvert == typeof(global::Together.DeModelWeightsSpeculatorMechanism?)

                    || typeToConvert == typeof(global::Together.DeModelWeightsDraftSpeculatorType)

                    || typeToConvert == typeof(global::Together.DeModelWeightsDraftSpeculatorType?)

                    || typeToConvert == typeof(global::Together.DeScalingMetricType)

                    || typeToConvert == typeof(global::Together.DeScalingMetricType?)

                    || typeToConvert == typeof(global::Together.RlModelResourcesStatus)

                    || typeToConvert == typeof(global::Together.RlModelResourcesStatus?)

                    || typeToConvert == typeof(global::Together.RlModelResourcesErrorCode)

                    || typeToConvert == typeof(global::Together.RlModelResourcesErrorCode?)

                    || typeToConvert == typeof(global::Together.RlDType)

                    || typeToConvert == typeof(global::Together.RlDType?)

                    || typeToConvert == typeof(global::Together.RlLossType)

                    || typeToConvert == typeof(global::Together.RlLossType?)

                    || typeToConvert == typeof(global::Together.RlWeightSyncType)

                    || typeToConvert == typeof(global::Together.RlWeightSyncType?)

                    || typeToConvert == typeof(global::Together.RlGRPOLossAggregationType)

                    || typeToConvert == typeof(global::Together.RlGRPOLossAggregationType?)

                    || typeToConvert == typeof(global::Together.RlGRPOLossRatioType)

                    || typeToConvert == typeof(global::Together.RlGRPOLossRatioType?)

                    || typeToConvert == typeof(global::Together.RlTensorDataDtype)

                    || typeToConvert == typeof(global::Together.RlTensorDataDtype?)

                    || typeToConvert == typeof(global::Together.RlStopReason)

                    || typeToConvert == typeof(global::Together.RlStopReason?)

                    || typeToConvert == typeof(global::Together.RlTrainingOperationErrorCode)

                    || typeToConvert == typeof(global::Together.RlTrainingOperationErrorCode?)

                    || typeToConvert == typeof(global::Together.RlTrainingOperationStatus)

                    || typeToConvert == typeof(global::Together.RlTrainingOperationStatus?)

                    || typeToConvert == typeof(global::Together.RlTrainingSessionStatus)

                    || typeToConvert == typeof(global::Together.RlTrainingSessionStatus?)

                    || typeToConvert == typeof(global::Together.RlTrainingSessionErrorCode)

                    || typeToConvert == typeof(global::Together.RlTrainingSessionErrorCode?)

                    || typeToConvert == typeof(global::Together.RlMuonScalingStrategy)

                    || typeToConvert == typeof(global::Together.RlMuonScalingStrategy?)

                    || typeToConvert == typeof(global::Together.RlCheckpointType)

                    || typeToConvert == typeof(global::Together.RlCheckpointType?)

                    || typeToConvert == typeof(global::Together.RlCheckpointVariant)

                    || typeToConvert == typeof(global::Together.RlCheckpointVariant?)

                    || typeToConvert == typeof(global::Together.GPUClusterCreateRequestClusterType)

                    || typeToConvert == typeof(global::Together.GPUClusterCreateRequestClusterType?)

                    || typeToConvert == typeof(global::Together.GPUClusterCreateRequestGpuType)

                    || typeToConvert == typeof(global::Together.GPUClusterCreateRequestGpuType?)

                    || typeToConvert == typeof(global::Together.GPUClusterCreateRequestBillingType)

                    || typeToConvert == typeof(global::Together.GPUClusterCreateRequestBillingType?)

                    || typeToConvert == typeof(global::Together.GPUClusterInfoClusterType)

                    || typeToConvert == typeof(global::Together.GPUClusterInfoClusterType?)

                    || typeToConvert == typeof(global::Together.GPUClusterInfoGpuType)

                    || typeToConvert == typeof(global::Together.GPUClusterInfoGpuType?)

                    || typeToConvert == typeof(global::Together.GPUClusterInfoStatus)

                    || typeToConvert == typeof(global::Together.GPUClusterInfoStatus?)

                    || typeToConvert == typeof(global::Together.GPUClusterInfoBillingType)

                    || typeToConvert == typeof(global::Together.GPUClusterInfoBillingType?)

                    || typeToConvert == typeof(global::Together.GPUClusterUpdateRequestClusterType)

                    || typeToConvert == typeof(global::Together.GPUClusterUpdateRequestClusterType?)

                    || typeToConvert == typeof(global::Together.InstanceTypesResponseType)

                    || typeToConvert == typeof(global::Together.InstanceTypesResponseType?)

                    || typeToConvert == typeof(global::Together.AcceptanceTestsParamsDcgmDiagLevel)

                    || typeToConvert == typeof(global::Together.AcceptanceTestsParamsDcgmDiagLevel?)

                    || typeToConvert == typeof(global::Together.ApproveRemediationRequestMode)

                    || typeToConvert == typeof(global::Together.ApproveRemediationRequestMode?)

                    || typeToConvert == typeof(global::Together.ClusterPhaseTransitionPhase)

                    || typeToConvert == typeof(global::Together.ClusterPhaseTransitionPhase?)

                    || typeToConvert == typeof(global::Together.InstanceClusterConfigLoadBalancer)

                    || typeToConvert == typeof(global::Together.InstanceClusterConfigLoadBalancer?)

                    || typeToConvert == typeof(global::Together.NodePhaseTransitionPhase)

                    || typeToConvert == typeof(global::Together.NodePhaseTransitionPhase?)

                    || typeToConvert == typeof(global::Together.PassiveHealthCheckAlertSeverity)

                    || typeToConvert == typeof(global::Together.PassiveHealthCheckAlertSeverity?)

                    || typeToConvert == typeof(global::Together.RemediationMode)

                    || typeToConvert == typeof(global::Together.RemediationMode?)

                    || typeToConvert == typeof(global::Together.RemediationTrigger)

                    || typeToConvert == typeof(global::Together.RemediationTrigger?)

                    || typeToConvert == typeof(global::Together.RemediationState)

                    || typeToConvert == typeof(global::Together.RemediationState?)

                    || typeToConvert == typeof(global::Together.GPUClustersSharedVolumeStatus)

                    || typeToConvert == typeof(global::Together.GPUClustersSharedVolumeStatus?)

                    || typeToConvert == typeof(global::Together.RerankRequestModel)

                    || typeToConvert == typeof(global::Together.RerankRequestModel?)

                    || typeToConvert == typeof(global::Together.FinishReason)

                    || typeToConvert == typeof(global::Together.FinishReason?)

                    || typeToConvert == typeof(global::Together.CompletionRequestModel)

                    || typeToConvert == typeof(global::Together.CompletionRequestModel?)

                    || typeToConvert == typeof(global::Together.CompletionRequestSafetyModel)

                    || typeToConvert == typeof(global::Together.CompletionRequestSafetyModel?)

                    || typeToConvert == typeof(global::Together.CompletionChoiceDeltaRole)

                    || typeToConvert == typeof(global::Together.CompletionChoiceDeltaRole?)

                    || typeToConvert == typeof(global::Together.ChatCompletionMessageRole)

                    || typeToConvert == typeof(global::Together.ChatCompletionMessageRole?)

                    || typeToConvert == typeof(global::Together.ChatCompletionToolType)

                    || typeToConvert == typeof(global::Together.ChatCompletionToolType?)

                    || typeToConvert == typeof(global::Together.ChatCompletionRequestContextLengthExceededBehavior)

                    || typeToConvert == typeof(global::Together.ChatCompletionRequestContextLengthExceededBehavior?)

                    || typeToConvert == typeof(global::Together.ChatCompletionRequestFunctionCallEnum)

                    || typeToConvert == typeof(global::Together.ChatCompletionRequestFunctionCallEnum?)

                    || typeToConvert == typeof(global::Together.ChatCompletionRequestResponseFormatDiscriminatorType)

                    || typeToConvert == typeof(global::Together.ChatCompletionRequestResponseFormatDiscriminatorType?)

                    || typeToConvert == typeof(global::Together.ChatCompletionRequestReasoningEffort)

                    || typeToConvert == typeof(global::Together.ChatCompletionRequestReasoningEffort?)

                    || typeToConvert == typeof(global::Together.ResponseFormatTextType)

                    || typeToConvert == typeof(global::Together.ResponseFormatTextType?)

                    || typeToConvert == typeof(global::Together.ResponseFormatJsonObjectType)

                    || typeToConvert == typeof(global::Together.ResponseFormatJsonObjectType?)

                    || typeToConvert == typeof(global::Together.ResponseFormatJsonSchemaType)

                    || typeToConvert == typeof(global::Together.ResponseFormatJsonSchemaType?)

                    || typeToConvert == typeof(global::Together.ChatCompletionSystemMessageParamRole)

                    || typeToConvert == typeof(global::Together.ChatCompletionSystemMessageParamRole?)

                    || typeToConvert == typeof(global::Together.ChatCompletionUserMessageParamRole)

                    || typeToConvert == typeof(global::Together.ChatCompletionUserMessageParamRole?)

                    || typeToConvert == typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1Type)

                    || typeToConvert == typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1Type?)

                    || typeToConvert == typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2Type)

                    || typeToConvert == typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2Type?)

                    || typeToConvert == typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemVideoType)

                    || typeToConvert == typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemVideoType?)

                    || typeToConvert == typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemAudioType)

                    || typeToConvert == typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemAudioType?)

                    || typeToConvert == typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudioType)

                    || typeToConvert == typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudioType?)

                    || typeToConvert == typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudioInputAudioFormat)

                    || typeToConvert == typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudioInputAudioFormat?)

                    || typeToConvert == typeof(global::Together.ChatCompletionAssistantMessageParamRole)

                    || typeToConvert == typeof(global::Together.ChatCompletionAssistantMessageParamRole?)

                    || typeToConvert == typeof(global::Together.ChatCompletionFunctionMessageParamRole)

                    || typeToConvert == typeof(global::Together.ChatCompletionFunctionMessageParamRole?)

                    || typeToConvert == typeof(global::Together.ChatCompletionToolMessageParamRole)

                    || typeToConvert == typeof(global::Together.ChatCompletionToolMessageParamRole?)

                    || typeToConvert == typeof(global::Together.ChatCompletionChunkChoiceDeltaRole)

                    || typeToConvert == typeof(global::Together.ChatCompletionChunkChoiceDeltaRole?)

                    || typeToConvert == typeof(global::Together.AudioSpeechRequestModel)

                    || typeToConvert == typeof(global::Together.AudioSpeechRequestModel?)

                    || typeToConvert == typeof(global::Together.AudioSpeechRequestResponseFormat)

                    || typeToConvert == typeof(global::Together.AudioSpeechRequestResponseFormat?)

                    || typeToConvert == typeof(global::Together.AudioSpeechRequestResponseEncoding)

                    || typeToConvert == typeof(global::Together.AudioSpeechRequestResponseEncoding?)

                    || typeToConvert == typeof(global::Together.AudioTranscriptionRequestModel)

                    || typeToConvert == typeof(global::Together.AudioTranscriptionRequestModel?)

                    || typeToConvert == typeof(global::Together.AudioTranscriptionRequestResponseFormat)

                    || typeToConvert == typeof(global::Together.AudioTranscriptionRequestResponseFormat?)

                    || typeToConvert == typeof(global::Together.AudioTranscriptionRequestTimestampGranularities)

                    || typeToConvert == typeof(global::Together.AudioTranscriptionRequestTimestampGranularities?)

                    || typeToConvert == typeof(global::Together.AudioTranscriptionRequestTimestampGranularitie)

                    || typeToConvert == typeof(global::Together.AudioTranscriptionRequestTimestampGranularitie?)

                    || typeToConvert == typeof(global::Together.AudioTranslationRequestModel)

                    || typeToConvert == typeof(global::Together.AudioTranslationRequestModel?)

                    || typeToConvert == typeof(global::Together.AudioTranslationRequestResponseFormat)

                    || typeToConvert == typeof(global::Together.AudioTranslationRequestResponseFormat?)

                    || typeToConvert == typeof(global::Together.AudioTranslationRequestTimestampGranularities)

                    || typeToConvert == typeof(global::Together.AudioTranslationRequestTimestampGranularities?)

                    || typeToConvert == typeof(global::Together.AudioTranslationRequestTimestampGranularitie)

                    || typeToConvert == typeof(global::Together.AudioTranslationRequestTimestampGranularitie?)

                    || typeToConvert == typeof(global::Together.StreamSentinelData)

                    || typeToConvert == typeof(global::Together.StreamSentinelData?)

                    || typeToConvert == typeof(global::Together.ChatCompletionChoiceDeltaRole)

                    || typeToConvert == typeof(global::Together.ChatCompletionChoiceDeltaRole?)

                    || typeToConvert == typeof(global::Together.EmbeddingsRequestModel)

                    || typeToConvert == typeof(global::Together.EmbeddingsRequestModel?)

                    || typeToConvert == typeof(global::Together.ModelInfoType)

                    || typeToConvert == typeof(global::Together.ModelInfoType?)

                    || typeToConvert == typeof(global::Together.ModelUploadRequestModelType)

                    || typeToConvert == typeof(global::Together.ModelUploadRequestModelType?)

                    || typeToConvert == typeof(global::Together.ImageResponseDataItemDiscriminatorType)

                    || typeToConvert == typeof(global::Together.ImageResponseDataItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Together.ImageResponseDataB64Type)

                    || typeToConvert == typeof(global::Together.ImageResponseDataB64Type?)

                    || typeToConvert == typeof(global::Together.ImageResponseDataUrlType)

                    || typeToConvert == typeof(global::Together.ImageResponseDataUrlType?)

                    || typeToConvert == typeof(global::Together.JobInfoSuccessResponseStatus)

                    || typeToConvert == typeof(global::Together.JobInfoSuccessResponseStatus?)

                    || typeToConvert == typeof(global::Together.ToolChoiceType)

                    || typeToConvert == typeof(global::Together.ToolChoiceType?)

                    || typeToConvert == typeof(global::Together.FileProcessingStatus)

                    || typeToConvert == typeof(global::Together.FileProcessingStatus?)

                    || typeToConvert == typeof(global::Together.FileValidationReportErrorType)

                    || typeToConvert == typeof(global::Together.FileValidationReportErrorType?)

                    || typeToConvert == typeof(global::Together.FilePurpose)

                    || typeToConvert == typeof(global::Together.FilePurpose?)

                    || typeToConvert == typeof(global::Together.FileType)

                    || typeToConvert == typeof(global::Together.FileType?)

                    || typeToConvert == typeof(global::Together.FinetuneResponseBatchSize)

                    || typeToConvert == typeof(global::Together.FinetuneResponseBatchSize?)

                    || typeToConvert == typeof(global::Together.FinetuneResponseTrainOnInputs)

                    || typeToConvert == typeof(global::Together.FinetuneResponseTrainOnInputs?)

                    || typeToConvert == typeof(global::Together.FineTunePreviewRequestTrainingMethod)

                    || typeToConvert == typeof(global::Together.FineTunePreviewRequestTrainingMethod?)

                    || typeToConvert == typeof(global::Together.FineTunePreviewResponseDatasetFormat)

                    || typeToConvert == typeof(global::Together.FineTunePreviewResponseDatasetFormat?)

                    || typeToConvert == typeof(global::Together.FinetuneJobStatus)

                    || typeToConvert == typeof(global::Together.FinetuneJobStatus?)

                    || typeToConvert == typeof(global::Together.FinetuneEventLevels)

                    || typeToConvert == typeof(global::Together.FinetuneEventLevels?)

                    || typeToConvert == typeof(global::Together.FinetuneEventType)

                    || typeToConvert == typeof(global::Together.FinetuneEventType?)

                    || typeToConvert == typeof(global::Together.FineTuneCheckpointCheckpoint)

                    || typeToConvert == typeof(global::Together.FineTuneCheckpointCheckpoint?)

                    || typeToConvert == typeof(global::Together.FullTrainingTypeType)

                    || typeToConvert == typeof(global::Together.FullTrainingTypeType?)

                    || typeToConvert == typeof(global::Together.LoRATrainingTypeType)

                    || typeToConvert == typeof(global::Together.LoRATrainingTypeType?)

                    || typeToConvert == typeof(global::Together.TrainingMethodSFTMethod)

                    || typeToConvert == typeof(global::Together.TrainingMethodSFTMethod?)

                    || typeToConvert == typeof(global::Together.TrainingMethodSFTTrainOnInputs)

                    || typeToConvert == typeof(global::Together.TrainingMethodSFTTrainOnInputs?)

                    || typeToConvert == typeof(global::Together.TrainingMethodDPOMethod)

                    || typeToConvert == typeof(global::Together.TrainingMethodDPOMethod?)

                    || typeToConvert == typeof(global::Together.LRSchedulerLrSchedulerType)

                    || typeToConvert == typeof(global::Together.LRSchedulerLrSchedulerType?)

                    || typeToConvert == typeof(global::Together.HardwareAvailabilityStatus)

                    || typeToConvert == typeof(global::Together.HardwareAvailabilityStatus?)

                    || typeToConvert == typeof(global::Together.CreateEndpointRequestState)

                    || typeToConvert == typeof(global::Together.CreateEndpointRequestState?)

                    || typeToConvert == typeof(global::Together.DedicatedEndpointType)

                    || typeToConvert == typeof(global::Together.DedicatedEndpointType?)

                    || typeToConvert == typeof(global::Together.DedicatedEndpointState)

                    || typeToConvert == typeof(global::Together.DedicatedEndpointState?)

                    || typeToConvert == typeof(global::Together.ListEndpointType)

                    || typeToConvert == typeof(global::Together.ListEndpointType?)

                    || typeToConvert == typeof(global::Together.ListEndpointState)

                    || typeToConvert == typeof(global::Together.ListEndpointState?)

                    || typeToConvert == typeof(global::Together.DisplayorExecuteOutputType)

                    || typeToConvert == typeof(global::Together.DisplayorExecuteOutputType?)

                    || typeToConvert == typeof(global::Together.ErrorOutputType)

                    || typeToConvert == typeof(global::Together.ErrorOutputType?)

                    || typeToConvert == typeof(global::Together.ExecuteRequestFileEncoding)

                    || typeToConvert == typeof(global::Together.ExecuteRequestFileEncoding?)

                    || typeToConvert == typeof(global::Together.ExecuteRequestLanguage)

                    || typeToConvert == typeof(global::Together.ExecuteRequestLanguage?)

                    || typeToConvert == typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputStreamOutputType)

                    || typeToConvert == typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputStreamOutputType?)

                    || typeToConvert == typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputErrorOutputType)

                    || typeToConvert == typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputErrorOutputType?)

                    || typeToConvert == typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutputType)

                    || typeToConvert == typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutputType?)

                    || typeToConvert == typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputDiscriminatorType)

                    || typeToConvert == typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputDiscriminatorType?)

                    || typeToConvert == typeof(global::Together.ExecuteResponseSuccessfulExecutionDataStatus)

                    || typeToConvert == typeof(global::Together.ExecuteResponseSuccessfulExecutionDataStatus?)

                    || typeToConvert == typeof(global::Together.InterpreterOutputStreamOutputType)

                    || typeToConvert == typeof(global::Together.InterpreterOutputStreamOutputType?)

                    || typeToConvert == typeof(global::Together.InterpreterOutputErrorOutputType)

                    || typeToConvert == typeof(global::Together.InterpreterOutputErrorOutputType?)

                    || typeToConvert == typeof(global::Together.InterpreterOutputDisplayorExecuteOutputType)

                    || typeToConvert == typeof(global::Together.InterpreterOutputDisplayorExecuteOutputType?)

                    || typeToConvert == typeof(global::Together.InterpreterOutputDiscriminatorType)

                    || typeToConvert == typeof(global::Together.InterpreterOutputDiscriminatorType?)

                    || typeToConvert == typeof(global::Together.StreamOutputType)

                    || typeToConvert == typeof(global::Together.StreamOutputType?)

                    || typeToConvert == typeof(global::Together.CreateBatchRequestEndpoint)

                    || typeToConvert == typeof(global::Together.CreateBatchRequestEndpoint?)

                    || typeToConvert == typeof(global::Together.BatchJobStatus)

                    || typeToConvert == typeof(global::Together.BatchJobStatus?)

                    || typeToConvert == typeof(global::Together.EvaluationTypedRequestType)

                    || typeToConvert == typeof(global::Together.EvaluationTypedRequestType?)

                    || typeToConvert == typeof(global::Together.EvaluationJudgeModelConfigModelSource)

                    || typeToConvert == typeof(global::Together.EvaluationJudgeModelConfigModelSource?)

                    || typeToConvert == typeof(global::Together.EvaluationModelRequestModelSource)

                    || typeToConvert == typeof(global::Together.EvaluationModelRequestModelSource?)

                    || typeToConvert == typeof(global::Together.EvaluationResponseStatus)

                    || typeToConvert == typeof(global::Together.EvaluationResponseStatus?)

                    || typeToConvert == typeof(global::Together.EvaluationJobType)

                    || typeToConvert == typeof(global::Together.EvaluationJobType?)

                    || typeToConvert == typeof(global::Together.EvaluationJobStatus)

                    || typeToConvert == typeof(global::Together.EvaluationJobStatus?)

                    || typeToConvert == typeof(global::Together.VideoStatus)

                    || typeToConvert == typeof(global::Together.VideoStatus?)

                    || typeToConvert == typeof(global::Together.VideoFrameImageInputFrame)

                    || typeToConvert == typeof(global::Together.VideoFrameImageInputFrame?)

                    || typeToConvert == typeof(global::Together.VideoOutputFormat)

                    || typeToConvert == typeof(global::Together.VideoOutputFormat?)

                    || typeToConvert == typeof(global::Together.CreateDeploymentRequestGpuType)

                    || typeToConvert == typeof(global::Together.CreateDeploymentRequestGpuType?)

                    || typeToConvert == typeof(global::Together.DeploymentResponseItemGpuType)

                    || typeToConvert == typeof(global::Together.DeploymentResponseItemGpuType?)

                    || typeToConvert == typeof(global::Together.DeploymentStatus)

                    || typeToConvert == typeof(global::Together.DeploymentStatus?)

                    || typeToConvert == typeof(global::Together.HTTPAutoscalingConfigMetric)

                    || typeToConvert == typeof(global::Together.HTTPAutoscalingConfigMetric?)

                    || typeToConvert == typeof(global::Together.QueueAutoscalingConfigMetric)

                    || typeToConvert == typeof(global::Together.QueueAutoscalingConfigMetric?)

                    || typeToConvert == typeof(global::Together.CustomMetricAutoscalingConfigMetric)

                    || typeToConvert == typeof(global::Together.CustomMetricAutoscalingConfigMetric?)

                    || typeToConvert == typeof(global::Together.UpdateDeploymentRequestGpuType)

                    || typeToConvert == typeof(global::Together.UpdateDeploymentRequestGpuType?)

                    || typeToConvert == typeof(global::Together.VolumeContentRequestType)

                    || typeToConvert == typeof(global::Together.VolumeContentRequestType?)

                    || typeToConvert == typeof(global::Together.VolumeContentType)

                    || typeToConvert == typeof(global::Together.VolumeContentType?)

                    || typeToConvert == typeof(global::Together.VolumeType)

                    || typeToConvert == typeof(global::Together.VolumeType?)

                    || typeToConvert == typeof(global::Together.QueueCancelResponseStatus)

                    || typeToConvert == typeof(global::Together.QueueCancelResponseStatus?)

                    || typeToConvert == typeof(global::Together.QueueJobStatusResponseStatus)

                    || typeToConvert == typeof(global::Together.QueueJobStatusResponseStatus?)

                    || typeToConvert == typeof(global::Together.CreateImagesGenerationsRequestModel)

                    || typeToConvert == typeof(global::Together.CreateImagesGenerationsRequestModel?)

                    || typeToConvert == typeof(global::Together.CreateImagesGenerationsRequestResponseFormat)

                    || typeToConvert == typeof(global::Together.CreateImagesGenerationsRequestResponseFormat?)

                    || typeToConvert == typeof(global::Together.CreateImagesGenerationsRequestOutputFormat)

                    || typeToConvert == typeof(global::Together.CreateImagesGenerationsRequestOutputFormat?)

                    || typeToConvert == typeof(global::Together.CreateFineTunesRequestBatchSize)

                    || typeToConvert == typeof(global::Together.CreateFineTunesRequestBatchSize?)

                    || typeToConvert == typeof(global::Together.CreateFineTunesRequestTrainOnInputs)

                    || typeToConvert == typeof(global::Together.CreateFineTunesRequestTrainOnInputs?)

                    || typeToConvert == typeof(global::Together.UpdateEndpointRequestState)

                    || typeToConvert == typeof(global::Together.UpdateEndpointRequestState?)

                    || typeToConvert == typeof(global::Together.RolloutServiceListRolloutsFilter)

                    || typeToConvert == typeof(global::Together.RolloutServiceListRolloutsFilter?)

                    || typeToConvert == typeof(global::Together.EndpointServiceListEndpointEventsMinLevel)

                    || typeToConvert == typeof(global::Together.EndpointServiceListEndpointEventsMinLevel?)

                    || typeToConvert == typeof(global::Together.EndpointServiceListEndpointEventsSourceKind)

                    || typeToConvert == typeof(global::Together.EndpointServiceListEndpointEventsSourceKind?)

                    || typeToConvert == typeof(global::Together.VolumeServiceListModelsVisibility)

                    || typeToConvert == typeof(global::Together.VolumeServiceListModelsVisibility?)

                    || typeToConvert == typeof(global::Together.SupportedModelsServiceListSupportedModelsModality)

                    || typeToConvert == typeof(global::Together.SupportedModelsServiceListSupportedModelsModality?)

                    || typeToConvert == typeof(global::Together.SupportedModelsServiceListSupportedModelsProduct)

                    || typeToConvert == typeof(global::Together.SupportedModelsServiceListSupportedModelsProduct?)

                    || typeToConvert == typeof(global::Together.GetFinetuneDownloadCheckpoint)

                    || typeToConvert == typeof(global::Together.GetFinetuneDownloadCheckpoint?)

                    || typeToConvert == typeof(global::Together.RealtimeTtsModel)

                    || typeToConvert == typeof(global::Together.RealtimeTtsModel?)

                    || typeToConvert == typeof(global::Together.ListEndpointsType)

                    || typeToConvert == typeof(global::Together.ListEndpointsType?)

                    || typeToConvert == typeof(global::Together.ListEndpointsUsageType)

                    || typeToConvert == typeof(global::Together.ListEndpointsUsageType?)

                    || typeToConvert == typeof(global::Together.RealtimeTranscriptionInputAudioFormat)

                    || typeToConvert == typeof(global::Together.RealtimeTranscriptionInputAudioFormat?)

                    || typeToConvert == typeof(global::Together.ListModelResourcesStatu)

                    || typeToConvert == typeof(global::Together.ListModelResourcesStatu?)

                    || typeToConvert == typeof(global::Together.ListTrainingSessionsStatu)

                    || typeToConvert == typeof(global::Together.ListTrainingSessionsStatu?)

                    || typeToConvert == typeof(global::Together.RemediationServiceListRemediationsStateItem)

                    || typeToConvert == typeof(global::Together.RemediationServiceListRemediationsStateItem?)

                    || typeToConvert == typeof(global::Together.RemediationServiceListRemediationsTriggerItem)

                    || typeToConvert == typeof(global::Together.RemediationServiceListRemediationsTriggerItem?)

                    || typeToConvert == typeof(global::Together.RemediationServiceListRemediationsModeItem)

                    || typeToConvert == typeof(global::Together.RemediationServiceListRemediationsModeItem?)

                    || typeToConvert == typeof(global::Together.HealthCheckServiceListPassiveHealthCheckAlertsStatus)

                    || typeToConvert == typeof(global::Together.HealthCheckServiceListPassiveHealthCheckAlertsStatus?)

                    || typeToConvert == typeof(global::Together.HealthCheckServiceListPassiveHealthCheckAlertsSeverityFilterItem)

                    || typeToConvert == typeof(global::Together.HealthCheckServiceListPassiveHealthCheckAlertsSeverityFilterItem?)

                    || typeToConvert == typeof(global::Together.HealthCheckServiceListPassiveHealthCheckAlertsOrderBy)

                    || typeToConvert == typeof(global::Together.HealthCheckServiceListPassiveHealthCheckAlertsOrderBy?)

                    || typeToConvert == typeof(global::Together.GetBillingUsageGranularity)

                    || typeToConvert == typeof(global::Together.GetBillingUsageGranularity?)

                    || typeToConvert == typeof(global::Together.CreateFineTunesEstimatePriceResponseVariant2UnavailableReason)

                    || typeToConvert == typeof(global::Together.CreateFineTunesEstimatePriceResponseVariant2UnavailableReason?)

                    || typeToConvert == typeof(global::Together.GetEvaluationJobStatusAndResultsResponseStatus)

                    || typeToConvert == typeof(global::Together.GetEvaluationJobStatusAndResultsResponseStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Together.DeEndpointVisibility))
                {
                    return new global::Together.JsonConverters.DeEndpointVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeEndpointVisibility?))
                {
                    return new global::Together.JsonConverters.DeEndpointVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeEndpointEndpointType))
                {
                    return new global::Together.JsonConverters.DeEndpointEndpointTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeEndpointEndpointType?))
                {
                    return new global::Together.JsonConverters.DeEndpointEndpointTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeDeploymentSummaryTrafficMode))
                {
                    return new global::Together.JsonConverters.DeDeploymentSummaryTrafficModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeDeploymentSummaryTrafficMode?))
                {
                    return new global::Together.JsonConverters.DeDeploymentSummaryTrafficModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeDeploymentSummaryState))
                {
                    return new global::Together.JsonConverters.DeDeploymentSummaryStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeDeploymentSummaryState?))
                {
                    return new global::Together.JsonConverters.DeDeploymentSummaryStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeCreateEndpointRequestVisibility))
                {
                    return new global::Together.JsonConverters.DeCreateEndpointRequestVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeCreateEndpointRequestVisibility?))
                {
                    return new global::Together.JsonConverters.DeCreateEndpointRequestVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeEndpointUpdateVisibility))
                {
                    return new global::Together.JsonConverters.DeEndpointUpdateVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeEndpointUpdateVisibility?))
                {
                    return new global::Together.JsonConverters.DeEndpointUpdateVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeDeploymentTrafficMode))
                {
                    return new global::Together.JsonConverters.DeDeploymentTrafficModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeDeploymentTrafficMode?))
                {
                    return new global::Together.JsonConverters.DeDeploymentTrafficModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeDeploymentAdapterStatusState))
                {
                    return new global::Together.JsonConverters.DeDeploymentAdapterStatusStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeDeploymentAdapterStatusState?))
                {
                    return new global::Together.JsonConverters.DeDeploymentAdapterStatusStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeMetricRuleName))
                {
                    return new global::Together.JsonConverters.DeMetricRuleNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeMetricRuleName?))
                {
                    return new global::Together.JsonConverters.DeMetricRuleNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeMetricRuleStat))
                {
                    return new global::Together.JsonConverters.DeMetricRuleStatJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeMetricRuleStat?))
                {
                    return new global::Together.JsonConverters.DeMetricRuleStatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeThresholdCheckOperator))
                {
                    return new global::Together.JsonConverters.DeThresholdCheckOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeThresholdCheckOperator?))
                {
                    return new global::Together.JsonConverters.DeThresholdCheckOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeRegressionCheckDirection))
                {
                    return new global::Together.JsonConverters.DeRegressionCheckDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeRegressionCheckDirection?))
                {
                    return new global::Together.JsonConverters.DeRegressionCheckDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeCancelRolloutRequestDisposition))
                {
                    return new global::Together.JsonConverters.DeCancelRolloutRequestDispositionJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeCancelRolloutRequestDisposition?))
                {
                    return new global::Together.JsonConverters.DeCancelRolloutRequestDispositionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeRolloutStrategy))
                {
                    return new global::Together.JsonConverters.DeRolloutStrategyJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeRolloutStrategy?))
                {
                    return new global::Together.JsonConverters.DeRolloutStrategyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeRolloutState))
                {
                    return new global::Together.JsonConverters.DeRolloutStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeRolloutState?))
                {
                    return new global::Together.JsonConverters.DeRolloutStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeRolloutConditionCategory))
                {
                    return new global::Together.JsonConverters.DeRolloutConditionCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeRolloutConditionCategory?))
                {
                    return new global::Together.JsonConverters.DeRolloutConditionCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeRolloutConditionType))
                {
                    return new global::Together.JsonConverters.DeRolloutConditionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeRolloutConditionType?))
                {
                    return new global::Together.JsonConverters.DeRolloutConditionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeRolloutStepStatusState))
                {
                    return new global::Together.JsonConverters.DeRolloutStepStatusStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeRolloutStepStatusState?))
                {
                    return new global::Together.JsonConverters.DeRolloutStepStatusStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeMetricResultStat))
                {
                    return new global::Together.JsonConverters.DeMetricResultStatJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeMetricResultStat?))
                {
                    return new global::Together.JsonConverters.DeMetricResultStatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeMetricResultCheck))
                {
                    return new global::Together.JsonConverters.DeMetricResultCheckJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeMetricResultCheck?))
                {
                    return new global::Together.JsonConverters.DeMetricResultCheckNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeMetricResultOperator))
                {
                    return new global::Together.JsonConverters.DeMetricResultOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeMetricResultOperator?))
                {
                    return new global::Together.JsonConverters.DeMetricResultOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeMetricResultDirection))
                {
                    return new global::Together.JsonConverters.DeMetricResultDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeMetricResultDirection?))
                {
                    return new global::Together.JsonConverters.DeMetricResultDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeMetricResultVerdict))
                {
                    return new global::Together.JsonConverters.DeMetricResultVerdictJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeMetricResultVerdict?))
                {
                    return new global::Together.JsonConverters.DeMetricResultVerdictNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeABExperimentMemberRole))
                {
                    return new global::Together.JsonConverters.DeABExperimentMemberRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeABExperimentMemberRole?))
                {
                    return new global::Together.JsonConverters.DeABExperimentMemberRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeInlinePlacementConstraint))
                {
                    return new global::Together.JsonConverters.DeInlinePlacementConstraintJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeInlinePlacementConstraint?))
                {
                    return new global::Together.JsonConverters.DeInlinePlacementConstraintNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeSupportedModelInputModalitie))
                {
                    return new global::Together.JsonConverters.DeSupportedModelInputModalitieJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeSupportedModelInputModalitie?))
                {
                    return new global::Together.JsonConverters.DeSupportedModelInputModalitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeSupportedModelOutputModalitie))
                {
                    return new global::Together.JsonConverters.DeSupportedModelOutputModalitieJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeSupportedModelOutputModalitie?))
                {
                    return new global::Together.JsonConverters.DeSupportedModelOutputModalitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeSupportedModelProduct))
                {
                    return new global::Together.JsonConverters.DeSupportedModelProductJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeSupportedModelProduct?))
                {
                    return new global::Together.JsonConverters.DeSupportedModelProductNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeSupportedModelFeature))
                {
                    return new global::Together.JsonConverters.DeSupportedModelFeatureJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeSupportedModelFeature?))
                {
                    return new global::Together.JsonConverters.DeSupportedModelFeatureNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeSupportedModelCapabilitie))
                {
                    return new global::Together.JsonConverters.DeSupportedModelCapabilitieJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeSupportedModelCapabilitie?))
                {
                    return new global::Together.JsonConverters.DeSupportedModelCapabilitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeSupportedModelStatus))
                {
                    return new global::Together.JsonConverters.DeSupportedModelStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeSupportedModelStatus?))
                {
                    return new global::Together.JsonConverters.DeSupportedModelStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeShadowExperimentState))
                {
                    return new global::Together.JsonConverters.DeShadowExperimentStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeShadowExperimentState?))
                {
                    return new global::Together.JsonConverters.DeShadowExperimentStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeUpdateModelRequestVisibility))
                {
                    return new global::Together.JsonConverters.DeUpdateModelRequestVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeUpdateModelRequestVisibility?))
                {
                    return new global::Together.JsonConverters.DeUpdateModelRequestVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeHeadroomRelation))
                {
                    return new global::Together.JsonConverters.DeHeadroomRelationJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeHeadroomRelation?))
                {
                    return new global::Together.JsonConverters.DeHeadroomRelationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeRemoteUploadStatus))
                {
                    return new global::Together.JsonConverters.DeRemoteUploadStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeRemoteUploadStatus?))
                {
                    return new global::Together.JsonConverters.DeRemoteUploadStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeModelVisibility))
                {
                    return new global::Together.JsonConverters.DeModelVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeModelVisibility?))
                {
                    return new global::Together.JsonConverters.DeModelVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeRemoteUploadEventLevel))
                {
                    return new global::Together.JsonConverters.DeRemoteUploadEventLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeRemoteUploadEventLevel?))
                {
                    return new global::Together.JsonConverters.DeRemoteUploadEventLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeDeploymentStatusState))
                {
                    return new global::Together.JsonConverters.DeDeploymentStatusStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeDeploymentStatusState?))
                {
                    return new global::Together.JsonConverters.DeDeploymentStatusStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeEndpointEventLevel))
                {
                    return new global::Together.JsonConverters.DeEndpointEventLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeEndpointEventLevel?))
                {
                    return new global::Together.JsonConverters.DeEndpointEventLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeEndpointEventSourceKind))
                {
                    return new global::Together.JsonConverters.DeEndpointEventSourceKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeEndpointEventSourceKind?))
                {
                    return new global::Together.JsonConverters.DeEndpointEventSourceKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeListRevisionsResponseRevisionValidationStatus))
                {
                    return new global::Together.JsonConverters.DeListRevisionsResponseRevisionValidationStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeListRevisionsResponseRevisionValidationStatus?))
                {
                    return new global::Together.JsonConverters.DeListRevisionsResponseRevisionValidationStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeConfigEngineType))
                {
                    return new global::Together.JsonConverters.DeConfigEngineTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeConfigEngineType?))
                {
                    return new global::Together.JsonConverters.DeConfigEngineTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeConfigDeploymentFramework))
                {
                    return new global::Together.JsonConverters.DeConfigDeploymentFrameworkJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeConfigDeploymentFramework?))
                {
                    return new global::Together.JsonConverters.DeConfigDeploymentFrameworkNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeCertificationTarget))
                {
                    return new global::Together.JsonConverters.DeCertificationTargetJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeCertificationTarget?))
                {
                    return new global::Together.JsonConverters.DeCertificationTargetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeCertificationCertificationType))
                {
                    return new global::Together.JsonConverters.DeCertificationCertificationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeCertificationCertificationType?))
                {
                    return new global::Together.JsonConverters.DeCertificationCertificationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeModelWeightsType))
                {
                    return new global::Together.JsonConverters.DeModelWeightsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeModelWeightsType?))
                {
                    return new global::Together.JsonConverters.DeModelWeightsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeModelWeightsSpeculatorMechanism))
                {
                    return new global::Together.JsonConverters.DeModelWeightsSpeculatorMechanismJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeModelWeightsSpeculatorMechanism?))
                {
                    return new global::Together.JsonConverters.DeModelWeightsSpeculatorMechanismNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeModelWeightsDraftSpeculatorType))
                {
                    return new global::Together.JsonConverters.DeModelWeightsDraftSpeculatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeModelWeightsDraftSpeculatorType?))
                {
                    return new global::Together.JsonConverters.DeModelWeightsDraftSpeculatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeScalingMetricType))
                {
                    return new global::Together.JsonConverters.DeScalingMetricTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeScalingMetricType?))
                {
                    return new global::Together.JsonConverters.DeScalingMetricTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RlModelResourcesStatus))
                {
                    return new global::Together.JsonConverters.RlModelResourcesStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RlModelResourcesStatus?))
                {
                    return new global::Together.JsonConverters.RlModelResourcesStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RlModelResourcesErrorCode))
                {
                    return new global::Together.JsonConverters.RlModelResourcesErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RlModelResourcesErrorCode?))
                {
                    return new global::Together.JsonConverters.RlModelResourcesErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RlDType))
                {
                    return new global::Together.JsonConverters.RlDTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RlDType?))
                {
                    return new global::Together.JsonConverters.RlDTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RlLossType))
                {
                    return new global::Together.JsonConverters.RlLossTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RlLossType?))
                {
                    return new global::Together.JsonConverters.RlLossTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RlWeightSyncType))
                {
                    return new global::Together.JsonConverters.RlWeightSyncTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RlWeightSyncType?))
                {
                    return new global::Together.JsonConverters.RlWeightSyncTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RlGRPOLossAggregationType))
                {
                    return new global::Together.JsonConverters.RlGRPOLossAggregationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RlGRPOLossAggregationType?))
                {
                    return new global::Together.JsonConverters.RlGRPOLossAggregationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RlGRPOLossRatioType))
                {
                    return new global::Together.JsonConverters.RlGRPOLossRatioTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RlGRPOLossRatioType?))
                {
                    return new global::Together.JsonConverters.RlGRPOLossRatioTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RlTensorDataDtype))
                {
                    return new global::Together.JsonConverters.RlTensorDataDtypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RlTensorDataDtype?))
                {
                    return new global::Together.JsonConverters.RlTensorDataDtypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RlStopReason))
                {
                    return new global::Together.JsonConverters.RlStopReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RlStopReason?))
                {
                    return new global::Together.JsonConverters.RlStopReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RlTrainingOperationErrorCode))
                {
                    return new global::Together.JsonConverters.RlTrainingOperationErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RlTrainingOperationErrorCode?))
                {
                    return new global::Together.JsonConverters.RlTrainingOperationErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RlTrainingOperationStatus))
                {
                    return new global::Together.JsonConverters.RlTrainingOperationStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RlTrainingOperationStatus?))
                {
                    return new global::Together.JsonConverters.RlTrainingOperationStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RlTrainingSessionStatus))
                {
                    return new global::Together.JsonConverters.RlTrainingSessionStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RlTrainingSessionStatus?))
                {
                    return new global::Together.JsonConverters.RlTrainingSessionStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RlTrainingSessionErrorCode))
                {
                    return new global::Together.JsonConverters.RlTrainingSessionErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RlTrainingSessionErrorCode?))
                {
                    return new global::Together.JsonConverters.RlTrainingSessionErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RlMuonScalingStrategy))
                {
                    return new global::Together.JsonConverters.RlMuonScalingStrategyJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RlMuonScalingStrategy?))
                {
                    return new global::Together.JsonConverters.RlMuonScalingStrategyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RlCheckpointType))
                {
                    return new global::Together.JsonConverters.RlCheckpointTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RlCheckpointType?))
                {
                    return new global::Together.JsonConverters.RlCheckpointTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RlCheckpointVariant))
                {
                    return new global::Together.JsonConverters.RlCheckpointVariantJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RlCheckpointVariant?))
                {
                    return new global::Together.JsonConverters.RlCheckpointVariantNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.GPUClusterCreateRequestClusterType))
                {
                    return new global::Together.JsonConverters.GPUClusterCreateRequestClusterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.GPUClusterCreateRequestClusterType?))
                {
                    return new global::Together.JsonConverters.GPUClusterCreateRequestClusterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.GPUClusterCreateRequestGpuType))
                {
                    return new global::Together.JsonConverters.GPUClusterCreateRequestGpuTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.GPUClusterCreateRequestGpuType?))
                {
                    return new global::Together.JsonConverters.GPUClusterCreateRequestGpuTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.GPUClusterCreateRequestBillingType))
                {
                    return new global::Together.JsonConverters.GPUClusterCreateRequestBillingTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.GPUClusterCreateRequestBillingType?))
                {
                    return new global::Together.JsonConverters.GPUClusterCreateRequestBillingTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.GPUClusterInfoClusterType))
                {
                    return new global::Together.JsonConverters.GPUClusterInfoClusterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.GPUClusterInfoClusterType?))
                {
                    return new global::Together.JsonConverters.GPUClusterInfoClusterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.GPUClusterInfoGpuType))
                {
                    return new global::Together.JsonConverters.GPUClusterInfoGpuTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.GPUClusterInfoGpuType?))
                {
                    return new global::Together.JsonConverters.GPUClusterInfoGpuTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.GPUClusterInfoStatus))
                {
                    return new global::Together.JsonConverters.GPUClusterInfoStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.GPUClusterInfoStatus?))
                {
                    return new global::Together.JsonConverters.GPUClusterInfoStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.GPUClusterInfoBillingType))
                {
                    return new global::Together.JsonConverters.GPUClusterInfoBillingTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.GPUClusterInfoBillingType?))
                {
                    return new global::Together.JsonConverters.GPUClusterInfoBillingTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.GPUClusterUpdateRequestClusterType))
                {
                    return new global::Together.JsonConverters.GPUClusterUpdateRequestClusterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.GPUClusterUpdateRequestClusterType?))
                {
                    return new global::Together.JsonConverters.GPUClusterUpdateRequestClusterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.InstanceTypesResponseType))
                {
                    return new global::Together.JsonConverters.InstanceTypesResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.InstanceTypesResponseType?))
                {
                    return new global::Together.JsonConverters.InstanceTypesResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AcceptanceTestsParamsDcgmDiagLevel))
                {
                    return new global::Together.JsonConverters.AcceptanceTestsParamsDcgmDiagLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AcceptanceTestsParamsDcgmDiagLevel?))
                {
                    return new global::Together.JsonConverters.AcceptanceTestsParamsDcgmDiagLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ApproveRemediationRequestMode))
                {
                    return new global::Together.JsonConverters.ApproveRemediationRequestModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ApproveRemediationRequestMode?))
                {
                    return new global::Together.JsonConverters.ApproveRemediationRequestModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ClusterPhaseTransitionPhase))
                {
                    return new global::Together.JsonConverters.ClusterPhaseTransitionPhaseJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ClusterPhaseTransitionPhase?))
                {
                    return new global::Together.JsonConverters.ClusterPhaseTransitionPhaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.InstanceClusterConfigLoadBalancer))
                {
                    return new global::Together.JsonConverters.InstanceClusterConfigLoadBalancerJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.InstanceClusterConfigLoadBalancer?))
                {
                    return new global::Together.JsonConverters.InstanceClusterConfigLoadBalancerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.NodePhaseTransitionPhase))
                {
                    return new global::Together.JsonConverters.NodePhaseTransitionPhaseJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.NodePhaseTransitionPhase?))
                {
                    return new global::Together.JsonConverters.NodePhaseTransitionPhaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.PassiveHealthCheckAlertSeverity))
                {
                    return new global::Together.JsonConverters.PassiveHealthCheckAlertSeverityJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.PassiveHealthCheckAlertSeverity?))
                {
                    return new global::Together.JsonConverters.PassiveHealthCheckAlertSeverityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RemediationMode))
                {
                    return new global::Together.JsonConverters.RemediationModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RemediationMode?))
                {
                    return new global::Together.JsonConverters.RemediationModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RemediationTrigger))
                {
                    return new global::Together.JsonConverters.RemediationTriggerJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RemediationTrigger?))
                {
                    return new global::Together.JsonConverters.RemediationTriggerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RemediationState))
                {
                    return new global::Together.JsonConverters.RemediationStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RemediationState?))
                {
                    return new global::Together.JsonConverters.RemediationStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.GPUClustersSharedVolumeStatus))
                {
                    return new global::Together.JsonConverters.GPUClustersSharedVolumeStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.GPUClustersSharedVolumeStatus?))
                {
                    return new global::Together.JsonConverters.GPUClustersSharedVolumeStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RerankRequestModel))
                {
                    return new global::Together.JsonConverters.RerankRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RerankRequestModel?))
                {
                    return new global::Together.JsonConverters.RerankRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FinishReason))
                {
                    return new global::Together.JsonConverters.FinishReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FinishReason?))
                {
                    return new global::Together.JsonConverters.FinishReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CompletionRequestModel))
                {
                    return new global::Together.JsonConverters.CompletionRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CompletionRequestModel?))
                {
                    return new global::Together.JsonConverters.CompletionRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CompletionRequestSafetyModel))
                {
                    return new global::Together.JsonConverters.CompletionRequestSafetyModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CompletionRequestSafetyModel?))
                {
                    return new global::Together.JsonConverters.CompletionRequestSafetyModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CompletionChoiceDeltaRole))
                {
                    return new global::Together.JsonConverters.CompletionChoiceDeltaRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CompletionChoiceDeltaRole?))
                {
                    return new global::Together.JsonConverters.CompletionChoiceDeltaRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ChatCompletionMessageRole))
                {
                    return new global::Together.JsonConverters.ChatCompletionMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ChatCompletionMessageRole?))
                {
                    return new global::Together.JsonConverters.ChatCompletionMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ChatCompletionToolType))
                {
                    return new global::Together.JsonConverters.ChatCompletionToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ChatCompletionToolType?))
                {
                    return new global::Together.JsonConverters.ChatCompletionToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ChatCompletionRequestContextLengthExceededBehavior))
                {
                    return new global::Together.JsonConverters.ChatCompletionRequestContextLengthExceededBehaviorJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ChatCompletionRequestContextLengthExceededBehavior?))
                {
                    return new global::Together.JsonConverters.ChatCompletionRequestContextLengthExceededBehaviorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ChatCompletionRequestFunctionCallEnum))
                {
                    return new global::Together.JsonConverters.ChatCompletionRequestFunctionCallEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ChatCompletionRequestFunctionCallEnum?))
                {
                    return new global::Together.JsonConverters.ChatCompletionRequestFunctionCallEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ChatCompletionRequestResponseFormatDiscriminatorType))
                {
                    return new global::Together.JsonConverters.ChatCompletionRequestResponseFormatDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ChatCompletionRequestResponseFormatDiscriminatorType?))
                {
                    return new global::Together.JsonConverters.ChatCompletionRequestResponseFormatDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ChatCompletionRequestReasoningEffort))
                {
                    return new global::Together.JsonConverters.ChatCompletionRequestReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ChatCompletionRequestReasoningEffort?))
                {
                    return new global::Together.JsonConverters.ChatCompletionRequestReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ResponseFormatTextType))
                {
                    return new global::Together.JsonConverters.ResponseFormatTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ResponseFormatTextType?))
                {
                    return new global::Together.JsonConverters.ResponseFormatTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ResponseFormatJsonObjectType))
                {
                    return new global::Together.JsonConverters.ResponseFormatJsonObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ResponseFormatJsonObjectType?))
                {
                    return new global::Together.JsonConverters.ResponseFormatJsonObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ResponseFormatJsonSchemaType))
                {
                    return new global::Together.JsonConverters.ResponseFormatJsonSchemaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ResponseFormatJsonSchemaType?))
                {
                    return new global::Together.JsonConverters.ResponseFormatJsonSchemaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ChatCompletionSystemMessageParamRole))
                {
                    return new global::Together.JsonConverters.ChatCompletionSystemMessageParamRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ChatCompletionSystemMessageParamRole?))
                {
                    return new global::Together.JsonConverters.ChatCompletionSystemMessageParamRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ChatCompletionUserMessageParamRole))
                {
                    return new global::Together.JsonConverters.ChatCompletionUserMessageParamRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ChatCompletionUserMessageParamRole?))
                {
                    return new global::Together.JsonConverters.ChatCompletionUserMessageParamRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1Type))
                {
                    return new global::Together.JsonConverters.ChatCompletionUserMessageContentMultimodalItemVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1Type?))
                {
                    return new global::Together.JsonConverters.ChatCompletionUserMessageContentMultimodalItemVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2Type))
                {
                    return new global::Together.JsonConverters.ChatCompletionUserMessageContentMultimodalItemVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2Type?))
                {
                    return new global::Together.JsonConverters.ChatCompletionUserMessageContentMultimodalItemVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemVideoType))
                {
                    return new global::Together.JsonConverters.ChatCompletionUserMessageContentMultimodalItemVideoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemVideoType?))
                {
                    return new global::Together.JsonConverters.ChatCompletionUserMessageContentMultimodalItemVideoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemAudioType))
                {
                    return new global::Together.JsonConverters.ChatCompletionUserMessageContentMultimodalItemAudioTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemAudioType?))
                {
                    return new global::Together.JsonConverters.ChatCompletionUserMessageContentMultimodalItemAudioTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudioType))
                {
                    return new global::Together.JsonConverters.ChatCompletionUserMessageContentMultimodalItemInputAudioTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudioType?))
                {
                    return new global::Together.JsonConverters.ChatCompletionUserMessageContentMultimodalItemInputAudioTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudioInputAudioFormat))
                {
                    return new global::Together.JsonConverters.ChatCompletionUserMessageContentMultimodalItemInputAudioInputAudioFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudioInputAudioFormat?))
                {
                    return new global::Together.JsonConverters.ChatCompletionUserMessageContentMultimodalItemInputAudioInputAudioFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ChatCompletionAssistantMessageParamRole))
                {
                    return new global::Together.JsonConverters.ChatCompletionAssistantMessageParamRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ChatCompletionAssistantMessageParamRole?))
                {
                    return new global::Together.JsonConverters.ChatCompletionAssistantMessageParamRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ChatCompletionFunctionMessageParamRole))
                {
                    return new global::Together.JsonConverters.ChatCompletionFunctionMessageParamRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ChatCompletionFunctionMessageParamRole?))
                {
                    return new global::Together.JsonConverters.ChatCompletionFunctionMessageParamRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ChatCompletionToolMessageParamRole))
                {
                    return new global::Together.JsonConverters.ChatCompletionToolMessageParamRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ChatCompletionToolMessageParamRole?))
                {
                    return new global::Together.JsonConverters.ChatCompletionToolMessageParamRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ChatCompletionChunkChoiceDeltaRole))
                {
                    return new global::Together.JsonConverters.ChatCompletionChunkChoiceDeltaRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ChatCompletionChunkChoiceDeltaRole?))
                {
                    return new global::Together.JsonConverters.ChatCompletionChunkChoiceDeltaRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AudioSpeechRequestModel))
                {
                    return new global::Together.JsonConverters.AudioSpeechRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AudioSpeechRequestModel?))
                {
                    return new global::Together.JsonConverters.AudioSpeechRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AudioSpeechRequestResponseFormat))
                {
                    return new global::Together.JsonConverters.AudioSpeechRequestResponseFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AudioSpeechRequestResponseFormat?))
                {
                    return new global::Together.JsonConverters.AudioSpeechRequestResponseFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AudioSpeechRequestResponseEncoding))
                {
                    return new global::Together.JsonConverters.AudioSpeechRequestResponseEncodingJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AudioSpeechRequestResponseEncoding?))
                {
                    return new global::Together.JsonConverters.AudioSpeechRequestResponseEncodingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AudioTranscriptionRequestModel))
                {
                    return new global::Together.JsonConverters.AudioTranscriptionRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AudioTranscriptionRequestModel?))
                {
                    return new global::Together.JsonConverters.AudioTranscriptionRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AudioTranscriptionRequestResponseFormat))
                {
                    return new global::Together.JsonConverters.AudioTranscriptionRequestResponseFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AudioTranscriptionRequestResponseFormat?))
                {
                    return new global::Together.JsonConverters.AudioTranscriptionRequestResponseFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AudioTranscriptionRequestTimestampGranularities))
                {
                    return new global::Together.JsonConverters.AudioTranscriptionRequestTimestampGranularitiesJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AudioTranscriptionRequestTimestampGranularities?))
                {
                    return new global::Together.JsonConverters.AudioTranscriptionRequestTimestampGranularitiesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AudioTranscriptionRequestTimestampGranularitie))
                {
                    return new global::Together.JsonConverters.AudioTranscriptionRequestTimestampGranularitieJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AudioTranscriptionRequestTimestampGranularitie?))
                {
                    return new global::Together.JsonConverters.AudioTranscriptionRequestTimestampGranularitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AudioTranslationRequestModel))
                {
                    return new global::Together.JsonConverters.AudioTranslationRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AudioTranslationRequestModel?))
                {
                    return new global::Together.JsonConverters.AudioTranslationRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AudioTranslationRequestResponseFormat))
                {
                    return new global::Together.JsonConverters.AudioTranslationRequestResponseFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AudioTranslationRequestResponseFormat?))
                {
                    return new global::Together.JsonConverters.AudioTranslationRequestResponseFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AudioTranslationRequestTimestampGranularities))
                {
                    return new global::Together.JsonConverters.AudioTranslationRequestTimestampGranularitiesJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AudioTranslationRequestTimestampGranularities?))
                {
                    return new global::Together.JsonConverters.AudioTranslationRequestTimestampGranularitiesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AudioTranslationRequestTimestampGranularitie))
                {
                    return new global::Together.JsonConverters.AudioTranslationRequestTimestampGranularitieJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.AudioTranslationRequestTimestampGranularitie?))
                {
                    return new global::Together.JsonConverters.AudioTranslationRequestTimestampGranularitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.StreamSentinelData))
                {
                    return new global::Together.JsonConverters.StreamSentinelDataJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.StreamSentinelData?))
                {
                    return new global::Together.JsonConverters.StreamSentinelDataNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ChatCompletionChoiceDeltaRole))
                {
                    return new global::Together.JsonConverters.ChatCompletionChoiceDeltaRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ChatCompletionChoiceDeltaRole?))
                {
                    return new global::Together.JsonConverters.ChatCompletionChoiceDeltaRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.EmbeddingsRequestModel))
                {
                    return new global::Together.JsonConverters.EmbeddingsRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.EmbeddingsRequestModel?))
                {
                    return new global::Together.JsonConverters.EmbeddingsRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ModelInfoType))
                {
                    return new global::Together.JsonConverters.ModelInfoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ModelInfoType?))
                {
                    return new global::Together.JsonConverters.ModelInfoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ModelUploadRequestModelType))
                {
                    return new global::Together.JsonConverters.ModelUploadRequestModelTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ModelUploadRequestModelType?))
                {
                    return new global::Together.JsonConverters.ModelUploadRequestModelTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ImageResponseDataItemDiscriminatorType))
                {
                    return new global::Together.JsonConverters.ImageResponseDataItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ImageResponseDataItemDiscriminatorType?))
                {
                    return new global::Together.JsonConverters.ImageResponseDataItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ImageResponseDataB64Type))
                {
                    return new global::Together.JsonConverters.ImageResponseDataB64TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ImageResponseDataB64Type?))
                {
                    return new global::Together.JsonConverters.ImageResponseDataB64TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ImageResponseDataUrlType))
                {
                    return new global::Together.JsonConverters.ImageResponseDataUrlTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ImageResponseDataUrlType?))
                {
                    return new global::Together.JsonConverters.ImageResponseDataUrlTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.JobInfoSuccessResponseStatus))
                {
                    return new global::Together.JsonConverters.JobInfoSuccessResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.JobInfoSuccessResponseStatus?))
                {
                    return new global::Together.JsonConverters.JobInfoSuccessResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ToolChoiceType))
                {
                    return new global::Together.JsonConverters.ToolChoiceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ToolChoiceType?))
                {
                    return new global::Together.JsonConverters.ToolChoiceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FileProcessingStatus))
                {
                    return new global::Together.JsonConverters.FileProcessingStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FileProcessingStatus?))
                {
                    return new global::Together.JsonConverters.FileProcessingStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FileValidationReportErrorType))
                {
                    return new global::Together.JsonConverters.FileValidationReportErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FileValidationReportErrorType?))
                {
                    return new global::Together.JsonConverters.FileValidationReportErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FilePurpose))
                {
                    return new global::Together.JsonConverters.FilePurposeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FilePurpose?))
                {
                    return new global::Together.JsonConverters.FilePurposeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FileType))
                {
                    return new global::Together.JsonConverters.FileTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FileType?))
                {
                    return new global::Together.JsonConverters.FileTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FinetuneResponseBatchSize))
                {
                    return new global::Together.JsonConverters.FinetuneResponseBatchSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FinetuneResponseBatchSize?))
                {
                    return new global::Together.JsonConverters.FinetuneResponseBatchSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FinetuneResponseTrainOnInputs))
                {
                    return new global::Together.JsonConverters.FinetuneResponseTrainOnInputsJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FinetuneResponseTrainOnInputs?))
                {
                    return new global::Together.JsonConverters.FinetuneResponseTrainOnInputsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FineTunePreviewRequestTrainingMethod))
                {
                    return new global::Together.JsonConverters.FineTunePreviewRequestTrainingMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FineTunePreviewRequestTrainingMethod?))
                {
                    return new global::Together.JsonConverters.FineTunePreviewRequestTrainingMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FineTunePreviewResponseDatasetFormat))
                {
                    return new global::Together.JsonConverters.FineTunePreviewResponseDatasetFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FineTunePreviewResponseDatasetFormat?))
                {
                    return new global::Together.JsonConverters.FineTunePreviewResponseDatasetFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FinetuneJobStatus))
                {
                    return new global::Together.JsonConverters.FinetuneJobStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FinetuneJobStatus?))
                {
                    return new global::Together.JsonConverters.FinetuneJobStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FinetuneEventLevels))
                {
                    return new global::Together.JsonConverters.FinetuneEventLevelsJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FinetuneEventLevels?))
                {
                    return new global::Together.JsonConverters.FinetuneEventLevelsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FinetuneEventType))
                {
                    return new global::Together.JsonConverters.FinetuneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FinetuneEventType?))
                {
                    return new global::Together.JsonConverters.FinetuneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FineTuneCheckpointCheckpoint))
                {
                    return new global::Together.JsonConverters.FineTuneCheckpointCheckpointJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FineTuneCheckpointCheckpoint?))
                {
                    return new global::Together.JsonConverters.FineTuneCheckpointCheckpointNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FullTrainingTypeType))
                {
                    return new global::Together.JsonConverters.FullTrainingTypeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FullTrainingTypeType?))
                {
                    return new global::Together.JsonConverters.FullTrainingTypeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.LoRATrainingTypeType))
                {
                    return new global::Together.JsonConverters.LoRATrainingTypeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.LoRATrainingTypeType?))
                {
                    return new global::Together.JsonConverters.LoRATrainingTypeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.TrainingMethodSFTMethod))
                {
                    return new global::Together.JsonConverters.TrainingMethodSFTMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.TrainingMethodSFTMethod?))
                {
                    return new global::Together.JsonConverters.TrainingMethodSFTMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.TrainingMethodSFTTrainOnInputs))
                {
                    return new global::Together.JsonConverters.TrainingMethodSFTTrainOnInputsJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.TrainingMethodSFTTrainOnInputs?))
                {
                    return new global::Together.JsonConverters.TrainingMethodSFTTrainOnInputsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.TrainingMethodDPOMethod))
                {
                    return new global::Together.JsonConverters.TrainingMethodDPOMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.TrainingMethodDPOMethod?))
                {
                    return new global::Together.JsonConverters.TrainingMethodDPOMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.LRSchedulerLrSchedulerType))
                {
                    return new global::Together.JsonConverters.LRSchedulerLrSchedulerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.LRSchedulerLrSchedulerType?))
                {
                    return new global::Together.JsonConverters.LRSchedulerLrSchedulerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.HardwareAvailabilityStatus))
                {
                    return new global::Together.JsonConverters.HardwareAvailabilityStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.HardwareAvailabilityStatus?))
                {
                    return new global::Together.JsonConverters.HardwareAvailabilityStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CreateEndpointRequestState))
                {
                    return new global::Together.JsonConverters.CreateEndpointRequestStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CreateEndpointRequestState?))
                {
                    return new global::Together.JsonConverters.CreateEndpointRequestStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DedicatedEndpointType))
                {
                    return new global::Together.JsonConverters.DedicatedEndpointTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DedicatedEndpointType?))
                {
                    return new global::Together.JsonConverters.DedicatedEndpointTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DedicatedEndpointState))
                {
                    return new global::Together.JsonConverters.DedicatedEndpointStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DedicatedEndpointState?))
                {
                    return new global::Together.JsonConverters.DedicatedEndpointStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ListEndpointType))
                {
                    return new global::Together.JsonConverters.ListEndpointTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ListEndpointType?))
                {
                    return new global::Together.JsonConverters.ListEndpointTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ListEndpointState))
                {
                    return new global::Together.JsonConverters.ListEndpointStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ListEndpointState?))
                {
                    return new global::Together.JsonConverters.ListEndpointStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DisplayorExecuteOutputType))
                {
                    return new global::Together.JsonConverters.DisplayorExecuteOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DisplayorExecuteOutputType?))
                {
                    return new global::Together.JsonConverters.DisplayorExecuteOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ErrorOutputType))
                {
                    return new global::Together.JsonConverters.ErrorOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ErrorOutputType?))
                {
                    return new global::Together.JsonConverters.ErrorOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ExecuteRequestFileEncoding))
                {
                    return new global::Together.JsonConverters.ExecuteRequestFileEncodingJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ExecuteRequestFileEncoding?))
                {
                    return new global::Together.JsonConverters.ExecuteRequestFileEncodingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ExecuteRequestLanguage))
                {
                    return new global::Together.JsonConverters.ExecuteRequestLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ExecuteRequestLanguage?))
                {
                    return new global::Together.JsonConverters.ExecuteRequestLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputStreamOutputType))
                {
                    return new global::Together.JsonConverters.ExecuteResponseSuccessfulExecutionDataOutputStreamOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputStreamOutputType?))
                {
                    return new global::Together.JsonConverters.ExecuteResponseSuccessfulExecutionDataOutputStreamOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputErrorOutputType))
                {
                    return new global::Together.JsonConverters.ExecuteResponseSuccessfulExecutionDataOutputErrorOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputErrorOutputType?))
                {
                    return new global::Together.JsonConverters.ExecuteResponseSuccessfulExecutionDataOutputErrorOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutputType))
                {
                    return new global::Together.JsonConverters.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutputType?))
                {
                    return new global::Together.JsonConverters.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputDiscriminatorType))
                {
                    return new global::Together.JsonConverters.ExecuteResponseSuccessfulExecutionDataOutputDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputDiscriminatorType?))
                {
                    return new global::Together.JsonConverters.ExecuteResponseSuccessfulExecutionDataOutputDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ExecuteResponseSuccessfulExecutionDataStatus))
                {
                    return new global::Together.JsonConverters.ExecuteResponseSuccessfulExecutionDataStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ExecuteResponseSuccessfulExecutionDataStatus?))
                {
                    return new global::Together.JsonConverters.ExecuteResponseSuccessfulExecutionDataStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.InterpreterOutputStreamOutputType))
                {
                    return new global::Together.JsonConverters.InterpreterOutputStreamOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.InterpreterOutputStreamOutputType?))
                {
                    return new global::Together.JsonConverters.InterpreterOutputStreamOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.InterpreterOutputErrorOutputType))
                {
                    return new global::Together.JsonConverters.InterpreterOutputErrorOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.InterpreterOutputErrorOutputType?))
                {
                    return new global::Together.JsonConverters.InterpreterOutputErrorOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.InterpreterOutputDisplayorExecuteOutputType))
                {
                    return new global::Together.JsonConverters.InterpreterOutputDisplayorExecuteOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.InterpreterOutputDisplayorExecuteOutputType?))
                {
                    return new global::Together.JsonConverters.InterpreterOutputDisplayorExecuteOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.InterpreterOutputDiscriminatorType))
                {
                    return new global::Together.JsonConverters.InterpreterOutputDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.InterpreterOutputDiscriminatorType?))
                {
                    return new global::Together.JsonConverters.InterpreterOutputDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.StreamOutputType))
                {
                    return new global::Together.JsonConverters.StreamOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.StreamOutputType?))
                {
                    return new global::Together.JsonConverters.StreamOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CreateBatchRequestEndpoint))
                {
                    return new global::Together.JsonConverters.CreateBatchRequestEndpointJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CreateBatchRequestEndpoint?))
                {
                    return new global::Together.JsonConverters.CreateBatchRequestEndpointNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.BatchJobStatus))
                {
                    return new global::Together.JsonConverters.BatchJobStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.BatchJobStatus?))
                {
                    return new global::Together.JsonConverters.BatchJobStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.EvaluationTypedRequestType))
                {
                    return new global::Together.JsonConverters.EvaluationTypedRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.EvaluationTypedRequestType?))
                {
                    return new global::Together.JsonConverters.EvaluationTypedRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.EvaluationJudgeModelConfigModelSource))
                {
                    return new global::Together.JsonConverters.EvaluationJudgeModelConfigModelSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.EvaluationJudgeModelConfigModelSource?))
                {
                    return new global::Together.JsonConverters.EvaluationJudgeModelConfigModelSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.EvaluationModelRequestModelSource))
                {
                    return new global::Together.JsonConverters.EvaluationModelRequestModelSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.EvaluationModelRequestModelSource?))
                {
                    return new global::Together.JsonConverters.EvaluationModelRequestModelSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.EvaluationResponseStatus))
                {
                    return new global::Together.JsonConverters.EvaluationResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.EvaluationResponseStatus?))
                {
                    return new global::Together.JsonConverters.EvaluationResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.EvaluationJobType))
                {
                    return new global::Together.JsonConverters.EvaluationJobTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.EvaluationJobType?))
                {
                    return new global::Together.JsonConverters.EvaluationJobTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.EvaluationJobStatus))
                {
                    return new global::Together.JsonConverters.EvaluationJobStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.EvaluationJobStatus?))
                {
                    return new global::Together.JsonConverters.EvaluationJobStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.VideoStatus))
                {
                    return new global::Together.JsonConverters.VideoStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.VideoStatus?))
                {
                    return new global::Together.JsonConverters.VideoStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.VideoFrameImageInputFrame))
                {
                    return new global::Together.JsonConverters.VideoFrameImageInputFrameJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.VideoFrameImageInputFrame?))
                {
                    return new global::Together.JsonConverters.VideoFrameImageInputFrameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.VideoOutputFormat))
                {
                    return new global::Together.JsonConverters.VideoOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.VideoOutputFormat?))
                {
                    return new global::Together.JsonConverters.VideoOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CreateDeploymentRequestGpuType))
                {
                    return new global::Together.JsonConverters.CreateDeploymentRequestGpuTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CreateDeploymentRequestGpuType?))
                {
                    return new global::Together.JsonConverters.CreateDeploymentRequestGpuTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeploymentResponseItemGpuType))
                {
                    return new global::Together.JsonConverters.DeploymentResponseItemGpuTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeploymentResponseItemGpuType?))
                {
                    return new global::Together.JsonConverters.DeploymentResponseItemGpuTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeploymentStatus))
                {
                    return new global::Together.JsonConverters.DeploymentStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeploymentStatus?))
                {
                    return new global::Together.JsonConverters.DeploymentStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.HTTPAutoscalingConfigMetric))
                {
                    return new global::Together.JsonConverters.HTTPAutoscalingConfigMetricJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.HTTPAutoscalingConfigMetric?))
                {
                    return new global::Together.JsonConverters.HTTPAutoscalingConfigMetricNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.QueueAutoscalingConfigMetric))
                {
                    return new global::Together.JsonConverters.QueueAutoscalingConfigMetricJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.QueueAutoscalingConfigMetric?))
                {
                    return new global::Together.JsonConverters.QueueAutoscalingConfigMetricNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CustomMetricAutoscalingConfigMetric))
                {
                    return new global::Together.JsonConverters.CustomMetricAutoscalingConfigMetricJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CustomMetricAutoscalingConfigMetric?))
                {
                    return new global::Together.JsonConverters.CustomMetricAutoscalingConfigMetricNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.UpdateDeploymentRequestGpuType))
                {
                    return new global::Together.JsonConverters.UpdateDeploymentRequestGpuTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.UpdateDeploymentRequestGpuType?))
                {
                    return new global::Together.JsonConverters.UpdateDeploymentRequestGpuTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.VolumeContentRequestType))
                {
                    return new global::Together.JsonConverters.VolumeContentRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.VolumeContentRequestType?))
                {
                    return new global::Together.JsonConverters.VolumeContentRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.VolumeContentType))
                {
                    return new global::Together.JsonConverters.VolumeContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.VolumeContentType?))
                {
                    return new global::Together.JsonConverters.VolumeContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.VolumeType))
                {
                    return new global::Together.JsonConverters.VolumeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.VolumeType?))
                {
                    return new global::Together.JsonConverters.VolumeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.QueueCancelResponseStatus))
                {
                    return new global::Together.JsonConverters.QueueCancelResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.QueueCancelResponseStatus?))
                {
                    return new global::Together.JsonConverters.QueueCancelResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.QueueJobStatusResponseStatus))
                {
                    return new global::Together.JsonConverters.QueueJobStatusResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.QueueJobStatusResponseStatus?))
                {
                    return new global::Together.JsonConverters.QueueJobStatusResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CreateImagesGenerationsRequestModel))
                {
                    return new global::Together.JsonConverters.CreateImagesGenerationsRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CreateImagesGenerationsRequestModel?))
                {
                    return new global::Together.JsonConverters.CreateImagesGenerationsRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CreateImagesGenerationsRequestResponseFormat))
                {
                    return new global::Together.JsonConverters.CreateImagesGenerationsRequestResponseFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CreateImagesGenerationsRequestResponseFormat?))
                {
                    return new global::Together.JsonConverters.CreateImagesGenerationsRequestResponseFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CreateImagesGenerationsRequestOutputFormat))
                {
                    return new global::Together.JsonConverters.CreateImagesGenerationsRequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CreateImagesGenerationsRequestOutputFormat?))
                {
                    return new global::Together.JsonConverters.CreateImagesGenerationsRequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CreateFineTunesRequestBatchSize))
                {
                    return new global::Together.JsonConverters.CreateFineTunesRequestBatchSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CreateFineTunesRequestBatchSize?))
                {
                    return new global::Together.JsonConverters.CreateFineTunesRequestBatchSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CreateFineTunesRequestTrainOnInputs))
                {
                    return new global::Together.JsonConverters.CreateFineTunesRequestTrainOnInputsJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CreateFineTunesRequestTrainOnInputs?))
                {
                    return new global::Together.JsonConverters.CreateFineTunesRequestTrainOnInputsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.UpdateEndpointRequestState))
                {
                    return new global::Together.JsonConverters.UpdateEndpointRequestStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.UpdateEndpointRequestState?))
                {
                    return new global::Together.JsonConverters.UpdateEndpointRequestStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RolloutServiceListRolloutsFilter))
                {
                    return new global::Together.JsonConverters.RolloutServiceListRolloutsFilterJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RolloutServiceListRolloutsFilter?))
                {
                    return new global::Together.JsonConverters.RolloutServiceListRolloutsFilterNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.EndpointServiceListEndpointEventsMinLevel))
                {
                    return new global::Together.JsonConverters.EndpointServiceListEndpointEventsMinLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.EndpointServiceListEndpointEventsMinLevel?))
                {
                    return new global::Together.JsonConverters.EndpointServiceListEndpointEventsMinLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.EndpointServiceListEndpointEventsSourceKind))
                {
                    return new global::Together.JsonConverters.EndpointServiceListEndpointEventsSourceKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.EndpointServiceListEndpointEventsSourceKind?))
                {
                    return new global::Together.JsonConverters.EndpointServiceListEndpointEventsSourceKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.VolumeServiceListModelsVisibility))
                {
                    return new global::Together.JsonConverters.VolumeServiceListModelsVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.VolumeServiceListModelsVisibility?))
                {
                    return new global::Together.JsonConverters.VolumeServiceListModelsVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.SupportedModelsServiceListSupportedModelsModality))
                {
                    return new global::Together.JsonConverters.SupportedModelsServiceListSupportedModelsModalityJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.SupportedModelsServiceListSupportedModelsModality?))
                {
                    return new global::Together.JsonConverters.SupportedModelsServiceListSupportedModelsModalityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.SupportedModelsServiceListSupportedModelsProduct))
                {
                    return new global::Together.JsonConverters.SupportedModelsServiceListSupportedModelsProductJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.SupportedModelsServiceListSupportedModelsProduct?))
                {
                    return new global::Together.JsonConverters.SupportedModelsServiceListSupportedModelsProductNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.GetFinetuneDownloadCheckpoint))
                {
                    return new global::Together.JsonConverters.GetFinetuneDownloadCheckpointJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.GetFinetuneDownloadCheckpoint?))
                {
                    return new global::Together.JsonConverters.GetFinetuneDownloadCheckpointNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RealtimeTtsModel))
                {
                    return new global::Together.JsonConverters.RealtimeTtsModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RealtimeTtsModel?))
                {
                    return new global::Together.JsonConverters.RealtimeTtsModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ListEndpointsType))
                {
                    return new global::Together.JsonConverters.ListEndpointsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ListEndpointsType?))
                {
                    return new global::Together.JsonConverters.ListEndpointsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ListEndpointsUsageType))
                {
                    return new global::Together.JsonConverters.ListEndpointsUsageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ListEndpointsUsageType?))
                {
                    return new global::Together.JsonConverters.ListEndpointsUsageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RealtimeTranscriptionInputAudioFormat))
                {
                    return new global::Together.JsonConverters.RealtimeTranscriptionInputAudioFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RealtimeTranscriptionInputAudioFormat?))
                {
                    return new global::Together.JsonConverters.RealtimeTranscriptionInputAudioFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ListModelResourcesStatu))
                {
                    return new global::Together.JsonConverters.ListModelResourcesStatuJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ListModelResourcesStatu?))
                {
                    return new global::Together.JsonConverters.ListModelResourcesStatuNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ListTrainingSessionsStatu))
                {
                    return new global::Together.JsonConverters.ListTrainingSessionsStatuJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.ListTrainingSessionsStatu?))
                {
                    return new global::Together.JsonConverters.ListTrainingSessionsStatuNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RemediationServiceListRemediationsStateItem))
                {
                    return new global::Together.JsonConverters.RemediationServiceListRemediationsStateItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RemediationServiceListRemediationsStateItem?))
                {
                    return new global::Together.JsonConverters.RemediationServiceListRemediationsStateItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RemediationServiceListRemediationsTriggerItem))
                {
                    return new global::Together.JsonConverters.RemediationServiceListRemediationsTriggerItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RemediationServiceListRemediationsTriggerItem?))
                {
                    return new global::Together.JsonConverters.RemediationServiceListRemediationsTriggerItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RemediationServiceListRemediationsModeItem))
                {
                    return new global::Together.JsonConverters.RemediationServiceListRemediationsModeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RemediationServiceListRemediationsModeItem?))
                {
                    return new global::Together.JsonConverters.RemediationServiceListRemediationsModeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.HealthCheckServiceListPassiveHealthCheckAlertsStatus))
                {
                    return new global::Together.JsonConverters.HealthCheckServiceListPassiveHealthCheckAlertsStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.HealthCheckServiceListPassiveHealthCheckAlertsStatus?))
                {
                    return new global::Together.JsonConverters.HealthCheckServiceListPassiveHealthCheckAlertsStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.HealthCheckServiceListPassiveHealthCheckAlertsSeverityFilterItem))
                {
                    return new global::Together.JsonConverters.HealthCheckServiceListPassiveHealthCheckAlertsSeverityFilterItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.HealthCheckServiceListPassiveHealthCheckAlertsSeverityFilterItem?))
                {
                    return new global::Together.JsonConverters.HealthCheckServiceListPassiveHealthCheckAlertsSeverityFilterItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.HealthCheckServiceListPassiveHealthCheckAlertsOrderBy))
                {
                    return new global::Together.JsonConverters.HealthCheckServiceListPassiveHealthCheckAlertsOrderByJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.HealthCheckServiceListPassiveHealthCheckAlertsOrderBy?))
                {
                    return new global::Together.JsonConverters.HealthCheckServiceListPassiveHealthCheckAlertsOrderByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.GetBillingUsageGranularity))
                {
                    return new global::Together.JsonConverters.GetBillingUsageGranularityJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.GetBillingUsageGranularity?))
                {
                    return new global::Together.JsonConverters.GetBillingUsageGranularityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CreateFineTunesEstimatePriceResponseVariant2UnavailableReason))
                {
                    return new global::Together.JsonConverters.CreateFineTunesEstimatePriceResponseVariant2UnavailableReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CreateFineTunesEstimatePriceResponseVariant2UnavailableReason?))
                {
                    return new global::Together.JsonConverters.CreateFineTunesEstimatePriceResponseVariant2UnavailableReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.GetEvaluationJobStatusAndResultsResponseStatus))
                {
                    return new global::Together.JsonConverters.GetEvaluationJobStatusAndResultsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.GetEvaluationJobStatusAndResultsResponseStatus?))
                {
                    return new global::Together.JsonConverters.GetEvaluationJobStatusAndResultsResponseStatusNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[3];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new SourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),

                    2 => new SourceGenerationContextChunk2(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}