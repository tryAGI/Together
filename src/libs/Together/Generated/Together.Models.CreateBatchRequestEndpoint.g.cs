
#nullable enable

namespace Together
{
    /// <summary>
    /// The endpoint to use for batch processing. Each line of the uploaded input file is dispatched against this endpoint.<br/>
    /// - `/v1/chat/completions` — chat completion batches<br/>
    /// - `/v1/audio/transcriptions` — audio transcription batches (e.g. `openai/whisper-large-v3`)<br/>
    /// - `/v1/audio/translations` — audio translation batches<br/>
    /// Example: /v1/chat/completions
    /// </summary>
    public enum CreateBatchRequestEndpoint
    {
        /// <summary>
        /// 
        /// </summary>
        V1AudioTranscriptions,
        /// <summary>
        /// 
        /// </summary>
        V1AudioTranslations,
        /// <summary>
        /// 
        /// </summary>
        V1ChatCompletions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateBatchRequestEndpointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBatchRequestEndpoint value)
        {
            return value switch
            {
                CreateBatchRequestEndpoint.V1AudioTranscriptions => "/v1/audio/transcriptions",
                CreateBatchRequestEndpoint.V1AudioTranslations => "/v1/audio/translations",
                CreateBatchRequestEndpoint.V1ChatCompletions => "/v1/chat/completions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBatchRequestEndpoint? ToEnum(string value)
        {
            return value switch
            {
                "/v1/audio/transcriptions" => CreateBatchRequestEndpoint.V1AudioTranscriptions,
                "/v1/audio/translations" => CreateBatchRequestEndpoint.V1AudioTranslations,
                "/v1/chat/completions" => CreateBatchRequestEndpoint.V1ChatCompletions,
                _ => null,
            };
        }
    }
}