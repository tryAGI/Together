#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// GPU Cluster create request
    /// </summary>
    public readonly partial struct GPUClusterCreateRequest : global::System.IEquatable<GPUClusterCreateRequest>
    {
        /// <summary>
        /// Create a cluster with a canonical NVIDIA version id. Do not also set cuda_version or nvidia_driver_version.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.GPUClusterCreateRequestNvidiaVersion? NvidiaVersion { get; init; }
#else
        public global::Together.GPUClusterCreateRequestNvidiaVersion? NvidiaVersion { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NvidiaVersion))]
#endif
        public bool IsNvidiaVersion => NvidiaVersion != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickNvidiaVersion(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Together.GPUClusterCreateRequestNvidiaVersion? value)
        {
            value = NvidiaVersion;
            return IsNvidiaVersion;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Together.GPUClusterCreateRequestNvidiaVersion PickNvidiaVersion() => NvidiaVersion is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'NvidiaVersion' but the value was {ToString()}.");

        /// <summary>
        /// Create a cluster with the legacy CUDA and NVIDIA driver selectors. nvidia_version_id may also be set when it resolves to the same catalog entry.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.GPUClusterCreateRequestLegacyNvidia? LegacyNvidia { get; init; }
#else
        public global::Together.GPUClusterCreateRequestLegacyNvidia? LegacyNvidia { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LegacyNvidia))]
#endif
        public bool IsLegacyNvidia => LegacyNvidia != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickLegacyNvidia(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Together.GPUClusterCreateRequestLegacyNvidia? value)
        {
            value = LegacyNvidia;
            return IsLegacyNvidia;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Together.GPUClusterCreateRequestLegacyNvidia PickLegacyNvidia() => LegacyNvidia is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'LegacyNvidia' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator GPUClusterCreateRequest(global::Together.GPUClusterCreateRequestNvidiaVersion value) => new GPUClusterCreateRequest((global::Together.GPUClusterCreateRequestNvidiaVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Together.GPUClusterCreateRequestNvidiaVersion?(GPUClusterCreateRequest @this) => @this.NvidiaVersion;

        /// <summary>
        ///
        /// </summary>
        public GPUClusterCreateRequest(global::Together.GPUClusterCreateRequestNvidiaVersion? value)
        {
            NvidiaVersion = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GPUClusterCreateRequest FromNvidiaVersion(global::Together.GPUClusterCreateRequestNvidiaVersion? value) => new GPUClusterCreateRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GPUClusterCreateRequest(global::Together.GPUClusterCreateRequestLegacyNvidia value) => new GPUClusterCreateRequest((global::Together.GPUClusterCreateRequestLegacyNvidia?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Together.GPUClusterCreateRequestLegacyNvidia?(GPUClusterCreateRequest @this) => @this.LegacyNvidia;

        /// <summary>
        ///
        /// </summary>
        public GPUClusterCreateRequest(global::Together.GPUClusterCreateRequestLegacyNvidia? value)
        {
            LegacyNvidia = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GPUClusterCreateRequest FromLegacyNvidia(global::Together.GPUClusterCreateRequestLegacyNvidia? value) => new GPUClusterCreateRequest(value);

        /// <summary>
        ///
        /// </summary>
        public GPUClusterCreateRequest(
            global::Together.GPUClusterCreateRequestNvidiaVersion? nvidiaVersion,
            global::Together.GPUClusterCreateRequestLegacyNvidia? legacyNvidia
            )
        {
            NvidiaVersion = nvidiaVersion;
            LegacyNvidia = legacyNvidia;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            LegacyNvidia as object ??
            NvidiaVersion as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            NvidiaVersion?.ToString() ??
            LegacyNvidia?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsNvidiaVersion || IsLegacyNvidia;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Together.GPUClusterCreateRequestNvidiaVersion?, TResult>? nvidiaVersion = null,
            global::System.Func<global::Together.GPUClusterCreateRequestLegacyNvidia?, TResult>? legacyNvidia = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (NvidiaVersion is { } __value0 && nvidiaVersion != null)
            {
                return nvidiaVersion(__value0);
            }
            else if (LegacyNvidia is { } __value1 && legacyNvidia != null)
            {
                return legacyNvidia(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Together.GPUClusterCreateRequestNvidiaVersion?>? nvidiaVersion = null,

            global::System.Action<global::Together.GPUClusterCreateRequestLegacyNvidia?>? legacyNvidia = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (NvidiaVersion is { } __value0)
            {
                nvidiaVersion?.Invoke(__value0);
            }
            else if (LegacyNvidia is { } __value1)
            {
                legacyNvidia?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Together.GPUClusterCreateRequestNvidiaVersion?>? nvidiaVersion = null,
            global::System.Action<global::Together.GPUClusterCreateRequestLegacyNvidia?>? legacyNvidia = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (NvidiaVersion is { } __value0)
            {
                nvidiaVersion?.Invoke(__value0);
            }
            else if (LegacyNvidia is { } __value1)
            {
                legacyNvidia?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                NvidiaVersion,
                typeof(global::Together.GPUClusterCreateRequestNvidiaVersion),
                LegacyNvidia,
                typeof(global::Together.GPUClusterCreateRequestLegacyNvidia),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(GPUClusterCreateRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Together.GPUClusterCreateRequestNvidiaVersion?>.Default.Equals(NvidiaVersion, other.NvidiaVersion) &&
                global::System.Collections.Generic.EqualityComparer<global::Together.GPUClusterCreateRequestLegacyNvidia?>.Default.Equals(LegacyNvidia, other.LegacyNvidia)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(GPUClusterCreateRequest obj1, GPUClusterCreateRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GPUClusterCreateRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GPUClusterCreateRequest obj1, GPUClusterCreateRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GPUClusterCreateRequest o && Equals(o);
        }
    }
}
