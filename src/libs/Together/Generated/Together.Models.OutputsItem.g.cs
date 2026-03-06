#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OutputsItem : global::System.IEquatable<OutputsItem>
    {
        /// <summary>
        /// Outputs that were printed to stdout or stderr
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.ExecuteResponseSuccessfulExecutionDataOutputStreamOutput? StreamOutput { get; init; }
#else
        public global::Together.ExecuteResponseSuccessfulExecutionDataOutputStreamOutput? StreamOutput { get; }
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
        public global::Together.ExecuteResponseSuccessfulExecutionDataOutputErrorOutput? Error { get; init; }
#else
        public global::Together.ExecuteResponseSuccessfulExecutionDataOutputErrorOutput? Error { get; }
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
        public global::Together.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutput? DisplayorExecuteOutput { get; init; }
#else
        public global::Together.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutput? DisplayorExecuteOutput { get; }
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
        public static implicit operator OutputsItem(global::Together.ExecuteResponseSuccessfulExecutionDataOutputStreamOutput value) => new OutputsItem((global::Together.ExecuteResponseSuccessfulExecutionDataOutputStreamOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Together.ExecuteResponseSuccessfulExecutionDataOutputStreamOutput?(OutputsItem @this) => @this.StreamOutput;

        /// <summary>
        /// 
        /// </summary>
        public OutputsItem(global::Together.ExecuteResponseSuccessfulExecutionDataOutputStreamOutput? value)
        {
            StreamOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputsItem(global::Together.ExecuteResponseSuccessfulExecutionDataOutputErrorOutput value) => new OutputsItem((global::Together.ExecuteResponseSuccessfulExecutionDataOutputErrorOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Together.ExecuteResponseSuccessfulExecutionDataOutputErrorOutput?(OutputsItem @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public OutputsItem(global::Together.ExecuteResponseSuccessfulExecutionDataOutputErrorOutput? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputsItem(global::Together.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutput value) => new OutputsItem((global::Together.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Together.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutput?(OutputsItem @this) => @this.DisplayorExecuteOutput;

        /// <summary>
        /// 
        /// </summary>
        public OutputsItem(global::Together.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutput? value)
        {
            DisplayorExecuteOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OutputsItem(
            global::Together.ExecuteResponseSuccessfulExecutionDataOutputStreamOutput? streamOutput,
            global::Together.ExecuteResponseSuccessfulExecutionDataOutputErrorOutput? error,
            global::Together.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutput? displayorExecuteOutput
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
            global::System.Func<global::Together.ExecuteResponseSuccessfulExecutionDataOutputStreamOutput?, TResult>? streamOutput = null,
            global::System.Func<global::Together.ExecuteResponseSuccessfulExecutionDataOutputErrorOutput?, TResult>? error = null,
            global::System.Func<global::Together.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutput?, TResult>? displayorExecuteOutput = null,
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
            global::System.Action<global::Together.ExecuteResponseSuccessfulExecutionDataOutputStreamOutput?>? streamOutput = null,
            global::System.Action<global::Together.ExecuteResponseSuccessfulExecutionDataOutputErrorOutput?>? error = null,
            global::System.Action<global::Together.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutput?>? displayorExecuteOutput = null,
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
                typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputStreamOutput),
                Error,
                typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputErrorOutput),
                DisplayorExecuteOutput,
                typeof(global::Together.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutput),
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
        public bool Equals(OutputsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Together.ExecuteResponseSuccessfulExecutionDataOutputStreamOutput?>.Default.Equals(StreamOutput, other.StreamOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::Together.ExecuteResponseSuccessfulExecutionDataOutputErrorOutput?>.Default.Equals(Error, other.Error) &&
                global::System.Collections.Generic.EqualityComparer<global::Together.ExecuteResponseSuccessfulExecutionDataOutputDisplayorExecuteOutput?>.Default.Equals(DisplayorExecuteOutput, other.DisplayorExecuteOutput) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OutputsItem obj1, OutputsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OutputsItem obj1, OutputsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputsItem o && Equals(o);
        }
    }
}
