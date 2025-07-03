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
        public global::Together.ImageResponseDataB64? ImageResponseB64 { get; init; }
#else
        public global::Together.ImageResponseDataB64? ImageResponseB64 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageResponseB64))]
#endif
        public bool IsImageResponseB64 => ImageResponseB64 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataItem(global::Together.ImageResponseDataB64 value) => new DataItem((global::Together.ImageResponseDataB64?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Together.ImageResponseDataB64?(DataItem @this) => @this.ImageResponseB64;

        /// <summary>
        /// 
        /// </summary>
        public DataItem(global::Together.ImageResponseDataB64? value)
        {
            ImageResponseB64 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.ImageResponseDataUrl? ImageResponseUrl { get; init; }
#else
        public global::Together.ImageResponseDataUrl? ImageResponseUrl { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageResponseUrl))]
#endif
        public bool IsImageResponseUrl => ImageResponseUrl != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataItem(global::Together.ImageResponseDataUrl value) => new DataItem((global::Together.ImageResponseDataUrl?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Together.ImageResponseDataUrl?(DataItem @this) => @this.ImageResponseUrl;

        /// <summary>
        /// 
        /// </summary>
        public DataItem(global::Together.ImageResponseDataUrl? value)
        {
            ImageResponseUrl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DataItem(
            global::Together.ImageResponseDataB64? imageResponseB64,
            global::Together.ImageResponseDataUrl? imageResponseUrl
            )
        {
            ImageResponseB64 = imageResponseB64;
            ImageResponseUrl = imageResponseUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ImageResponseUrl as object ??
            ImageResponseB64 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ImageResponseB64?.ToString() ??
            ImageResponseUrl?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsImageResponseB64 && !IsImageResponseUrl || !IsImageResponseB64 && IsImageResponseUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Together.ImageResponseDataB64?, TResult>? imageResponseB64 = null,
            global::System.Func<global::Together.ImageResponseDataUrl?, TResult>? imageResponseUrl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImageResponseB64 && imageResponseB64 != null)
            {
                return imageResponseB64(ImageResponseB64!);
            }
            else if (IsImageResponseUrl && imageResponseUrl != null)
            {
                return imageResponseUrl(ImageResponseUrl!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Together.ImageResponseDataB64?>? imageResponseB64 = null,
            global::System.Action<global::Together.ImageResponseDataUrl?>? imageResponseUrl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImageResponseB64)
            {
                imageResponseB64?.Invoke(ImageResponseB64!);
            }
            else if (IsImageResponseUrl)
            {
                imageResponseUrl?.Invoke(ImageResponseUrl!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ImageResponseB64,
                typeof(global::Together.ImageResponseDataB64),
                ImageResponseUrl,
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
                global::System.Collections.Generic.EqualityComparer<global::Together.ImageResponseDataB64?>.Default.Equals(ImageResponseB64, other.ImageResponseB64) &&
                global::System.Collections.Generic.EqualityComparer<global::Together.ImageResponseDataUrl?>.Default.Equals(ImageResponseUrl, other.ImageResponseUrl) 
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
