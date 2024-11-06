using System.Linq;
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
            return fields.Aggregate(offset, HashCodeAggregator);
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


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::Together.FinetuneResponseTrainingType? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::Together.FinetuneResponseTrainingType),
                jsonSerializerContext) as global::Together.FinetuneResponseTrainingType?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::Together.FinetuneResponseTrainingType? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::Together.FinetuneResponseTrainingType>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::Together.FinetuneResponseTrainingType?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::Together.FinetuneResponseTrainingType),
                jsonSerializerContext).ConfigureAwait(false)) as global::Together.FinetuneResponseTrainingType?;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::Together.FinetuneResponseTrainingType?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::Together.FinetuneResponseTrainingType?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}
