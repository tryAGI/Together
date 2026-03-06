#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SessionListResponse : global::System.IEquatable<SessionListResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.SessionListResponseResponse? Response { get; init; }
#else
        public global::Together.SessionListResponseResponse? Response { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Response))]
#endif
        public bool IsResponse => Response != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.SessionListResponseVariant2? Value2 { get; init; }
#else
        public global::Together.SessionListResponseVariant2? Value2 { get; }
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
        public static implicit operator SessionListResponse(global::Together.SessionListResponseResponse value) => new SessionListResponse((global::Together.SessionListResponseResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Together.SessionListResponseResponse?(SessionListResponse @this) => @this.Response;

        /// <summary>
        /// 
        /// </summary>
        public SessionListResponse(global::Together.SessionListResponseResponse? value)
        {
            Response = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SessionListResponse(global::Together.SessionListResponseVariant2 value) => new SessionListResponse((global::Together.SessionListResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Together.SessionListResponseVariant2?(SessionListResponse @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public SessionListResponse(global::Together.SessionListResponseVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SessionListResponse(
            global::Together.SessionListResponseResponse? response,
            global::Together.SessionListResponseVariant2? value2
            )
        {
            Response = response;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            Response as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Response?.ToString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsResponse && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Together.SessionListResponseResponse?, TResult>? response = null,
            global::System.Func<global::Together.SessionListResponseVariant2?, TResult>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponse && response != null)
            {
                return response(Response!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Together.SessionListResponseResponse?>? response = null,
            global::System.Action<global::Together.SessionListResponseVariant2?>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponse)
            {
                response?.Invoke(Response!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Response,
                typeof(global::Together.SessionListResponseResponse),
                Value2,
                typeof(global::Together.SessionListResponseVariant2),
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
        public bool Equals(SessionListResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Together.SessionListResponseResponse?>.Default.Equals(Response, other.Response) &&
                global::System.Collections.Generic.EqualityComparer<global::Together.SessionListResponseVariant2?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SessionListResponse obj1, SessionListResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SessionListResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SessionListResponse obj1, SessionListResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SessionListResponse o && Equals(o);
        }
    }
}
