#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// The content of the message, which can either be a simple string or a structured format.
    /// </summary>
    public readonly partial struct ChatCompletionUserMessageContent : global::System.IEquatable<ChatCompletionUserMessageContent>
    {
        /// <summary>
        /// A plain text message.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? String { get; init; }
#else
        public string? String { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(String))]
#endif
        public bool IsString => String != null;

        /// <summary>
        /// A structured message with mixed content types.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Together.OneOf<global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2, global::Together.ChatCompletionUserMessageContentMultimodalItemVideo, global::Together.ChatCompletionUserMessageContentMultimodalItemAudio, global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudio>>? Multimodal { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Together.OneOf<global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2, global::Together.ChatCompletionUserMessageContentMultimodalItemVideo, global::Together.ChatCompletionUserMessageContentMultimodalItemAudio, global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudio>>? Multimodal { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Multimodal))]
#endif
        public bool IsMultimodal => Multimodal != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionUserMessageContent(string value) => new ChatCompletionUserMessageContent((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ChatCompletionUserMessageContent @this) => @this.String;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionUserMessageContent(string? value)
        {
            String = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionUserMessageContent(
            string? @string,
            global::System.Collections.Generic.IList<global::Together.OneOf<global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2, global::Together.ChatCompletionUserMessageContentMultimodalItemVideo, global::Together.ChatCompletionUserMessageContentMultimodalItemAudio, global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudio>>? multimodal
            )
        {
            String = @string;
            Multimodal = multimodal;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Multimodal as object ??
            String as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            String?.ToString() ??
            Multimodal?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsString && !IsMultimodal || !IsString && IsMultimodal;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? @string = null,
            global::System.Func<global::System.Collections.Generic.IList<global::Together.OneOf<global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2, global::Together.ChatCompletionUserMessageContentMultimodalItemVideo, global::Together.ChatCompletionUserMessageContentMultimodalItemAudio, global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudio>>?, TResult>? multimodal = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsString && @string != null)
            {
                return @string(String!);
            }
            else if (IsMultimodal && multimodal != null)
            {
                return multimodal(Multimodal!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? @string = null,
            global::System.Action<global::System.Collections.Generic.IList<global::Together.OneOf<global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2, global::Together.ChatCompletionUserMessageContentMultimodalItemVideo, global::Together.ChatCompletionUserMessageContentMultimodalItemAudio, global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudio>>?>? multimodal = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsString)
            {
                @string?.Invoke(String!);
            }
            else if (IsMultimodal)
            {
                multimodal?.Invoke(Multimodal!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                String,
                typeof(string),
                Multimodal,
                typeof(global::System.Collections.Generic.IList<global::Together.OneOf<global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2, global::Together.ChatCompletionUserMessageContentMultimodalItemVideo, global::Together.ChatCompletionUserMessageContentMultimodalItemAudio, global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudio>>),
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
        public bool Equals(ChatCompletionUserMessageContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(String, other.String) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Together.OneOf<global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2, global::Together.ChatCompletionUserMessageContentMultimodalItemVideo, global::Together.ChatCompletionUserMessageContentMultimodalItemAudio, global::Together.ChatCompletionUserMessageContentMultimodalItemInputAudio>>?>.Default.Equals(Multimodal, other.Multimodal) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionUserMessageContent obj1, ChatCompletionUserMessageContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionUserMessageContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionUserMessageContent obj1, ChatCompletionUserMessageContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionUserMessageContent o && Equals(o);
        }
    }
}
