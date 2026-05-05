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
        /// - `input_audio_buffer.commit`: Signal end of audio stream. When VAD is enabled, the server automatically detects speech boundaries and emits `completed` events. When VAD is disabled, you must send `commit` to trigger transcription of the buffered audio.<br/>
        ///   ```json<br/>
        ///   {<br/>
        ///     "type": "input_audio_buffer.commit"<br/>
        ///   }<br/>
        ///   ```<br/>
        /// - `transcription_session.updated`: Update session configuration, including Voice Activity Detection (VAD) parameters. Send this after receiving `session.created`. Can also be sent at any time during the session to change VAD settings.<br/>
        ///   ```json<br/>
        ///   {<br/>
        ///     "type": "transcription_session.updated",<br/>
        ///     "session": {<br/>
        ///       "turn_detection": {<br/>
        ///         "type": "server_vad",<br/>
        ///         "threshold": 0.3,<br/>
        ///         "min_silence_duration_ms": 500,<br/>
        ///         "min_speech_duration_ms": 250,<br/>
        ///         "max_speech_duration_s": 5.0,<br/>
        ///         "speech_pad_ms": 250<br/>
        ///       }<br/>
        ///     }<br/>
        ///   }<br/>
        ///   ```<br/>
        ///   To disable VAD entirely (manual commit mode), set `turn_detection` to `null`:<br/>
        ///   ```json<br/>
        ///   {<br/>
        ///     "type": "transcription_session.updated",<br/>
        ///     "session": {<br/>
        ///       "turn_detection": null<br/>
        ///     }<br/>
        ///   }<br/>
        ///   ```<br/>
        /// **Voice Activity Detection (VAD)**<br/>
        /// VAD controls how the server automatically detects speech segments in the audio stream. When enabled (the default), the server uses Silero VAD to identify speech regions and emits transcription events as each segment completes. When disabled, you must manually call `input_audio_buffer.commit` to trigger transcription.<br/>
        /// VAD can be configured in two ways:<br/>
        /// 1. **Query parameters** at connection time: `turn_detection=server_vad&amp;threshold=0.3&amp;min_silence_duration_ms=500`<br/>
        /// 2. **Session message** after connection: Send `transcription_session.updated` with a `turn_detection` object (see above)<br/>
        /// To disable VAD at connection time, use `turn_detection=none` as a query parameter.<br/>
        /// **VAD Parameters:**<br/>
        /// All parameters are optional — omitted fields use their defaults.<br/>
        /// | Parameter | Type | Default | Description |<br/>
        /// |-----------|------|---------|-------------|<br/>
        /// | `type` | string | `server_vad` | VAD mode. Use `server_vad` to enable, or set `turn_detection` to `null` to disable. |<br/>
        /// | `threshold` | float | `0.3` | Speech probability threshold (0.0–1.0). Audio frames with probability above this value are classified as speech. Lower values detect more speech but may increase false positives. For low-SNR audio (e.g., 8kHz phone calls), values of 0.01–0.2 may work better. |<br/>
        /// | `min_silence_duration_ms` | int | `500` | Minimum silence duration in milliseconds before ending a speech segment. Higher values merge nearby speech bursts into single segments. For phone calls with mid-sentence pauses, 2000–5000ms prevents over-segmentation. |<br/>
        /// | `min_speech_duration_ms` | int | `250` | Minimum speech segment duration in milliseconds. Segments shorter than this are discarded. Filters out brief noise bursts or clicks. |<br/>
        /// | `max_speech_duration_s` | float | `5.0` | Maximum speech segment duration in seconds. Segments longer than this are force-split at the longest internal silence gap. Useful for continuous speech without natural pauses. |<br/>
        /// | `speech_pad_ms` | int | `250` | Padding in milliseconds added to the start and end of each detected segment. Prevents clipping speech edges. When padding would cause adjacent segments to overlap, the gap is split at the midpoint instead. |<br/>
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
        /// - `transcription_session.updated`: Confirms session configuration was applied. Sent in response to a client `transcription_session.updated` message.<br/>
        ///   ```json<br/>
        ///   {<br/>
        ///     "type": "transcription_session.updated",<br/>
        ///     "session": {<br/>
        ///       "turn_detection": {<br/>
        ///         "type": "server_vad",<br/>
        ///         "threshold": 0.3,<br/>
        ///         "min_silence_duration_ms": 500,<br/>
        ///         "min_speech_duration_ms": 250,<br/>
        ///         "max_speech_duration_s": 5.0,<br/>
        ///         "speech_pad_ms": 250<br/>
        ///       }<br/>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// import asyncio<br/>
        /// import websockets<br/>
        /// import json<br/>
        /// import base64<br/>
        /// import os<br/>
        /// async def transcribe_audio():<br/>
        ///     api_key = os.environ.get("TOGETHER_API_KEY")<br/>
        ///     url = "wss://api.together.ai/v1/realtime?model=openai/whisper-large-v3&amp;input_audio_format=pcm_s16le_16000"<br/>
        ///     headers = {<br/>
        ///         "Authorization": f"Bearer {api_key}"<br/>
        ///     }<br/>
        ///     async with websockets.connect(url, additional_headers=headers) as ws:<br/>
        ///         # Read audio file<br/>
        ///         with open("audio.wav", "rb") as f:<br/>
        ///             audio_data = f.read()<br/>
        ///         # Send audio in chunks with delay to simulate real-time<br/>
        ///         chunk_size = 8192<br/>
        ///         bytes_per_second = 16000 * 2  # 16kHz * 2 bytes (16-bit)<br/>
        ///         delay_per_chunk = chunk_size / bytes_per_second<br/>
        ///         for i in range(0, len(audio_data), chunk_size):<br/>
        ///             chunk = audio_data[i:i+chunk_size]<br/>
        ///             base64_chunk = base64.b64encode(chunk).decode('utf-8')<br/>
        ///             await ws.send(json.dumps({<br/>
        ///                 "type": "input_audio_buffer.append",<br/>
        ///                 "audio": base64_chunk<br/>
        ///             }))<br/>
        ///             # Simulate real-time streaming<br/>
        ///             if i + chunk_size &lt; len(audio_data):<br/>
        ///                 await asyncio.sleep(delay_per_chunk)<br/>
        ///         # Commit the audio buffer<br/>
        ///         await ws.send(json.dumps({<br/>
        ///             "type": "input_audio_buffer.commit"<br/>
        ///         }))<br/>
        ///         # Receive transcription results<br/>
        ///         async for message in ws:<br/>
        ///             data = json.loads(message)<br/>
        ///             if data["type"] == "conversation.item.input_audio_transcription.delta":<br/>
        ///                 print(f"Partial: {data['delta']}")<br/>
        ///             elif data["type"] == "conversation.item.input_audio_transcription.completed":<br/>
        ///                 print(f"Final: {data['transcript']}")<br/>
        ///                 break<br/>
        ///             elif data["type"] == "conversation.item.input_audio_transcription.failed":<br/>
        ///                 error = data.get("error", {})<br/>
        ///                 print(f"Error: {error.get('message')}")<br/>
        ///                 break<br/>
        /// asyncio.run(transcribe_audio())
        /// </remarks>
        global::System.Threading.Tasks.Task RealtimeTranscriptionAsync(
            string model,
            global::Together.RealtimeTranscriptionInputAudioFormat inputAudioFormat = global::Together.RealtimeTranscriptionInputAudioFormat.PcmS16le16000,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}