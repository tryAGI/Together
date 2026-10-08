#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// Create a cluster with the legacy CUDA and NVIDIA driver selectors. nvidia_version_id may also be set when it resolves to the same catalog entry.
    /// </summary>
    public readonly partial struct GPUClusterCreateRequestLegacyNvidia : global::System.IEquatable<GPUClusterCreateRequestLegacyNvidia>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.GPUClusterCreateRequestCommon? Common { get; init; }
#else
        public global::Together.GPUClusterCreateRequestCommon? Common { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Common))]
#endif
        public bool IsCommon => Common != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCommon(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Together.GPUClusterCreateRequestCommon? value)
        {
            value = Common;
            return IsCommon;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Together.GPUClusterCreateRequestCommon PickCommon() => Common is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Common' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? GPUClusterCreateRequestLegacyNvidiaVariant2 { get; init; }
#else
        public object? GPUClusterCreateRequestLegacyNvidiaVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GPUClusterCreateRequestLegacyNvidiaVariant2))]
#endif
        public bool IsGPUClusterCreateRequestLegacyNvidiaVariant2 => GPUClusterCreateRequestLegacyNvidiaVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGPUClusterCreateRequestLegacyNvidiaVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = GPUClusterCreateRequestLegacyNvidiaVariant2;
            return IsGPUClusterCreateRequestLegacyNvidiaVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickGPUClusterCreateRequestLegacyNvidiaVariant2() => GPUClusterCreateRequestLegacyNvidiaVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GPUClusterCreateRequestLegacyNvidiaVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator GPUClusterCreateRequestLegacyNvidia(global::Together.GPUClusterCreateRequestCommon value) => new GPUClusterCreateRequestLegacyNvidia((global::Together.GPUClusterCreateRequestCommon?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Together.GPUClusterCreateRequestCommon?(GPUClusterCreateRequestLegacyNvidia @this) => @this.Common;

        /// <summary>
        ///
        /// </summary>
        public GPUClusterCreateRequestLegacyNvidia(global::Together.GPUClusterCreateRequestCommon? value)
        {
            Common = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GPUClusterCreateRequestLegacyNvidia FromCommon(global::Together.GPUClusterCreateRequestCommon? value) => new GPUClusterCreateRequestLegacyNvidia(value);

        /// <summary>
        ///
        /// </summary>
        public GPUClusterCreateRequestLegacyNvidia(
            global::Together.GPUClusterCreateRequestCommon? common,
            object? gPUClusterCreateRequestLegacyNvidiaVariant2
            )
        {
            Common = common;
            GPUClusterCreateRequestLegacyNvidiaVariant2 = gPUClusterCreateRequestLegacyNvidiaVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            GPUClusterCreateRequestLegacyNvidiaVariant2 as object ??
            Common as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Common?.ToString() ??
            GPUClusterCreateRequestLegacyNvidiaVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCommon && IsGPUClusterCreateRequestLegacyNvidiaVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Together.GPUClusterCreateRequestCommon, TResult>? common = null,
            global::System.Func<object, TResult>? gPUClusterCreateRequestLegacyNvidiaVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Common is { } __value0 && common != null)
            {
                return common(__value0);
            }
            else if (GPUClusterCreateRequestLegacyNvidiaVariant2 is { } __value1 && gPUClusterCreateRequestLegacyNvidiaVariant2 != null)
            {
                return gPUClusterCreateRequestLegacyNvidiaVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Together.GPUClusterCreateRequestCommon>? common = null,

            global::System.Action<object>? gPUClusterCreateRequestLegacyNvidiaVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Common is { } __value0)
            {
                common?.Invoke(__value0);
            }
            else if (GPUClusterCreateRequestLegacyNvidiaVariant2 is { } __value1)
            {
                gPUClusterCreateRequestLegacyNvidiaVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Together.GPUClusterCreateRequestCommon>? common = null,
            global::System.Action<object>? gPUClusterCreateRequestLegacyNvidiaVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Common is { } __value0)
            {
                common?.Invoke(__value0);
            }
            else if (GPUClusterCreateRequestLegacyNvidiaVariant2 is { } __value1)
            {
                gPUClusterCreateRequestLegacyNvidiaVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Common,
                typeof(global::Together.GPUClusterCreateRequestCommon),
                GPUClusterCreateRequestLegacyNvidiaVariant2,
                typeof(object),
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
        public bool Equals(GPUClusterCreateRequestLegacyNvidia other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Together.GPUClusterCreateRequestCommon?>.Default.Equals(Common, other.Common) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(GPUClusterCreateRequestLegacyNvidiaVariant2, other.GPUClusterCreateRequestLegacyNvidiaVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(GPUClusterCreateRequestLegacyNvidia obj1, GPUClusterCreateRequestLegacyNvidia obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GPUClusterCreateRequestLegacyNvidia>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GPUClusterCreateRequestLegacyNvidia obj1, GPUClusterCreateRequestLegacyNvidia obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GPUClusterCreateRequestLegacyNvidia o && Equals(o);
        }
    }
}
