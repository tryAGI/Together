using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatCompletionMessageParam : global::System.IEquatable<ChatCompletionMessageParam>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.ChatCompletionSystemMessageParam? System { get; init; }
#else
        public global::Together.ChatCompletionSystemMessageParam? System { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(System))]
#endif
        public bool IsSystem => System != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionMessageParam(global::Together.ChatCompletionSystemMessageParam value) => new ChatCompletionMessageParam(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Together.ChatCompletionSystemMessageParam?(ChatCompletionMessageParam @this) => @this.System;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionMessageParam(global::Together.ChatCompletionSystemMessageParam? value)
        {
            System = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.ChatCompletionUserMessageParam? User { get; init; }
#else
        public global::Together.ChatCompletionUserMessageParam? User { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(User))]
#endif
        public bool IsUser => User != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionMessageParam(global::Together.ChatCompletionUserMessageParam value) => new ChatCompletionMessageParam(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Together.ChatCompletionUserMessageParam?(ChatCompletionMessageParam @this) => @this.User;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionMessageParam(global::Together.ChatCompletionUserMessageParam? value)
        {
            User = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.ChatCompletionAssistantMessageParam? Assistant { get; init; }
#else
        public global::Together.ChatCompletionAssistantMessageParam? Assistant { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Assistant))]
#endif
        public bool IsAssistant => Assistant != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionMessageParam(global::Together.ChatCompletionAssistantMessageParam value) => new ChatCompletionMessageParam(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Together.ChatCompletionAssistantMessageParam?(ChatCompletionMessageParam @this) => @this.Assistant;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionMessageParam(global::Together.ChatCompletionAssistantMessageParam? value)
        {
            Assistant = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.ChatCompletionToolMessageParam? Tool { get; init; }
#else
        public global::Together.ChatCompletionToolMessageParam? Tool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Tool))]
#endif
        public bool IsTool => Tool != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionMessageParam(global::Together.ChatCompletionToolMessageParam value) => new ChatCompletionMessageParam(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Together.ChatCompletionToolMessageParam?(ChatCompletionMessageParam @this) => @this.Tool;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionMessageParam(global::Together.ChatCompletionToolMessageParam? value)
        {
            Tool = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.ChatCompletionFunctionMessageParam? Function { get; init; }
#else
        public global::Together.ChatCompletionFunctionMessageParam? Function { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Function))]
#endif
        public bool IsFunction => Function != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionMessageParam(global::Together.ChatCompletionFunctionMessageParam value) => new ChatCompletionMessageParam(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Together.ChatCompletionFunctionMessageParam?(ChatCompletionMessageParam @this) => @this.Function;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionMessageParam(global::Together.ChatCompletionFunctionMessageParam? value)
        {
            Function = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionMessageParam(
            global::Together.ChatCompletionSystemMessageParam? system,
            global::Together.ChatCompletionUserMessageParam? user,
            global::Together.ChatCompletionAssistantMessageParam? assistant,
            global::Together.ChatCompletionToolMessageParam? tool,
            global::Together.ChatCompletionFunctionMessageParam? function
            )
        {
            System = system;
            User = user;
            Assistant = assistant;
            Tool = tool;
            Function = function;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Function as object ??
            Tool as object ??
            Assistant as object ??
            User as object ??
            System as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSystem && !IsUser && !IsAssistant && !IsTool && !IsFunction || !IsSystem && IsUser && !IsAssistant && !IsTool && !IsFunction || !IsSystem && !IsUser && IsAssistant && !IsTool && !IsFunction || !IsSystem && !IsUser && !IsAssistant && IsTool && !IsFunction || !IsSystem && !IsUser && !IsAssistant && !IsTool && IsFunction;
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                System,
                typeof(global::Together.ChatCompletionSystemMessageParam),
                User,
                typeof(global::Together.ChatCompletionUserMessageParam),
                Assistant,
                typeof(global::Together.ChatCompletionAssistantMessageParam),
                Tool,
                typeof(global::Together.ChatCompletionToolMessageParam),
                Function,
                typeof(global::Together.ChatCompletionFunctionMessageParam),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ChatCompletionMessageParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Together.ChatCompletionSystemMessageParam?>.Default.Equals(System, other.System) &&
                global::System.Collections.Generic.EqualityComparer<global::Together.ChatCompletionUserMessageParam?>.Default.Equals(User, other.User) &&
                global::System.Collections.Generic.EqualityComparer<global::Together.ChatCompletionAssistantMessageParam?>.Default.Equals(Assistant, other.Assistant) &&
                global::System.Collections.Generic.EqualityComparer<global::Together.ChatCompletionToolMessageParam?>.Default.Equals(Tool, other.Tool) &&
                global::System.Collections.Generic.EqualityComparer<global::Together.ChatCompletionFunctionMessageParam?>.Default.Equals(Function, other.Function) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionMessageParam obj1, ChatCompletionMessageParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionMessageParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionMessageParam obj1, ChatCompletionMessageParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionMessageParam o && Equals(o);
        }
    }
}