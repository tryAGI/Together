
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Request3
    {
        /// <summary>
        /// The checkpoint identifier to continue training from a previous fine-tuning job. Format is `{$JOB_ID}` or `{$OUTPUT_MODEL_NAME}` or `{$JOB_ID}:{$STEP}` or `{$OUTPUT_MODEL_NAME}:{$STEP}`. The step value is optional; without it, the final checkpoint will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_checkpoint")]
        public string? FromCheckpoint { get; set; }

        /// <summary>
        /// Name of the base model to run fine-tune job on
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Number of complete passes through the training dataset (higher values may improve results but increase cost and risk of overfitting)<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n_epochs")]
        public int? NEpochs { get; set; }

        /// <summary>
        /// Number of evaluations to be run on a given validation set during training<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n_evals")]
        public int? NEvals { get; set; }

        /// <summary>
        /// File-ID of a training file uploaded to the Together API
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string TrainingFile { get; set; } = default!;

        /// <summary>
        /// The training method to use. 'sft' for Supervised Fine-Tuning or 'dpo' for Direct Preference Optimization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.TrainingMethodSFT, global::Together.TrainingMethodDPO>))]
        public global::Together.OneOf<global::Together.TrainingMethodSFT, global::Together.TrainingMethodDPO>? TrainingMethod { get; set; }

        /// <summary>
        /// The training type to use. If not provided, the job will default to LoRA training type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Together.JsonConverters.OneOfJsonConverter<global::Together.FullTrainingType, global::Together.LoRATrainingType>))]
        public global::Together.OneOf<global::Together.FullTrainingType, global::Together.LoRATrainingType>? TrainingType { get; set; }

        /// <summary>
        /// File-ID of a validation file uploaded to the Together API
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_file")]
        public string? ValidationFile { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Request3" /> class.
        /// </summary>
        /// <param name="fromCheckpoint">
        /// The checkpoint identifier to continue training from a previous fine-tuning job. Format is `{$JOB_ID}` or `{$OUTPUT_MODEL_NAME}` or `{$JOB_ID}:{$STEP}` or `{$OUTPUT_MODEL_NAME}:{$STEP}`. The step value is optional; without it, the final checkpoint will be used.
        /// </param>
        /// <param name="model">
        /// Name of the base model to run fine-tune job on
        /// </param>
        /// <param name="nEpochs">
        /// Number of complete passes through the training dataset (higher values may improve results but increase cost and risk of overfitting)<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="nEvals">
        /// Number of evaluations to be run on a given validation set during training<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="trainingFile">
        /// File-ID of a training file uploaded to the Together API
        /// </param>
        /// <param name="trainingMethod">
        /// The training method to use. 'sft' for Supervised Fine-Tuning or 'dpo' for Direct Preference Optimization.
        /// </param>
        /// <param name="trainingType">
        /// The training type to use. If not provided, the job will default to LoRA training type.
        /// </param>
        /// <param name="validationFile">
        /// File-ID of a validation file uploaded to the Together API
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Request3(
            string trainingFile,
            string? fromCheckpoint,
            string? model,
            int? nEpochs,
            int? nEvals,
            global::Together.OneOf<global::Together.TrainingMethodSFT, global::Together.TrainingMethodDPO>? trainingMethod,
            global::Together.OneOf<global::Together.FullTrainingType, global::Together.LoRATrainingType>? trainingType,
            string? validationFile)
        {
            this.TrainingFile = trainingFile ?? throw new global::System.ArgumentNullException(nameof(trainingFile));
            this.FromCheckpoint = fromCheckpoint;
            this.Model = model;
            this.NEpochs = nEpochs;
            this.NEvals = nEvals;
            this.TrainingMethod = trainingMethod;
            this.TrainingType = trainingType;
            this.ValidationFile = validationFile;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Request3" /> class.
        /// </summary>
        public Request3()
        {
        }
    }
}