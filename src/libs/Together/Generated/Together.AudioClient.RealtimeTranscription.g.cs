
#nullable enable

namespace Together
{
    public partial class AudioClient
    {
        partial void PrepareRealtimeTranscriptionArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string model,
            ref global::Together.RealtimeTranscriptionInputAudioFormat inputAudioFormat);
        partial void PrepareRealtimeTranscriptionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string model,
            global::Together.RealtimeTranscriptionInputAudioFormat inputAudioFormat);
        partial void ProcessRealtimeTranscriptionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);


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
        public async global::System.Threading.Tasks.Task RealtimeTranscriptionAsync(
            string model,
            global::Together.RealtimeTranscriptionInputAudioFormat inputAudioFormat = global::Together.RealtimeTranscriptionInputAudioFormat.PcmS16le16000,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareRealtimeTranscriptionArguments(
                httpClient: HttpClient,
                model: ref model,
                inputAudioFormat: ref inputAudioFormat);

            var __pathBuilder = new global::Together.PathBuilder(
                path: "/realtime",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddRequiredParameter("model", model)
                .AddRequiredParameter("input_audio_format", inputAudioFormat.ToValueString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareRealtimeTranscriptionRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                model: model,
                inputAudioFormat: inputAudioFormat);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessRealtimeTranscriptionResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // 
            if ((int)__response.StatusCode == 101)
            {
                string? __content_101 = null;
                global::System.Exception? __exception_101 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_101 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_101 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_101 = __ex;
                }

                throw new global::Together.ApiException(
                    message: __content_101 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_101,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_101,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Together.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Together.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
    }
}