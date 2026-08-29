#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// Sampling strategy returned for endpoint-level shadow traffic.
    /// </summary>
    public readonly partial struct DeShadowExperimentSamplingResponse : global::System.IEquatable<DeShadowExperimentSamplingResponse>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.DeShadowExperimentSamplingResponseVariant1? DeShadowExperimentSamplingResponseVariant1 { get; init; }
#else
        public global::Together.DeShadowExperimentSamplingResponseVariant1? DeShadowExperimentSamplingResponseVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeShadowExperimentSamplingResponseVariant1))]
#endif
        public bool IsDeShadowExperimentSamplingResponseVariant1 => DeShadowExperimentSamplingResponseVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDeShadowExperimentSamplingResponseVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Together.DeShadowExperimentSamplingResponseVariant1? value)
        {
            value = DeShadowExperimentSamplingResponseVariant1;
            return IsDeShadowExperimentSamplingResponseVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Together.DeShadowExperimentSamplingResponseVariant1 PickDeShadowExperimentSamplingResponseVariant1() => IsDeShadowExperimentSamplingResponseVariant1
            ? DeShadowExperimentSamplingResponseVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DeShadowExperimentSamplingResponseVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.DeShadowExperimentSamplingResponseVariant2? DeShadowExperimentSamplingResponseVariant2 { get; init; }
#else
        public global::Together.DeShadowExperimentSamplingResponseVariant2? DeShadowExperimentSamplingResponseVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeShadowExperimentSamplingResponseVariant2))]
#endif
        public bool IsDeShadowExperimentSamplingResponseVariant2 => DeShadowExperimentSamplingResponseVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDeShadowExperimentSamplingResponseVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Together.DeShadowExperimentSamplingResponseVariant2? value)
        {
            value = DeShadowExperimentSamplingResponseVariant2;
            return IsDeShadowExperimentSamplingResponseVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Together.DeShadowExperimentSamplingResponseVariant2 PickDeShadowExperimentSamplingResponseVariant2() => IsDeShadowExperimentSamplingResponseVariant2
            ? DeShadowExperimentSamplingResponseVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DeShadowExperimentSamplingResponseVariant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.DeShadowExperimentSamplingResponseVariant3? DeShadowExperimentSamplingResponseVariant3 { get; init; }
#else
        public global::Together.DeShadowExperimentSamplingResponseVariant3? DeShadowExperimentSamplingResponseVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeShadowExperimentSamplingResponseVariant3))]
#endif
        public bool IsDeShadowExperimentSamplingResponseVariant3 => DeShadowExperimentSamplingResponseVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDeShadowExperimentSamplingResponseVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Together.DeShadowExperimentSamplingResponseVariant3? value)
        {
            value = DeShadowExperimentSamplingResponseVariant3;
            return IsDeShadowExperimentSamplingResponseVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Together.DeShadowExperimentSamplingResponseVariant3 PickDeShadowExperimentSamplingResponseVariant3() => IsDeShadowExperimentSamplingResponseVariant3
            ? DeShadowExperimentSamplingResponseVariant3!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DeShadowExperimentSamplingResponseVariant3' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.DeShadowExperimentSamplingResponseVariant4? DeShadowExperimentSamplingResponseVariant4 { get; init; }
#else
        public global::Together.DeShadowExperimentSamplingResponseVariant4? DeShadowExperimentSamplingResponseVariant4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeShadowExperimentSamplingResponseVariant4))]
