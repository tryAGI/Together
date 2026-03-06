#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// The result of the execution. If successful, `data` contains the result and `errors` will be null. If unsuccessful, `data` will be null and `errors` will contain the errors.
    /// </summary>
    public readonly partial struct ExecuteResponse : global::System.IEquatable<ExecuteResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.ExecuteResponseSuccessfulExecution? SuccessfulExecution { get; init; }
#else
        public global::Together.ExecuteResponseSuccessfulExecution? SuccessfulExecution { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SuccessfulExecution))]
#endif
        public bool IsSuccessfulExecution => SuccessfulExecution != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.ExecuteResponseFailedExecution? FailedExecution { get; init; }
#else
        public global::Together.ExecuteResponseFailedExecution? FailedExecution { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FailedExecution))]
#endif
        public bool IsFailedExecution => FailedExecution != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExecuteResponse(global::Together.ExecuteResponseSuccessfulExecution value) => new ExecuteResponse((global::Together.ExecuteResponseSuccessfulExecution?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Together.ExecuteResponseSuccessfulExecution?(ExecuteResponse @this) => @this.SuccessfulExecution;

        /// <summary>
        /// 
        /// </summary>
        public ExecuteResponse(global::Together.ExecuteResponseSuccessfulExecution? value)
        {
            SuccessfulExecution = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExecuteResponse(global::Together.ExecuteResponseFailedExecution value) => new ExecuteResponse((global::Together.ExecuteResponseFailedExecution?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Together.ExecuteResponseFailedExecution?(ExecuteResponse @this) => @this.FailedExecution;

        /// <summary>
        /// 
        /// </summary>
        public ExecuteResponse(global::Together.ExecuteResponseFailedExecution? value)
        {
            FailedExecution = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ExecuteResponse(
            global::Together.ExecuteResponseSuccessfulExecution? successfulExecution,
            global::Together.ExecuteResponseFailedExecution? failedExecution
            )
        {
            SuccessfulExecution = successfulExecution;
            FailedExecution = failedExecution;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FailedExecution as object ??
            SuccessfulExecution as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SuccessfulExecution?.ToString() ??
            FailedExecution?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSuccessfulExecution && !IsFailedExecution || !IsSuccessfulExecution && IsFailedExecution;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Together.ExecuteResponseSuccessfulExecution?, TResult>? successfulExecution = null,
            global::System.Func<global::Together.ExecuteResponseFailedExecution?, TResult>? failedExecution = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSuccessfulExecution && successfulExecution != null)
            {
                return successfulExecution(SuccessfulExecution!);
            }
            else if (IsFailedExecution && failedExecution != null)
            {
                return failedExecution(FailedExecution!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Together.ExecuteResponseSuccessfulExecution?>? successfulExecution = null,
            global::System.Action<global::Together.ExecuteResponseFailedExecution?>? failedExecution = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSuccessfulExecution)
            {
                successfulExecution?.Invoke(SuccessfulExecution!);
            }
            else if (IsFailedExecution)
            {
                failedExecution?.Invoke(FailedExecution!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SuccessfulExecution,
                typeof(global::Together.ExecuteResponseSuccessfulExecution),
                FailedExecution,
                typeof(global::Together.ExecuteResponseFailedExecution),
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
        public bool Equals(ExecuteResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Together.ExecuteResponseSuccessfulExecution?>.Default.Equals(SuccessfulExecution, other.SuccessfulExecution) &&
                global::System.Collections.Generic.EqualityComparer<global::Together.ExecuteResponseFailedExecution?>.Default.Equals(FailedExecution, other.FailedExecution) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ExecuteResponse obj1, ExecuteResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ExecuteResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ExecuteResponse obj1, ExecuteResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ExecuteResponse o && Equals(o);
        }
    }
}
