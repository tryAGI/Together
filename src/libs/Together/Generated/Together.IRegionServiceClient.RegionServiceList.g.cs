#nullable enable

namespace Together
{
    public partial interface IRegionServiceClient
    {
        /// <summary>
        /// List regions and corresponding supported driver versions
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>
        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// regions = client.beta.clusters.list_regions()<br/>
        /// print(regions)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.RegionListResponse> RegionServiceListAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}