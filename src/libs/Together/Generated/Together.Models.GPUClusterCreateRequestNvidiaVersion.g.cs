#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// Create a cluster with a canonical NVIDIA version id. Do not also set cuda_version or nvidia_driver_version.
    /// </summary>
    public readonly partial struct GPUClusterCreateRequestNvidiaVersion : global::System.IEquatable<GPUClusterCreateRequestNvidiaVersion>
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
        public object? GPUClusterCreateRequestNvidiaVersionVariant2 { get; init; }
#else
        public object? GPUClusterCreateRequestNvidiaVersionVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GPUClusterCreateRequestNvidiaVersionVariant2))]
#endif
        public bool IsGPUClusterCreateRequestNvidiaVersionVariant2 => GPUClusterCreateRequestNvidiaVersionVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGPUClusterCreateRequestNvidiaVersionVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = GPUClusterCreateRequestNvidiaVersionVariant2;
            return IsGPUClusterCreateRequestNvidiaVersionVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickGPUClusterCreateRequestNvidiaVersionVariant2() => GPUClusterCreateRequestNvidiaVersionVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GPUClusterCreateRequestNvidiaVersionVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator GPUClusterCreateRequestNvidiaVersion(global::Together.GPUClusterCreateRequestCommon value) => new GPUClusterCreateRequestNvidiaVersion((global::Together.GPUClusterCreateRequestCommon?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Together.GPUClusterCreateRequestCommon?(GPUClusterCreateRequestNvidiaVersion @this) => @this.Common;

        /// <summary>
        ///
        /// </summary>
        public GPUClusterCreateRequestNvidiaVersion(global::Together.GPUClusterCreateRequestCommon? value)
        {
            Common = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GPUClusterCreateRequestNvidiaVersion FromCommon(global::Together.GPUClusterCreateRequestCommon? value) => new GPUClusterCreateRequestNvidiaVersion(value);

        /// <summary>
        ///
        /// </summary>
        public GPUClusterCreateRequestNvidiaVersion(
            global::Together.GPUClusterCreateRequestCommon? common,
            object? gPUClusterCreateRequestNvidiaVersionVariant2
            )
        {
            Common = common;
            GPUClusterCreateRequestNvidiaVersionVariant2 = gPUClusterCreateRequestNvidiaVersionVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            GPUClusterCreateRequestNvidiaVersionVariant2 as object ??
            Common as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Common?.ToString() ??
            GPUClusterCreateRequestNvidiaVersionVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCommon && IsGPUClusterCreateRequestNvidiaVersionVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Together.GPUClusterCreateRequestCommon, TResult>? common = null,
            global::System.Func<object, TResult>? gPUClusterCreateRequestNvidiaVersionVariant2 = null,
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
            else if (GPUClusterCreateRequestNvidiaVersionVariant2 is { } __value1 && gPUClusterCreateRequestNvidiaVersionVariant2 != null)
            {
                return gPUClusterCreateRequestNvidiaVersionVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Together.GPUClusterCreateRequestCommon>? common = null,

            global::System.Action<object>? gPUClusterCreateRequestNvidiaVersionVariant2 = null,
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
            else if (GPUClusterCreateRequestNvidiaVersionVariant2 is { } __value1)
            {
                gPUClusterCreateRequestNvidiaVersionVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Together.GPUClusterCreateRequestCommon>? common = null,
            global::System.Action<object>? gPUClusterCreateRequestNvidiaVersionVariant2 = null,
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
            else if (GPUClusterCreateRequestNvidiaVersionVariant2 is { } __value1)
            {
                gPUClusterCreateRequestNvidiaVersionVariant2?.Invoke(__value1);
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
                GPUClusterCreateRequestNvidiaVersionVariant2,
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
        public bool Equals(GPUClusterCreateRequestNvidiaVersion other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Together.GPUClusterCreateRequestCommon?>.Default.Equals(Common, other.Common) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(GPUClusterCreateRequestNvidiaVersionVariant2, other.GPUClusterCreateRequestNvidiaVersionVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(GPUClusterCreateRequestNvidiaVersion obj1, GPUClusterCreateRequestNvidiaVersion obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GPUClusterCreateRequestNvidiaVersion>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GPUClusterCreateRequestNvidiaVersion obj1, GPUClusterCreateRequestNvidiaVersion obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GPUClusterCreateRequestNvidiaVersion o && Equals(o);
        }
    }
}
