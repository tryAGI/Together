#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// Quantization job that prepares an adapter for FP4 inference.
    /// </summary>
    public readonly partial struct QuantizationJob : global::System.IEquatable<QuantizationJob>
    {
        /// <summary>
        /// Public fields common to shaping jobs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.BaseShapingJob? BaseShaping { get; init; }
#else
        public global::Together.BaseShapingJob? BaseShaping { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseShaping))]
#endif
        public bool IsBaseShaping => BaseShaping != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBaseShaping(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Together.BaseShapingJob? value)
        {
            value = BaseShaping;
            return IsBaseShaping;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Together.BaseShapingJob PickBaseShaping() => BaseShaping is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BaseShaping' but the value was {ToString()}.");

        /// <summary>
        /// Quantization job that prepares an adapter for FP4 inference.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.QuantizationJobVariant2? QuantizationJobVariant2 { get; init; }
#else
        public global::Together.QuantizationJobVariant2? QuantizationJobVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(QuantizationJobVariant2))]
#endif
        public bool IsQuantizationJobVariant2 => QuantizationJobVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickQuantizationJobVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Together.QuantizationJobVariant2? value)
        {
            value = QuantizationJobVariant2;
            return IsQuantizationJobVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Together.QuantizationJobVariant2 PickQuantizationJobVariant2() => QuantizationJobVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'QuantizationJobVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator QuantizationJob(global::Together.BaseShapingJob value) => new QuantizationJob((global::Together.BaseShapingJob?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Together.BaseShapingJob?(QuantizationJob @this) => @this.BaseShaping;

        /// <summary>
        ///
        /// </summary>
        public QuantizationJob(global::Together.BaseShapingJob? value)
        {
            BaseShaping = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static QuantizationJob FromBaseShaping(global::Together.BaseShapingJob? value) => new QuantizationJob(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator QuantizationJob(global::Together.QuantizationJobVariant2 value) => new QuantizationJob((global::Together.QuantizationJobVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Together.QuantizationJobVariant2?(QuantizationJob @this) => @this.QuantizationJobVariant2;

        /// <summary>
        ///
        /// </summary>
        public QuantizationJob(global::Together.QuantizationJobVariant2? value)
        {
            QuantizationJobVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static QuantizationJob FromQuantizationJobVariant2(global::Together.QuantizationJobVariant2? value) => new QuantizationJob(value);

        /// <summary>
        ///
        /// </summary>
        public QuantizationJob(
            global::Together.BaseShapingJob? baseShaping,
            global::Together.QuantizationJobVariant2? quantizationJobVariant2
            )
        {
            BaseShaping = baseShaping;
            QuantizationJobVariant2 = quantizationJobVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            QuantizationJobVariant2 as object ??
            BaseShaping as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            BaseShaping?.ToString() ??
            QuantizationJobVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBaseShaping && IsQuantizationJobVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Together.BaseShapingJob, TResult>? baseShaping = null,
            global::System.Func<global::Together.QuantizationJobVariant2, TResult>? quantizationJobVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BaseShaping is { } __value0 && baseShaping != null)
            {
                return baseShaping(__value0);
            }
            else if (QuantizationJobVariant2 is { } __value1 && quantizationJobVariant2 != null)
            {
                return quantizationJobVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Together.BaseShapingJob>? baseShaping = null,

            global::System.Action<global::Together.QuantizationJobVariant2>? quantizationJobVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BaseShaping is { } __value0)
            {
                baseShaping?.Invoke(__value0);
            }
            else if (QuantizationJobVariant2 is { } __value1)
            {
                quantizationJobVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Together.BaseShapingJob>? baseShaping = null,
            global::System.Action<global::Together.QuantizationJobVariant2>? quantizationJobVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BaseShaping is { } __value0)
            {
                baseShaping?.Invoke(__value0);
            }
            else if (QuantizationJobVariant2 is { } __value1)
            {
                quantizationJobVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BaseShaping,
                typeof(global::Together.BaseShapingJob),
                QuantizationJobVariant2,
                typeof(global::Together.QuantizationJobVariant2),
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
        public bool Equals(QuantizationJob other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Together.BaseShapingJob?>.Default.Equals(BaseShaping, other.BaseShaping) &&
                global::System.Collections.Generic.EqualityComparer<global::Together.QuantizationJobVariant2?>.Default.Equals(QuantizationJobVariant2, other.QuantizationJobVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(QuantizationJob obj1, QuantizationJob obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<QuantizationJob>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(QuantizationJob obj1, QuantizationJob obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is QuantizationJob o && Equals(o);
        }
    }
}
