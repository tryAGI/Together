#nullable enable

namespace Together
{
    public partial interface IShapingClient
    {
        /// <summary>
        /// List shaping job events<br/>
        /// List events for a shaping job owned by the caller's project.
        /// </summary>
        /// <param name="id">
        /// Shaping job ID beginning with `shp-quant-`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// events = client.post_training.prepare_for_fp4_inference.list_events(<br/>
        ///     "&lt;JOB_ID&gt;",<br/>
        /// )<br/>
        /// for event in events.data:<br/>
        ///     print(event)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.EventsList> GetShapingEventsAsync(
            string id,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List shaping job events<br/>
        /// List events for a shaping job owned by the caller's project.
        /// </summary>
        /// <param name="id">
        /// Shaping job ID beginning with `shp-quant-`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// events = client.post_training.prepare_for_fp4_inference.list_events(<br/>
        ///     "&lt;JOB_ID&gt;",<br/>
        /// )<br/>
        /// for event in events.data:<br/>
        ///     print(event)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.EventsList>> GetShapingEventsAsResponseAsync(
            string id,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}