#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// Sampling strategy for endpoint-level shadow traffic. Exactly one strategy must be set.
    /// </summary>
    public readonly partial struct DeShadowExperimentSampling : global::System.IEquatable<DeShadowExperimentSampling>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.DeShadowExperimentSamplingVariant1? DeShadowExperimentSamplingVariant1 { get; init; }
#else
        public global::Together.DeShadowExperimentSamplingVariant1? DeShadowExperimentSamplingVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeShadowExperimentSamplingVariant1))]
#endif
        public bool IsDeShadowExperimentSamplingVariant1 => DeShadowExperimentSamplingVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDeShadowExperimentSamplingVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Together.DeShadowExperimentSamplingVariant1? value)
        {
            value = DeShadowExperimentSamplingVariant1;
            return IsDeShadowExperimentSamplingVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Together.DeShadowExperimentSamplingVariant1 PickDeShadowExperimentSamplingVariant1() => IsDeShadowExperimentSamplingVariant1
            ? DeShadowExperimentSamplingVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DeShadowExperimentSamplingVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.DeShadowExperimentSamplingVariant2? DeShadowExperimentSamplingVariant2 { get; init; }
#else
        public global::Together.DeShadowExperimentSamplingVariant2? DeShadowExperimentSamplingVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeShadowExperimentSamplingVariant2))]
#endif
        public bool IsDeShadowExperimentSamplingVariant2 => DeShadowExperimentSamplingVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDeShadowExperimentSamplingVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Together.DeShadowExperimentSamplingVariant2? value)
        {
            value = DeShadowExperimentSamplingVariant2;
            return IsDeShadowExperimentSamplingVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Together.DeShadowExperimentSamplingVariant2 PickDeShadowExperimentSamplingVariant2() => IsDeShadowExperimentSamplingVariant2
            ? DeShadowExperimentSamplingVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DeShadowExperimentSamplingVariant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.DeShadowExperimentSamplingVariant3? DeShadowExperimentSamplingVariant3 { get; init; }
#else
        public global::Together.DeShadowExperimentSamplingVariant3? DeShadowExperimentSamplingVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeShadowExperimentSamplingVariant3))]
#endif
        public bool IsDeShadowExperimentSamplingVariant3 => DeShadowExperimentSamplingVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDeShadowExperimentSamplingVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Together.DeShadowExperimentSamplingVariant3? value)
        {
            value = DeShadowExperimentSamplingVariant3;
            return IsDeShadowExperimentSamplingVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Together.DeShadowExperimentSamplingVariant3 PickDeShadowExperimentSamplingVariant3() => IsDeShadowExperimentSamplingVariant3
            ? DeShadowExperimentSamplingVariant3!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DeShadowExperimentSamplingVariant3' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.DeShadowExperimentSamplingVariant4? DeShadowExperimentSamplingVariant4 { get; init; }
#else
        public global::Together.DeShadowExperimentSamplingVariant4? DeShadowExperimentSamplingVariant4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeShadowExperimentSamplingVariant4))]
