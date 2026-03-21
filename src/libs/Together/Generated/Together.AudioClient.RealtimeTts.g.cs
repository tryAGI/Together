
#nullable enable

namespace Together
{
    public partial class AudioClient
    {
        partial void PrepareRealtimeTtsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::Together.RealtimeTtsModel? model,
            ref string? voice,
            ref int? maxPartialLength);
        partial void PrepareRealtimeTtsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Together.RealtimeTtsModel? model,
            string? voice,
            int? maxPartialLength);
        partial void ProcessRealtimeTtsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Real-time text-to-speech via WebSocket<br/>
        /// Establishes a WebSocket connection for real-time text-to-speech generation. This endpoint uses WebSocket protocol (wss://api.together.ai/v1/audio/speech/websocket) for bidirectional streaming communication.<br/>
        /// **Connection Setup:**<br/>
        /// - Protocol: WebSocket (wss://)<br/>
        /// - Authentication: Pass API key as Bearer token in Authorization header<br/>
        /// - Parameters: Sent as query parameters (model, voice, max_partial_length)<br/>
        /// **Client Events:**<br/>
        /// - `tts_session.updated`: Update session parameters like voice<br/>
        ///   ```json<br/>
        ///   {<br/>
        ///     "type": "tts_session.updated",<br/>
        ///     "session": {<br/>
        ///       "voice": "tara"<br/>
        ///     }<br/>
        ///   }<br/>
        ///   ```<br/>
        /// - `input_text_buffer.append`: Send text chunks for TTS generation<br/>
        ///   ```json<br/>
        ///   {<br/>
        ///     "type": "input_text_buffer.append",<br/>
        ///     "text": "Hello, this is a test."<br/>
        ///   }<br/>
        ///   ```<br/>
        /// - `input_text_buffer.clear`: Clear the buffered text<br/>
        ///   ```json<br/>
        ///   {<br/>
        ///     "type": "input_text_buffer.clear"<br/>
        ///   }<br/>
        ///   ```<br/>
        /// - `input_text_buffer.commit`: Signal end of text input and process remaining text<br/>
        ///   ```json<br/>
        ///   {<br/>
        ///     "type": "input_text_buffer.commit"<br/>
        ///   }<br/>
        ///   ```<br/>
        /// **Server Events:**<br/>
        /// - `session.created`: Initial session confirmation (sent first)<br/>
        ///   ```json<br/>
        ///   {<br/>
        ///     "event_id": "evt_123456",<br/>
        ///     "type": "session.created",<br/>
        ///     "session": {<br/>
        ///       "id": "session-id",<br/>
        ///       "object": "realtime.tts.session",<br/>
        ///       "modalities": ["text", "audio"],<br/>
        ///       "model": "hexgrad/Kokoro-82M",<br/>
        ///       "voice": "tara"<br/>
        ///     }<br/>
        ///   }<br/>
        ///   ```<br/>
        /// - `conversation.item.input_text.received`: Acknowledgment that text was received<br/>
        ///   ```json<br/>
        ///   {<br/>
        ///     "type": "conversation.item.input_text.received",<br/>
        ///     "text": "Hello, this is a test."<br/>
        ///   }<br/>
        ///   ```<br/>
        /// - `conversation.item.audio_output.delta`: Audio chunks as base64-encoded data<br/>
        ///   ```json<br/>
        ///   {<br/>
        ///     "type": "conversation.item.audio_output.delta",<br/>
        ///     "item_id": "tts_1",<br/>
        ///     "delta": "&lt;base64_encoded_audio_chunk&gt;"<br/>
        ///   }<br/>
        ///   ```<br/>
        /// - `conversation.item.audio_output.done`: Audio generation complete for an item<br/>
        ///   ```json<br/>
        ///   {<br/>
        ///     "type": "conversation.item.audio_output.done",<br/>
        ///     "item_id": "tts_1"<br/>
        ///   }<br/>
        ///   ```<br/>
        /// - `conversation.item.tts.failed`: Error occurred<br/>
        ///   ```json<br/>
        ///   {<br/>
        ///     "type": "conversation.item.tts.failed",<br/>
        ///     "error": {<br/>
        ///       "message": "Error description",<br/>
        ///       "type": "invalid_request_error",<br/>
        ///       "param": null,<br/>
        ///       "code": "invalid_api_key"<br/>
        ///     }<br/>
        ///   }<br/>
        ///   ```<br/>
        /// **Text Processing:**<br/>
        /// - Partial text (no sentence ending) is held in buffer until:<br/>
        ///   - We believe that the text is complete enough to be processed for TTS generation<br/>
        ///   - The partial text exceeds `max_partial_length` characters (default: 250)<br/>
        ///   - The `input_text_buffer.commit` event is received<br/>
        /// **Audio Format:**<br/>
        /// - Format: WAV (PCM s16le)<br/>
        /// - Sample Rate: 24000 Hz<br/>
        /// - Encoding: Base64<br/>
        /// - Delivered via `conversation.item.audio_output.delta` events<br/>
        /// **Error Codes:**<br/>
        /// - `invalid_api_key`: Invalid API key provided (401)<br/>
        /// - `missing_api_key`: Authorization header missing (401)<br/>
        /// - `model_not_available`: Invalid or unavailable model (400)<br/>
        /// - Invalid text format errors (400)
        /// </summary>
        /// <param name="model">
        /// The TTS model to use for speech generation. Can also be set via `tts_session.updated` event.<br/>
        /// Default Value: hexgrad/Kokoro-82M
        /// </param>
        /// <param name="voice">
        /// The voice to use for speech generation. Default is 'tara'.<br/>
        /// Available voices vary by model. Can also be updated via `tts_session.updated` event.
        /// </param>
        /// <param name="maxPartialLength">
        /// Maximum number of characters in partial text before forcing TTS generation<br/>
        /// even without a sentence ending. Helps reduce latency for long text without punctuation.<br/>
        /// Default Value: 250
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// import asyncio<br/>
        /// import websockets<br/>
        /// import json<br/>
        /// import base64<br/>
        /// import os<br/>
        /// async def generate_speech():<br/>
        ///     api_key = os.environ.get("TOGETHER_API_KEY")<br/>
        ///     url = "wss://api.together.ai/v1/audio/speech/websocket?model=hexgrad/Kokoro-82M&amp;voice=tara"<br/>
        ///     headers = {<br/>
        ///         "Authorization": f"Bearer {api_key}"<br/>
        ///     }<br/>
        ///     async with websockets.connect(url, additional_headers=headers) as ws:<br/>
        ///         # Wait for session created<br/>
        ///         session_msg = await ws.recv()<br/>
        ///         session_data = json.loads(session_msg)<br/>
        ///         print(f"Session created: {session_data['session']['id']}")<br/>
        ///         # Send text for TTS<br/>
        ///         text_chunks = [<br/>
        ///             "Hello, this is a test.",<br/>
        ///             "This is the second sentence.",<br/>
        ///             "And this is the final one."<br/>
        ///         ]<br/>
        ///         async def send_text():<br/>
        ///             for chunk in text_chunks:<br/>
        ///                 await ws.send(json.dumps({<br/>
        ///                     "type": "input_text_buffer.append",<br/>
        ///                     "text": chunk<br/>
        ///                 }))<br/>
        ///                 await asyncio.sleep(0.5)  # Simulate typing<br/>
        ///             # Commit to process any remaining text<br/>
        ///             await ws.send(json.dumps({<br/>
        ///                 "type": "input_text_buffer.commit"<br/>
        ///             }))<br/>
        ///         async def receive_audio():<br/>
        ///             audio_data = bytearray()<br/>
        ///             async for message in ws:<br/>
        ///                 data = json.loads(message)<br/>
        ///                 if data["type"] == "conversation.item.input_text.received":<br/>
        ///                     print(f"Text received: {data['text']}")<br/>
        ///                 elif data["type"] == "conversation.item.audio_output.delta":<br/>
        ///                     # Decode base64 audio chunk<br/>
        ///                     audio_chunk = base64.b64decode(data['delta'])<br/>
        ///                     audio_data.extend(audio_chunk)<br/>
        ///                     print(f"Received audio chunk for item {data['item_id']}")<br/>
        ///                 elif data["type"] == "conversation.item.audio_output.done":<br/>
        ///                     print(f"Audio generation complete for item {data['item_id']}")<br/>
        ///                 elif data["type"] == "conversation.item.tts.failed":<br/>
        ///                     error = data.get("error", {})<br/>
        ///                     print(f"Error: {error.get('message')}")<br/>
        ///                     break<br/>
        ///             # Save the audio to a file<br/>
        ///             with open("output.wav", "wb") as f:<br/>
        ///                 f.write(audio_data)<br/>
        ///             print("Audio saved to output.wav")<br/>
        ///         # Run send and receive concurrently<br/>
        ///         await asyncio.gather(send_text(), receive_audio())<br/>
        /// asyncio.run(generate_speech())
        /// </remarks>
        public async global::System.Threading.Tasks.Task RealtimeTtsAsync(
            global::Together.RealtimeTtsModel? model = default,
            string? voice = default,
            int? maxPartialLength = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareRealtimeTtsArguments(
                httpClient: HttpClient,
                model: ref model,
                voice: ref voice,
                maxPartialLength: ref maxPartialLength);

            var __pathBuilder = new global::Together.PathBuilder(
                path: "/audio/speech/websocket",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("model", model?.ToValueString())
                .AddOptionalParameter("voice", voice)
                .AddOptionalParameter("max_partial_length", maxPartialLength?.ToString()) 
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
            PrepareRealtimeTtsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                model: model,
                voice: voice,
                maxPartialLength: maxPartialLength);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessRealtimeTtsResponse(
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