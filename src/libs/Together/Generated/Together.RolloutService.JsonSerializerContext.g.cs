
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Together
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeListRolloutsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeRollout>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRollout))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeCreateRolloutRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeCanaryConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeBlueGreenConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRollingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeMetricRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeMetricRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeRolloutStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRolloutStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeMetricRuleName), TypeInfoPropertyName = "DeMetricRuleName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeMetricRuleStat), TypeInfoPropertyName = "DeMetricRuleStat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeThresholdCheck))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRegressionCheck))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeThresholdCheckOperator), TypeInfoPropertyName = "DeThresholdCheckOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRegressionCheckDirection), TypeInfoPropertyName = "DeRegressionCheckDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DePauseRolloutRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeResumeRolloutRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeCancelRolloutRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeCancelRolloutRequestDisposition), TypeInfoPropertyName = "DeCancelRolloutRequestDisposition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DePromoteRolloutRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRolloutDefaultsPreview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DePreviewWarning>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DePreviewWarning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DePauseInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRolloutStrategy), TypeInfoPropertyName = "DeRolloutStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRolloutState), TypeInfoPropertyName = "DeRolloutState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRolloutStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRolloutCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeRolloutStepStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRolloutStepStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeRolloutCondition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRolloutConditionCategory), TypeInfoPropertyName = "DeRolloutConditionCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.DeMetricResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeMetricResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRolloutConditionType), TypeInfoPropertyName = "DeRolloutConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRolloutStepStatusState), TypeInfoPropertyName = "DeRolloutStepStatusState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeMetricResultStat), TypeInfoPropertyName = "DeMetricResultStat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeMetricResultCheck), TypeInfoPropertyName = "DeMetricResultCheck2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeMetricResultOperator), TypeInfoPropertyName = "DeMetricResultOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeMetricResultDirection), TypeInfoPropertyName = "DeMetricResultDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeMetricResultVerdict), TypeInfoPropertyName = "DeMetricResultVerdict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ErrorDataError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RolloutServiceListRolloutsFilter), TypeInfoPropertyName = "RolloutServiceListRolloutsFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeMetricRuleName?), TypeInfoPropertyName = "NullableDeMetricRuleName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeMetricRuleStat?), TypeInfoPropertyName = "NullableDeMetricRuleStat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeThresholdCheckOperator?), TypeInfoPropertyName = "NullableDeThresholdCheckOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRegressionCheckDirection?), TypeInfoPropertyName = "NullableDeRegressionCheckDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeCancelRolloutRequestDisposition?), TypeInfoPropertyName = "NullableDeCancelRolloutRequestDisposition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRolloutStrategy?), TypeInfoPropertyName = "NullableDeRolloutStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRolloutState?), TypeInfoPropertyName = "NullableDeRolloutState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRolloutConditionCategory?), TypeInfoPropertyName = "NullableDeRolloutConditionCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRolloutConditionType?), TypeInfoPropertyName = "NullableDeRolloutConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeRolloutStepStatusState?), TypeInfoPropertyName = "NullableDeRolloutStepStatusState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeMetricResultStat?), TypeInfoPropertyName = "NullableDeMetricResultStat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeMetricResultCheck?), TypeInfoPropertyName = "NullableDeMetricResultCheck2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeMetricResultOperator?), TypeInfoPropertyName = "NullableDeMetricResultOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeMetricResultDirection?), TypeInfoPropertyName = "NullableDeMetricResultDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.DeMetricResultVerdict?), TypeInfoPropertyName = "NullableDeMetricResultVerdict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.RolloutServiceListRolloutsFilter?), TypeInfoPropertyName = "NullableRolloutServiceListRolloutsFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeRollout>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeMetricRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeRolloutStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DePreviewWarning>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeRolloutStepStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeRolloutCondition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.DeMetricResult>))]
    internal sealed partial class RolloutServiceSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RolloutServiceSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static RolloutServiceSourceGenerationContext Default { get; } = new(DefaultOptions);

        private RolloutServiceSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, long?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<object>, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<byte[], string>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<byte[], string>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, object>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, object>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, object>());
            options.Converters.Add(new global::Together.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Together.DeMetricRuleName)

                    || typeToConvert == typeof(global::Together.DeMetricRuleName?)

                    || typeToConvert == typeof(global::Together.DeMetricRuleStat)

                    || typeToConvert == typeof(global::Together.DeMetricRuleStat?)

                    || typeToConvert == typeof(global::Together.DeThresholdCheckOperator)

                    || typeToConvert == typeof(global::Together.DeThresholdCheckOperator?)

                    || typeToConvert == typeof(global::Together.DeRegressionCheckDirection)

                    || typeToConvert == typeof(global::Together.DeRegressionCheckDirection?)

                    || typeToConvert == typeof(global::Together.DeCancelRolloutRequestDisposition)

                    || typeToConvert == typeof(global::Together.DeCancelRolloutRequestDisposition?)

                    || typeToConvert == typeof(global::Together.DeRolloutStrategy)

                    || typeToConvert == typeof(global::Together.DeRolloutStrategy?)

                    || typeToConvert == typeof(global::Together.DeRolloutState)

                    || typeToConvert == typeof(global::Together.DeRolloutState?)

                    || typeToConvert == typeof(global::Together.DeRolloutConditionCategory)

                    || typeToConvert == typeof(global::Together.DeRolloutConditionCategory?)

                    || typeToConvert == typeof(global::Together.DeRolloutConditionType)

                    || typeToConvert == typeof(global::Together.DeRolloutConditionType?)

                    || typeToConvert == typeof(global::Together.DeRolloutStepStatusState)

                    || typeToConvert == typeof(global::Together.DeRolloutStepStatusState?)

                    || typeToConvert == typeof(global::Together.DeMetricResultStat)

                    || typeToConvert == typeof(global::Together.DeMetricResultStat?)

                    || typeToConvert == typeof(global::Together.DeMetricResultCheck)

                    || typeToConvert == typeof(global::Together.DeMetricResultCheck?)

                    || typeToConvert == typeof(global::Together.DeMetricResultOperator)

                    || typeToConvert == typeof(global::Together.DeMetricResultOperator?)

                    || typeToConvert == typeof(global::Together.DeMetricResultDirection)

                    || typeToConvert == typeof(global::Together.DeMetricResultDirection?)

                    || typeToConvert == typeof(global::Together.DeMetricResultVerdict)

                    || typeToConvert == typeof(global::Together.DeMetricResultVerdict?)

                    || typeToConvert == typeof(global::Together.RolloutServiceListRolloutsFilter)

                    || typeToConvert == typeof(global::Together.RolloutServiceListRolloutsFilter?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Together.DeMetricRuleName))
                {
                    return new global::Together.JsonConverters.DeMetricRuleNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeMetricRuleName?))
                {
                    return new global::Together.JsonConverters.DeMetricRuleNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeMetricRuleStat))
                {
                    return new global::Together.JsonConverters.DeMetricRuleStatJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeMetricRuleStat?))
                {
                    return new global::Together.JsonConverters.DeMetricRuleStatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeThresholdCheckOperator))
                {
                    return new global::Together.JsonConverters.DeThresholdCheckOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeThresholdCheckOperator?))
                {
                    return new global::Together.JsonConverters.DeThresholdCheckOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeRegressionCheckDirection))
                {
                    return new global::Together.JsonConverters.DeRegressionCheckDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeRegressionCheckDirection?))
                {
                    return new global::Together.JsonConverters.DeRegressionCheckDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeCancelRolloutRequestDisposition))
                {
                    return new global::Together.JsonConverters.DeCancelRolloutRequestDispositionJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeCancelRolloutRequestDisposition?))
                {
                    return new global::Together.JsonConverters.DeCancelRolloutRequestDispositionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeRolloutStrategy))
                {
                    return new global::Together.JsonConverters.DeRolloutStrategyJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeRolloutStrategy?))
                {
                    return new global::Together.JsonConverters.DeRolloutStrategyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeRolloutState))
                {
                    return new global::Together.JsonConverters.DeRolloutStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeRolloutState?))
                {
                    return new global::Together.JsonConverters.DeRolloutStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeRolloutConditionCategory))
                {
                    return new global::Together.JsonConverters.DeRolloutConditionCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeRolloutConditionCategory?))
                {
                    return new global::Together.JsonConverters.DeRolloutConditionCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeRolloutConditionType))
                {
                    return new global::Together.JsonConverters.DeRolloutConditionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeRolloutConditionType?))
                {
                    return new global::Together.JsonConverters.DeRolloutConditionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeRolloutStepStatusState))
                {
                    return new global::Together.JsonConverters.DeRolloutStepStatusStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeRolloutStepStatusState?))
                {
                    return new global::Together.JsonConverters.DeRolloutStepStatusStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeMetricResultStat))
                {
                    return new global::Together.JsonConverters.DeMetricResultStatJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeMetricResultStat?))
                {
                    return new global::Together.JsonConverters.DeMetricResultStatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeMetricResultCheck))
                {
                    return new global::Together.JsonConverters.DeMetricResultCheckJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeMetricResultCheck?))
                {
                    return new global::Together.JsonConverters.DeMetricResultCheckNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeMetricResultOperator))
                {
                    return new global::Together.JsonConverters.DeMetricResultOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeMetricResultOperator?))
                {
                    return new global::Together.JsonConverters.DeMetricResultOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeMetricResultDirection))
                {
                    return new global::Together.JsonConverters.DeMetricResultDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeMetricResultDirection?))
                {
                    return new global::Together.JsonConverters.DeMetricResultDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeMetricResultVerdict))
                {
                    return new global::Together.JsonConverters.DeMetricResultVerdictJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.DeMetricResultVerdict?))
                {
                    return new global::Together.JsonConverters.DeMetricResultVerdictNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RolloutServiceListRolloutsFilter))
                {
                    return new global::Together.JsonConverters.RolloutServiceListRolloutsFilterJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.RolloutServiceListRolloutsFilter?))
                {
                    return new global::Together.JsonConverters.RolloutServiceListRolloutsFilterNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new RolloutServiceSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}