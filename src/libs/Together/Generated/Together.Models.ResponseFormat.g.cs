#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// An object specifying the format that the model must output.<br/>
    /// Setting to `{ "type": "json_schema", "json_schema": {...} }` enables<br/>
    /// Structured Outputs which ensures the model will match your supplied JSON<br/>
    /// schema. Learn more in the [Structured Outputs<br/>
    /// guide](https://docs.together.ai/docs/json-mode).<br/>
    /// Setting to `{ "type": "json_object" }` enables the older JSON mode, which<br/>
    /// ensures the message the model generates is valid JSON. Using `json_schema`<br/>
    /// is preferred for models that support it.
    /// </summary>
    public readonly partial struct ResponseFormat : global::System.IEquatable<ResponseFormat>
    {
        /// <summary>
        /// Default response format. Used to generate text responses.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.ResponseFormatText? Text { get; init; }
#else
        public global::Together.ResponseFormatText? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// JSON Schema response format. Used to generate structured JSON responses.<br/>
        /// Learn more about [Structured Outputs](https://docs.together.ai/docs/json-mode).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.ResponseFormatJsonSchema? JsonSchema { get; init; }
#else
        public global::Together.ResponseFormatJsonSchema? JsonSchema { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonSchema))]
#endif
        public bool IsJsonSchema => JsonSchema != null;

        /// <summary>
        /// JSON object response format. An older method of generating JSON responses.<br/>
        /// Using `json_schema` is recommended for models that support it. Note that the<br/>
        /// model will not generate JSON without a system or user message instructing it<br/>
        /// to do so.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.ResponseFormatJsonObject? JsonObject { get; init; }
#else
        public global::Together.ResponseFormatJsonObject? JsonObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonObject))]
#endif
        public bool IsJsonObject => JsonObject != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseFormat(global::Together.ResponseFormatText value) => new ResponseFormat((global::Together.ResponseFormatText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Together.ResponseFormatText?(ResponseFormat @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ResponseFormat(global::Together.ResponseFormatText? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseFormat(global::Together.ResponseFormatJsonSchema value) => new ResponseFormat((global::Together.ResponseFormatJsonSchema?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Together.ResponseFormatJsonSchema?(ResponseFormat @this) => @this.JsonSchema;

        /// <summary>
        /// 
        /// </summary>
        public ResponseFormat(global::Together.ResponseFormatJsonSchema? value)
        {
            JsonSchema = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseFormat(global::Together.ResponseFormatJsonObject value) => new ResponseFormat((global::Together.ResponseFormatJsonObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Together.ResponseFormatJsonObject?(ResponseFormat @this) => @this.JsonObject;

        /// <summary>
        /// 
        /// </summary>
        public ResponseFormat(global::Together.ResponseFormatJsonObject? value)
        {
            JsonObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResponseFormat(
            global::Together.ResponseFormatText? text,
            global::Together.ResponseFormatJsonSchema? jsonSchema,
            global::Together.ResponseFormatJsonObject? jsonObject
            )
        {
            Text = text;
            JsonSchema = jsonSchema;
            JsonObject = jsonObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            JsonObject as object ??
            JsonSchema as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            JsonSchema?.ToString() ??
            JsonObject?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText || IsJsonSchema || IsJsonObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Together.ResponseFormatText?, TResult>? text = null,
            global::System.Func<global::Together.ResponseFormatJsonSchema?, TResult>? jsonSchema = null,
            global::System.Func<global::Together.ResponseFormatJsonObject?, TResult>? jsonObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsJsonSchema && jsonSchema != null)
            {
                return jsonSchema(JsonSchema!);
            }
            else if (IsJsonObject && jsonObject != null)
            {
                return jsonObject(JsonObject!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Together.ResponseFormatText?>? text = null,
            global::System.Action<global::Together.ResponseFormatJsonSchema?>? jsonSchema = null,
            global::System.Action<global::Together.ResponseFormatJsonObject?>? jsonObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsJsonSchema)
            {
                jsonSchema?.Invoke(JsonSchema!);
            }
            else if (IsJsonObject)
            {
                jsonObject?.Invoke(JsonObject!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::Together.ResponseFormatText),
                JsonSchema,
                typeof(global::Together.ResponseFormatJsonSchema),
                JsonObject,
                typeof(global::Together.ResponseFormatJsonObject),
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
        public bool Equals(ResponseFormat other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Together.ResponseFormatText?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Together.ResponseFormatJsonSchema?>.Default.Equals(JsonSchema, other.JsonSchema) &&
                global::System.Collections.Generic.EqualityComparer<global::Together.ResponseFormatJsonObject?>.Default.Equals(JsonObject, other.JsonObject) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResponseFormat obj1, ResponseFormat obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponseFormat>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResponseFormat obj1, ResponseFormat obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponseFormat o && Equals(o);
        }
    }
}
