#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AudioTranscriptionResponse : global::System.IEquatable<AudioTranscriptionResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.AudioTranscriptionJsonResponse? Json { get; init; }
#else
        public global::Together.AudioTranscriptionJsonResponse? Json { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Json))]
#endif
        public bool IsJson => Json != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AudioTranscriptionResponse(global::Together.AudioTranscriptionJsonResponse value) => new AudioTranscriptionResponse((global::Together.AudioTranscriptionJsonResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Together.AudioTranscriptionJsonResponse?(AudioTranscriptionResponse @this) => @this.Json;

        /// <summary>
        /// 
        /// </summary>
        public AudioTranscriptionResponse(global::Together.AudioTranscriptionJsonResponse? value)
        {
            Json = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.AudioTranscriptionVerboseJsonResponse? VerboseJson { get; init; }
#else
        public global::Together.AudioTranscriptionVerboseJsonResponse? VerboseJson { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VerboseJson))]
#endif
        public bool IsVerboseJson => VerboseJson != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AudioTranscriptionResponse(global::Together.AudioTranscriptionVerboseJsonResponse value) => new AudioTranscriptionResponse((global::Together.AudioTranscriptionVerboseJsonResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Together.AudioTranscriptionVerboseJsonResponse?(AudioTranscriptionResponse @this) => @this.VerboseJson;

        /// <summary>
        /// 
        /// </summary>
        public AudioTranscriptionResponse(global::Together.AudioTranscriptionVerboseJsonResponse? value)
        {
            VerboseJson = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AudioTranscriptionResponse(
            global::Together.AudioTranscriptionJsonResponse? json,
            global::Together.AudioTranscriptionVerboseJsonResponse? verboseJson
            )
        {
            Json = json;
            VerboseJson = verboseJson;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            VerboseJson as object ??
            Json as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Json?.ToString() ??
            VerboseJson?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsJson && !IsVerboseJson || !IsJson && IsVerboseJson;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Together.AudioTranscriptionJsonResponse?, TResult>? json = null,
            global::System.Func<global::Together.AudioTranscriptionVerboseJsonResponse?, TResult>? verboseJson = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsJson && json != null)
            {
                return json(Json!);
            }
            else if (IsVerboseJson && verboseJson != null)
            {
                return verboseJson(VerboseJson!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Together.AudioTranscriptionJsonResponse?>? json = null,
            global::System.Action<global::Together.AudioTranscriptionVerboseJsonResponse?>? verboseJson = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsJson)
            {
                json?.Invoke(Json!);
            }
            else if (IsVerboseJson)
            {
                verboseJson?.Invoke(VerboseJson!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Json,
                typeof(global::Together.AudioTranscriptionJsonResponse),
                VerboseJson,
                typeof(global::Together.AudioTranscriptionVerboseJsonResponse),
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
        public bool Equals(AudioTranscriptionResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Together.AudioTranscriptionJsonResponse?>.Default.Equals(Json, other.Json) &&
                global::System.Collections.Generic.EqualityComparer<global::Together.AudioTranscriptionVerboseJsonResponse?>.Default.Equals(VerboseJson, other.VerboseJson) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AudioTranscriptionResponse obj1, AudioTranscriptionResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AudioTranscriptionResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AudioTranscriptionResponse obj1, AudioTranscriptionResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AudioTranscriptionResponse o && Equals(o);
        }
    }
}
