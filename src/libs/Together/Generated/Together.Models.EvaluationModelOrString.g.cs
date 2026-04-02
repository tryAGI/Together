#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EvaluationModelOrString : global::System.IEquatable<EvaluationModelOrString>
    {
        /// <summary>
        /// Field name in the input data
        /// </summary>
#if NET6_0_OR_GREATER
        public string? EvaluationModelOrStringVariant1 { get; init; }
#else
        public string? EvaluationModelOrStringVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EvaluationModelOrStringVariant1))]
#endif
        public bool IsEvaluationModelOrStringVariant1 => EvaluationModelOrStringVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.EvaluationModelRequest? Request { get; init; }
#else
        public global::Together.EvaluationModelRequest? Request { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Request))]
#endif
        public bool IsRequest => Request != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EvaluationModelOrString(string value) => new EvaluationModelOrString((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(EvaluationModelOrString @this) => @this.EvaluationModelOrStringVariant1;

        /// <summary>
        /// 
        /// </summary>
        public EvaluationModelOrString(string? value)
        {
            EvaluationModelOrStringVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EvaluationModelOrString(global::Together.EvaluationModelRequest value) => new EvaluationModelOrString((global::Together.EvaluationModelRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Together.EvaluationModelRequest?(EvaluationModelOrString @this) => @this.Request;

        /// <summary>
        /// 
        /// </summary>
        public EvaluationModelOrString(global::Together.EvaluationModelRequest? value)
        {
            Request = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EvaluationModelOrString(
            string? evaluationModelOrStringVariant1,
            global::Together.EvaluationModelRequest? request
            )
        {
            EvaluationModelOrStringVariant1 = evaluationModelOrStringVariant1;
            Request = request;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Request as object ??
            EvaluationModelOrStringVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            EvaluationModelOrStringVariant1?.ToString() ??
            Request?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEvaluationModelOrStringVariant1 && !IsRequest || !IsEvaluationModelOrStringVariant1 && IsRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? evaluationModelOrStringVariant1 = null,
            global::System.Func<global::Together.EvaluationModelRequest?, TResult>? request = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEvaluationModelOrStringVariant1 && evaluationModelOrStringVariant1 != null)
            {
                return evaluationModelOrStringVariant1(EvaluationModelOrStringVariant1!);
            }
            else if (IsRequest && request != null)
            {
                return request(Request!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? evaluationModelOrStringVariant1 = null,
            global::System.Action<global::Together.EvaluationModelRequest?>? request = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEvaluationModelOrStringVariant1)
            {
                evaluationModelOrStringVariant1?.Invoke(EvaluationModelOrStringVariant1!);
            }
            else if (IsRequest)
            {
                request?.Invoke(Request!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                EvaluationModelOrStringVariant1,
                typeof(string),
                Request,
                typeof(global::Together.EvaluationModelRequest),
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
        public bool Equals(EvaluationModelOrString other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(EvaluationModelOrStringVariant1, other.EvaluationModelOrStringVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Together.EvaluationModelRequest?>.Default.Equals(Request, other.Request) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EvaluationModelOrString obj1, EvaluationModelOrString obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EvaluationModelOrString>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EvaluationModelOrString obj1, EvaluationModelOrString obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EvaluationModelOrString o && Equals(o);
        }
    }
}
