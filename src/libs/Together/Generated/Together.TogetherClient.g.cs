
#nullable enable

namespace Together
{
    /// <summary>
    /// The Together REST API. Please see https://docs.together.ai for more details.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class TogetherClient : global::Together.ITogetherClient, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api.together.xyz/v1";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::Together.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif
        /// <summary>
        /// 
        /// </summary>
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::Together.JsonConverters.RlDTypeJsonConverter(),
                    new global::Together.JsonConverters.RlDTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.RlLossTypeJsonConverter(),
                    new global::Together.JsonConverters.RlLossTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.RlGRPOLossAggregationTypeJsonConverter(),
                    new global::Together.JsonConverters.RlGRPOLossAggregationTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.RlTrainingOperationErrorCodeJsonConverter(),
                    new global::Together.JsonConverters.RlTrainingOperationErrorCodeNullableJsonConverter(),
                    new global::Together.JsonConverters.RlTrainingOperationStatusJsonConverter(),
                    new global::Together.JsonConverters.RlTrainingOperationStatusNullableJsonConverter(),
                    new global::Together.JsonConverters.RlTrainingSessionStatusJsonConverter(),
                    new global::Together.JsonConverters.RlTrainingSessionStatusNullableJsonConverter(),
                    new global::Together.JsonConverters.RlCheckpointVariantJsonConverter(),
                    new global::Together.JsonConverters.RlCheckpointVariantNullableJsonConverter(),
                    new global::Together.JsonConverters.GPUClusterCreateRequestClusterTypeJsonConverter(),
                    new global::Together.JsonConverters.GPUClusterCreateRequestClusterTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.GPUClusterCreateRequestGpuTypeJsonConverter(),
                    new global::Together.JsonConverters.GPUClusterCreateRequestGpuTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.GPUClusterCreateRequestDriverVersionJsonConverter(),
                    new global::Together.JsonConverters.GPUClusterCreateRequestDriverVersionNullableJsonConverter(),
                    new global::Together.JsonConverters.GPUClusterCreateRequestBillingTypeJsonConverter(),
                    new global::Together.JsonConverters.GPUClusterCreateRequestBillingTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.GPUClusterInfoClusterTypeJsonConverter(),
                    new global::Together.JsonConverters.GPUClusterInfoClusterTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.GPUClusterInfoGpuTypeJsonConverter(),
                    new global::Together.JsonConverters.GPUClusterInfoGpuTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.GPUClusterInfoDriverVersionJsonConverter(),
                    new global::Together.JsonConverters.GPUClusterInfoDriverVersionNullableJsonConverter(),
                    new global::Together.JsonConverters.GPUClusterInfoStatusJsonConverter(),
                    new global::Together.JsonConverters.GPUClusterInfoStatusNullableJsonConverter(),
                    new global::Together.JsonConverters.GPUClusterUpdateRequestClusterTypeJsonConverter(),
                    new global::Together.JsonConverters.GPUClusterUpdateRequestClusterTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.InstanceTypesResponseTypeJsonConverter(),
                    new global::Together.JsonConverters.InstanceTypesResponseTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.GPUClustersSharedVolumeStatusJsonConverter(),
                    new global::Together.JsonConverters.GPUClustersSharedVolumeStatusNullableJsonConverter(),
                    new global::Together.JsonConverters.RerankRequestModelJsonConverter(),
                    new global::Together.JsonConverters.RerankRequestModelNullableJsonConverter(),
                    new global::Together.JsonConverters.FinishReasonJsonConverter(),
                    new global::Together.JsonConverters.FinishReasonNullableJsonConverter(),
                    new global::Together.JsonConverters.CompletionRequestModelJsonConverter(),
                    new global::Together.JsonConverters.CompletionRequestModelNullableJsonConverter(),
                    new global::Together.JsonConverters.CompletionRequestSafetyModelJsonConverter(),
                    new global::Together.JsonConverters.CompletionRequestSafetyModelNullableJsonConverter(),
                    new global::Together.JsonConverters.CompletionChoiceDeltaRoleJsonConverter(),
                    new global::Together.JsonConverters.CompletionChoiceDeltaRoleNullableJsonConverter(),
                    new global::Together.JsonConverters.ChatCompletionMessageRoleJsonConverter(),
                    new global::Together.JsonConverters.ChatCompletionMessageRoleNullableJsonConverter(),
                    new global::Together.JsonConverters.ChatCompletionToolTypeJsonConverter(),
                    new global::Together.JsonConverters.ChatCompletionToolTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.ChatCompletionRequestContextLengthExceededBehaviorJsonConverter(),
                    new global::Together.JsonConverters.ChatCompletionRequestContextLengthExceededBehaviorNullableJsonConverter(),
                    new global::Together.JsonConverters.ChatCompletionRequestFunctionCallEnumJsonConverter(),
                    new global::Together.JsonConverters.ChatCompletionRequestFunctionCallEnumNullableJsonConverter(),
                    new global::Together.JsonConverters.ChatCompletionRequestReasoningEffortJsonConverter(),
                    new global::Together.JsonConverters.ChatCompletionRequestReasoningEffortNullableJsonConverter(),
                    new global::Together.JsonConverters.ResponseFormatTextTypeJsonConverter(),
                    new global::Together.JsonConverters.ResponseFormatTextTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.ResponseFormatJsonObjectTypeJsonConverter(),
                    new global::Together.JsonConverters.ResponseFormatJsonObjectTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.ResponseFormatJsonSchemaTypeJsonConverter(),
                    new global::Together.JsonConverters.ResponseFormatJsonSchemaTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.ChatCompletionSystemMessageParamRoleJsonConverter(),
                    new global::Together.JsonConverters.ChatCompletionSystemMessageParamRoleNullableJsonConverter(),
                    new global::Together.JsonConverters.ChatCompletionUserMessageParamRoleJsonConverter(),
                    new global::Together.JsonConverters.ChatCompletionUserMessageParamRoleNullableJsonConverter(),
                    new global::Together.JsonConverters.ChatCompletionUserMessageContentMultimodalItemVariant1TypeJsonConverter(),
                    new global::Together.JsonConverters.ChatCompletionUserMessageContentMultimodalItemVariant1TypeNullableJsonConverter(),
                    new global::Together.JsonConverters.ChatCompletionUserMessageContentMultimodalItemVariant2TypeJsonConverter(),
                    new global::Together.JsonConverters.ChatCompletionUserMessageContentMultimodalItemVariant2TypeNullableJsonConverter(),
                    new global::Together.JsonConverters.ChatCompletionUserMessageContentMultimodalItemVideoTypeJsonConverter(),
                    new global::Together.JsonConverters.ChatCompletionUserMessageContentMultimodalItemVideoTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.ChatCompletionUserMessageContentMultimodalItemAudioTypeJsonConverter(),
                    new global::Together.JsonConverters.ChatCompletionUserMessageContentMultimodalItemAudioTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.ChatCompletionUserMessageContentMultimodalItemInputAudioTypeJsonConverter(),
                    new global::Together.JsonConverters.ChatCompletionUserMessageContentMultimodalItemInputAudioTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.ChatCompletionUserMessageContentMultimodalItemInputAudioInputAudioFormatJsonConverter(),
                    new global::Together.JsonConverters.ChatCompletionUserMessageContentMultimodalItemInputAudioInputAudioFormatNullableJsonConverter(),
                    new global::Together.JsonConverters.ChatCompletionAssistantMessageParamRoleJsonConverter(),
                    new global::Together.JsonConverters.ChatCompletionAssistantMessageParamRoleNullableJsonConverter(),
                    new global::Together.JsonConverters.ChatCompletionFunctionMessageParamRoleJsonConverter(),
                    new global::Together.JsonConverters.ChatCompletionFunctionMessageParamRoleNullableJsonConverter(),
                    new global::Together.JsonConverters.ChatCompletionToolMessageParamRoleJsonConverter(),
                    new global::Together.JsonConverters.ChatCompletionToolMessageParamRoleNullableJsonConverter(),
                    new global::Together.JsonConverters.ChatCompletionChunkChoiceDeltaRoleJsonConverter(),
                    new global::Together.JsonConverters.ChatCompletionChunkChoiceDeltaRoleNullableJsonConverter(),
                    new global::Together.JsonConverters.AudioSpeechRequestModelJsonConverter(),
                    new global::Together.JsonConverters.AudioSpeechRequestModelNullableJsonConverter(),
                    new global::Together.JsonConverters.AudioSpeechRequestResponseFormatJsonConverter(),
                    new global::Together.JsonConverters.AudioSpeechRequestResponseFormatNullableJsonConverter(),
                    new global::Together.JsonConverters.AudioSpeechRequestLanguageJsonConverter(),
                    new global::Together.JsonConverters.AudioSpeechRequestLanguageNullableJsonConverter(),
                    new global::Together.JsonConverters.AudioSpeechRequestResponseEncodingJsonConverter(),
                    new global::Together.JsonConverters.AudioSpeechRequestResponseEncodingNullableJsonConverter(),
                    new global::Together.JsonConverters.AudioTranscriptionRequestModelJsonConverter(),
                    new global::Together.JsonConverters.AudioTranscriptionRequestModelNullableJsonConverter(),
                    new global::Together.JsonConverters.AudioTranscriptionRequestResponseFormatJsonConverter(),
                    new global::Together.JsonConverters.AudioTranscriptionRequestResponseFormatNullableJsonConverter(),
                    new global::Together.JsonConverters.AudioTranscriptionRequestTimestampGranularitiesJsonConverter(),
                    new global::Together.JsonConverters.AudioTranscriptionRequestTimestampGranularitiesNullableJsonConverter(),
                    new global::Together.JsonConverters.AudioTranscriptionRequestTimestampGranularitieJsonConverter(),
                    new global::Together.JsonConverters.AudioTranscriptionRequestTimestampGranularitieNullableJsonConverter(),
                    new global::Together.JsonConverters.AudioTranscriptionVerboseJsonResponseTaskJsonConverter(),
                    new global::Together.JsonConverters.AudioTranscriptionVerboseJsonResponseTaskNullableJsonConverter(),
                    new global::Together.JsonConverters.AudioTranslationRequestModelJsonConverter(),
                    new global::Together.JsonConverters.AudioTranslationRequestModelNullableJsonConverter(),
                    new global::Together.JsonConverters.AudioTranslationRequestResponseFormatJsonConverter(),
                    new global::Together.JsonConverters.AudioTranslationRequestResponseFormatNullableJsonConverter(),
                    new global::Together.JsonConverters.AudioTranslationRequestTimestampGranularitiesJsonConverter(),
                    new global::Together.JsonConverters.AudioTranslationRequestTimestampGranularitiesNullableJsonConverter(),
                    new global::Together.JsonConverters.AudioTranslationRequestTimestampGranularitieJsonConverter(),
                    new global::Together.JsonConverters.AudioTranslationRequestTimestampGranularitieNullableJsonConverter(),
                    new global::Together.JsonConverters.AudioTranslationVerboseJsonResponseTaskJsonConverter(),
                    new global::Together.JsonConverters.AudioTranslationVerboseJsonResponseTaskNullableJsonConverter(),
                    new global::Together.JsonConverters.StreamSentinelDataJsonConverter(),
                    new global::Together.JsonConverters.StreamSentinelDataNullableJsonConverter(),
                    new global::Together.JsonConverters.ChatCompletionChoiceDeltaRoleJsonConverter(),
                    new global::Together.JsonConverters.ChatCompletionChoiceDeltaRoleNullableJsonConverter(),
                    new global::Together.JsonConverters.EmbeddingsRequestModelJsonConverter(),
                    new global::Together.JsonConverters.EmbeddingsRequestModelNullableJsonConverter(),
                    new global::Together.JsonConverters.ModelInfoTypeJsonConverter(),
                    new global::Together.JsonConverters.ModelInfoTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.ModelUploadRequestModelTypeJsonConverter(),
                    new global::Together.JsonConverters.ModelUploadRequestModelTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.ImageResponseDataB64TypeJsonConverter(),
                    new global::Together.JsonConverters.ImageResponseDataB64TypeNullableJsonConverter(),
                    new global::Together.JsonConverters.ImageResponseDataUrlTypeJsonConverter(),
                    new global::Together.JsonConverters.ImageResponseDataUrlTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.JobInfoSuccessResponseStatusJsonConverter(),
                    new global::Together.JsonConverters.JobInfoSuccessResponseStatusNullableJsonConverter(),
                    new global::Together.JsonConverters.ToolChoiceTypeJsonConverter(),
                    new global::Together.JsonConverters.ToolChoiceTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.FilePurposeJsonConverter(),
                    new global::Together.JsonConverters.FilePurposeNullableJsonConverter(),
                    new global::Together.JsonConverters.FileTypeJsonConverter(),
                    new global::Together.JsonConverters.FileTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.FinetuneResponseBatchSizeJsonConverter(),
                    new global::Together.JsonConverters.FinetuneResponseBatchSizeNullableJsonConverter(),
                    new global::Together.JsonConverters.FinetuneResponseTrainOnInputsJsonConverter(),
                    new global::Together.JsonConverters.FinetuneResponseTrainOnInputsNullableJsonConverter(),
                    new global::Together.JsonConverters.FinetuneJobStatusJsonConverter(),
                    new global::Together.JsonConverters.FinetuneJobStatusNullableJsonConverter(),
                    new global::Together.JsonConverters.FinetuneEventLevelsJsonConverter(),
                    new global::Together.JsonConverters.FinetuneEventLevelsNullableJsonConverter(),
                    new global::Together.JsonConverters.FinetuneEventTypeJsonConverter(),
                    new global::Together.JsonConverters.FinetuneEventTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.FullTrainingTypeTypeJsonConverter(),
                    new global::Together.JsonConverters.FullTrainingTypeTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.LoRATrainingTypeTypeJsonConverter(),
                    new global::Together.JsonConverters.LoRATrainingTypeTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.TrainingMethodSFTMethodJsonConverter(),
                    new global::Together.JsonConverters.TrainingMethodSFTMethodNullableJsonConverter(),
                    new global::Together.JsonConverters.TrainingMethodSFTTrainOnInputsJsonConverter(),
                    new global::Together.JsonConverters.TrainingMethodSFTTrainOnInputsNullableJsonConverter(),
                    new global::Together.JsonConverters.TrainingMethodDPOMethodJsonConverter(),
                    new global::Together.JsonConverters.TrainingMethodDPOMethodNullableJsonConverter(),
                    new global::Together.JsonConverters.LRSchedulerLrSchedulerTypeJsonConverter(),
                    new global::Together.JsonConverters.LRSchedulerLrSchedulerTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.HardwareAvailabilityStatusJsonConverter(),
                    new global::Together.JsonConverters.HardwareAvailabilityStatusNullableJsonConverter(),
                    new global::Together.JsonConverters.CreateEndpointRequestStateJsonConverter(),
                    new global::Together.JsonConverters.CreateEndpointRequestStateNullableJsonConverter(),
                    new global::Together.JsonConverters.DedicatedEndpointTypeJsonConverter(),
                    new global::Together.JsonConverters.DedicatedEndpointTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.DedicatedEndpointStateJsonConverter(),
                    new global::Together.JsonConverters.DedicatedEndpointStateNullableJsonConverter(),
                    new global::Together.JsonConverters.ListEndpointTypeJsonConverter(),
                    new global::Together.JsonConverters.ListEndpointTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.ListEndpointStateJsonConverter(),
                    new global::Together.JsonConverters.ListEndpointStateNullableJsonConverter(),
                    new global::Together.JsonConverters.DisplayorExecuteOutputTypeJsonConverter(),
                    new global::Together.JsonConverters.DisplayorExecuteOutputTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.ErrorOutputTypeJsonConverter(),
                    new global::Together.JsonConverters.ErrorOutputTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.ExecuteRequestFileEncodingJsonConverter(),
                    new global::Together.JsonConverters.ExecuteRequestFileEncodingNullableJsonConverter(),
                    new global::Together.JsonConverters.ExecuteRequestLanguageJsonConverter(),
                    new global::Together.JsonConverters.ExecuteRequestLanguageNullableJsonConverter(),
                    new global::Together.JsonConverters.ExecuteResponseSuccessfulExecutionDataOutputStreamOutputTypeJsonConverter(),
                    new global::Together.JsonConverters.ExecuteResponseSuccessfulExecutionDataOutputStreamOutputTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.ExecuteResponseSuccessfulExecutionDataOutputErrorOutputTypeJsonConverter(),
                    new global::Together.JsonConverters.ExecuteResponseSuccessfulExecutionDataOutputErrorOutputTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutputTypeJsonConverter(),
                    new global::Together.JsonConverters.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutputTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.ExecuteResponseSuccessfulExecutionDataStatusJsonConverter(),
                    new global::Together.JsonConverters.ExecuteResponseSuccessfulExecutionDataStatusNullableJsonConverter(),
                    new global::Together.JsonConverters.InterpreterOutputStreamOutputTypeJsonConverter(),
                    new global::Together.JsonConverters.InterpreterOutputStreamOutputTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.InterpreterOutputErrorOutputTypeJsonConverter(),
                    new global::Together.JsonConverters.InterpreterOutputErrorOutputTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.InterpreterOutputDisplayorExecuteOutputTypeJsonConverter(),
                    new global::Together.JsonConverters.InterpreterOutputDisplayorExecuteOutputTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.StreamOutputTypeJsonConverter(),
                    new global::Together.JsonConverters.StreamOutputTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.BatchJobStatusJsonConverter(),
                    new global::Together.JsonConverters.BatchJobStatusNullableJsonConverter(),
                    new global::Together.JsonConverters.EvaluationTypedRequestTypeJsonConverter(),
                    new global::Together.JsonConverters.EvaluationTypedRequestTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.EvaluationJudgeModelConfigModelSourceJsonConverter(),
                    new global::Together.JsonConverters.EvaluationJudgeModelConfigModelSourceNullableJsonConverter(),
                    new global::Together.JsonConverters.EvaluationModelRequestModelSourceJsonConverter(),
                    new global::Together.JsonConverters.EvaluationModelRequestModelSourceNullableJsonConverter(),
                    new global::Together.JsonConverters.EvaluationResponseStatusJsonConverter(),
                    new global::Together.JsonConverters.EvaluationResponseStatusNullableJsonConverter(),
                    new global::Together.JsonConverters.EvaluationJobTypeJsonConverter(),
                    new global::Together.JsonConverters.EvaluationJobTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.EvaluationJobStatusJsonConverter(),
                    new global::Together.JsonConverters.EvaluationJobStatusNullableJsonConverter(),
                    new global::Together.JsonConverters.VideoStatusJsonConverter(),
                    new global::Together.JsonConverters.VideoStatusNullableJsonConverter(),
                    new global::Together.JsonConverters.VideoFrameImageInputFrameJsonConverter(),
                    new global::Together.JsonConverters.VideoFrameImageInputFrameNullableJsonConverter(),
                    new global::Together.JsonConverters.VideoOutputFormatJsonConverter(),
                    new global::Together.JsonConverters.VideoOutputFormatNullableJsonConverter(),
                    new global::Together.JsonConverters.CreateDeploymentRequestGpuTypeJsonConverter(),
                    new global::Together.JsonConverters.CreateDeploymentRequestGpuTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.DeploymentResponseItemGpuTypeJsonConverter(),
                    new global::Together.JsonConverters.DeploymentResponseItemGpuTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.DeploymentStatusJsonConverter(),
                    new global::Together.JsonConverters.DeploymentStatusNullableJsonConverter(),
                    new global::Together.JsonConverters.HTTPAutoscalingConfigMetricJsonConverter(),
                    new global::Together.JsonConverters.HTTPAutoscalingConfigMetricNullableJsonConverter(),
                    new global::Together.JsonConverters.QueueAutoscalingConfigMetricJsonConverter(),
                    new global::Together.JsonConverters.QueueAutoscalingConfigMetricNullableJsonConverter(),
                    new global::Together.JsonConverters.CustomMetricAutoscalingConfigMetricJsonConverter(),
                    new global::Together.JsonConverters.CustomMetricAutoscalingConfigMetricNullableJsonConverter(),
                    new global::Together.JsonConverters.UpdateDeploymentRequestGpuTypeJsonConverter(),
                    new global::Together.JsonConverters.UpdateDeploymentRequestGpuTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.VolumeContentRequestTypeJsonConverter(),
                    new global::Together.JsonConverters.VolumeContentRequestTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.VolumeContentTypeJsonConverter(),
                    new global::Together.JsonConverters.VolumeContentTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.VolumeTypeJsonConverter(),
                    new global::Together.JsonConverters.VolumeTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.QueueCancelResponseStatusJsonConverter(),
                    new global::Together.JsonConverters.QueueCancelResponseStatusNullableJsonConverter(),
                    new global::Together.JsonConverters.QueueJobStatusResponseStatusJsonConverter(),
                    new global::Together.JsonConverters.QueueJobStatusResponseStatusNullableJsonConverter(),
                    new global::Together.JsonConverters.CreateImagesGenerationsRequestModelJsonConverter(),
                    new global::Together.JsonConverters.CreateImagesGenerationsRequestModelNullableJsonConverter(),
                    new global::Together.JsonConverters.CreateImagesGenerationsRequestResponseFormatJsonConverter(),
                    new global::Together.JsonConverters.CreateImagesGenerationsRequestResponseFormatNullableJsonConverter(),
                    new global::Together.JsonConverters.CreateImagesGenerationsRequestOutputFormatJsonConverter(),
                    new global::Together.JsonConverters.CreateImagesGenerationsRequestOutputFormatNullableJsonConverter(),
                    new global::Together.JsonConverters.CreateFineTunesRequestBatchSizeJsonConverter(),
                    new global::Together.JsonConverters.CreateFineTunesRequestBatchSizeNullableJsonConverter(),
                    new global::Together.JsonConverters.CreateFineTunesRequestTrainOnInputsJsonConverter(),
                    new global::Together.JsonConverters.CreateFineTunesRequestTrainOnInputsNullableJsonConverter(),
                    new global::Together.JsonConverters.UpdateEndpointRequestStateJsonConverter(),
                    new global::Together.JsonConverters.UpdateEndpointRequestStateNullableJsonConverter(),
                    new global::Together.JsonConverters.GetFinetuneDownloadCheckpointJsonConverter(),
                    new global::Together.JsonConverters.GetFinetuneDownloadCheckpointNullableJsonConverter(),
                    new global::Together.JsonConverters.RealtimeTtsModelJsonConverter(),
                    new global::Together.JsonConverters.RealtimeTtsModelNullableJsonConverter(),
                    new global::Together.JsonConverters.ListEndpointsTypeJsonConverter(),
                    new global::Together.JsonConverters.ListEndpointsTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.ListEndpointsUsageTypeJsonConverter(),
                    new global::Together.JsonConverters.ListEndpointsUsageTypeNullableJsonConverter(),
                    new global::Together.JsonConverters.RealtimeTranscriptionInputAudioFormatJsonConverter(),
                    new global::Together.JsonConverters.RealtimeTranscriptionInputAudioFormatNullableJsonConverter(),
                    new global::Together.JsonConverters.GetEvaluationJobStatusAndResultsResponseStatusJsonConverter(),
                    new global::Together.JsonConverters.GetEvaluationJobStatusAndResultsResponseStatusNullableJsonConverter(),
                    new global::Together.JsonConverters.CompletionStreamJsonConverter(),
                    new global::Together.JsonConverters.ResponseFormatJsonConverter(),
                    new global::Together.JsonConverters.ChatCompletionMessageParamJsonConverter(),
                    new global::Together.JsonConverters.ChatCompletionUserMessageContentJsonConverter(),
                    new global::Together.JsonConverters.ChatCompletionStreamJsonConverter(),
                    new global::Together.JsonConverters.AudioTranscriptionResponseJsonConverter(),
                    new global::Together.JsonConverters.AudioTranslationResponseJsonConverter(),
                    new global::Together.JsonConverters.AudioSpeechStreamResponseJsonConverter(),
                    new global::Together.JsonConverters.DataItem3JsonConverter(),
                    new global::Together.JsonConverters.ErrorJsonConverter(),
                    new global::Together.JsonConverters.ExecuteResponseJsonConverter(),
                    new global::Together.JsonConverters.OutputsItemJsonConverter(),
                    new global::Together.JsonConverters.InterpreterOutputJsonConverter(),
                    new global::Together.JsonConverters.SessionListResponseJsonConverter(),
                    new global::Together.JsonConverters.EvaluationModelOrStringJsonConverter(),
                    new global::Together.JsonConverters.OneOfJsonConverter<string, int?>(),
                    new global::Together.JsonConverters.OneOfJsonConverter<string, int?>(),
                    new global::Together.JsonConverters.OneOfJsonConverter<string, int?>(),
                    new global::Together.JsonConverters.AnyOfJsonConverter<global::Together.RerankRequestModel?, string>(),
                    new global::Together.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<object>, global::System.Collections.Generic.IList<string>>(),
                    new global::Together.JsonConverters.AnyOfJsonConverter<global::Together.CompletionRequestModel?, string>(),
                    new global::Together.JsonConverters.AnyOfJsonConverter<global::Together.CompletionRequestSafetyModel?, string>(),
                    new global::Together.JsonConverters.AllOfJsonConverter<global::Together.UsageData, object>(),
                    new global::Together.JsonConverters.AllOfJsonConverter<global::Together.FinishReason?, object>(),
                    new global::Together.JsonConverters.AllOfJsonConverter<object, global::Together.LogprobsPart>(),
                    new global::Together.JsonConverters.OneOfJsonConverter<global::Together.ChatCompletionRequestFunctionCallEnum?, global::Together.ChatCompletionRequestFunctionCallEnum2>(),
                    new global::Together.JsonConverters.OneOfJsonConverter<string, global::Together.ToolChoice2>(),
                    new global::Together.JsonConverters.OneOfJsonConverter<global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2, global::Together.ChatCompletionUserMessageContentMultimodalItemVideo, global::Together.ChatCompletionUserMessageContentMultimodalItemAudio, global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudio>(),
                    new global::Together.JsonConverters.AllOfJsonConverter<global::Together.UsageData, object>(),
                    new global::Together.JsonConverters.AnyOfJsonConverter<global::Together.AudioSpeechRequestModel?, string>(),
                    new global::Together.JsonConverters.OneOfJsonConverter<byte[], string>(),
                    new global::Together.JsonConverters.OneOfJsonConverter<global::Together.AudioTranscriptionRequestTimestampGranularities?, global::System.Collections.Generic.IList<global::Together.AudioTranscriptionRequestTimestampGranularitie>>(),
                    new global::Together.JsonConverters.OneOfJsonConverter<byte[], string>(),
                    new global::Together.JsonConverters.OneOfJsonConverter<global::Together.AudioTranslationRequestTimestampGranularities?, global::System.Collections.Generic.IList<global::Together.AudioTranslationRequestTimestampGranularitie>>(),
                    new global::Together.JsonConverters.AnyOfJsonConverter<global::Together.EmbeddingsRequestModel?, string>(),
                    new global::Together.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Together.JsonConverters.OneOfJsonConverter<int?, global::Together.FinetuneResponseBatchSize?>(),
                    new global::Together.JsonConverters.OneOfJsonConverter<bool?, global::Together.FinetuneResponseTrainOnInputs?>(),
                    new global::Together.JsonConverters.OneOfJsonConverter<global::Together.TrainingMethodSFT, global::Together.TrainingMethodDPO>(),
                    new global::Together.JsonConverters.OneOfJsonConverter<global::Together.FullTrainingType, global::Together.LoRATrainingType>(),
                    new global::Together.JsonConverters.OneOfJsonConverter<global::Together.FullTrainingType, global::Together.LoRATrainingType>(),
                    new global::Together.JsonConverters.OneOfJsonConverter<global::Together.TrainingMethodSFT, global::Together.TrainingMethodDPO>(),
                    new global::Together.JsonConverters.OneOfJsonConverter<bool?, global::Together.TrainingMethodSFTTrainOnInputs?>(),
                    new global::Together.JsonConverters.OneOfJsonConverter<global::Together.LinearLRSchedulerArgs, global::Together.CosineLRSchedulerArgs>(),
                    new global::Together.JsonConverters.OneOfJsonConverter<string, object>(),
                    new global::Together.JsonConverters.OneOfJsonConverter<string, object>(),
                    new global::Together.JsonConverters.OneOfJsonConverter<string, object>(),
                    new global::Together.JsonConverters.OneOfJsonConverter<global::Together.EvaluationClassifyParameters, global::Together.EvaluationScoreParameters, global::Together.EvaluationCompareParameters>(),
                    new global::Together.JsonConverters.OneOfJsonConverter<global::Together.EvaluationClassifyResults, global::Together.EvaluationScoreResults, global::Together.EvaluationCompareResults, global::Together.EvaluationJobResults>(),
                    new global::Together.JsonConverters.AnyOfJsonConverter<double?, global::Together.VideoFrameImageInputFrame?>(),
                    new global::Together.JsonConverters.OneOfJsonConverter<global::Together.HTTPAutoscalingConfig, global::Together.QueueAutoscalingConfig, global::Together.CustomMetricAutoscalingConfig>(),
                    new global::Together.JsonConverters.OneOfJsonConverter<global::Together.HTTPAutoscalingConfig, global::Together.QueueAutoscalingConfig, global::Together.CustomMetricAutoscalingConfig>(),
                    new global::Together.JsonConverters.OneOfJsonConverter<global::Together.HTTPAutoscalingConfig, global::Together.QueueAutoscalingConfig, global::Together.CustomMetricAutoscalingConfig>(),
                    new global::Together.JsonConverters.AnyOfJsonConverter<global::Together.CreateImagesGenerationsRequestModel?, string>(),
                    new global::Together.JsonConverters.OneOfJsonConverter<int?, global::Together.CreateFineTunesRequestBatchSize?>(),
                    new global::Together.JsonConverters.OneOfJsonConverter<bool?, global::Together.CreateFineTunesRequestTrainOnInputs?>(),
                    new global::Together.JsonConverters.OneOfJsonConverter<global::Together.TrainingMethodSFT, global::Together.TrainingMethodDPO>(),
                    new global::Together.JsonConverters.AnyOfJsonConverter<global::Together.FullTrainingType, global::Together.LoRATrainingType>(),
                    new global::Together.JsonConverters.OneOfJsonConverter<global::Together.TrainingMethodSFT, global::Together.TrainingMethodDPO>(),
                    new global::Together.JsonConverters.OneOfJsonConverter<global::Together.FullTrainingType, global::Together.LoRATrainingType>(),
                    new global::Together.JsonConverters.OneOfJsonConverter<global::Together.EvaluationClassifyResults, global::Together.EvaluationScoreResults, global::Together.EvaluationCompareResults>(),
                    new global::Together.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// 
        /// </summary>
        public AudioClient Audio => new AudioClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public BatchesClient Batches => new BatchesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ChatClient Chat => new ChatClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CodeInterpreterClient CodeInterpreter => new CodeInterpreterClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CompletionClient Completion => new CompletionClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DeploymentsClient Deployments => new DeploymentsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DeploymentsStorageClient DeploymentsStorage => new DeploymentsStorageClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DeploymentsVolumesClient DeploymentsVolumes => new DeploymentsVolumesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsClient Embeddings => new EmbeddingsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public EndpointsClient Endpoints => new EndpointsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public Endpoints2Client Endpoints2 => new Endpoints2Client(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public EvaluationClient Evaluation => new EvaluationClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FilesClient Files => new FilesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FineTuningClient FineTuning => new FineTuningClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public GPUClusterServiceClient GPUClusterService => new GPUClusterServiceClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public HardwareClient Hardware => new HardwareClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ImagesClient Images => new ImagesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public JobsClient Jobs => new JobsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ModelsClient Models => new ModelsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public QueueClient Queue => new QueueClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public RegionServiceClient RegionService => new RegionServiceClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public RerankClient Rerank => new RerankClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public RlClient Rl => new RlClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SecretsClient Secrets => new SecretsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SharedVolumeServiceClient SharedVolumeService => new SharedVolumeServiceClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public VideoClient Video => new VideoClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public VoicesClient Voices => new VoicesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public VolumesClient Volumes => new VolumesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Creates a new instance of the TogetherClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public TogetherClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Together.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::Together.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}