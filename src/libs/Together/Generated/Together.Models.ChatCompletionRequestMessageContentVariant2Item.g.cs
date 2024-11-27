#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatCompletionRequestMessageContentVariant2Item : global::System.IEquatable<ChatCompletionRequestMessageContentVariant2Item>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Together.ChatCompletionRequestMessageContentVariant2ItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.ChatCompletionRequestMessageContentVariant2ItemVariant1? Text { get; init; }
#else
        public global::Together.ChatCompletionRequestMessageContentVariant2ItemVariant1? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestMessageContentVariant2Item(global::Together.ChatCompletionRequestMessageContentVariant2ItemVariant1 value) => new ChatCompletionRequestMessageContentVariant2Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Together.ChatCompletionRequestMessageContentVariant2ItemVariant1?(ChatCompletionRequestMessageContentVariant2Item @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessageContentVariant2Item(global::Together.ChatCompletionRequestMessageContentVariant2ItemVariant1? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.ChatCompletionRequestMessageContentVariant2ItemVariant2? ImageUrl { get; init; }
#else
        public global::Together.ChatCompletionRequestMessageContentVariant2ItemVariant2? ImageUrl { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageUrl))]
#endif
        public bool IsImageUrl => ImageUrl != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestMessageContentVariant2Item(global::Together.ChatCompletionRequestMessageContentVariant2ItemVariant2 value) => new ChatCompletionRequestMessageContentVariant2Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Together.ChatCompletionRequestMessageContentVariant2ItemVariant2?(ChatCompletionRequestMessageContentVariant2Item @this) => @this.ImageUrl;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessageContentVariant2Item(global::Together.ChatCompletionRequestMessageContentVariant2ItemVariant2? value)
        {
            ImageUrl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessageContentVariant2Item(
            global::Together.ChatCompletionRequestMessageContentVariant2ItemDiscriminatorType? type,
            global::Together.ChatCompletionRequestMessageContentVariant2ItemVariant1? text,
            global::Together.ChatCompletionRequestMessageContentVariant2ItemVariant2? imageUrl
            )
        {
            Type = type;

            Text = text;
            ImageUrl = imageUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ImageUrl as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImageUrl || !IsText && IsImageUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Together.ChatCompletionRequestMessageContentVariant2ItemVariant1?, TResult>? text = null,
            global::System.Func<global::Together.ChatCompletionRequestMessageContentVariant2ItemVariant2?, TResult>? imageUrl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsImageUrl && imageUrl != null)
            {
                return imageUrl(ImageUrl!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Together.ChatCompletionRequestMessageContentVariant2ItemVariant1?>? text = null,
            global::System.Action<global::Together.ChatCompletionRequestMessageContentVariant2ItemVariant2?>? imageUrl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsImageUrl)
            {
                imageUrl?.Invoke(ImageUrl!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::Together.ChatCompletionRequestMessageContentVariant2ItemVariant1),
                ImageUrl,
                typeof(global::Together.ChatCompletionRequestMessageContentVariant2ItemVariant2),
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
        public bool Equals(ChatCompletionRequestMessageContentVariant2Item other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Together.ChatCompletionRequestMessageContentVariant2ItemVariant1?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Together.ChatCompletionRequestMessageContentVariant2ItemVariant2?>.Default.Equals(ImageUrl, other.ImageUrl) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionRequestMessageContentVariant2Item obj1, ChatCompletionRequestMessageContentVariant2Item obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionRequestMessageContentVariant2Item>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionRequestMessageContentVariant2Item obj1, ChatCompletionRequestMessageContentVariant2Item obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionRequestMessageContentVariant2Item o && Equals(o);
        }
    }
}
