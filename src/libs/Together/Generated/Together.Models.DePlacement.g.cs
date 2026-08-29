#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// Placement controls where a deployment is scheduled.
    /// </summary>
    public readonly partial struct DePlacement : global::System.IEquatable<DePlacement>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.DePlacementVariant1? DePlacementVariant1 { get; init; }
#else
        public global::Together.DePlacementVariant1? DePlacementVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DePlacementVariant1))]
#endif
        public bool IsDePlacementVariant1 => DePlacementVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDePlacementVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Together.DePlacementVariant1? value)
        {
            value = DePlacementVariant1;
            return IsDePlacementVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Together.DePlacementVariant1 PickDePlacementVariant1() => IsDePlacementVariant1
            ? DePlacementVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DePlacementVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.DePlacementVariant2? DePlacementVariant2 { get; init; }
#else
        public global::Together.DePlacementVariant2? DePlacementVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DePlacementVariant2))]
#endif
        public bool IsDePlacementVariant2 => DePlacementVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDePlacementVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Together.DePlacementVariant2? value)
        {
            value = DePlacementVariant2;
            return IsDePlacementVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Together.DePlacementVariant2 PickDePlacementVariant2() => IsDePlacementVariant2
            ? DePlacementVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DePlacementVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator DePlacement(global::Together.DePlacementVariant1 value) => new DePlacement((global::Together.DePlacementVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Together.DePlacementVariant1?(DePlacement @this) => @this.DePlacementVariant1;

        /// <summary>
        ///
        /// </summary>
        public DePlacement(global::Together.DePlacementVariant1? value)
        {
            DePlacementVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DePlacement FromDePlacementVariant1(global::Together.DePlacementVariant1? value) => new DePlacement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator DePlacement(global::Together.DePlacementVariant2 value) => new DePlacement((global::Together.DePlacementVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Together.DePlacementVariant2?(DePlacement @this) => @this.DePlacementVariant2;

        /// <summary>
        ///
        /// </summary>
        public DePlacement(global::Together.DePlacementVariant2? value)
        {
            DePlacementVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DePlacement FromDePlacementVariant2(global::Together.DePlacementVariant2? value) => new DePlacement(value);

        /// <summary>
        ///
        /// </summary>
        public DePlacement(
            global::Together.DePlacementVariant1? dePlacementVariant1,
            global::Together.DePlacementVariant2? dePlacementVariant2
            )
        {
            DePlacementVariant1 = dePlacementVariant1;
            DePlacementVariant2 = dePlacementVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            DePlacementVariant2 as object ??
            DePlacementVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            DePlacementVariant1?.ToString() ??
            DePlacementVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsDePlacementVariant1 && !IsDePlacementVariant2 || !IsDePlacementVariant1 && IsDePlacementVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Together.DePlacementVariant1, TResult>? dePlacementVariant1 = null,
            global::System.Func<global::Together.DePlacementVariant2, TResult>? dePlacementVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDePlacementVariant1 && dePlacementVariant1 != null)
            {
                return dePlacementVariant1(DePlacementVariant1!);
            }
            else if (IsDePlacementVariant2 && dePlacementVariant2 != null)
            {
                return dePlacementVariant2(DePlacementVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Together.DePlacementVariant1>? dePlacementVariant1 = null,

            global::System.Action<global::Together.DePlacementVariant2>? dePlacementVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDePlacementVariant1)
            {
                dePlacementVariant1?.Invoke(DePlacementVariant1!);
            }
            else if (IsDePlacementVariant2)
            {
                dePlacementVariant2?.Invoke(DePlacementVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Together.DePlacementVariant1>? dePlacementVariant1 = null,
            global::System.Action<global::Together.DePlacementVariant2>? dePlacementVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDePlacementVariant1)
            {
                dePlacementVariant1?.Invoke(DePlacementVariant1!);
            }
            else if (IsDePlacementVariant2)
            {
                dePlacementVariant2?.Invoke(DePlacementVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                DePlacementVariant1,
                typeof(global::Together.DePlacementVariant1),
                DePlacementVariant2,
                typeof(global::Together.DePlacementVariant2),
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
        public bool Equals(DePlacement other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Together.DePlacementVariant1?>.Default.Equals(DePlacementVariant1, other.DePlacementVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Together.DePlacementVariant2?>.Default.Equals(DePlacementVariant2, other.DePlacementVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(DePlacement obj1, DePlacement obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DePlacement>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(DePlacement obj1, DePlacement obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DePlacement o && Equals(o);
        }
    }
}
