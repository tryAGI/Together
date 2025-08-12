#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// Audio file upload or public HTTP/HTTPS URL. Supported formats .wav, .mp3, .m4a, .webm, .flac.
    /// </summary>
    public readonly partial struct File : global::System.IEquatable<File>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.AudioFileBinary? AudioBinary { get; init; }
#else
        public global::Together.AudioFileBinary? AudioBinary { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioBinary))]
#endif
        public bool IsAudioBinary => AudioBinary != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator File(global::Together.AudioFileBinary value) => new File((global::Together.AudioFileBinary?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Together.AudioFileBinary?(File @this) => @this.AudioBinary;

        /// <summary>
        /// 
        /// </summary>
        public File(global::Together.AudioFileBinary? value)
        {
            AudioBinary = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.AudioFileUrl? AudioUrl { get; init; }
#else
        public global::Together.AudioFileUrl? AudioUrl { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioUrl))]
#endif
        public bool IsAudioUrl => AudioUrl != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator File(global::Together.AudioFileUrl value) => new File((global::Together.AudioFileUrl?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Together.AudioFileUrl?(File @this) => @this.AudioUrl;

        /// <summary>
        /// 
        /// </summary>
        public File(global::Together.AudioFileUrl? value)
        {
            AudioUrl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public File(
            global::Together.AudioFileBinary? audioBinary,
            global::Together.AudioFileUrl? audioUrl
            )
        {
            AudioBinary = audioBinary;
            AudioUrl = audioUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AudioUrl as object ??
            AudioBinary as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AudioBinary?.ToString() ??
            AudioUrl?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAudioBinary && !IsAudioUrl || !IsAudioBinary && IsAudioUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Together.AudioFileBinary?, TResult>? audioBinary = null,
            global::System.Func<global::Together.AudioFileUrl?, TResult>? audioUrl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAudioBinary && audioBinary != null)
            {
                return audioBinary(AudioBinary!);
            }
            else if (IsAudioUrl && audioUrl != null)
            {
                return audioUrl(AudioUrl!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Together.AudioFileBinary?>? audioBinary = null,
            global::System.Action<global::Together.AudioFileUrl?>? audioUrl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAudioBinary)
            {
                audioBinary?.Invoke(AudioBinary!);
            }
            else if (IsAudioUrl)
            {
                audioUrl?.Invoke(AudioUrl!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AudioBinary,
                typeof(global::Together.AudioFileBinary),
                AudioUrl,
                typeof(global::Together.AudioFileUrl),
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
        public bool Equals(File other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Together.AudioFileBinary?>.Default.Equals(AudioBinary, other.AudioBinary) &&
                global::System.Collections.Generic.EqualityComparer<global::Together.AudioFileUrl?>.Default.Equals(AudioUrl, other.AudioUrl) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(File obj1, File obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<File>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(File obj1, File obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is File o && Equals(o);
        }
    }
}
