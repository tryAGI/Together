
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.ErrorDataError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FinetuneResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<int?, global::Together.FinetuneResponseBatchSize?>), TypeInfoPropertyName = "OneOfInt32FinetuneResponseBatchSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FinetuneResponseBatchSize), TypeInfoPropertyName = "FinetuneResponseBatchSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.LRScheduler))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<bool?, global::Together.FinetuneResponseTrainOnInputs?>), TypeInfoPropertyName = "OneOfBooleanFinetuneResponseTrainOnInputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FinetuneResponseTrainOnInputs), TypeInfoPropertyName = "FinetuneResponseTrainOnInputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.TrainingMethodSFT, global::Together.TrainingMethodDPO>), TypeInfoPropertyName = "OneOfTrainingMethodSFTTrainingMethodDPO2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.TrainingMethodSFT))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.TrainingMethodDPO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.FullTrainingType, global::Together.LoRATrainingType>), TypeInfoPropertyName = "OneOfFullTrainingTypeLoRATrainingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FullTrainingType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.LoRATrainingType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.MultimodalParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FinetuneJobStatus), TypeInfoPropertyName = "FinetuneJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.FineTuneEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FineTuneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FineTuneProgress))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FinetuneResponseTruncated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FinetuneDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FineTunePreviewRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FineTunePreviewRequestTrainingMethod), TypeInfoPropertyName = "FineTunePreviewRequestTrainingMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FineTunePreviewResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FineTunePreviewResponseDatasetFormat), TypeInfoPropertyName = "FineTunePreviewResponseDatasetFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.FineTunePreviewRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FineTunePreviewRow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FineTunePreviewMessageError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FineTunePreviewDetailError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FineTuneModelLimits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FineTuneModelLimitsFullTraining))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FineTuneModelLimitsLoraTraining))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FinetuneEventLevels), TypeInfoPropertyName = "FinetuneEventLevels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FinetuneEventType), TypeInfoPropertyName = "FinetuneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FinetuneTruncatedList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.FinetuneResponseTruncated>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FinetuneListEvents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FineTuneTokenizedDatasetRetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FinetuneListCheckpoints))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.FineTuneCheckpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FineTuneCheckpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FineTuneCheckpointCheckpoint), TypeInfoPropertyName = "FineTuneCheckpointCheckpoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FullTrainingTypeType), TypeInfoPropertyName = "FullTrainingTypeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.LoRATrainingTypeType), TypeInfoPropertyName = "LoRATrainingTypeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.TrainingMethodSFTMethod), TypeInfoPropertyName = "TrainingMethodSFTMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<bool?, global::Together.TrainingMethodSFTTrainOnInputs?>), TypeInfoPropertyName = "OneOfBooleanTrainingMethodSFTTrainOnInputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.TrainingMethodSFTTrainOnInputs), TypeInfoPropertyName = "TrainingMethodSFTTrainOnInputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.TrainingMethodDPOMethod), TypeInfoPropertyName = "TrainingMethodDPOMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.LRSchedulerLrSchedulerType), TypeInfoPropertyName = "LRSchedulerLrSchedulerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.LinearLRSchedulerArgs, global::Together.CosineLRSchedulerArgs>), TypeInfoPropertyName = "OneOfLinearLRSchedulerArgsCosineLRSchedulerArgs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.LinearLRSchedulerArgs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CosineLRSchedulerArgs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateFineTunesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<int?, global::Together.CreateFineTunesRequestBatchSize?>), TypeInfoPropertyName = "OneOfInt32CreateFineTunesRequestBatchSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateFineTunesRequestBatchSize), TypeInfoPropertyName = "CreateFineTunesRequestBatchSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<bool?, global::Together.CreateFineTunesRequestTrainOnInputs?>), TypeInfoPropertyName = "OneOfBooleanCreateFineTunesRequestTrainOnInputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateFineTunesRequestTrainOnInputs), TypeInfoPropertyName = "CreateFineTunesRequestTrainOnInputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AnyOf<global::Together.FullTrainingType, global::Together.LoRATrainingType>), TypeInfoPropertyName = "AnyOfFullTrainingTypeLoRATrainingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateFineTunesEstimatePriceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GetFinetuneDownloadCheckpoint), TypeInfoPropertyName = "GetFinetuneDownloadCheckpoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.CreateFineTunesEstimatePriceResponseVariant1, global::Together.CreateFineTunesEstimatePriceResponseVariant2>), TypeInfoPropertyName = "OneOfCreateFineTunesEstimatePriceResponseVariant1CreateFineTunesEstimatePriceResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateFineTunesEstimatePriceResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateFineTunesEstimatePriceResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateFineTunesEstimatePriceResponseVariant2UnavailableReason), TypeInfoPropertyName = "CreateFineTunesEstimatePriceResponseVariant2UnavailableReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.FineTunePreviewMessageError, global::Together.FineTunePreviewDetailError>), TypeInfoPropertyName = "OneOfFineTunePreviewMessageErrorFineTunePreviewDetailError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GetFineTunesMetricsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GetFineTunesModelsSupportedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Together.GetFineTunesModelsSupportedResponseDetailedModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GetFineTunesModelsSupportedResponseDetailedModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GetFineTunesModelsLimitsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<int?, global::Together.FinetuneResponseBatchSize?>?), TypeInfoPropertyName = "NullableOneOfInt32FinetuneResponseBatchSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FinetuneResponseBatchSize?), TypeInfoPropertyName = "NullableFinetuneResponseBatchSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<bool?, global::Together.FinetuneResponseTrainOnInputs?>?), TypeInfoPropertyName = "NullableOneOfBooleanFinetuneResponseTrainOnInputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FinetuneResponseTrainOnInputs?), TypeInfoPropertyName = "NullableFinetuneResponseTrainOnInputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.TrainingMethodSFT, global::Together.TrainingMethodDPO>?), TypeInfoPropertyName = "NullableOneOfTrainingMethodSFTTrainingMethodDPO2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.FullTrainingType, global::Together.LoRATrainingType>?), TypeInfoPropertyName = "NullableOneOfFullTrainingTypeLoRATrainingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FinetuneJobStatus?), TypeInfoPropertyName = "NullableFinetuneJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FineTunePreviewRequestTrainingMethod?), TypeInfoPropertyName = "NullableFineTunePreviewRequestTrainingMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FineTunePreviewResponseDatasetFormat?), TypeInfoPropertyName = "NullableFineTunePreviewResponseDatasetFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FinetuneEventLevels?), TypeInfoPropertyName = "NullableFinetuneEventLevels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FinetuneEventType?), TypeInfoPropertyName = "NullableFinetuneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FineTuneCheckpointCheckpoint?), TypeInfoPropertyName = "NullableFineTuneCheckpointCheckpoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.FullTrainingTypeType?), TypeInfoPropertyName = "NullableFullTrainingTypeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.LoRATrainingTypeType?), TypeInfoPropertyName = "NullableLoRATrainingTypeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.TrainingMethodSFTMethod?), TypeInfoPropertyName = "NullableTrainingMethodSFTMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<bool?, global::Together.TrainingMethodSFTTrainOnInputs?>?), TypeInfoPropertyName = "NullableOneOfBooleanTrainingMethodSFTTrainOnInputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.TrainingMethodSFTTrainOnInputs?), TypeInfoPropertyName = "NullableTrainingMethodSFTTrainOnInputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.TrainingMethodDPOMethod?), TypeInfoPropertyName = "NullableTrainingMethodDPOMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.LRSchedulerLrSchedulerType?), TypeInfoPropertyName = "NullableLRSchedulerLrSchedulerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.LinearLRSchedulerArgs, global::Together.CosineLRSchedulerArgs>?), TypeInfoPropertyName = "NullableOneOfLinearLRSchedulerArgsCosineLRSchedulerArgs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<int?, global::Together.CreateFineTunesRequestBatchSize?>?), TypeInfoPropertyName = "NullableOneOfInt32CreateFineTunesRequestBatchSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateFineTunesRequestBatchSize?), TypeInfoPropertyName = "NullableCreateFineTunesRequestBatchSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<bool?, global::Together.CreateFineTunesRequestTrainOnInputs?>?), TypeInfoPropertyName = "NullableOneOfBooleanCreateFineTunesRequestTrainOnInputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateFineTunesRequestTrainOnInputs?), TypeInfoPropertyName = "NullableCreateFineTunesRequestTrainOnInputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.AnyOf<global::Together.FullTrainingType, global::Together.LoRATrainingType>?), TypeInfoPropertyName = "NullableAnyOfFullTrainingTypeLoRATrainingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.GetFinetuneDownloadCheckpoint?), TypeInfoPropertyName = "NullableGetFinetuneDownloadCheckpoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.CreateFineTunesEstimatePriceResponseVariant1, global::Together.CreateFineTunesEstimatePriceResponseVariant2>?), TypeInfoPropertyName = "NullableOneOfCreateFineTunesEstimatePriceResponseVariant1CreateFineTunesEstimatePriceResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.CreateFineTunesEstimatePriceResponseVariant2UnavailableReason?), TypeInfoPropertyName = "NullableCreateFineTunesEstimatePriceResponseVariant2UnavailableReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Together.OneOf<global::Together.FineTunePreviewMessageError, global::Together.FineTunePreviewDetailError>?), TypeInfoPropertyName = "NullableOneOfFineTunePreviewMessageErrorFineTunePreviewDetailError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.FineTuneEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.FineTunePreviewRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.FinetuneResponseTruncated>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.FineTuneCheckpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Together.GetFineTunesModelsSupportedResponseDetailedModel>))]
    internal sealed partial class FineTuningSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FineTuningSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static FineTuningSourceGenerationContext Default { get; } = new(DefaultOptions);

        private FineTuningSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, long?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<object>, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<byte[], string>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<byte[], string>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<int?, global::Together.FinetuneResponseBatchSize?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<bool?, global::Together.FinetuneResponseTrainOnInputs?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::Together.TrainingMethodSFT, global::Together.TrainingMethodDPO>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::Together.FullTrainingType, global::Together.LoRATrainingType>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::Together.FullTrainingType, global::Together.LoRATrainingType>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::Together.TrainingMethodSFT, global::Together.TrainingMethodDPO>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<bool?, global::Together.TrainingMethodSFTTrainOnInputs?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::Together.LinearLRSchedulerArgs, global::Together.CosineLRSchedulerArgs>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, object>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, object>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<string, object>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<int?, global::Together.CreateFineTunesRequestBatchSize?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<bool?, global::Together.CreateFineTunesRequestTrainOnInputs?>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::Together.TrainingMethodSFT, global::Together.TrainingMethodDPO>());
            options.Converters.Add(new global::Together.JsonConverters.AnyOfJsonConverter<global::Together.FullTrainingType, global::Together.LoRATrainingType>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::Together.TrainingMethodSFT, global::Together.TrainingMethodDPO>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::Together.FullTrainingType, global::Together.LoRATrainingType>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::Together.CreateFineTunesEstimatePriceResponseVariant1, global::Together.CreateFineTunesEstimatePriceResponseVariant2>());
            options.Converters.Add(new global::Together.JsonConverters.OneOfJsonConverter<global::Together.FineTunePreviewMessageError, global::Together.FineTunePreviewDetailError>());
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
                    typeToConvert == typeof(global::Together.FinetuneResponseBatchSize)

                    || typeToConvert == typeof(global::Together.FinetuneResponseBatchSize?)

                    || typeToConvert == typeof(global::Together.FinetuneResponseTrainOnInputs)

                    || typeToConvert == typeof(global::Together.FinetuneResponseTrainOnInputs?)

                    || typeToConvert == typeof(global::Together.FineTunePreviewRequestTrainingMethod)

                    || typeToConvert == typeof(global::Together.FineTunePreviewRequestTrainingMethod?)

                    || typeToConvert == typeof(global::Together.FineTunePreviewResponseDatasetFormat)

                    || typeToConvert == typeof(global::Together.FineTunePreviewResponseDatasetFormat?)

                    || typeToConvert == typeof(global::Together.FinetuneJobStatus)

                    || typeToConvert == typeof(global::Together.FinetuneJobStatus?)

                    || typeToConvert == typeof(global::Together.FinetuneEventLevels)

                    || typeToConvert == typeof(global::Together.FinetuneEventLevels?)

                    || typeToConvert == typeof(global::Together.FinetuneEventType)

                    || typeToConvert == typeof(global::Together.FinetuneEventType?)

                    || typeToConvert == typeof(global::Together.FineTuneCheckpointCheckpoint)

                    || typeToConvert == typeof(global::Together.FineTuneCheckpointCheckpoint?)

                    || typeToConvert == typeof(global::Together.FullTrainingTypeType)

                    || typeToConvert == typeof(global::Together.FullTrainingTypeType?)

                    || typeToConvert == typeof(global::Together.LoRATrainingTypeType)

                    || typeToConvert == typeof(global::Together.LoRATrainingTypeType?)

                    || typeToConvert == typeof(global::Together.TrainingMethodSFTMethod)

                    || typeToConvert == typeof(global::Together.TrainingMethodSFTMethod?)

                    || typeToConvert == typeof(global::Together.TrainingMethodSFTTrainOnInputs)

                    || typeToConvert == typeof(global::Together.TrainingMethodSFTTrainOnInputs?)

                    || typeToConvert == typeof(global::Together.TrainingMethodDPOMethod)

                    || typeToConvert == typeof(global::Together.TrainingMethodDPOMethod?)

                    || typeToConvert == typeof(global::Together.LRSchedulerLrSchedulerType)

                    || typeToConvert == typeof(global::Together.LRSchedulerLrSchedulerType?)

                    || typeToConvert == typeof(global::Together.CreateFineTunesRequestBatchSize)

                    || typeToConvert == typeof(global::Together.CreateFineTunesRequestBatchSize?)

                    || typeToConvert == typeof(global::Together.CreateFineTunesRequestTrainOnInputs)

                    || typeToConvert == typeof(global::Together.CreateFineTunesRequestTrainOnInputs?)

                    || typeToConvert == typeof(global::Together.GetFinetuneDownloadCheckpoint)

                    || typeToConvert == typeof(global::Together.GetFinetuneDownloadCheckpoint?)

                    || typeToConvert == typeof(global::Together.CreateFineTunesEstimatePriceResponseVariant2UnavailableReason)

                    || typeToConvert == typeof(global::Together.CreateFineTunesEstimatePriceResponseVariant2UnavailableReason?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Together.FinetuneResponseBatchSize))
                {
                    return new global::Together.JsonConverters.FinetuneResponseBatchSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FinetuneResponseBatchSize?))
                {
                    return new global::Together.JsonConverters.FinetuneResponseBatchSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FinetuneResponseTrainOnInputs))
                {
                    return new global::Together.JsonConverters.FinetuneResponseTrainOnInputsJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FinetuneResponseTrainOnInputs?))
                {
                    return new global::Together.JsonConverters.FinetuneResponseTrainOnInputsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FineTunePreviewRequestTrainingMethod))
                {
                    return new global::Together.JsonConverters.FineTunePreviewRequestTrainingMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FineTunePreviewRequestTrainingMethod?))
                {
                    return new global::Together.JsonConverters.FineTunePreviewRequestTrainingMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FineTunePreviewResponseDatasetFormat))
                {
                    return new global::Together.JsonConverters.FineTunePreviewResponseDatasetFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FineTunePreviewResponseDatasetFormat?))
                {
                    return new global::Together.JsonConverters.FineTunePreviewResponseDatasetFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FinetuneJobStatus))
                {
                    return new global::Together.JsonConverters.FinetuneJobStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FinetuneJobStatus?))
                {
                    return new global::Together.JsonConverters.FinetuneJobStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FinetuneEventLevels))
                {
                    return new global::Together.JsonConverters.FinetuneEventLevelsJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FinetuneEventLevels?))
                {
                    return new global::Together.JsonConverters.FinetuneEventLevelsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FinetuneEventType))
                {
                    return new global::Together.JsonConverters.FinetuneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FinetuneEventType?))
                {
                    return new global::Together.JsonConverters.FinetuneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FineTuneCheckpointCheckpoint))
                {
                    return new global::Together.JsonConverters.FineTuneCheckpointCheckpointJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FineTuneCheckpointCheckpoint?))
                {
                    return new global::Together.JsonConverters.FineTuneCheckpointCheckpointNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FullTrainingTypeType))
                {
                    return new global::Together.JsonConverters.FullTrainingTypeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.FullTrainingTypeType?))
                {
                    return new global::Together.JsonConverters.FullTrainingTypeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.LoRATrainingTypeType))
                {
                    return new global::Together.JsonConverters.LoRATrainingTypeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.LoRATrainingTypeType?))
                {
                    return new global::Together.JsonConverters.LoRATrainingTypeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.TrainingMethodSFTMethod))
                {
                    return new global::Together.JsonConverters.TrainingMethodSFTMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.TrainingMethodSFTMethod?))
                {
                    return new global::Together.JsonConverters.TrainingMethodSFTMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.TrainingMethodSFTTrainOnInputs))
                {
                    return new global::Together.JsonConverters.TrainingMethodSFTTrainOnInputsJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.TrainingMethodSFTTrainOnInputs?))
                {
                    return new global::Together.JsonConverters.TrainingMethodSFTTrainOnInputsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.TrainingMethodDPOMethod))
                {
                    return new global::Together.JsonConverters.TrainingMethodDPOMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.TrainingMethodDPOMethod?))
                {
                    return new global::Together.JsonConverters.TrainingMethodDPOMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.LRSchedulerLrSchedulerType))
                {
                    return new global::Together.JsonConverters.LRSchedulerLrSchedulerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.LRSchedulerLrSchedulerType?))
                {
                    return new global::Together.JsonConverters.LRSchedulerLrSchedulerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CreateFineTunesRequestBatchSize))
                {
                    return new global::Together.JsonConverters.CreateFineTunesRequestBatchSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CreateFineTunesRequestBatchSize?))
                {
                    return new global::Together.JsonConverters.CreateFineTunesRequestBatchSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CreateFineTunesRequestTrainOnInputs))
                {
                    return new global::Together.JsonConverters.CreateFineTunesRequestTrainOnInputsJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CreateFineTunesRequestTrainOnInputs?))
                {
                    return new global::Together.JsonConverters.CreateFineTunesRequestTrainOnInputsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.GetFinetuneDownloadCheckpoint))
                {
                    return new global::Together.JsonConverters.GetFinetuneDownloadCheckpointJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.GetFinetuneDownloadCheckpoint?))
                {
                    return new global::Together.JsonConverters.GetFinetuneDownloadCheckpointNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CreateFineTunesEstimatePriceResponseVariant2UnavailableReason))
                {
                    return new global::Together.JsonConverters.CreateFineTunesEstimatePriceResponseVariant2UnavailableReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Together.CreateFineTunesEstimatePriceResponseVariant2UnavailableReason?))
                {
                    return new global::Together.JsonConverters.CreateFineTunesEstimatePriceResponseVariant2UnavailableReasonNullableJsonConverter();
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
                    0 => new FineTuningSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}