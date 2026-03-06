#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct InterpreterOutput : global::System.IEquatable<InterpreterOutput>
    {
        /// <summary>
        /// Outputs that were printed to stdout or stderr
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.InterpreterOutputStreamOutput? StreamOutput { get; init; }
#else
        public global::Together.InterpreterOutputStreamOutput? StreamOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamOutput))]
#endif
        public bool IsStreamOutput => StreamOutput != null;

        /// <summary>
        /// Errors and exceptions that occurred. If this output type is present, your code did not execute successfully.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.InterpreterOutputErrorOutput? Error { get; init; }
#else
        public global::Together.InterpreterOutputErrorOutput? Error { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.InterpreterOutputDisplayorExecuteOutput? DisplayorExecuteOutput { get; init; }
#else
        public global::Together.InterpreterOutputDisplayorExecuteOutput? DisplayorExecuteOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DisplayorExecuteOutput))]
#endif
        public bool IsDisplayorExecuteOutput => DisplayorExecuteOutput != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InterpreterOutput(global::Together.InterpreterOutputStreamOutput value) => new InterpreterOutput((global::Together.InterpreterOutputStreamOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Together.InterpreterOutputStreamOutput?(InterpreterOutput @this) => @this.StreamOutput;

        /// <summary>
        /// 
        /// </summary>
        public InterpreterOutput(global::Together.InterpreterOutputStreamOutput? value)
        {
            StreamOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InterpreterOutput(global::Together.InterpreterOutputErrorOutput value) => new InterpreterOutput((global::Together.InterpreterOutputErrorOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Together.InterpreterOutputErrorOutput?(InterpreterOutput @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public InterpreterOutput(global::Together.InterpreterOutputErrorOutput? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InterpreterOutput(global::Together.InterpreterOutputDisplayorExecuteOutput value) => new InterpreterOutput((global::Together.InterpreterOutputDisplayorExecuteOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Together.InterpreterOutputDisplayorExecuteOutput?(InterpreterOutput @this) => @this.DisplayorExecuteOutput;

        /// <summary>
        /// 
        /// </summary>
        public InterpreterOutput(global::Together.InterpreterOutputDisplayorExecuteOutput? value)
        {
            DisplayorExecuteOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InterpreterOutput(
            global::Together.InterpreterOutputStreamOutput? streamOutput,
            global::Together.InterpreterOutputErrorOutput? error,
            global::Together.InterpreterOutputDisplayorExecuteOutput? displayorExecuteOutput
            )
        {
            StreamOutput = streamOutput;
            Error = error;
            DisplayorExecuteOutput = displayorExecuteOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DisplayorExecuteOutput as object ??
            Error as object ??
            StreamOutput as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StreamOutput?.ToString() ??
            Error?.ToString() ??
            DisplayorExecuteOutput?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStreamOutput && !IsError && !IsDisplayorExecuteOutput || !IsStreamOutput && IsError && !IsDisplayorExecuteOutput || !IsStreamOutput && !IsError && IsDisplayorExecuteOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Together.InterpreterOutputStreamOutput?, TResult>? streamOutput = null,
            global::System.Func<global::Together.InterpreterOutputErrorOutput?, TResult>? error = null,
            global::System.Func<global::Together.InterpreterOutputDisplayorExecuteOutput?, TResult>? displayorExecuteOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStreamOutput && streamOutput != null)
            {
                return streamOutput(StreamOutput!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
            }
            else if (IsDisplayorExecuteOutput && displayorExecuteOutput != null)
            {
                return displayorExecuteOutput(DisplayorExecuteOutput!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Together.InterpreterOutputStreamOutput?>? streamOutput = null,
            global::System.Action<global::Together.InterpreterOutputErrorOutput?>? error = null,
            global::System.Action<global::Together.InterpreterOutputDisplayorExecuteOutput?>? displayorExecuteOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStreamOutput)
            {
                streamOutput?.Invoke(StreamOutput!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
            else if (IsDisplayorExecuteOutput)
            {
                displayorExecuteOutput?.Invoke(DisplayorExecuteOutput!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StreamOutput,
                typeof(global::Together.InterpreterOutputStreamOutput),
                Error,
                typeof(global::Together.InterpreterOutputErrorOutput),
                DisplayorExecuteOutput,
                typeof(global::Together.InterpreterOutputDisplayorExecuteOutput),
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
        public bool Equals(InterpreterOutput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Together.InterpreterOutputStreamOutput?>.Default.Equals(StreamOutput, other.StreamOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::Together.InterpreterOutputErrorOutput?>.Default.Equals(Error, other.Error) &&
                global::System.Collections.Generic.EqualityComparer<global::Together.InterpreterOutputDisplayorExecuteOutput?>.Default.Equals(DisplayorExecuteOutput, other.DisplayorExecuteOutput) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InterpreterOutput obj1, InterpreterOutput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InterpreterOutput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InterpreterOutput obj1, InterpreterOutput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InterpreterOutput o && Equals(o);
        }
    }
}
