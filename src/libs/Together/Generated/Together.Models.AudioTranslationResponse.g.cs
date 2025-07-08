#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AudioTranslationResponse : global::System.IEquatable<AudioTranslationResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.AudioTranslationJsonResponse? Json { get; init; }
#else
        public global::Together.AudioTranslationJsonResponse? Json { get; }
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
        public static implicit operator AudioTranslationResponse(global::Together.AudioTranslationJsonResponse value) => new AudioTranslationResponse((global::Together.AudioTranslationJsonResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Together.AudioTranslationJsonResponse?(AudioTranslationResponse @this) => @this.Json;

        /// <summary>
        /// 
        /// </summary>
        public AudioTranslationResponse(global::Together.AudioTranslationJsonResponse? value)
        {
            Json = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.AudioTranslationVerboseJsonResponse? VerboseJson { get; init; }
#else
        public global::Together.AudioTranslationVerboseJsonResponse? VerboseJson { get; }
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
        public static implicit operator AudioTranslationResponse(global::Together.AudioTranslationVerboseJsonResponse value) => new AudioTranslationResponse((global::Together.AudioTranslationVerboseJsonResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Together.AudioTranslationVerboseJsonResponse?(AudioTranslationResponse @this) => @this.VerboseJson;

        /// <summary>
        /// 
        /// </summary>
        public AudioTranslationResponse(global::Together.AudioTranslationVerboseJsonResponse? value)
        {
            VerboseJson = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AudioTranslationResponse(
            global::Together.AudioTranslationJsonResponse? json,
            global::Together.AudioTranslationVerboseJsonResponse? verboseJson
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
            global::System.Func<global::Together.AudioTranslationJsonResponse?, TResult>? json = null,
            global::System.Func<global::Together.AudioTranslationVerboseJsonResponse?, TResult>? verboseJson = null,
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
            global::System.Action<global::Together.AudioTranslationJsonResponse?>? json = null,
            global::System.Action<global::Together.AudioTranslationVerboseJsonResponse?>? verboseJson = null,
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
                typeof(global::Together.AudioTranslationJsonResponse),
                VerboseJson,
                typeof(global::Together.AudioTranslationVerboseJsonResponse),
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
        public bool Equals(AudioTranslationResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Together.AudioTranslationJsonResponse?>.Default.Equals(Json, other.Json) &&
                global::System.Collections.Generic.EqualityComparer<global::Together.AudioTranslationVerboseJsonResponse?>.Default.Equals(VerboseJson, other.VerboseJson) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AudioTranslationResponse obj1, AudioTranslationResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AudioTranslationResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AudioTranslationResponse obj1, AudioTranslationResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AudioTranslationResponse o && Equals(o);
        }
    }
}
