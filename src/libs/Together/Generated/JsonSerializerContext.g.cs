
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
            typeof(global::Together.JsonConverters.ChatCompletionAssistantMessageParamRoleJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionAssistantMessageParamRoleNullableJsonConverter),
            typeof(global::Together.JsonConverters.ToolChoiceTypeJsonConverter),
            typeof(global::Together.JsonConverters.ToolChoiceTypeNullableJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionChoiceDeltaRoleJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionChoiceDeltaRoleNullableJsonConverter),
            typeof(global::Together.JsonConverters.FinishReasonJsonConverter),
            typeof(global::Together.JsonConverters.FinishReasonNullableJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionMessageRoleJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionMessageRoleNullableJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionChunkChoiceDeltaRoleJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionChunkChoiceDeltaRoleNullableJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionChunkObjectJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionChunkObjectNullableJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionFunctionMessageParamRoleJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionFunctionMessageParamRoleNullableJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionSystemMessageParamRoleJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionSystemMessageParamRoleNullableJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionUserMessageParamRoleJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionUserMessageParamRoleNullableJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionToolMessageParamRoleJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionToolMessageParamRoleNullableJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionMessageParamDiscriminatorRoleJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionMessageParamDiscriminatorRoleNullableJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionRequestFunctionCallEnumJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionRequestFunctionCallEnumNullableJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionRequestMessageRoleJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionRequestMessageRoleNullableJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionRequestModelJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionRequestModelNullableJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionResponseObjectJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionResponseObjectNullableJsonConverter),
            typeof(global::Together.JsonConverters.StreamSentinelDataJsonConverter),
            typeof(global::Together.JsonConverters.StreamSentinelDataNullableJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionToolTypeJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionToolTypeNullableJsonConverter),
            typeof(global::Together.JsonConverters.CompletionRequestModelJsonConverter),
            typeof(global::Together.JsonConverters.CompletionRequestModelNullableJsonConverter),
            typeof(global::Together.JsonConverters.CompletionRequestSafetyModelJsonConverter),
            typeof(global::Together.JsonConverters.CompletionRequestSafetyModelNullableJsonConverter),
            typeof(global::Together.JsonConverters.CompletionResponseObjectJsonConverter),
            typeof(global::Together.JsonConverters.CompletionResponseObjectNullableJsonConverter),
            typeof(global::Together.JsonConverters.EmbeddingsRequestModelJsonConverter),
            typeof(global::Together.JsonConverters.EmbeddingsRequestModelNullableJsonConverter),
            typeof(global::Together.JsonConverters.EmbeddingsResponseDataItemObjectJsonConverter),
            typeof(global::Together.JsonConverters.EmbeddingsResponseDataItemObjectNullableJsonConverter),
            typeof(global::Together.JsonConverters.EmbeddingsResponseObjectJsonConverter),
            typeof(global::Together.JsonConverters.EmbeddingsResponseObjectNullableJsonConverter),
            typeof(global::Together.JsonConverters.FileResponseFileTypeJsonConverter),
            typeof(global::Together.JsonConverters.FileResponseFileTypeNullableJsonConverter),
            typeof(global::Together.JsonConverters.FileResponsePurposeJsonConverter),
            typeof(global::Together.JsonConverters.FileResponsePurposeNullableJsonConverter),
            typeof(global::Together.JsonConverters.FineTuneEventLevelJsonConverter),
            typeof(global::Together.JsonConverters.FineTuneEventLevelNullableJsonConverter),
            typeof(global::Together.JsonConverters.FineTuneEventObjectJsonConverter),
            typeof(global::Together.JsonConverters.FineTuneEventObjectNullableJsonConverter),
            typeof(global::Together.JsonConverters.FineTuneEventTypeJsonConverter),
            typeof(global::Together.JsonConverters.FineTuneEventTypeNullableJsonConverter),
            typeof(global::Together.JsonConverters.FinetuneDownloadResultObjectJsonConverter),
            typeof(global::Together.JsonConverters.FinetuneDownloadResultObjectNullableJsonConverter),
            typeof(global::Together.JsonConverters.FinetuneEventLevelsJsonConverter),
            typeof(global::Together.JsonConverters.FinetuneEventLevelsNullableJsonConverter),
            typeof(global::Together.JsonConverters.FinetuneEventObject2JsonConverter),
            typeof(global::Together.JsonConverters.FinetuneEventObject2NullableJsonConverter),
            typeof(global::Together.JsonConverters.FinetuneEventType2JsonConverter),
            typeof(global::Together.JsonConverters.FinetuneEventType2NullableJsonConverter),
            typeof(global::Together.JsonConverters.FinetuneJobStatusJsonConverter),
            typeof(global::Together.JsonConverters.FinetuneJobStatusNullableJsonConverter),
            typeof(global::Together.JsonConverters.FinetuneResponseTrainOnInputsJsonConverter),
            typeof(global::Together.JsonConverters.FinetuneResponseTrainOnInputsNullableJsonConverter),
            typeof(global::Together.JsonConverters.FullTrainingTypeTypeJsonConverter),
            typeof(global::Together.JsonConverters.FullTrainingTypeTypeNullableJsonConverter),
            typeof(global::Together.JsonConverters.LoRATrainingTypeTypeJsonConverter),
            typeof(global::Together.JsonConverters.LoRATrainingTypeTypeNullableJsonConverter),
            typeof(global::Together.JsonConverters.FinetuneResponseTrainingTypeDiscriminatorTypeJsonConverter),
            typeof(global::Together.JsonConverters.FinetuneResponseTrainingTypeDiscriminatorTypeNullableJsonConverter),
            typeof(global::Together.JsonConverters.ImageResponseObjectJsonConverter),
            typeof(global::Together.JsonConverters.ImageResponseObjectNullableJsonConverter),
            typeof(global::Together.JsonConverters.ModelInfoTypeJsonConverter),
            typeof(global::Together.JsonConverters.ModelInfoTypeNullableJsonConverter),
            typeof(global::Together.JsonConverters.RerankRequestModelJsonConverter),
            typeof(global::Together.JsonConverters.RerankRequestModelNullableJsonConverter),
            typeof(global::Together.JsonConverters.RerankResponseObjectJsonConverter),
            typeof(global::Together.JsonConverters.RerankResponseObjectNullableJsonConverter),
            typeof(global::Together.JsonConverters.RequestTrainOnInputsJsonConverter),
            typeof(global::Together.JsonConverters.RequestTrainOnInputsNullableJsonConverter),
            typeof(global::Together.JsonConverters.RequestModelJsonConverter),
            typeof(global::Together.JsonConverters.RequestModelNullableJsonConverter),
            typeof(global::Together.JsonConverters.CheckpointJsonConverter),
            typeof(global::Together.JsonConverters.CheckpointNullableJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionMessageParamJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionStreamJsonConverter),
            typeof(global::Together.JsonConverters.CompletionStreamJsonConverter),
            typeof(global::Together.JsonConverters.FinetuneResponseTrainingTypeJsonConverter),
            typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.ChatCompletionRequestFunctionCallEnum?, global::Together.ChatCompletionRequestFunctionCallEnum2>),
            typeof(global::Together.JsonConverters.AnyOfJsonConverter<global::Together.ChatCompletionRequestModel?, string>),
            typeof(global::Together.JsonConverters.OneOfJsonConverter<string, global::Together.ToolChoice2>),
            typeof(global::Together.JsonConverters.AnyOfJsonConverter<global::Together.CompletionRequestModel?, string>),
            typeof(global::Together.JsonConverters.AnyOfJsonConverter<global::Together.CompletionRequestSafetyModel?, string>),
            typeof(global::Together.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),
            typeof(global::Together.JsonConverters.AnyOfJsonConverter<global::Together.EmbeddingsRequestModel?, string>),
            typeof(global::Together.JsonConverters.OneOfJsonConverter<bool?, global::Together.FinetuneResponseTrainOnInputs?>),
            typeof(global::Together.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<object>, global::System.Collections.Generic.IList<string>>),
            typeof(global::Together.JsonConverters.AnyOfJsonConverter<global::Together.RerankRequestModel?, string>),
            typeof(global::Together.JsonConverters.OneOfJsonConverter<bool?, global::Together.RequestTrainOnInputs?>),
            typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.FullTrainingType, global::Together.LoRATrainingType>),
            typeof(global::Together.JsonConverters.AnyOfJsonConverter<global::Together.RequestModel?, string>),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}