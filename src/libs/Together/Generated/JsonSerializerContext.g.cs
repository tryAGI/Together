
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
            typeof(global::OpenApiGenerator.JsonConverters.RerankResponseObjectJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.RerankResponseObjectNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.FinishReasonJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.FinishReasonNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.CompletionResponseObjectJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.CompletionResponseObjectNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.StreamSentinelDataJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.StreamSentinelDataNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ChatCompletionMessageRoleJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ChatCompletionMessageRoleNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ToolChoiceTypeJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ToolChoiceTypeNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ChatCompletionToolTypeJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ChatCompletionToolTypeNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ChatCompletionRequestMessageRoleJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ChatCompletionRequestMessageRoleNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ChatCompletionRequestFunctionCallEnumJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ChatCompletionRequestFunctionCallEnumNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ChatCompletionSystemMessageParamRoleJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ChatCompletionSystemMessageParamRoleNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ChatCompletionUserMessageParamRoleJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ChatCompletionUserMessageParamRoleNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ChatCompletionAssistantMessageParamRoleJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ChatCompletionAssistantMessageParamRoleNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ChatCompletionToolMessageParamRoleJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ChatCompletionToolMessageParamRoleNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ChatCompletionFunctionMessageParamRoleJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ChatCompletionFunctionMessageParamRoleNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ChatCompletionResponseObjectJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ChatCompletionResponseObjectNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ChatCompletionChunkObjectJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ChatCompletionChunkObjectNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ChatCompletionChunkChoiceDeltaRoleJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ChatCompletionChunkChoiceDeltaRoleNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ChatCompletionChoiceDeltaRoleJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ChatCompletionChoiceDeltaRoleNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.EmbeddingsResponseObjectJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.EmbeddingsResponseObjectNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.EmbeddingsResponseDataItemObjectJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.EmbeddingsResponseDataItemObjectNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ModelInfoTypeJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ModelInfoTypeNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ImageResponseObjectJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ImageResponseObjectNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.FileResponsePurposeJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.FileResponsePurposeNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.FileResponseFileTypeJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.FileResponseFileTypeNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.FinetuneJobStatusJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.FinetuneJobStatusNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.FinetuneEventObjectJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.FinetuneEventObjectNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.FinetuneEventLevelsJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.FinetuneEventLevelsNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.FinetuneEventTypeJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.FinetuneEventTypeNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.FineTuneEventObject2JsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.FineTuneEventObject2NullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.FineTuneEventLevelJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.FineTuneEventLevelNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.FineTuneEventType2JsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.FineTuneEventType2NullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.FinetuneDownloadResultObjectJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.FinetuneDownloadResultObjectNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.OneOfJsonConverterFactory2),
            typeof(global::OpenApiGenerator.JsonConverters.CompletionStreamJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.AllOfJsonConverterFactory2),
            typeof(global::OpenApiGenerator.JsonConverters.ChatCompletionMessageParamJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ChatCompletionStreamJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.AnyOfJsonConverterFactory1),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}