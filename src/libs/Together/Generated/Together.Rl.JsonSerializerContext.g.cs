
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlComputeConfigGpuType), TypeInfoPropertyName = "RlComputeConfigGpuType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlComputeConfigCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlComputeConfigCreateRequestGpuType), TypeInfoPropertyName = "RlComputeConfigCreateRequestGpuType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlSupportedModelComputeConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlSupportedModelComputeConfigGpuType), TypeInfoPropertyName = "RlSupportedModelComputeConfigGpuType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlSupportedModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlSupportedModelDefaultGpuType), TypeInfoPropertyName = "RlSupportedModelDefaultGpuType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.RlSupportedModelComputeConfig>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlDPPOLossParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlLossFnOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Together.RlTensorData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTensorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTensorDataDtype), TypeInfoPropertyName = "RlTensorDataDtype2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlPolicyVersionSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlPromptTopLogprobs))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.RlLossFnOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlCustomForwardBackwardBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.RlTargetLogprobGradients>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTargetLogprobGradients))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlCustomForwardBackwardOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlCustomForwardBackwardResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTrainingOperationErrorCode), TypeInfoPropertyName = "RlTrainingOperationErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlStartTrainingSessionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlLoraConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTrainingSessionMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlUpdateTrainingSessionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTrainingSessionStatus), TypeInfoPropertyName = "RlTrainingSessionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTrainingSessionError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTrainingSessionErrorCode), TypeInfoPropertyName = "RlTrainingSessionErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlWandbMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlSessionPolicyState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTrainingSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.RlInferenceCheckpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlInferenceCheckpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.RlTrainingCheckpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTrainingCheckpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTrainingSessionsListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.RlTrainingSession>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlSupportedModelsListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.RlSupportedModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlAdamConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlMuonConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlMuonScalingStrategy), TypeInfoPropertyName = "RlMuonScalingStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlInferenceCheckpointOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlInferenceCheckpointResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlInferenceCheckpointRegistration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTrainingCheckpointRegistration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTrainingCheckpointResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTrainingCheckpointOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlCheckpointsListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.RlCheckpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlCheckpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlCheckpointType), TypeInfoPropertyName = "RlCheckpointType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlCheckpointVariant), TypeInfoPropertyName = "RlCheckpointVariant2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlCheckpointFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<string, long?>), TypeInfoPropertyName = "OneOfStringInt642")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlCheckpointDownloadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.RlCheckpointFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ErrorDataError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.ListModelResourcesStatu>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ListModelResourcesStatu), TypeInfoPropertyName = "ListModelResourcesStatu2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.ListTrainingSessionsStatu>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ListTrainingSessionsStatu), TypeInfoPropertyName = "ListTrainingSessionsStatu2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlWeightSyncType?), TypeInfoPropertyName = "NullableRlWeightSyncType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<string, int?>?), TypeInfoPropertyName = "NullableOneOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlComputeConfigGpuType?), TypeInfoPropertyName = "NullableRlComputeConfigGpuType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlComputeConfigCreateRequestGpuType?), TypeInfoPropertyName = "NullableRlComputeConfigCreateRequestGpuType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlModelResourcesStatus?), TypeInfoPropertyName = "NullableRlModelResourcesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlModelResourcesErrorCode?), TypeInfoPropertyName = "NullableRlModelResourcesErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlSupportedModelComputeConfigGpuType?), TypeInfoPropertyName = "NullableRlSupportedModelComputeConfigGpuType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlSupportedModelDefaultGpuType?), TypeInfoPropertyName = "NullableRlSupportedModelDefaultGpuType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ListModelResourcesStatu?), TypeInfoPropertyName = "NullableListModelResourcesStatu2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ListTrainingSessionsStatu?), TypeInfoPropertyName = "NullableListTrainingSessionsStatu2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RlModelInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RlTrainingSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RlModelInputChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RlModelResources>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RlSupportedModelComputeConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.OneOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RlSampleResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RlSampledSequence>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RlPromptTopLogprobs>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RlPolicyVersionSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RlLossFnOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RlTargetLogprobGradients>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RlInferenceCheckpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RlTrainingCheckpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RlTrainingSession>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RlSupportedModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RlCheckpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RlCheckpointFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.ListModelResourcesStatu>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.ListTrainingSessionsStatu>))]
    internal sealed partial class RlSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RlSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static RlSourceGenerationContext Default { get; } = new(DefaultOptions);

        private RlSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
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
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, long?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<object>, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<byte[], string>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<byte[], string>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, object>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, object>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, object>());
            options.Converters.Add(new global::Together.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Together.RlComputeConfigGpuType)

                    || typeToConvert == typeof(global::Together.RlComputeConfigGpuType?)

                    || typeToConvert == typeof(global::Together.RlComputeConfigCreateRequestGpuType)

                    || typeToConvert == typeof(global::Together.RlComputeConfigCreateRequestGpuType?)

                    || typeToConvert == typeof(global::Together.RlModelResourcesStatus)

                    || typeToConvert == typeof(global::Together.RlModelResourcesStatus?)

                    || typeToConvert == typeof(global::Together.RlModelResourcesErrorCode)

                    || typeToConvert == typeof(global::Together.RlModelResourcesErrorCode?)

                    || typeToConvert == typeof(global::Together.RlSupportedModelComputeConfigGpuType)

                    || typeToConvert == typeof(global::Together.RlSupportedModelComputeConfigGpuType?)

                    || typeToConvert == typeof(global::Together.RlSupportedModelDefaultGpuType)

                    || typeToConvert == typeof(global::Together.RlSupportedModelDefaultGpuType?)

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

                    || typeToConvert == typeof(global::Together.ListModelResourcesStatu)

                    || typeToConvert == typeof(global::Together.ListModelResourcesStatu?)

                    || typeToConvert == typeof(global::Together.ListTrainingSessionsStatu)

                    || typeToConvert == typeof(global::Together.ListTrainingSessionsStatu?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Together.RlComputeConfigGpuType))
                {
                    return new global::Together.JsonConverters.RlComputeConfigGpuTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RlComputeConfigGpuType?))
                {
                    return new global::Together.JsonConverters.RlComputeConfigGpuTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RlComputeConfigCreateRequestGpuType))
                {
                    return new global::Together.JsonConverters.RlComputeConfigCreateRequestGpuTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RlComputeConfigCreateRequestGpuType?))
                {
                    return new global::Together.JsonConverters.RlComputeConfigCreateRequestGpuTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Together.RlSupportedModelComputeConfigGpuType))
                {
                    return new global::Together.JsonConverters.RlSupportedModelComputeConfigGpuTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RlSupportedModelComputeConfigGpuType?))
                {
                    return new global::Together.JsonConverters.RlSupportedModelComputeConfigGpuTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RlSupportedModelDefaultGpuType))
                {
                    return new global::Together.JsonConverters.RlSupportedModelDefaultGpuTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RlSupportedModelDefaultGpuType?))
                {
                    return new global::Together.JsonConverters.RlSupportedModelDefaultGpuTypeNullableJsonConverter();
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
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

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
                    0 => new RlSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}