#endif
        public bool IsDeShadowExperimentSamplingVariant4 => DeShadowExperimentSamplingVariant4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDeShadowExperimentSamplingVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Together.DeShadowExperimentSamplingVariant4? value)
        {
            value = DeShadowExperimentSamplingVariant4;
            return IsDeShadowExperimentSamplingVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Together.DeShadowExperimentSamplingVariant4 PickDeShadowExperimentSamplingVariant4() => IsDeShadowExperimentSamplingVariant4
            ? DeShadowExperimentSamplingVariant4!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DeShadowExperimentSamplingVariant4' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator DeShadowExperimentSampling(global::Together.DeShadowExperimentSamplingVariant1 value) => new DeShadowExperimentSampling((global::Together.DeShadowExperimentSamplingVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Together.DeShadowExperimentSamplingVariant1?(DeShadowExperimentSampling @this) => @this.DeShadowExperimentSamplingVariant1;

        /// <summary>
        ///
        /// </summary>
        public DeShadowExperimentSampling(global::Together.DeShadowExperimentSamplingVariant1? value)
        {
            DeShadowExperimentSamplingVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DeShadowExperimentSampling FromDeShadowExperimentSamplingVariant1(global::Together.DeShadowExperimentSamplingVariant1? value) => new DeShadowExperimentSampling(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator DeShadowExperimentSampling(global::Together.DeShadowExperimentSamplingVariant2 value) => new DeShadowExperimentSampling((global::Together.DeShadowExperimentSamplingVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Together.DeShadowExperimentSamplingVariant2?(DeShadowExperimentSampling @this) => @this.DeShadowExperimentSamplingVariant2;

        /// <summary>
        ///
        /// </summary>
        public DeShadowExperimentSampling(global::Together.DeShadowExperimentSamplingVariant2? value)
        {
            DeShadowExperimentSamplingVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DeShadowExperimentSampling FromDeShadowExperimentSamplingVariant2(global::Together.DeShadowExperimentSamplingVariant2? value) => new DeShadowExperimentSampling(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator DeShadowExperimentSampling(global::Together.DeShadowExperimentSamplingVariant3 value) => new DeShadowExperimentSampling((global::Together.DeShadowExperimentSamplingVariant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Together.DeShadowExperimentSamplingVariant3?(DeShadowExperimentSampling @this) => @this.DeShadowExperimentSamplingVariant3;

        /// <summary>
        ///
        /// </summary>
        public DeShadowExperimentSampling(global::Together.DeShadowExperimentSamplingVariant3? value)
        {
            DeShadowExperimentSamplingVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DeShadowExperimentSampling FromDeShadowExperimentSamplingVariant3(global::Together.DeShadowExperimentSamplingVariant3? value) => new DeShadowExperimentSampling(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator DeShadowExperimentSampling(global::Together.DeShadowExperimentSamplingVariant4 value) => new DeShadowExperimentSampling((global::Together.DeShadowExperimentSamplingVariant4?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Together.DeShadowExperimentSamplingVariant4?(DeShadowExperimentSampling @this) => @this.DeShadowExperimentSamplingVariant4;

        /// <summary>
        ///
        /// </summary>
        public DeShadowExperimentSampling(global::Together.DeShadowExperimentSamplingVariant4? value)
        {
            DeShadowExperimentSamplingVariant4 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DeShadowExperimentSampling FromDeShadowExperimentSamplingVariant4(global::Together.DeShadowExperimentSamplingVariant4? value) => new DeShadowExperimentSampling(value);

        /// <summary>
        ///
        /// </summary>
        public DeShadowExperimentSampling(
            global::Together.DeShadowExperimentSamplingVariant1? deShadowExperimentSamplingVariant1,
            global::Together.DeShadowExperimentSamplingVariant2? deShadowExperimentSamplingVariant2,
            global::Together.DeShadowExperimentSamplingVariant3? deShadowExperimentSamplingVariant3,
            global::Together.DeShadowExperimentSamplingVariant4? deShadowExperimentSamplingVariant4
            )
        {
            DeShadowExperimentSamplingVariant1 = deShadowExperimentSamplingVariant1;
            DeShadowExperimentSamplingVariant2 = deShadowExperimentSamplingVariant2;
            DeShadowExperimentSamplingVariant3 = deShadowExperimentSamplingVariant3;
            DeShadowExperimentSamplingVariant4 = deShadowExperimentSamplingVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            DeShadowExperimentSamplingVariant4 as object ??
            DeShadowExperimentSamplingVariant3 as object ??
            DeShadowExperimentSamplingVariant2 as object ??
            DeShadowExperimentSamplingVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            DeShadowExperimentSamplingVariant1?.ToString() ??
            DeShadowExperimentSamplingVariant2?.ToString() ??
            DeShadowExperimentSamplingVariant3?.ToString() ??
            DeShadowExperimentSamplingVariant4?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsDeShadowExperimentSamplingVariant1 && !IsDeShadowExperimentSamplingVariant2 && !IsDeShadowExperimentSamplingVariant3 && !IsDeShadowExperimentSamplingVariant4 || !IsDeShadowExperimentSamplingVariant1 && IsDeShadowExperimentSamplingVariant2 && !IsDeShadowExperimentSamplingVariant3 && !IsDeShadowExperimentSamplingVariant4 || !IsDeShadowExperimentSamplingVariant1 && !IsDeShadowExperimentSamplingVariant2 && IsDeShadowExperimentSamplingVariant3 && !IsDeShadowExperimentSamplingVariant4 || !IsDeShadowExperimentSamplingVariant1 && !IsDeShadowExperimentSamplingVariant2 && !IsDeShadowExperimentSamplingVariant3 && IsDeShadowExperimentSamplingVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Together.DeShadowExperimentSamplingVariant1, TResult>? deShadowExperimentSamplingVariant1 = null,
            global::System.Func<global::Together.DeShadowExperimentSamplingVariant2, TResult>? deShadowExperimentSamplingVariant2 = null,
            global::System.Func<global::Together.DeShadowExperimentSamplingVariant3, TResult>? deShadowExperimentSamplingVariant3 = null,
            global::System.Func<global::Together.DeShadowExperimentSamplingVariant4, TResult>? deShadowExperimentSamplingVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDeShadowExperimentSamplingVariant1 && deShadowExperimentSamplingVariant1 != null)
            {
                return deShadowExperimentSamplingVariant1(DeShadowExperimentSamplingVariant1!);
            }
            else if (IsDeShadowExperimentSamplingVariant2 && deShadowExperimentSamplingVariant2 != null)
            {
                return deShadowExperimentSamplingVariant2(DeShadowExperimentSamplingVariant2!);
            }
            else if (IsDeShadowExperimentSamplingVariant3 && deShadowExperimentSamplingVariant3 != null)
            {
                return deShadowExperimentSamplingVariant3(DeShadowExperimentSamplingVariant3!);
            }
            else if (IsDeShadowExperimentSamplingVariant4 && deShadowExperimentSamplingVariant4 != null)
            {
                return deShadowExperimentSamplingVariant4(DeShadowExperimentSamplingVariant4!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Together.DeShadowExperimentSamplingVariant1>? deShadowExperimentSamplingVariant1 = null,

            global::System.Action<global::Together.DeShadowExperimentSamplingVariant2>? deShadowExperimentSamplingVariant2 = null,

            global::System.Action<global::Together.DeShadowExperimentSamplingVariant3>? deShadowExperimentSamplingVariant3 = null,

            global::System.Action<global::Together.DeShadowExperimentSamplingVariant4>? deShadowExperimentSamplingVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDeShadowExperimentSamplingVariant1)
            {
                deShadowExperimentSamplingVariant1?.Invoke(DeShadowExperimentSamplingVariant1!);
            }
            else if (IsDeShadowExperimentSamplingVariant2)
            {
                deShadowExperimentSamplingVariant2?.Invoke(DeShadowExperimentSamplingVariant2!);
            }
            else if (IsDeShadowExperimentSamplingVariant3)
            {
                deShadowExperimentSamplingVariant3?.Invoke(DeShadowExperimentSamplingVariant3!);
            }
            else if (IsDeShadowExperimentSamplingVariant4)
            {
                deShadowExperimentSamplingVariant4?.Invoke(DeShadowExperimentSamplingVariant4!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Together.DeShadowExperimentSamplingVariant1>? deShadowExperimentSamplingVariant1 = null,
            global::System.Action<global::Together.DeShadowExperimentSamplingVariant2>? deShadowExperimentSamplingVariant2 = null,
            global::System.Action<global::Together.DeShadowExperimentSamplingVariant3>? deShadowExperimentSamplingVariant3 = null,
            global::System.Action<global::Together.DeShadowExperimentSamplingVariant4>? deShadowExperimentSamplingVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDeShadowExperimentSamplingVariant1)
            {
                deShadowExperimentSamplingVariant1?.Invoke(DeShadowExperimentSamplingVariant1!);
            }
            else if (IsDeShadowExperimentSamplingVariant2)
            {
                deShadowExperimentSamplingVariant2?.Invoke(DeShadowExperimentSamplingVariant2!);
            }
            else if (IsDeShadowExperimentSamplingVariant3)
            {
                deShadowExperimentSamplingVariant3?.Invoke(DeShadowExperimentSamplingVariant3!);
            }
            else if (IsDeShadowExperimentSamplingVariant4)
            {
                deShadowExperimentSamplingVariant4?.Invoke(DeShadowExperimentSamplingVariant4!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                DeShadowExperimentSamplingVariant1,
                typeof(global::Together.DeShadowExperimentSamplingVariant1),
                DeShadowExperimentSamplingVariant2,
                typeof(global::Together.DeShadowExperimentSamplingVariant2),
                DeShadowExperimentSamplingVariant3,
                typeof(global::Together.DeShadowExperimentSamplingVariant3),
                DeShadowExperimentSamplingVariant4,
                typeof(global::Together.DeShadowExperimentSamplingVariant4),
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
        public bool Equals(DeShadowExperimentSampling other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Together.DeShadowExperimentSamplingVariant1?>.Default.Equals(DeShadowExperimentSamplingVariant1, other.DeShadowExperimentSamplingVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Together.DeShadowExperimentSamplingVariant2?>.Default.Equals(DeShadowExperimentSamplingVariant2, other.DeShadowExperimentSamplingVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Together.DeShadowExperimentSamplingVariant3?>.Default.Equals(DeShadowExperimentSamplingVariant3, other.DeShadowExperimentSamplingVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Together.DeShadowExperimentSamplingVariant4?>.Default.Equals(DeShadowExperimentSamplingVariant4, other.DeShadowExperimentSamplingVariant4)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(DeShadowExperimentSampling obj1, DeShadowExperimentSampling obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DeShadowExperimentSampling>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(DeShadowExperimentSampling obj1, DeShadowExperimentSampling obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DeShadowExperimentSampling o && Equals(o);
        }
    }
}
