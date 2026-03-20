#nullable enable

namespace Together
{
    public partial interface ISharedVolumeServiceClient
    {

        /// <summary>
        /// Create a shared volume.<br/>
        /// Instant Clusters supports long-lived, resizable in-DC shared storage with user data persistence.<br/>
        /// You can dynamically create and attach volumes to your cluster at cluster creation time, and resize as your data grows.<br/>
        /// All shared storage is backed by multi-NIC bare metal paths, ensuring high-throughput and low-latency performance for shared storage.
        /// </summary>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>

        /// <remarks>
        /// from together import Together<br/>
        /// client = Together()<br/>
        /// volume = client.beta.clusters.storage.create(<br/>
        ///   volume_name="my-shared-volume",<br/>
        ///   size_tib=2,<br/>
        ///   region="us-west-2"<br/>
        /// )
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.GPUClustersSharedVolume> SharedVolumeServiceCreateAsync(

            global::Together.GPUClustersSharedVolumeCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a shared volume.<br/>
        /// Instant Clusters supports long-lived, resizable in-DC shared storage with user data persistence.<br/>
        /// You can dynamically create and attach volumes to your cluster at cluster creation time, and resize as your data grows.<br/>
        /// All shared storage is backed by multi-NIC bare metal paths, ensuring high-throughput and low-latency performance for shared storage.
        /// </summary>
        /// <param name="volumeName">
        /// Customizable name of the volume to create.
        /// </param>
        /// <param name="sizeTib">
        /// Volume size in whole tebibytes (TiB).
        /// </param>
        /// <param name="region">
        /// Region name. Usable regions can be found from `client.clusters.list_regions()`
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.GPUClustersSharedVolume> SharedVolumeServiceCreateAsync(
            string volumeName,
            long sizeTib,
            string region,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}