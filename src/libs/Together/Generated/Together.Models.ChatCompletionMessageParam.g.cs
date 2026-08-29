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
        public bool TryPickSystem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Together.ChatCompletionSystemMessageParam? value)
        {
            value = System;
            return IsSystem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Together.ChatCompletionSystemMessageParam PickSystem() => IsSystem
            ? System!
            : throw new global::System.InvalidOperationException($"Expected union variant 'System' but the value was {ToString()}.");

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
        public bool TryPickUser(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Together.ChatCompletionUserMessageParam? value)
        {
            value = User;
            return IsUser;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Together.ChatCompletionUserMessageParam PickUser() => IsUser
            ? User!
            : throw new global::System.InvalidOperationException($"Expected union variant 'User' but the value was {ToString()}.");

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
        public bool TryPickAssistant(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Together.ChatCompletionAssistantMessageParam? value)
        {
            value = Assistant;
            return IsAssistant;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Together.ChatCompletionAssistantMessageParam PickAssistant() => IsAssistant
            ? Assistant!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Assistant' but the value was {ToString()}.");

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
        public bool TryPickTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Together.ChatCompletionToolMessageParam? value)
        {
            value = Tool;
            return IsTool;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Together.ChatCompletionToolMessageParam PickTool() => IsTool
            ? Tool!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Tool' but the value was {ToString()}.");

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
        public bool TryPickFunction(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Together.ChatCompletionFunctionMessageParam? value)
        {
            value = Function;
            return IsFunction;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Together.ChatCompletionFunctionMessageParam PickFunction() => IsFunction
            ? Function!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Function' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatCompletionMessageParam(global::Together.ChatCompletionSystemMessageParam value) => new ChatCompletionMessageParam((global::Together.ChatCompletionSystemMessageParam?)value);

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
        public static ChatCompletionMessageParam FromSystem(global::Together.ChatCompletionSystemMessageParam? value) => new ChatCompletionMessageParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatCompletionMessageParam(global::Together.ChatCompletionUserMessageParam value) => new ChatCompletionMessageParam((global::Together.ChatCompletionUserMessageParam?)value);

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
        public static ChatCompletionMessageParam FromUser(global::Together.ChatCompletionUserMessageParam? value) => new ChatCompletionMessageParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatCompletionMessageParam(global::Together.ChatCompletionAssistantMessageParam value) => new ChatCompletionMessageParam((global::Together.ChatCompletionAssistantMessageParam?)value);

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
        public static ChatCompletionMessageParam FromAssistant(global::Together.ChatCompletionAssistantMessageParam? value) => new ChatCompletionMessageParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatCompletionMessageParam(global::Together.ChatCompletionToolMessageParam value) => new ChatCompletionMessageParam((global::Together.ChatCompletionToolMessageParam?)value);

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
        public static ChatCompletionMessageParam FromTool(global::Together.ChatCompletionToolMessageParam? value) => new ChatCompletionMessageParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatCompletionMessageParam(global::Together.ChatCompletionFunctionMessageParam value) => new ChatCompletionMessageParam((global::Together.ChatCompletionFunctionMessageParam?)value);

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
        public static ChatCompletionMessageParam FromFunction(global::Together.ChatCompletionFunctionMessageParam? value) => new ChatCompletionMessageParam(value);

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
        public override string? ToString() =>
            System?.ToString() ??
            User?.ToString() ??
            Assistant?.ToString() ??
            Tool?.ToString() ??
            Function?.ToString()
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
        public TResult? Match<TResult>(
            global::System.Func<global::Together.ChatCompletionSystemMessageParam, TResult>? system = null,
            global::System.Func<global::Together.ChatCompletionUserMessageParam, TResult>? user = null,
            global::System.Func<global::Together.ChatCompletionAssistantMessageParam, TResult>? assistant = null,
            global::System.Func<global::Together.ChatCompletionToolMessageParam, TResult>? tool = null,
            global::System.Func<global::Together.ChatCompletionFunctionMessageParam, TResult>? function = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSystem && system != null)
            {
                return system(System!);
            }
            else if (IsUser && user != null)
            {
                return user(User!);
            }
            else if (IsAssistant && assistant != null)
            {
                return assistant(Assistant!);
            }
            else if (IsTool && tool != null)
            {
                return tool(Tool!);
            }
            else if (IsFunction && function != null)
            {
                return function(Function!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Together.ChatCompletionSystemMessageParam>? system = null,

            global::System.Action<global::Together.ChatCompletionUserMessageParam>? user = null,

            global::System.Action<global::Together.ChatCompletionAssistantMessageParam>? assistant = null,

            global::System.Action<global::Together.ChatCompletionToolMessageParam>? tool = null,

            global::System.Action<global::Together.ChatCompletionFunctionMessageParam>? function = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSystem)
            {
                system?.Invoke(System!);
            }
            else if (IsUser)
            {
                user?.Invoke(User!);
            }
            else if (IsAssistant)
            {
                assistant?.Invoke(Assistant!);
            }
            else if (IsTool)
            {
                tool?.Invoke(Tool!);
            }
            else if (IsFunction)
            {
                function?.Invoke(Function!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Together.ChatCompletionSystemMessageParam>? system = null,
            global::System.Action<global::Together.ChatCompletionUserMessageParam>? user = null,
            global::System.Action<global::Together.ChatCompletionAssistantMessageParam>? assistant = null,
            global::System.Action<global::Together.ChatCompletionToolMessageParam>? tool = null,
            global::System.Action<global::Together.ChatCompletionFunctionMessageParam>? function = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSystem)
            {
                system?.Invoke(System!);
            }
            else if (IsUser)
            {
                user?.Invoke(User!);
            }
            else if (IsAssistant)
            {
                assistant?.Invoke(Assistant!);
            }
            else if (IsTool)
            {
                tool?.Invoke(Tool!);
            }
            else if (IsFunction)
            {
                function?.Invoke(Function!);
            }
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

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
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
