#nullable enable

namespace Together
{
    public partial interface IAudioClient
    {
        /// <summary>
        /// Real-time audio transcription via WebSocket<br/>
        /// Establishes a WebSocket connection for real-time audio transcription. This endpoint uses WebSocket protocol (wss://api.together.ai/v1/realtime) for bidirectional streaming communication.<br/>
        /// **Connection Setup:**<br/>
        /// - Protocol: WebSocket (wss://)<br/>
        /// - Authentication: Pass API key as Bearer token in Authorization header<br/>
        /// - Parameters: Sent as query parameters (model, input_audio_format)<br/>
        /// **Client Events:**<br/>
        /// - `input_audio_buffer.append`: Send audio chunks as base64-encoded data<br/>
        ///   ```json<br/>
        ///   {<br/>
        ///     "type": "input_audio_buffer.append",<br/>
        ///     "audio": "&lt;base64_encoded_audio_chunk&gt;"<br/>
        ///   }<br/>
        ///   ```<br/>
        /// - `input_audio_buffer.commit`: Signal end of audio stream<br/>
        ///   ```json<br/>
        ///   {<br/>
        ///     "type": "input_audio_buffer.commit"<br/>
        ///   }<br/>
        ///   ```<br/>
        /// **Server Events:**<br/>
        /// - `session.created`: Initial session confirmation (sent first)<br/>
        ///   ```json<br/>
        ///   {<br/>
        ///     "type": "session.created",<br/>
        ///     "session": {<br/>
        ///       "id": "session-id",<br/>
        ///       "object": "realtime.session",<br/>
        ///       "modalities": ["audio"],<br/>
        ///       "model": "openai/whisper-large-v3"<br/>
        ///     }<br/>
        ///   }<br/>
        ///   ```<br/>
        /// - `conversation.item.input_audio_transcription.delta`: Partial transcription results<br/>
        ///   ```json<br/>
        ///   {<br/>
        ///     "type": "conversation.item.input_audio_transcription.delta",<br/>
        ///     "delta": "The quick brown"<br/>
        ///   }<br/>
        ///   ```<br/>
        /// - `conversation.item.input_audio_transcription.completed`: Final transcription<br/>
        ///   ```json<br/>
        ///   {<br/>
        ///     "type": "conversation.item.input_audio_transcription.completed",<br/>
        ///     "transcript": "The quick brown fox jumps over the lazy dog"<br/>
        ///   }<br/>
        ///   ```<br/>
        /// - `conversation.item.input_audio_transcription.failed`: Error occurred<br/>
        ///   ```json<br/>
        ///   {<br/>
        ///     "type": "conversation.item.input_audio_transcription.failed",<br/>
        ///     "error": {<br/>
        ///       "message": "Error description",<br/>
        ///       "type": "invalid_request_error",<br/>
        ///       "param": null,<br/>
        ///       "code": "invalid_api_key"<br/>
        ///     }<br/>
        ///   }<br/>
        ///   ```<br/>
        /// **Error Codes:**<br/>
        /// - `invalid_api_key`: Invalid API key provided (401)<br/>
        /// - `missing_api_key`: Authorization header missing (401)<br/>
        /// - `model_not_available`: Invalid or unavailable model (400)<br/>
        /// - Unsupported audio format errors (400)
        /// </summary>
        /// <param name="model">
        /// The Whisper model to use for transcription
        /// </param>
        /// <param name="inputAudioFormat">
        /// Default Value: pcm_s16le_16000
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        global::System.Threading.Tasks.Task RealtimeTranscriptionAsync(
            string model,
            global::Together.RealtimeTranscriptionInputAudioFormat inputAudioFormat = global::Together.RealtimeTranscriptionInputAudioFormat.PcmS16le16000,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}