#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatCompletionStream : global::System.IEquatable<ChatCompletionStream>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.ChatCompletionEvent? Event { get; init; }
#else
        public global::Together.ChatCompletionEvent? Event { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Event))]
#endif
        public bool IsEvent => Event != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionStream(global::Together.ChatCompletionEvent value) => new ChatCompletionStream(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Together.ChatCompletionEvent?(ChatCompletionStream @this) => @this.Event;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionStream(global::Together.ChatCompletionEvent? value)
        {
            Event = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.StreamSentinel? Sentinel { get; init; }
#else
        public global::Together.StreamSentinel? Sentinel { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sentinel))]
#endif
        public bool IsSentinel => Sentinel != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionStream(global::Together.StreamSentinel value) => new ChatCompletionStream(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Together.StreamSentinel?(ChatCompletionStream @this) => @this.Sentinel;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionStream(global::Together.StreamSentinel? value)
        {
            Sentinel = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionStream(
            global::Together.ChatCompletionEvent? @event,
            global::Together.StreamSentinel? sentinel
            )
        {
            Event = @event;
            Sentinel = sentinel;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Sentinel as object ??
            Event as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Event?.ToString() ??
            Sentinel?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEvent && !IsSentinel || !IsEvent && IsSentinel;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Together.ChatCompletionEvent?, TResult>? @event = null,
            global::System.Func<global::Together.StreamSentinel?, TResult>? sentinel = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEvent && @event != null)
            {
                return @event(Event!);
            }
            else if (IsSentinel && sentinel != null)
            {
                return sentinel(Sentinel!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Together.ChatCompletionEvent?>? @event = null,
            global::System.Action<global::Together.StreamSentinel?>? sentinel = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEvent)
            {
                @event?.Invoke(Event!);
            }
            else if (IsSentinel)
            {
                sentinel?.Invoke(Sentinel!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Event,
                typeof(global::Together.ChatCompletionEvent),
                Sentinel,
                typeof(global::Together.StreamSentinel),
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
        public bool Equals(ChatCompletionStream other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Together.ChatCompletionEvent?>.Default.Equals(Event, other.Event) &&
                global::System.Collections.Generic.EqualityComparer<global::Together.StreamSentinel?>.Default.Equals(Sentinel, other.Sentinel) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionStream obj1, ChatCompletionStream obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionStream>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionStream obj1, ChatCompletionStream obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionStream o && Equals(o);
        }
    }
}
