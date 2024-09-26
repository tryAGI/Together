
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
            typeof(global::Together.JsonConverters.RerankResponseObjectJsonConverter),
            typeof(global::Together.JsonConverters.RerankResponseObjectNullableJsonConverter),
            typeof(global::Together.JsonConverters.FinishReasonJsonConverter),
            typeof(global::Together.JsonConverters.FinishReasonNullableJsonConverter),
            typeof(global::Together.JsonConverters.CompletionResponseObjectJsonConverter),
            typeof(global::Together.JsonConverters.CompletionResponseObjectNullableJsonConverter),
            typeof(global::Together.JsonConverters.StreamSentinelDataJsonConverter),
            typeof(global::Together.JsonConverters.StreamSentinelDataNullableJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionMessageRoleJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionMessageRoleNullableJsonConverter),
            typeof(global::Together.JsonConverters.ToolChoiceTypeJsonConverter),
            typeof(global::Together.JsonConverters.ToolChoiceTypeNullableJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionToolTypeJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionToolTypeNullableJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionRequestMessageRoleJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionRequestMessageRoleNullableJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionRequestFunctionCallEnumJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionRequestFunctionCallEnumNullableJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionSystemMessageParamRoleJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionSystemMessageParamRoleNullableJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionUserMessageParamRoleJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionUserMessageParamRoleNullableJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionAssistantMessageParamRoleJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionAssistantMessageParamRoleNullableJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionToolMessageParamRoleJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionToolMessageParamRoleNullableJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionFunctionMessageParamRoleJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionFunctionMessageParamRoleNullableJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionResponseObjectJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionResponseObjectNullableJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionChunkObjectJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionChunkObjectNullableJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionChunkChoiceDeltaRoleJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionChunkChoiceDeltaRoleNullableJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionChoiceDeltaRoleJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionChoiceDeltaRoleNullableJsonConverter),
            typeof(global::Together.JsonConverters.EmbeddingsResponseObjectJsonConverter),
            typeof(global::Together.JsonConverters.EmbeddingsResponseObjectNullableJsonConverter),
            typeof(global::Together.JsonConverters.EmbeddingsResponseDataItemObjectJsonConverter),
            typeof(global::Together.JsonConverters.EmbeddingsResponseDataItemObjectNullableJsonConverter),
            typeof(global::Together.JsonConverters.ModelInfoTypeJsonConverter),
            typeof(global::Together.JsonConverters.ModelInfoTypeNullableJsonConverter),
            typeof(global::Together.JsonConverters.ImageResponseObjectJsonConverter),
            typeof(global::Together.JsonConverters.ImageResponseObjectNullableJsonConverter),
            typeof(global::Together.JsonConverters.FileResponsePurposeJsonConverter),
            typeof(global::Together.JsonConverters.FileResponsePurposeNullableJsonConverter),
            typeof(global::Together.JsonConverters.FileResponseFileTypeJsonConverter),
            typeof(global::Together.JsonConverters.FileResponseFileTypeNullableJsonConverter),
            typeof(global::Together.JsonConverters.FinetuneJobStatusJsonConverter),
            typeof(global::Together.JsonConverters.FinetuneJobStatusNullableJsonConverter),
            typeof(global::Together.JsonConverters.FinetuneEventObjectJsonConverter),
            typeof(global::Together.JsonConverters.FinetuneEventObjectNullableJsonConverter),
            typeof(global::Together.JsonConverters.FinetuneEventLevelsJsonConverter),
            typeof(global::Together.JsonConverters.FinetuneEventLevelsNullableJsonConverter),
            typeof(global::Together.JsonConverters.FinetuneEventTypeJsonConverter),
            typeof(global::Together.JsonConverters.FinetuneEventTypeNullableJsonConverter),
            typeof(global::Together.JsonConverters.FineTuneEventObject2JsonConverter),
            typeof(global::Together.JsonConverters.FineTuneEventObject2NullableJsonConverter),
            typeof(global::Together.JsonConverters.FineTuneEventLevelJsonConverter),
            typeof(global::Together.JsonConverters.FineTuneEventLevelNullableJsonConverter),
            typeof(global::Together.JsonConverters.FineTuneEventType2JsonConverter),
            typeof(global::Together.JsonConverters.FineTuneEventType2NullableJsonConverter),
            typeof(global::Together.JsonConverters.FinetuneDownloadResultObjectJsonConverter),
            typeof(global::Together.JsonConverters.FinetuneDownloadResultObjectNullableJsonConverter),
            typeof(global::Together.JsonConverters.OneOfJsonConverterFactory2),
            typeof(global::Together.JsonConverters.CompletionStreamJsonConverter),
            typeof(global::Together.JsonConverters.AllOfJsonConverterFactory2),
            typeof(global::Together.JsonConverters.ChatCompletionMessageParamJsonConverter),
            typeof(global::Together.JsonConverters.ChatCompletionStreamJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}