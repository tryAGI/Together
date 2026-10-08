#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// Event emitted by a quantization job.
    /// </summary>
    public readonly partial struct QuantizationEvent : global::System.IEquatable<QuantizationEvent>
    {
        /// <summary>
        /// Public fields common to shaping events.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.BaseShapingEvent? BaseShaping { get; init; }
#else
        public global::Together.BaseShapingEvent? BaseShaping { get; }
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
            out global::Together.BaseShapingEvent? value)
        {
            value = BaseShaping;
            return IsBaseShaping;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Together.BaseShapingEvent PickBaseShaping() => BaseShaping is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BaseShaping' but the value was {ToString()}.");

        /// <summary>
        /// Event emitted by a quantization job.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.QuantizationEventVariant2? QuantizationEventVariant2 { get; init; }
#else
        public global::Together.QuantizationEventVariant2? QuantizationEventVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(QuantizationEventVariant2))]
#endif
        public bool IsQuantizationEventVariant2 => QuantizationEventVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickQuantizationEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Together.QuantizationEventVariant2? value)
        {
            value = QuantizationEventVariant2;
            return IsQuantizationEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Together.QuantizationEventVariant2 PickQuantizationEventVariant2() => QuantizationEventVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'QuantizationEventVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator QuantizationEvent(global::Together.BaseShapingEvent value) => new QuantizationEvent((global::Together.BaseShapingEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Together.BaseShapingEvent?(QuantizationEvent @this) => @this.BaseShaping;

        /// <summary>
        ///
        /// </summary>
        public QuantizationEvent(global::Together.BaseShapingEvent? value)
        {
            BaseShaping = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static QuantizationEvent FromBaseShaping(global::Together.BaseShapingEvent? value) => new QuantizationEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator QuantizationEvent(global::Together.QuantizationEventVariant2 value) => new QuantizationEvent((global::Together.QuantizationEventVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Together.QuantizationEventVariant2?(QuantizationEvent @this) => @this.QuantizationEventVariant2;

        /// <summary>
        ///
        /// </summary>
        public QuantizationEvent(global::Together.QuantizationEventVariant2? value)
        {
            QuantizationEventVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static QuantizationEvent FromQuantizationEventVariant2(global::Together.QuantizationEventVariant2? value) => new QuantizationEvent(value);

        /// <summary>
        ///
        /// </summary>
        public QuantizationEvent(
            global::Together.BaseShapingEvent? baseShaping,
            global::Together.QuantizationEventVariant2? quantizationEventVariant2
            )
        {
            BaseShaping = baseShaping;
            QuantizationEventVariant2 = quantizationEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            QuantizationEventVariant2 as object ??
            BaseShaping as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            BaseShaping?.ToString() ??
            QuantizationEventVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBaseShaping && IsQuantizationEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Together.BaseShapingEvent, TResult>? baseShaping = null,
            global::System.Func<global::Together.QuantizationEventVariant2, TResult>? quantizationEventVariant2 = null,
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
            else if (QuantizationEventVariant2 is { } __value1 && quantizationEventVariant2 != null)
            {
                return quantizationEventVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Together.BaseShapingEvent>? baseShaping = null,

            global::System.Action<global::Together.QuantizationEventVariant2>? quantizationEventVariant2 = null,
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
            else if (QuantizationEventVariant2 is { } __value1)
            {
                quantizationEventVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Together.BaseShapingEvent>? baseShaping = null,
            global::System.Action<global::Together.QuantizationEventVariant2>? quantizationEventVariant2 = null,
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
            else if (QuantizationEventVariant2 is { } __value1)
            {
                quantizationEventVariant2?.Invoke(__value1);
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
                typeof(global::Together.BaseShapingEvent),
                QuantizationEventVariant2,
                typeof(global::Together.QuantizationEventVariant2),
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
        public bool Equals(QuantizationEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Together.BaseShapingEvent?>.Default.Equals(BaseShaping, other.BaseShaping) &&
                global::System.Collections.Generic.EqualityComparer<global::Together.QuantizationEventVariant2?>.Default.Equals(QuantizationEventVariant2, other.QuantizationEventVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(QuantizationEvent obj1, QuantizationEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<QuantizationEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(QuantizationEvent obj1, QuantizationEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is QuantizationEvent o && Equals(o);
        }
    }
}
