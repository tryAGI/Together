#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// Resolved autoscaling configuration returned for a deployment.
    /// </summary>
    public readonly partial struct DeAutoscalingResponse : global::System.IEquatable<DeAutoscalingResponse>
    {
        /// <summary>
        /// Autoscaling configuration for a deployment.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.DeAutoscaling? DeAutoscaling { get; init; }
#else
        public global::Together.DeAutoscaling? DeAutoscaling { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeAutoscaling))]
#endif
        public bool IsDeAutoscaling => DeAutoscaling != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDeAutoscaling(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Together.DeAutoscaling? value)
        {
            value = DeAutoscaling;
            return IsDeAutoscaling;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Together.DeAutoscaling PickDeAutoscaling() => IsDeAutoscaling
            ? DeAutoscaling!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DeAutoscaling' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? DeAutoscalingResponseVariant2 { get; init; }
#else
        public object? DeAutoscalingResponseVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeAutoscalingResponseVariant2))]
#endif
        public bool IsDeAutoscalingResponseVariant2 => DeAutoscalingResponseVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDeAutoscalingResponseVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = DeAutoscalingResponseVariant2;
            return IsDeAutoscalingResponseVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickDeAutoscalingResponseVariant2() => IsDeAutoscalingResponseVariant2
            ? DeAutoscalingResponseVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DeAutoscalingResponseVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator DeAutoscalingResponse(global::Together.DeAutoscaling value) => new DeAutoscalingResponse((global::Together.DeAutoscaling?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Together.DeAutoscaling?(DeAutoscalingResponse @this) => @this.DeAutoscaling;

        /// <summary>
        ///
        /// </summary>
        public DeAutoscalingResponse(global::Together.DeAutoscaling? value)
        {
            DeAutoscaling = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DeAutoscalingResponse FromDeAutoscaling(global::Together.DeAutoscaling? value) => new DeAutoscalingResponse(value);

        /// <summary>
        ///
        /// </summary>
        public DeAutoscalingResponse(
            global::Together.DeAutoscaling? deAutoscaling,
            object? deAutoscalingResponseVariant2
            )
        {
            DeAutoscaling = deAutoscaling;
            DeAutoscalingResponseVariant2 = deAutoscalingResponseVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            DeAutoscalingResponseVariant2 as object ??
            DeAutoscaling as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            DeAutoscaling?.ToString() ??
            DeAutoscalingResponseVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsDeAutoscaling && IsDeAutoscalingResponseVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Together.DeAutoscaling, TResult>? deAutoscaling = null,
            global::System.Func<object, TResult>? deAutoscalingResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDeAutoscaling && deAutoscaling != null)
            {
                return deAutoscaling(DeAutoscaling!);
            }
            else if (IsDeAutoscalingResponseVariant2 && deAutoscalingResponseVariant2 != null)
            {
                return deAutoscalingResponseVariant2(DeAutoscalingResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Together.DeAutoscaling>? deAutoscaling = null,

            global::System.Action<object>? deAutoscalingResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDeAutoscaling)
            {
                deAutoscaling?.Invoke(DeAutoscaling!);
            }
            else if (IsDeAutoscalingResponseVariant2)
            {
                deAutoscalingResponseVariant2?.Invoke(DeAutoscalingResponseVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Together.DeAutoscaling>? deAutoscaling = null,
            global::System.Action<object>? deAutoscalingResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDeAutoscaling)
            {
                deAutoscaling?.Invoke(DeAutoscaling!);
            }
            else if (IsDeAutoscalingResponseVariant2)
            {
                deAutoscalingResponseVariant2?.Invoke(DeAutoscalingResponseVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                DeAutoscaling,
                typeof(global::Together.DeAutoscaling),
                DeAutoscalingResponseVariant2,
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
        public bool Equals(DeAutoscalingResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Together.DeAutoscaling?>.Default.Equals(DeAutoscaling, other.DeAutoscaling) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(DeAutoscalingResponseVariant2, other.DeAutoscalingResponseVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(DeAutoscalingResponse obj1, DeAutoscalingResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DeAutoscalingResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(DeAutoscalingResponse obj1, DeAutoscalingResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DeAutoscalingResponse o && Equals(o);
        }
    }
}
