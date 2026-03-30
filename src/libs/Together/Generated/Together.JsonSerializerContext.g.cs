
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
            typeof(global::Together.JsonConverters.RlDTypeJsonConverter),

            typeof(global::Together.JsonConverters.RlDTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.RlLossTypeJsonConverter),

            typeof(global::Together.JsonConverters.RlLossTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.RlGRPOLossAggregationTypeJsonConverter),

            typeof(global::Together.JsonConverters.RlGRPOLossAggregationTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.RlTrainingOperationErrorCodeJsonConverter),

            typeof(global::Together.JsonConverters.RlTrainingOperationErrorCodeNullableJsonConverter),

            typeof(global::Together.JsonConverters.RlTrainingOperationStatusJsonConverter),

            typeof(global::Together.JsonConverters.RlTrainingOperationStatusNullableJsonConverter),

            typeof(global::Together.JsonConverters.RlTrainingSessionStatusJsonConverter),

            typeof(global::Together.JsonConverters.RlTrainingSessionStatusNullableJsonConverter),

            typeof(global::Together.JsonConverters.RlCheckpointVariantJsonConverter),

            typeof(global::Together.JsonConverters.RlCheckpointVariantNullableJsonConverter),

            typeof(global::Together.JsonConverters.GPUClusterCreateRequestClusterTypeJsonConverter),

            typeof(global::Together.JsonConverters.GPUClusterCreateRequestClusterTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.GPUClusterCreateRequestGpuTypeJsonConverter),

            typeof(global::Together.JsonConverters.GPUClusterCreateRequestGpuTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.GPUClusterCreateRequestDriverVersionJsonConverter),

            typeof(global::Together.JsonConverters.GPUClusterCreateRequestDriverVersionNullableJsonConverter),

            typeof(global::Together.JsonConverters.GPUClusterCreateRequestBillingTypeJsonConverter),

            typeof(global::Together.JsonConverters.GPUClusterCreateRequestBillingTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.GPUClusterInfoClusterTypeJsonConverter),

            typeof(global::Together.JsonConverters.GPUClusterInfoClusterTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.GPUClusterInfoGpuTypeJsonConverter),

            typeof(global::Together.JsonConverters.GPUClusterInfoGpuTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.GPUClusterInfoDriverVersionJsonConverter),

            typeof(global::Together.JsonConverters.GPUClusterInfoDriverVersionNullableJsonConverter),

            typeof(global::Together.JsonConverters.GPUClusterInfoStatusJsonConverter),

            typeof(global::Together.JsonConverters.GPUClusterInfoStatusNullableJsonConverter),

            typeof(global::Together.JsonConverters.GPUClusterUpdateRequestClusterTypeJsonConverter),

            typeof(global::Together.JsonConverters.GPUClusterUpdateRequestClusterTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.InstanceTypesResponseTypeJsonConverter),

            typeof(global::Together.JsonConverters.InstanceTypesResponseTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.GPUClustersSharedVolumeStatusJsonConverter),

            typeof(global::Together.JsonConverters.GPUClustersSharedVolumeStatusNullableJsonConverter),

            typeof(global::Together.JsonConverters.RerankRequestModelJsonConverter),

            typeof(global::Together.JsonConverters.RerankRequestModelNullableJsonConverter),

            typeof(global::Together.JsonConverters.FinishReasonJsonConverter),

            typeof(global::Together.JsonConverters.FinishReasonNullableJsonConverter),

            typeof(global::Together.JsonConverters.CompletionRequestModelJsonConverter),

            typeof(global::Together.JsonConverters.CompletionRequestModelNullableJsonConverter),

            typeof(global::Together.JsonConverters.CompletionRequestSafetyModelJsonConverter),

            typeof(global::Together.JsonConverters.CompletionRequestSafetyModelNullableJsonConverter),

            typeof(global::Together.JsonConverters.CompletionChoiceDeltaRoleJsonConverter),

            typeof(global::Together.JsonConverters.CompletionChoiceDeltaRoleNullableJsonConverter),

            typeof(global::Together.JsonConverters.ChatCompletionMessageRoleJsonConverter),

            typeof(global::Together.JsonConverters.ChatCompletionMessageRoleNullableJsonConverter),

            typeof(global::Together.JsonConverters.ChatCompletionToolTypeJsonConverter),

            typeof(global::Together.JsonConverters.ChatCompletionToolTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.ChatCompletionRequestContextLengthExceededBehaviorJsonConverter),

            typeof(global::Together.JsonConverters.ChatCompletionRequestContextLengthExceededBehaviorNullableJsonConverter),

            typeof(global::Together.JsonConverters.ChatCompletionRequestFunctionCallEnumJsonConverter),

            typeof(global::Together.JsonConverters.ChatCompletionRequestFunctionCallEnumNullableJsonConverter),

            typeof(global::Together.JsonConverters.ChatCompletionRequestReasoningEffortJsonConverter),

            typeof(global::Together.JsonConverters.ChatCompletionRequestReasoningEffortNullableJsonConverter),

            typeof(global::Together.JsonConverters.ResponseFormatTextTypeJsonConverter),

            typeof(global::Together.JsonConverters.ResponseFormatTextTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.ResponseFormatJsonObjectTypeJsonConverter),

            typeof(global::Together.JsonConverters.ResponseFormatJsonObjectTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.ResponseFormatJsonSchemaTypeJsonConverter),

            typeof(global::Together.JsonConverters.ResponseFormatJsonSchemaTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.ChatCompletionSystemMessageParamRoleJsonConverter),

            typeof(global::Together.JsonConverters.ChatCompletionSystemMessageParamRoleNullableJsonConverter),

            typeof(global::Together.JsonConverters.ChatCompletionUserMessageParamRoleJsonConverter),

            typeof(global::Together.JsonConverters.ChatCompletionUserMessageParamRoleNullableJsonConverter),

            typeof(global::Together.JsonConverters.ChatCompletionUserMessageContentMultimodalItemVariant1TypeJsonConverter),

            typeof(global::Together.JsonConverters.ChatCompletionUserMessageContentMultimodalItemVariant1TypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.ChatCompletionUserMessageContentMultimodalItemVariant2TypeJsonConverter),

            typeof(global::Together.JsonConverters.ChatCompletionUserMessageContentMultimodalItemVariant2TypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.ChatCompletionUserMessageContentMultimodalItemVideoTypeJsonConverter),

            typeof(global::Together.JsonConverters.ChatCompletionUserMessageContentMultimodalItemVideoTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.ChatCompletionUserMessageContentMultimodalItemAudioTypeJsonConverter),

            typeof(global::Together.JsonConverters.ChatCompletionUserMessageContentMultimodalItemAudioTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.ChatCompletionUserMessageContentMultimodalItemInputAudioTypeJsonConverter),

            typeof(global::Together.JsonConverters.ChatCompletionUserMessageContentMultimodalItemInputAudioTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.ChatCompletionUserMessageContentMultimodalItemInputAudioInputAudioFormatJsonConverter),

            typeof(global::Together.JsonConverters.ChatCompletionUserMessageContentMultimodalItemInputAudioInputAudioFormatNullableJsonConverter),

            typeof(global::Together.JsonConverters.ChatCompletionAssistantMessageParamRoleJsonConverter),

            typeof(global::Together.JsonConverters.ChatCompletionAssistantMessageParamRoleNullableJsonConverter),

            typeof(global::Together.JsonConverters.ChatCompletionFunctionMessageParamRoleJsonConverter),

            typeof(global::Together.JsonConverters.ChatCompletionFunctionMessageParamRoleNullableJsonConverter),

            typeof(global::Together.JsonConverters.ChatCompletionToolMessageParamRoleJsonConverter),

            typeof(global::Together.JsonConverters.ChatCompletionToolMessageParamRoleNullableJsonConverter),

            typeof(global::Together.JsonConverters.ChatCompletionChunkChoiceDeltaRoleJsonConverter),

            typeof(global::Together.JsonConverters.ChatCompletionChunkChoiceDeltaRoleNullableJsonConverter),

            typeof(global::Together.JsonConverters.AudioSpeechRequestModelJsonConverter),

            typeof(global::Together.JsonConverters.AudioSpeechRequestModelNullableJsonConverter),

            typeof(global::Together.JsonConverters.AudioSpeechRequestResponseFormatJsonConverter),

            typeof(global::Together.JsonConverters.AudioSpeechRequestResponseFormatNullableJsonConverter),

            typeof(global::Together.JsonConverters.AudioSpeechRequestLanguageJsonConverter),

            typeof(global::Together.JsonConverters.AudioSpeechRequestLanguageNullableJsonConverter),

            typeof(global::Together.JsonConverters.AudioSpeechRequestResponseEncodingJsonConverter),

            typeof(global::Together.JsonConverters.AudioSpeechRequestResponseEncodingNullableJsonConverter),

            typeof(global::Together.JsonConverters.AudioTranscriptionRequestModelJsonConverter),

            typeof(global::Together.JsonConverters.AudioTranscriptionRequestModelNullableJsonConverter),

            typeof(global::Together.JsonConverters.AudioTranscriptionRequestResponseFormatJsonConverter),

            typeof(global::Together.JsonConverters.AudioTranscriptionRequestResponseFormatNullableJsonConverter),

            typeof(global::Together.JsonConverters.AudioTranscriptionRequestTimestampGranularitiesJsonConverter),

            typeof(global::Together.JsonConverters.AudioTranscriptionRequestTimestampGranularitiesNullableJsonConverter),

            typeof(global::Together.JsonConverters.AudioTranscriptionRequestTimestampGranularitieJsonConverter),

            typeof(global::Together.JsonConverters.AudioTranscriptionRequestTimestampGranularitieNullableJsonConverter),

            typeof(global::Together.JsonConverters.AudioTranscriptionVerboseJsonResponseTaskJsonConverter),

            typeof(global::Together.JsonConverters.AudioTranscriptionVerboseJsonResponseTaskNullableJsonConverter),

            typeof(global::Together.JsonConverters.AudioTranslationRequestModelJsonConverter),

            typeof(global::Together.JsonConverters.AudioTranslationRequestModelNullableJsonConverter),

            typeof(global::Together.JsonConverters.AudioTranslationRequestResponseFormatJsonConverter),

            typeof(global::Together.JsonConverters.AudioTranslationRequestResponseFormatNullableJsonConverter),

            typeof(global::Together.JsonConverters.AudioTranslationRequestTimestampGranularitiesJsonConverter),

            typeof(global::Together.JsonConverters.AudioTranslationRequestTimestampGranularitiesNullableJsonConverter),

            typeof(global::Together.JsonConverters.AudioTranslationRequestTimestampGranularitieJsonConverter),

            typeof(global::Together.JsonConverters.AudioTranslationRequestTimestampGranularitieNullableJsonConverter),

            typeof(global::Together.JsonConverters.AudioTranslationVerboseJsonResponseTaskJsonConverter),

            typeof(global::Together.JsonConverters.AudioTranslationVerboseJsonResponseTaskNullableJsonConverter),

            typeof(global::Together.JsonConverters.StreamSentinelDataJsonConverter),

            typeof(global::Together.JsonConverters.StreamSentinelDataNullableJsonConverter),

            typeof(global::Together.JsonConverters.ChatCompletionChoiceDeltaRoleJsonConverter),

            typeof(global::Together.JsonConverters.ChatCompletionChoiceDeltaRoleNullableJsonConverter),

            typeof(global::Together.JsonConverters.EmbeddingsRequestModelJsonConverter),

            typeof(global::Together.JsonConverters.EmbeddingsRequestModelNullableJsonConverter),

            typeof(global::Together.JsonConverters.ModelInfoTypeJsonConverter),

            typeof(global::Together.JsonConverters.ModelInfoTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.ModelUploadRequestModelTypeJsonConverter),

            typeof(global::Together.JsonConverters.ModelUploadRequestModelTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.ImageResponseDataB64TypeJsonConverter),

            typeof(global::Together.JsonConverters.ImageResponseDataB64TypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.ImageResponseDataUrlTypeJsonConverter),

            typeof(global::Together.JsonConverters.ImageResponseDataUrlTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.JobInfoSuccessResponseStatusJsonConverter),

            typeof(global::Together.JsonConverters.JobInfoSuccessResponseStatusNullableJsonConverter),

            typeof(global::Together.JsonConverters.ToolChoiceTypeJsonConverter),

            typeof(global::Together.JsonConverters.ToolChoiceTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.FilePurposeJsonConverter),

            typeof(global::Together.JsonConverters.FilePurposeNullableJsonConverter),

            typeof(global::Together.JsonConverters.FileTypeJsonConverter),

            typeof(global::Together.JsonConverters.FileTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.FinetuneResponseBatchSizeJsonConverter),

            typeof(global::Together.JsonConverters.FinetuneResponseBatchSizeNullableJsonConverter),

            typeof(global::Together.JsonConverters.FinetuneResponseTrainOnInputsJsonConverter),

            typeof(global::Together.JsonConverters.FinetuneResponseTrainOnInputsNullableJsonConverter),

            typeof(global::Together.JsonConverters.FinetuneJobStatusJsonConverter),

            typeof(global::Together.JsonConverters.FinetuneJobStatusNullableJsonConverter),

            typeof(global::Together.JsonConverters.FinetuneEventLevelsJsonConverter),

            typeof(global::Together.JsonConverters.FinetuneEventLevelsNullableJsonConverter),

            typeof(global::Together.JsonConverters.FinetuneEventTypeJsonConverter),

            typeof(global::Together.JsonConverters.FinetuneEventTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.FullTrainingTypeTypeJsonConverter),

            typeof(global::Together.JsonConverters.FullTrainingTypeTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.LoRATrainingTypeTypeJsonConverter),

            typeof(global::Together.JsonConverters.LoRATrainingTypeTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.TrainingMethodSFTMethodJsonConverter),

            typeof(global::Together.JsonConverters.TrainingMethodSFTMethodNullableJsonConverter),

            typeof(global::Together.JsonConverters.TrainingMethodSFTTrainOnInputsJsonConverter),

            typeof(global::Together.JsonConverters.TrainingMethodSFTTrainOnInputsNullableJsonConverter),

            typeof(global::Together.JsonConverters.TrainingMethodDPOMethodJsonConverter),

            typeof(global::Together.JsonConverters.TrainingMethodDPOMethodNullableJsonConverter),

            typeof(global::Together.JsonConverters.LRSchedulerLrSchedulerTypeJsonConverter),

            typeof(global::Together.JsonConverters.LRSchedulerLrSchedulerTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.HardwareAvailabilityStatusJsonConverter),

            typeof(global::Together.JsonConverters.HardwareAvailabilityStatusNullableJsonConverter),

            typeof(global::Together.JsonConverters.CreateEndpointRequestStateJsonConverter),

            typeof(global::Together.JsonConverters.CreateEndpointRequestStateNullableJsonConverter),

            typeof(global::Together.JsonConverters.DedicatedEndpointTypeJsonConverter),

            typeof(global::Together.JsonConverters.DedicatedEndpointTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.DedicatedEndpointStateJsonConverter),

            typeof(global::Together.JsonConverters.DedicatedEndpointStateNullableJsonConverter),

            typeof(global::Together.JsonConverters.ListEndpointTypeJsonConverter),

            typeof(global::Together.JsonConverters.ListEndpointTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.ListEndpointStateJsonConverter),

            typeof(global::Together.JsonConverters.ListEndpointStateNullableJsonConverter),

            typeof(global::Together.JsonConverters.DisplayorExecuteOutputTypeJsonConverter),

            typeof(global::Together.JsonConverters.DisplayorExecuteOutputTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.ErrorOutputTypeJsonConverter),

            typeof(global::Together.JsonConverters.ErrorOutputTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.ExecuteRequestFileEncodingJsonConverter),

            typeof(global::Together.JsonConverters.ExecuteRequestFileEncodingNullableJsonConverter),

            typeof(global::Together.JsonConverters.ExecuteRequestLanguageJsonConverter),

            typeof(global::Together.JsonConverters.ExecuteRequestLanguageNullableJsonConverter),

            typeof(global::Together.JsonConverters.ExecuteResponseSuccessfulExecutionDataOutputStreamOutputTypeJsonConverter),

            typeof(global::Together.JsonConverters.ExecuteResponseSuccessfulExecutionDataOutputStreamOutputTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.ExecuteResponseSuccessfulExecutionDataOutputErrorOutputTypeJsonConverter),

            typeof(global::Together.JsonConverters.ExecuteResponseSuccessfulExecutionDataOutputErrorOutputTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutputTypeJsonConverter),

            typeof(global::Together.JsonConverters.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutputTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.ExecuteResponseSuccessfulExecutionDataStatusJsonConverter),

            typeof(global::Together.JsonConverters.ExecuteResponseSuccessfulExecutionDataStatusNullableJsonConverter),

            typeof(global::Together.JsonConverters.InterpreterOutputStreamOutputTypeJsonConverter),

            typeof(global::Together.JsonConverters.InterpreterOutputStreamOutputTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.InterpreterOutputErrorOutputTypeJsonConverter),

            typeof(global::Together.JsonConverters.InterpreterOutputErrorOutputTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.InterpreterOutputDisplayorExecuteOutputTypeJsonConverter),

            typeof(global::Together.JsonConverters.InterpreterOutputDisplayorExecuteOutputTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.StreamOutputTypeJsonConverter),

            typeof(global::Together.JsonConverters.StreamOutputTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.BatchJobStatusJsonConverter),

            typeof(global::Together.JsonConverters.BatchJobStatusNullableJsonConverter),

            typeof(global::Together.JsonConverters.EvaluationTypedRequestTypeJsonConverter),

            typeof(global::Together.JsonConverters.EvaluationTypedRequestTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.EvaluationJudgeModelConfigModelSourceJsonConverter),

            typeof(global::Together.JsonConverters.EvaluationJudgeModelConfigModelSourceNullableJsonConverter),

            typeof(global::Together.JsonConverters.EvaluationModelRequestModelSourceJsonConverter),

            typeof(global::Together.JsonConverters.EvaluationModelRequestModelSourceNullableJsonConverter),

            typeof(global::Together.JsonConverters.EvaluationResponseStatusJsonConverter),

            typeof(global::Together.JsonConverters.EvaluationResponseStatusNullableJsonConverter),

            typeof(global::Together.JsonConverters.EvaluationJobTypeJsonConverter),

            typeof(global::Together.JsonConverters.EvaluationJobTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.EvaluationJobStatusJsonConverter),

            typeof(global::Together.JsonConverters.EvaluationJobStatusNullableJsonConverter),

            typeof(global::Together.JsonConverters.VideoStatusJsonConverter),

            typeof(global::Together.JsonConverters.VideoStatusNullableJsonConverter),

            typeof(global::Together.JsonConverters.VideoFrameImageInputFrameJsonConverter),

            typeof(global::Together.JsonConverters.VideoFrameImageInputFrameNullableJsonConverter),

            typeof(global::Together.JsonConverters.VideoOutputFormatJsonConverter),

            typeof(global::Together.JsonConverters.VideoOutputFormatNullableJsonConverter),

            typeof(global::Together.JsonConverters.CreateDeploymentRequestGpuTypeJsonConverter),

            typeof(global::Together.JsonConverters.CreateDeploymentRequestGpuTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.DeploymentResponseItemGpuTypeJsonConverter),

            typeof(global::Together.JsonConverters.DeploymentResponseItemGpuTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.DeploymentStatusJsonConverter),

            typeof(global::Together.JsonConverters.DeploymentStatusNullableJsonConverter),

            typeof(global::Together.JsonConverters.HTTPAutoscalingConfigMetricJsonConverter),

            typeof(global::Together.JsonConverters.HTTPAutoscalingConfigMetricNullableJsonConverter),

            typeof(global::Together.JsonConverters.QueueAutoscalingConfigMetricJsonConverter),

            typeof(global::Together.JsonConverters.QueueAutoscalingConfigMetricNullableJsonConverter),

            typeof(global::Together.JsonConverters.CustomMetricAutoscalingConfigMetricJsonConverter),

            typeof(global::Together.JsonConverters.CustomMetricAutoscalingConfigMetricNullableJsonConverter),

            typeof(global::Together.JsonConverters.UpdateDeploymentRequestGpuTypeJsonConverter),

            typeof(global::Together.JsonConverters.UpdateDeploymentRequestGpuTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.VolumeContentRequestTypeJsonConverter),

            typeof(global::Together.JsonConverters.VolumeContentRequestTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.VolumeContentTypeJsonConverter),

            typeof(global::Together.JsonConverters.VolumeContentTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.VolumeTypeJsonConverter),

            typeof(global::Together.JsonConverters.VolumeTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.QueueCancelResponseStatusJsonConverter),

            typeof(global::Together.JsonConverters.QueueCancelResponseStatusNullableJsonConverter),

            typeof(global::Together.JsonConverters.QueueJobStatusResponseStatusJsonConverter),

            typeof(global::Together.JsonConverters.QueueJobStatusResponseStatusNullableJsonConverter),

            typeof(global::Together.JsonConverters.CreateImagesGenerationsRequestModelJsonConverter),

            typeof(global::Together.JsonConverters.CreateImagesGenerationsRequestModelNullableJsonConverter),

            typeof(global::Together.JsonConverters.CreateImagesGenerationsRequestResponseFormatJsonConverter),

            typeof(global::Together.JsonConverters.CreateImagesGenerationsRequestResponseFormatNullableJsonConverter),

            typeof(global::Together.JsonConverters.CreateImagesGenerationsRequestOutputFormatJsonConverter),

            typeof(global::Together.JsonConverters.CreateImagesGenerationsRequestOutputFormatNullableJsonConverter),

            typeof(global::Together.JsonConverters.CreateFineTunesRequestBatchSizeJsonConverter),

            typeof(global::Together.JsonConverters.CreateFineTunesRequestBatchSizeNullableJsonConverter),

            typeof(global::Together.JsonConverters.CreateFineTunesRequestTrainOnInputsJsonConverter),

            typeof(global::Together.JsonConverters.CreateFineTunesRequestTrainOnInputsNullableJsonConverter),

            typeof(global::Together.JsonConverters.UpdateEndpointRequestStateJsonConverter),

            typeof(global::Together.JsonConverters.UpdateEndpointRequestStateNullableJsonConverter),

            typeof(global::Together.JsonConverters.GetFinetuneDownloadCheckpointJsonConverter),

            typeof(global::Together.JsonConverters.GetFinetuneDownloadCheckpointNullableJsonConverter),

            typeof(global::Together.JsonConverters.RealtimeTtsModelJsonConverter),

            typeof(global::Together.JsonConverters.RealtimeTtsModelNullableJsonConverter),

            typeof(global::Together.JsonConverters.ListEndpointsTypeJsonConverter),

            typeof(global::Together.JsonConverters.ListEndpointsTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.ListEndpointsUsageTypeJsonConverter),

            typeof(global::Together.JsonConverters.ListEndpointsUsageTypeNullableJsonConverter),

            typeof(global::Together.JsonConverters.RealtimeTranscriptionInputAudioFormatJsonConverter),

            typeof(global::Together.JsonConverters.RealtimeTranscriptionInputAudioFormatNullableJsonConverter),

            typeof(global::Together.JsonConverters.GetEvaluationJobStatusAndResultsResponseStatusJsonConverter),

            typeof(global::Together.JsonConverters.GetEvaluationJobStatusAndResultsResponseStatusNullableJsonConverter),

            typeof(global::Together.JsonConverters.CompletionStreamJsonConverter),

            typeof(global::Together.JsonConverters.ResponseFormatJsonConverter),

            typeof(global::Together.JsonConverters.ChatCompletionMessageParamJsonConverter),

            typeof(global::Together.JsonConverters.ChatCompletionUserMessageContentJsonConverter),

            typeof(global::Together.JsonConverters.ChatCompletionStreamJsonConverter),

            typeof(global::Together.JsonConverters.AudioTranscriptionResponseJsonConverter),

            typeof(global::Together.JsonConverters.AudioTranslationResponseJsonConverter),

            typeof(global::Together.JsonConverters.AudioSpeechStreamResponseJsonConverter),

            typeof(global::Together.JsonConverters.DataItem3JsonConverter),

            typeof(global::Together.JsonConverters.ErrorJsonConverter),

            typeof(global::Together.JsonConverters.ExecuteResponseJsonConverter),

            typeof(global::Together.JsonConverters.OutputsItemJsonConverter),

            typeof(global::Together.JsonConverters.InterpreterOutputJsonConverter),

            typeof(global::Together.JsonConverters.SessionListResponseJsonConverter),

            typeof(global::Together.JsonConverters.EvaluationModelOrStringJsonConverter),

            typeof(global::Together.JsonConverters.OneOfJsonConverter<string, int?>),

            typeof(global::Together.JsonConverters.OneOfJsonConverter<string, int?>),

            typeof(global::Together.JsonConverters.OneOfJsonConverter<string, int?>),

            typeof(global::Together.JsonConverters.AnyOfJsonConverter<global::Together.RerankRequestModel?, string>),

            typeof(global::Together.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<object>, global::System.Collections.Generic.IList<string>>),

            typeof(global::Together.JsonConverters.AnyOfJsonConverter<global::Together.CompletionRequestModel?, string>),

            typeof(global::Together.JsonConverters.AnyOfJsonConverter<global::Together.CompletionRequestSafetyModel?, string>),

            typeof(global::Together.JsonConverters.AllOfJsonConverter<global::Together.UsageData, object>),

            typeof(global::Together.JsonConverters.AllOfJsonConverter<global::Together.FinishReason?, object>),

            typeof(global::Together.JsonConverters.AllOfJsonConverter<object, global::Together.LogprobsPart>),

            typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.ChatCompletionRequestFunctionCallEnum?, global::Together.ChatCompletionRequestFunctionCallEnum2>),

            typeof(global::Together.JsonConverters.OneOfJsonConverter<string, global::Together.ToolChoice2>),

            typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2, global::Together.ChatCompletionUserMessageContentMultimodalItemVideo, global::Together.ChatCompletionUserMessageContentMultimodalItemAudio, global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudio>),

            typeof(global::Together.JsonConverters.AllOfJsonConverter<global::Together.UsageData, object>),

            typeof(global::Together.JsonConverters.AnyOfJsonConverter<global::Together.AudioSpeechRequestModel?, string>),

            typeof(global::Together.JsonConverters.OneOfJsonConverter<byte[], string>),

            typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.AudioTranscriptionRequestTimestampGranularities?, global::System.Collections.Generic.IList<global::Together.AudioTranscriptionRequestTimestampGranularitie>>),

            typeof(global::Together.JsonConverters.OneOfJsonConverter<byte[], string>),

            typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.AudioTranslationRequestTimestampGranularities?, global::System.Collections.Generic.IList<global::Together.AudioTranslationRequestTimestampGranularitie>>),

            typeof(global::Together.JsonConverters.AnyOfJsonConverter<global::Together.EmbeddingsRequestModel?, string>),

            typeof(global::Together.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Together.JsonConverters.OneOfJsonConverter<int?, global::Together.FinetuneResponseBatchSize?>),

            typeof(global::Together.JsonConverters.OneOfJsonConverter<bool?, global::Together.FinetuneResponseTrainOnInputs?>),

            typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.TrainingMethodSFT, global::Together.TrainingMethodDPO>),

            typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.FullTrainingType, global::Together.LoRATrainingType>),

            typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.FullTrainingType, global::Together.LoRATrainingType>),

            typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.TrainingMethodSFT, global::Together.TrainingMethodDPO>),

            typeof(global::Together.JsonConverters.OneOfJsonConverter<bool?, global::Together.TrainingMethodSFTTrainOnInputs?>),

            typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.LinearLRSchedulerArgs, global::Together.CosineLRSchedulerArgs>),

            typeof(global::Together.JsonConverters.OneOfJsonConverter<string, object>),

            typeof(global::Together.JsonConverters.OneOfJsonConverter<string, object>),

            typeof(global::Together.JsonConverters.OneOfJsonConverter<string, object>),

            typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.EvaluationClassifyParameters, global::Together.EvaluationScoreParameters, global::Together.EvaluationCompareParameters>),

            typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.EvaluationClassifyResults, global::Together.EvaluationScoreResults, global::Together.EvaluationCompareResults, global::Together.EvaluationJobResults>),

            typeof(global::Together.JsonConverters.AnyOfJsonConverter<double?, global::Together.VideoFrameImageInputFrame?>),

            typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.HTTPAutoscalingConfig, global::Together.QueueAutoscalingConfig, global::Together.CustomMetricAutoscalingConfig>),

            typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.HTTPAutoscalingConfig, global::Together.QueueAutoscalingConfig, global::Together.CustomMetricAutoscalingConfig>),

            typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.HTTPAutoscalingConfig, global::Together.QueueAutoscalingConfig, global::Together.CustomMetricAutoscalingConfig>),

            typeof(global::Together.JsonConverters.AnyOfJsonConverter<global::Together.CreateImagesGenerationsRequestModel?, string>),

            typeof(global::Together.JsonConverters.OneOfJsonConverter<int?, global::Together.CreateFineTunesRequestBatchSize?>),

            typeof(global::Together.JsonConverters.OneOfJsonConverter<bool?, global::Together.CreateFineTunesRequestTrainOnInputs?>),

            typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.TrainingMethodSFT, global::Together.TrainingMethodDPO>),

            typeof(global::Together.JsonConverters.AnyOfJsonConverter<global::Together.FullTrainingType, global::Together.LoRATrainingType>),

            typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.TrainingMethodSFT, global::Together.TrainingMethodDPO>),

            typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.FullTrainingType, global::Together.LoRATrainingType>),

            typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.EvaluationClassifyResults, global::Together.EvaluationScoreResults, global::Together.EvaluationCompareResults>),

            typeof(global::Together.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlOptimStepBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlAdamWOptimizerParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlSampleBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.RlModelInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlModelInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlSamplingParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlForwardBackwardBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.RlTrainingSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTrainingSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlLossConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.RlInputChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlInputChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlEncodedText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlListMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.OneOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<string, int?>), TypeInfoPropertyName = "OneOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlDType), TypeInfoPropertyName = "RlDType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlLossType), TypeInfoPropertyName = "RlLossType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlCrossEntropyLossParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlGRPOLossParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlGRPOLossAggregationType), TypeInfoPropertyName = "RlGRPOLossAggregationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlLossTargetTokens))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlLossMask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlLossAdvantages))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<float>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlLossLogprobs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlGRPOLossInputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlLossInputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlOptimStepOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTrainingOperationStatus), TypeInfoPropertyName = "RlTrainingOperationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlOptimStepResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTrainingOperationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlSampleOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlSampleResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.RlSampleRollout>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlSampleRollout))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.RlSampleSequence>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlSampleSequence))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlForwardBackwardOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlForwardBackwardResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTrainingOperationErrorCode), TypeInfoPropertyName = "RlTrainingOperationErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlStartTrainingSessionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlLoraConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTrainingSessionStatus), TypeInfoPropertyName = "RlTrainingSessionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTrainingSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.RlInferenceCheckpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlInferenceCheckpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.RlTrainingCheckpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTrainingCheckpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTrainingSessionsListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.RlTrainingSession>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlInferenceCheckpointOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlInferenceCheckpointResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlInferenceCheckpointRegistration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTrainingCheckpointResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlTrainingCheckpointOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlCheckpointVariant), TypeInfoPropertyName = "RlCheckpointVariant2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlCheckpointFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RlCheckpointDownloadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.RlCheckpointFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterControlPlaneNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterCreateRequestClusterType), TypeInfoPropertyName = "GPUClusterCreateRequestClusterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterCreateRequestGpuType), TypeInfoPropertyName = "GPUClusterCreateRequestGpuType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterCreateRequestDriverVersion), TypeInfoPropertyName = "GPUClusterCreateRequestDriverVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClustersSharedVolumeCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterCreateRequestBillingType), TypeInfoPropertyName = "GPUClusterCreateRequestBillingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterGPUWorkerNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterInfoClusterType), TypeInfoPropertyName = "GPUClusterInfoClusterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterInfoGpuType), TypeInfoPropertyName = "GPUClusterInfoGpuType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterInfoDriverVersion), TypeInfoPropertyName = "GPUClusterInfoDriverVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.GPUClusterVolume>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterVolume))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterInfoStatus), TypeInfoPropertyName = "GPUClusterInfoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.GPUClusterControlPlaneNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.GPUClusterGPUWorkerNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterUpdateRequestClusterType), TypeInfoPropertyName = "GPUClusterUpdateRequestClusterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.GPUClusterInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.InstanceTypesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.InstanceTypesResponseType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.InstanceTypesResponseType), TypeInfoPropertyName = "InstanceTypesResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RegionListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.RegionListResponseRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RegionListResponseRegion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClustersSharedVolumeDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClustersSharedVolume))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClustersSharedVolumeStatus), TypeInfoPropertyName = "GPUClustersSharedVolumeStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClustersSharedVolumeUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClustersSharedVolumes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.GPUClustersSharedVolume>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, float>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionRequestFunctionCallEnum), TypeInfoPropertyName = "ChatCompletionRequestFunctionCallEnum3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionRequestFunctionCallEnum2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ResponseFormat), TypeInfoPropertyName = "ResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ResponseFormatText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ResponseFormatJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ResponseFormatJsonObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ChatCompletionRequestResponseFormatDiscriminator))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.OneOf<global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2, global::Together.ChatCompletionUserMessageContentMultimodalItemVideo, global::Together.ChatCompletionUserMessageContentMultimodalItemAudio, global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudio>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2, global::Together.ChatCompletionUserMessageContentMultimodalItemVideo, global::Together.ChatCompletionUserMessageContentMultimodalItemAudio, global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudio>), TypeInfoPropertyName = "OneOfChatCompletionUserMessageContentMultimodalItemVariant1ChatCompletionUserMessageContentMultimodalItemVariant2ChatCompletionUserMessageContentMultimodalItemVideoChatCompletionUserMessageContentMultimodalItemAudioChatCompletionUserMessageContentMultimodalItemInputAudio2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioSpeechRequestLanguage), TypeInfoPropertyName = "AudioSpeechRequestLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioSpeechRequestResponseEncoding), TypeInfoPropertyName = "AudioSpeechRequestResponseEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranscriptionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<byte[], string>), TypeInfoPropertyName = "OneOfByteArrayString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranscriptionRequestModel), TypeInfoPropertyName = "AudioTranscriptionRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranscriptionRequestResponseFormat), TypeInfoPropertyName = "AudioTranscriptionRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.AudioTranscriptionRequestTimestampGranularities?, global::System.Collections.Generic.IList<global::Together.AudioTranscriptionRequestTimestampGranularitie>>), TypeInfoPropertyName = "OneOfAudioTranscriptionRequestTimestampGranularitiesIListAudioTranscriptionRequestTimestampGranularitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranscriptionRequestTimestampGranularities), TypeInfoPropertyName = "AudioTranscriptionRequestTimestampGranularities2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.AudioTranscriptionRequestTimestampGranularitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranscriptionRequestTimestampGranularitie), TypeInfoPropertyName = "AudioTranscriptionRequestTimestampGranularitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranscriptionResponse), TypeInfoPropertyName = "AudioTranscriptionResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranscriptionJsonResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranscriptionVerboseJsonResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranscriptionVerboseJsonResponseTask), TypeInfoPropertyName = "AudioTranscriptionVerboseJsonResponseTask2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AudioTranslationVerboseJsonResponseTask), TypeInfoPropertyName = "AudioTranslationVerboseJsonResponseTask2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DataItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DataItem3), TypeInfoPropertyName = "DataItem32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ImageResponseDataB64))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ImageResponseDataUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ImageResponseDataItemDiscriminator))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FineTuneModelLimits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FineTuneModelLimitsFullTraining))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FineTuneModelLimitsLoraTraining))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FinetuneEventLevels), TypeInfoPropertyName = "FinetuneEventLevels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FinetuneEventType), TypeInfoPropertyName = "FinetuneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FinetuneTruncatedList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.FinetuneResponseTruncated>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FinetuneListEvents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FinetuneListCheckpoints))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.FineTuneCheckpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FineTuneCheckpoint))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationJudgeModelConfigModelSource), TypeInfoPropertyName = "EvaluationJudgeModelConfigModelSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.EvaluationModelRequest))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.VideoFrameImageInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.VideoFrameImageInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.VideoStatus), TypeInfoPropertyName = "VideoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AnyOf<double?, global::Together.VideoFrameImageInputFrame?>), TypeInfoPropertyName = "AnyOfDoubleVideoFrameImageInputFrame2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.VideoFrameImageInputFrame), TypeInfoPropertyName = "VideoFrameImageInputFrame2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.VideoJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.VideoJobError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.VideoJobOutputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ContainerStatus))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.QueueJobRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.QueueJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.QueueJobStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.QueueJobStatusResponseStatus), TypeInfoPropertyName = "QueueJobStatusResponseStatus2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GetFinetuneDownloadCheckpoint), TypeInfoPropertyName = "GetFinetuneDownloadCheckpoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RealtimeTtsModel), TypeInfoPropertyName = "RealtimeTtsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ListEndpointsType), TypeInfoPropertyName = "ListEndpointsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ListEndpointsUsageType), TypeInfoPropertyName = "ListEndpointsUsageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RealtimeTranscriptionInputAudioFormat), TypeInfoPropertyName = "RealtimeTranscriptionInputAudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateFineTunesEstimatePriceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GetFineTunesModelsSupportedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GetFineTunesModelsLimitsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GPUClusterServiceDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ListEndpointsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.ListEndpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ListHardwareResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.HardwareWithStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.BatchJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.EvaluationJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GetModelListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GetEvaluationJobStatusAndResultsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GetEvaluationJobStatusAndResultsResponseStatus), TypeInfoPropertyName = "GetEvaluationJobStatusAndResultsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.EvaluationClassifyResults, global::Together.EvaluationScoreResults, global::Together.EvaluationCompareResults>), TypeInfoPropertyName = "OneOfEvaluationClassifyResultsEvaluationScoreResultsEvaluationCompareResults2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RlModelInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RlTrainingSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RlInputChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.OneOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<float>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RlSampleRollout>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RlSampleSequence>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RlInferenceCheckpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RlTrainingCheckpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RlTrainingSession>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RlCheckpointFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.GPUClusterVolume>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.GPUClusterControlPlaneNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.GPUClusterGPUWorkerNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.GPUClusterInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.InstanceTypesResponseType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RegionListResponseRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.GPUClustersSharedVolume>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.ModelVoices>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.ModelVoicesVoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::System.Collections.Generic.List<object>, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.RerankResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.PromptPartItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.CompletionChoicesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.CompletionChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.ToolChoice2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.ChatCompletionChoicesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.ChatCompletionMessageParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.ToolsPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.OneOf<global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2, global::Together.ChatCompletionUserMessageContentMultimodalItemVideo, global::Together.ChatCompletionUserMessageContentMultimodalItemAudio, global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudio>>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DataItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.JobInfoSuccessResponseStatusUpdate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.JobInfoSuccessResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.FileResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.FineTuneEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.FinetuneResponseTruncated>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.FineTuneCheckpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.ExecuteRequestFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.OutputsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.OneOf<string, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.SessionListResponseVariant2DataSession>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.EvaluationJobStatusUpdate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.VideoFrameImageInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.EnvironmentVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.VolumeMount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeploymentResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.SecretResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.VolumeResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.FileInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.CreateImagesGenerationsRequestImageLora>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.ListEndpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.HardwareWithStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.BatchJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.EvaluationJob>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}