#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DataItem : global::System.IEquatable<DataItem>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.ImageResponseDataB64? B64Json { get; init; }
#else
        public global::Together.ImageResponseDataB64? B64Json { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(B64Json))]
#endif
        public bool IsB64Json => B64Json != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.ImageResponseDataUrl? Url { get; init; }
#else
        public global::Together.ImageResponseDataUrl? Url { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Url))]
#endif
        public bool IsUrl => Url != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataItem(global::Together.ImageResponseDataB64 value) => new DataItem((global::Together.ImageResponseDataB64?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Together.ImageResponseDataB64?(DataItem @this) => @this.B64Json;

        /// <summary>
        /// 
        /// </summary>
        public DataItem(global::Together.ImageResponseDataB64? value)
        {
            B64Json = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataItem(global::Together.ImageResponseDataUrl value) => new DataItem((global::Together.ImageResponseDataUrl?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Together.ImageResponseDataUrl?(DataItem @this) => @this.Url;

        /// <summary>
        /// 
        /// </summary>
        public DataItem(global::Together.ImageResponseDataUrl? value)
        {
            Url = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DataItem(
            global::Together.ImageResponseDataB64? b64Json,
            global::Together.ImageResponseDataUrl? url
            )
        {
            B64Json = b64Json;
            Url = url;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Url as object ??
            B64Json as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            B64Json?.ToString() ??
            Url?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsB64Json && !IsUrl || !IsB64Json && IsUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Together.ImageResponseDataB64?, TResult>? b64Json = null,
            global::System.Func<global::Together.ImageResponseDataUrl?, TResult>? url = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsB64Json && b64Json != null)
            {
                return b64Json(B64Json!);
            }
            else if (IsUrl && url != null)
            {
                return url(Url!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Together.ImageResponseDataB64?>? b64Json = null,
            global::System.Action<global::Together.ImageResponseDataUrl?>? url = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsB64Json)
            {
                b64Json?.Invoke(B64Json!);
            }
            else if (IsUrl)
            {
                url?.Invoke(Url!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                B64Json,
                typeof(global::Together.ImageResponseDataB64),
                Url,
                typeof(global::Together.ImageResponseDataUrl),
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
        public bool Equals(DataItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Together.ImageResponseDataB64?>.Default.Equals(B64Json, other.B64Json) &&
                global::System.Collections.Generic.EqualityComparer<global::Together.ImageResponseDataUrl?>.Default.Equals(Url, other.Url) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DataItem obj1, DataItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DataItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DataItem obj1, DataItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DataItem o && Equals(o);
        }
    }
}
