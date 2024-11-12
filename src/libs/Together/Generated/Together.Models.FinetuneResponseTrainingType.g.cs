#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct FinetuneResponseTrainingType : global::System.IEquatable<FinetuneResponseTrainingType>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Together.FinetuneResponseTrainingTypeDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.FullTrainingType? Full { get; init; }
#else
        public global::Together.FullTrainingType? Full { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Full))]
#endif
        public bool IsFull => Full != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FinetuneResponseTrainingType(global::Together.FullTrainingType value) => new FinetuneResponseTrainingType(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Together.FullTrainingType?(FinetuneResponseTrainingType @this) => @this.Full;

        /// <summary>
        /// 
        /// </summary>
        public FinetuneResponseTrainingType(global::Together.FullTrainingType? value)
        {
            Full = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.LoRATrainingType? Lora { get; init; }
#else
        public global::Together.LoRATrainingType? Lora { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Lora))]
#endif
        public bool IsLora => Lora != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FinetuneResponseTrainingType(global::Together.LoRATrainingType value) => new FinetuneResponseTrainingType(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Together.LoRATrainingType?(FinetuneResponseTrainingType @this) => @this.Lora;

        /// <summary>
        /// 
        /// </summary>
        public FinetuneResponseTrainingType(global::Together.LoRATrainingType? value)
        {
            Lora = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FinetuneResponseTrainingType(
            global::Together.FinetuneResponseTrainingTypeDiscriminatorType? type,
            global::Together.FullTrainingType? full,
            global::Together.LoRATrainingType? lora
            )
        {
            Type = type;

            Full = full;
            Lora = lora;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Lora as object ??
            Full as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFull && !IsLora || !IsFull && IsLora;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Together.FullTrainingType?, TResult>? full = null,
            global::System.Func<global::Together.LoRATrainingType?, TResult>? lora = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFull && full != null)
            {
                return full(Full!);
            }
            else if (IsLora && lora != null)
            {
                return lora(Lora!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Together.FullTrainingType?>? full = null,
            global::System.Action<global::Together.LoRATrainingType?>? lora = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFull)
            {
                full?.Invoke(Full!);
            }
            else if (IsLora)
            {
                lora?.Invoke(Lora!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Full,
                typeof(global::Together.FullTrainingType),
                Lora,
                typeof(global::Together.LoRATrainingType),
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
        public bool Equals(FinetuneResponseTrainingType other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Together.FullTrainingType?>.Default.Equals(Full, other.Full) &&
                global::System.Collections.Generic.EqualityComparer<global::Together.LoRATrainingType?>.Default.Equals(Lora, other.Lora) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FinetuneResponseTrainingType obj1, FinetuneResponseTrainingType obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FinetuneResponseTrainingType>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FinetuneResponseTrainingType obj1, FinetuneResponseTrainingType obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FinetuneResponseTrainingType o && Equals(o);
        }
    }
}
