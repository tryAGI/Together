#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Error : global::System.IEquatable<Error>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ErrorVariant1 { get; init; }
#else
        public string? ErrorVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ErrorVariant1))]
#endif
        public bool IsErrorVariant1 => ErrorVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? ErrorVariant2 { get; init; }
#else
        public object? ErrorVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ErrorVariant2))]
#endif
        public bool IsErrorVariant2 => ErrorVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Error(string value) => new Error((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(Error @this) => @this.ErrorVariant1;

        /// <summary>
        /// 
        /// </summary>
        public Error(string? value)
        {
            ErrorVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Error(
            string? errorVariant1,
            object? errorVariant2
            )
        {
            ErrorVariant1 = errorVariant1;
            ErrorVariant2 = errorVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ErrorVariant2 as object ??
            ErrorVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ErrorVariant1?.ToString() ??
            ErrorVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsErrorVariant1 && !IsErrorVariant2 || !IsErrorVariant1 && IsErrorVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? errorVariant1 = null,
            global::System.Func<object?, TResult>? errorVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsErrorVariant1 && errorVariant1 != null)
            {
                return errorVariant1(ErrorVariant1!);
            }
            else if (IsErrorVariant2 && errorVariant2 != null)
            {
                return errorVariant2(ErrorVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? errorVariant1 = null,
            global::System.Action<object?>? errorVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsErrorVariant1)
            {
                errorVariant1?.Invoke(ErrorVariant1!);
            }
            else if (IsErrorVariant2)
            {
                errorVariant2?.Invoke(ErrorVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ErrorVariant1,
                typeof(string),
                ErrorVariant2,
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
        public bool Equals(Error other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ErrorVariant1, other.ErrorVariant1) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(ErrorVariant2, other.ErrorVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Error obj1, Error obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Error>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Error obj1, Error obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Error o && Equals(o);
        }
    }
}
