#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct InterpreterOutput : global::System.IEquatable<InterpreterOutput>
    {
        /// <summary>
        /// Outputs that were printed to stdout or stderr
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.InterpreterOutputVariant1? Value1 { get; init; }
#else
        public global::Together.InterpreterOutputVariant1? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InterpreterOutput(global::Together.InterpreterOutputVariant1 value) => new InterpreterOutput(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Together.InterpreterOutputVariant1?(InterpreterOutput @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public InterpreterOutput(global::Together.InterpreterOutputVariant1? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// Errors and exceptions that occurred. If this output type is present, your code did not execute successfully.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.InterpreterOutputVariant2? Value2 { get; init; }
#else
        public global::Together.InterpreterOutputVariant2? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InterpreterOutput(global::Together.InterpreterOutputVariant2 value) => new InterpreterOutput(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Together.InterpreterOutputVariant2?(InterpreterOutput @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public InterpreterOutput(global::Together.InterpreterOutputVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.InterpreterOutputVariant3? Value3 { get; init; }
#else
        public global::Together.InterpreterOutputVariant3? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InterpreterOutput(global::Together.InterpreterOutputVariant3 value) => new InterpreterOutput(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Together.InterpreterOutputVariant3?(InterpreterOutput @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public InterpreterOutput(global::Together.InterpreterOutputVariant3? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InterpreterOutput(
            global::Together.InterpreterOutputVariant1? value1,
            global::Together.InterpreterOutputVariant2? value2,
            global::Together.InterpreterOutputVariant3? value3
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() ??
            Value3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 && !IsValue3 || !IsValue1 && IsValue2 && !IsValue3 || !IsValue1 && !IsValue2 && IsValue3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Together.InterpreterOutputVariant1?, TResult>? value1 = null,
            global::System.Func<global::Together.InterpreterOutputVariant2?, TResult>? value2 = null,
            global::System.Func<global::Together.InterpreterOutputVariant3?, TResult>? value3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Together.InterpreterOutputVariant1?>? value1 = null,
            global::System.Action<global::Together.InterpreterOutputVariant2?>? value2 = null,
            global::System.Action<global::Together.InterpreterOutputVariant3?>? value3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::Together.InterpreterOutputVariant1),
                Value2,
                typeof(global::Together.InterpreterOutputVariant2),
                Value3,
                typeof(global::Together.InterpreterOutputVariant3),
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
        public bool Equals(InterpreterOutput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Together.InterpreterOutputVariant1?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::Together.InterpreterOutputVariant2?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::Together.InterpreterOutputVariant3?>.Default.Equals(Value3, other.Value3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InterpreterOutput obj1, InterpreterOutput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InterpreterOutput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InterpreterOutput obj1, InterpreterOutput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InterpreterOutput o && Equals(o);
        }
    }
}
