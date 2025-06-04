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
        public string? Value1 { get; init; }
#else
        public string? Value1 { get; }
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
        public static implicit operator ChatCompletionUserMessageContent(string value) => new ChatCompletionUserMessageContent((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ChatCompletionUserMessageContent @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionUserMessageContent(string? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// A structured message with mixed content types.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Together.OneOf<global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant3>>? Value2 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Together.OneOf<global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant3>>? Value2 { get; }
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
        public ChatCompletionUserMessageContent(global::System.Collections.Generic.IList<global::Together.OneOf<global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant3>>? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionUserMessageContent(
            string? value1,
            global::System.Collections.Generic.IList<global::Together.OneOf<global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant3>>? value2
            )
        {
            Value1 = value1;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 || !IsValue1 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? value1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::Together.OneOf<global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant3>>?, TResult>? value2 = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? value1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::Together.OneOf<global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant3>>?>? value2 = null,
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
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(string),
                Value2,
                typeof(global::System.Collections.Generic.IList<global::Together.OneOf<global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant3>>),
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
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Together.OneOf<global::Together.ChatCompletionUserMessageContentMultimodalItemVariant1, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant2, global::Together.ChatCompletionUserMessageContentMultimodalItemVariant3>>?>.Default.Equals(Value2, other.Value2) 
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
