#nullable enable

namespace Together
{
    public partial interface IBillingClient
    {
        /// <summary>
        /// Get billing usage<br/>
        /// Returns an organization's billing usage for a month as cost-annotated line items grouped into time windows. Finalized windows are returned through the end of yesterday at daily granularity, or the last completed hour at hourly granularity (UTC).
        /// </summary>
        /// <param name="month">
        /// Billing month in YYYY-MM format. Defaults to the current month, which returns data through yesterday (daily) or the last completed hour (hourly).
        /// </param>
        /// <param name="organizationId">
        /// Organization to report on. Usage is always reported for the organization that owns the API key, so this is optional; supplying an ID that is not that organization returns 403.
        /// </param>
        /// <param name="granularity">
        /// Time window size for rows. 'hour' returns ~24x more rows than 'day'.<br/>
        /// Default Value: day
        /// </param>
        /// <param name="limit">
        /// Maximum number of time windows per page (max 1000).<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="after">
        /// Opaque cursor from a previous response's `next_cursor`. Only valid for the month and granularity it was issued for. Current-month data is a moving snapshot: each page reflects data as of its request, so newly completed windows may appear at the end of the sequence.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// # First page<br/>
        /// curl "https://api.together.ai/v1/billing/usage?month=2026-06&amp;granularity=day" \<br/>
        ///      -H "Authorization: Bearer $TOGETHER_API_KEY"<br/>
        /// # Next page: pass the previous response's next_cursor<br/>
        /// curl "https://api.together.ai/v1/billing/usage?month=2026-06&amp;granularity=day&amp;after=NEXT_CURSOR" \<br/>
        ///      -H "Authorization: Bearer $TOGETHER_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.BillingUsageReport> GetBillingUsageAsync(
            string? month = default,
            string? organizationId = default,
            global::Together.GetBillingUsageGranularity? granularity = default,
            int? limit = default,
            string? after = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get billing usage<br/>
        /// Returns an organization's billing usage for a month as cost-annotated line items grouped into time windows. Finalized windows are returned through the end of yesterday at daily granularity, or the last completed hour at hourly granularity (UTC).
        /// </summary>
        /// <param name="month">
        /// Billing month in YYYY-MM format. Defaults to the current month, which returns data through yesterday (daily) or the last completed hour (hourly).
        /// </param>
        /// <param name="organizationId">
        /// Organization to report on. Usage is always reported for the organization that owns the API key, so this is optional; supplying an ID that is not that organization returns 403.
        /// </param>
        /// <param name="granularity">
        /// Time window size for rows. 'hour' returns ~24x more rows than 'day'.<br/>
        /// Default Value: day
        /// </param>
        /// <param name="limit">
        /// Maximum number of time windows per page (max 1000).<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="after">
        /// Opaque cursor from a previous response's `next_cursor`. Only valid for the month and granularity it was issued for. Current-month data is a moving snapshot: each page reflects data as of its request, so newly completed windows may appear at the end of the sequence.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// # First page<br/>
        /// curl "https://api.together.ai/v1/billing/usage?month=2026-06&amp;granularity=day" \<br/>
        ///      -H "Authorization: Bearer $TOGETHER_API_KEY"<br/>
        /// # Next page: pass the previous response's next_cursor<br/>
        /// curl "https://api.together.ai/v1/billing/usage?month=2026-06&amp;granularity=day&amp;after=NEXT_CURSOR" \<br/>
        ///      -H "Authorization: Bearer $TOGETHER_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.AutoSDKHttpResponse<global::Together.BillingUsageReport>> GetBillingUsageAsResponseAsync(
            string? month = default,
            string? organizationId = default,
            global::Together.GetBillingUsageGranularity? granularity = default,
            int? limit = default,
            string? after = default,
            global::Together.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}