#endif
        public bool IsDeShadowExperimentSamplingResponseVariant4 => DeShadowExperimentSamplingResponseVariant4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDeShadowExperimentSamplingResponseVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Together.DeShadowExperimentSamplingResponseVariant4? value)
        {
            value = DeShadowExperimentSamplingResponseVariant4;
            return IsDeShadowExperimentSamplingResponseVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Together.DeShadowExperimentSamplingResponseVariant4 PickDeShadowExperimentSamplingResponseVariant4() => IsDeShadowExperimentSamplingResponseVariant4
            ? DeShadowExperimentSamplingResponseVariant4!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DeShadowExperimentSamplingResponseVariant4' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator DeShadowExperimentSamplingResponse(global::Together.DeShadowExperimentSamplingResponseVariant1 value) => new DeShadowExperimentSamplingResponse((global::Together.DeShadowExperimentSamplingResponseVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Together.DeShadowExperimentSamplingResponseVariant1?(DeShadowExperimentSamplingResponse @this) => @this.DeShadowExperimentSamplingResponseVariant1;

        /// <summary>
        ///
        /// </summary>
        public DeShadowExperimentSamplingResponse(global::Together.DeShadowExperimentSamplingResponseVariant1? value)
        {
            DeShadowExperimentSamplingResponseVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DeShadowExperimentSamplingResponse FromDeShadowExperimentSamplingResponseVariant1(global::Together.DeShadowExperimentSamplingResponseVariant1? value) => new DeShadowExperimentSamplingResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator DeShadowExperimentSamplingResponse(global::Together.DeShadowExperimentSamplingResponseVariant2 value) => new DeShadowExperimentSamplingResponse((global::Together.DeShadowExperimentSamplingResponseVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Together.DeShadowExperimentSamplingResponseVariant2?(DeShadowExperimentSamplingResponse @this) => @this.DeShadowExperimentSamplingResponseVariant2;

        /// <summary>
        ///
        /// </summary>
        public DeShadowExperimentSamplingResponse(global::Together.DeShadowExperimentSamplingResponseVariant2? value)
        {
            DeShadowExperimentSamplingResponseVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DeShadowExperimentSamplingResponse FromDeShadowExperimentSamplingResponseVariant2(global::Together.DeShadowExperimentSamplingResponseVariant2? value) => new DeShadowExperimentSamplingResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator DeShadowExperimentSamplingResponse(global::Together.DeShadowExperimentSamplingResponseVariant3 value) => new DeShadowExperimentSamplingResponse((global::Together.DeShadowExperimentSamplingResponseVariant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Together.DeShadowExperimentSamplingResponseVariant3?(DeShadowExperimentSamplingResponse @this) => @this.DeShadowExperimentSamplingResponseVariant3;

        /// <summary>
        ///
        /// </summary>
        public DeShadowExperimentSamplingResponse(global::Together.DeShadowExperimentSamplingResponseVariant3? value)
        {
            DeShadowExperimentSamplingResponseVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DeShadowExperimentSamplingResponse FromDeShadowExperimentSamplingResponseVariant3(global::Together.DeShadowExperimentSamplingResponseVariant3? value) => new DeShadowExperimentSamplingResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator DeShadowExperimentSamplingResponse(global::Together.DeShadowExperimentSamplingResponseVariant4 value) => new DeShadowExperimentSamplingResponse((global::Together.DeShadowExperimentSamplingResponseVariant4?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Together.DeShadowExperimentSamplingResponseVariant4?(DeShadowExperimentSamplingResponse @this) => @this.DeShadowExperimentSamplingResponseVariant4;

        /// <summary>
        ///
        /// </summary>
        public DeShadowExperimentSamplingResponse(global::Together.DeShadowExperimentSamplingResponseVariant4? value)
        {
            DeShadowExperimentSamplingResponseVariant4 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DeShadowExperimentSamplingResponse FromDeShadowExperimentSamplingResponseVariant4(global::Together.DeShadowExperimentSamplingResponseVariant4? value) => new DeShadowExperimentSamplingResponse(value);

        /// <summary>
        ///
        /// </summary>
        public DeShadowExperimentSamplingResponse(
            global::Together.DeShadowExperimentSamplingResponseVariant1? deShadowExperimentSamplingResponseVariant1,
            global::Together.DeShadowExperimentSamplingResponseVariant2? deShadowExperimentSamplingResponseVariant2,
            global::Together.DeShadowExperimentSamplingResponseVariant3? deShadowExperimentSamplingResponseVariant3,
            global::Together.DeShadowExperimentSamplingResponseVariant4? deShadowExperimentSamplingResponseVariant4
            )
        {
            DeShadowExperimentSamplingResponseVariant1 = deShadowExperimentSamplingResponseVariant1;
            DeShadowExperimentSamplingResponseVariant2 = deShadowExperimentSamplingResponseVariant2;
            DeShadowExperimentSamplingResponseVariant3 = deShadowExperimentSamplingResponseVariant3;
            DeShadowExperimentSamplingResponseVariant4 = deShadowExperimentSamplingResponseVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            DeShadowExperimentSamplingResponseVariant4 as object ??
            DeShadowExperimentSamplingResponseVariant3 as object ??
            DeShadowExperimentSamplingResponseVariant2 as object ??
            DeShadowExperimentSamplingResponseVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            DeShadowExperimentSamplingResponseVariant1?.ToString() ??
            DeShadowExperimentSamplingResponseVariant2?.ToString() ??
            DeShadowExperimentSamplingResponseVariant3?.ToString() ??
            DeShadowExperimentSamplingResponseVariant4?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsDeShadowExperimentSamplingResponseVariant1 && !IsDeShadowExperimentSamplingResponseVariant2 && !IsDeShadowExperimentSamplingResponseVariant3 && !IsDeShadowExperimentSamplingResponseVariant4 || !IsDeShadowExperimentSamplingResponseVariant1 && IsDeShadowExperimentSamplingResponseVariant2 && !IsDeShadowExperimentSamplingResponseVariant3 && !IsDeShadowExperimentSamplingResponseVariant4 || !IsDeShadowExperimentSamplingResponseVariant1 && !IsDeShadowExperimentSamplingResponseVariant2 && IsDeShadowExperimentSamplingResponseVariant3 && !IsDeShadowExperimentSamplingResponseVariant4 || !IsDeShadowExperimentSamplingResponseVariant1 && !IsDeShadowExperimentSamplingResponseVariant2 && !IsDeShadowExperimentSamplingResponseVariant3 && IsDeShadowExperimentSamplingResponseVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Together.DeShadowExperimentSamplingResponseVariant1, TResult>? deShadowExperimentSamplingResponseVariant1 = null,
            global::System.Func<global::Together.DeShadowExperimentSamplingResponseVariant2, TResult>? deShadowExperimentSamplingResponseVariant2 = null,
            global::System.Func<global::Together.DeShadowExperimentSamplingResponseVariant3, TResult>? deShadowExperimentSamplingResponseVariant3 = null,
            global::System.Func<global::Together.DeShadowExperimentSamplingResponseVariant4, TResult>? deShadowExperimentSamplingResponseVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDeShadowExperimentSamplingResponseVariant1 && deShadowExperimentSamplingResponseVariant1 != null)
            {
                return deShadowExperimentSamplingResponseVariant1(DeShadowExperimentSamplingResponseVariant1!);
            }
            else if (IsDeShadowExperimentSamplingResponseVariant2 && deShadowExperimentSamplingResponseVariant2 != null)
            {
                return deShadowExperimentSamplingResponseVariant2(DeShadowExperimentSamplingResponseVariant2!);
            }
            else if (IsDeShadowExperimentSamplingResponseVariant3 && deShadowExperimentSamplingResponseVariant3 != null)
            {
                return deShadowExperimentSamplingResponseVariant3(DeShadowExperimentSamplingResponseVariant3!);
            }
            else if (IsDeShadowExperimentSamplingResponseVariant4 && deShadowExperimentSamplingResponseVariant4 != null)
            {
                return deShadowExperimentSamplingResponseVariant4(DeShadowExperimentSamplingResponseVariant4!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Together.DeShadowExperimentSamplingResponseVariant1>? deShadowExperimentSamplingResponseVariant1 = null,

            global::System.Action<global::Together.DeShadowExperimentSamplingResponseVariant2>? deShadowExperimentSamplingResponseVariant2 = null,

            global::System.Action<global::Together.DeShadowExperimentSamplingResponseVariant3>? deShadowExperimentSamplingResponseVariant3 = null,

            global::System.Action<global::Together.DeShadowExperimentSamplingResponseVariant4>? deShadowExperimentSamplingResponseVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDeShadowExperimentSamplingResponseVariant1)
            {
                deShadowExperimentSamplingResponseVariant1?.Invoke(DeShadowExperimentSamplingResponseVariant1!);
            }
            else if (IsDeShadowExperimentSamplingResponseVariant2)
            {
                deShadowExperimentSamplingResponseVariant2?.Invoke(DeShadowExperimentSamplingResponseVariant2!);
            }
            else if (IsDeShadowExperimentSamplingResponseVariant3)
            {
                deShadowExperimentSamplingResponseVariant3?.Invoke(DeShadowExperimentSamplingResponseVariant3!);
            }
            else if (IsDeShadowExperimentSamplingResponseVariant4)
            {
                deShadowExperimentSamplingResponseVariant4?.Invoke(DeShadowExperimentSamplingResponseVariant4!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Together.DeShadowExperimentSamplingResponseVariant1>? deShadowExperimentSamplingResponseVariant1 = null,
            global::System.Action<global::Together.DeShadowExperimentSamplingResponseVariant2>? deShadowExperimentSamplingResponseVariant2 = null,
            global::System.Action<global::Together.DeShadowExperimentSamplingResponseVariant3>? deShadowExperimentSamplingResponseVariant3 = null,
            global::System.Action<global::Together.DeShadowExperimentSamplingResponseVariant4>? deShadowExperimentSamplingResponseVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDeShadowExperimentSamplingResponseVariant1)
            {
                deShadowExperimentSamplingResponseVariant1?.Invoke(DeShadowExperimentSamplingResponseVariant1!);
            }
            else if (IsDeShadowExperimentSamplingResponseVariant2)
            {
                deShadowExperimentSamplingResponseVariant2?.Invoke(DeShadowExperimentSamplingResponseVariant2!);
            }
            else if (IsDeShadowExperimentSamplingResponseVariant3)
            {
                deShadowExperimentSamplingResponseVariant3?.Invoke(DeShadowExperimentSamplingResponseVariant3!);
            }
            else if (IsDeShadowExperimentSamplingResponseVariant4)
            {
                deShadowExperimentSamplingResponseVariant4?.Invoke(DeShadowExperimentSamplingResponseVariant4!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                DeShadowExperimentSamplingResponseVariant1,
                typeof(global::Together.DeShadowExperimentSamplingResponseVariant1),
                DeShadowExperimentSamplingResponseVariant2,
                typeof(global::Together.DeShadowExperimentSamplingResponseVariant2),
                DeShadowExperimentSamplingResponseVariant3,
                typeof(global::Together.DeShadowExperimentSamplingResponseVariant3),
                DeShadowExperimentSamplingResponseVariant4,
                typeof(global::Together.DeShadowExperimentSamplingResponseVariant4),
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
        public bool Equals(DeShadowExperimentSamplingResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Together.DeShadowExperimentSamplingResponseVariant1?>.Default.Equals(DeShadowExperimentSamplingResponseVariant1, other.DeShadowExperimentSamplingResponseVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Together.DeShadowExperimentSamplingResponseVariant2?>.Default.Equals(DeShadowExperimentSamplingResponseVariant2, other.DeShadowExperimentSamplingResponseVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Together.DeShadowExperimentSamplingResponseVariant3?>.Default.Equals(DeShadowExperimentSamplingResponseVariant3, other.DeShadowExperimentSamplingResponseVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Together.DeShadowExperimentSamplingResponseVariant4?>.Default.Equals(DeShadowExperimentSamplingResponseVariant4, other.DeShadowExperimentSamplingResponseVariant4)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(DeShadowExperimentSamplingResponse obj1, DeShadowExperimentSamplingResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DeShadowExperimentSamplingResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(DeShadowExperimentSamplingResponse obj1, DeShadowExperimentSamplingResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DeShadowExperimentSamplingResponse o && Equals(o);
        }
    }
}
