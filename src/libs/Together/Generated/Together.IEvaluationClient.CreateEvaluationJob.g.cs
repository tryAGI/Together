#nullable enable

namespace Together
{
    public partial interface IEvaluationClient
    {

        /// <summary>
        /// Create an evaluation job
        /// </summary>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Together.ApiException"></exception>

        /// <remarks>
        /// # Docs for v1 can be found by changing the above selector ^<br/>
        /// from together import Together<br/>
        /// import os<br/>
        /// client = Together(<br/>
        ///     api_key=os.environ.get("TOGETHER_API_KEY"),<br/>
        /// )<br/>
        /// response = client.evals.create(<br/>
        ///     type="classify",<br/>
        ///     parameters=ParametersEvaluationClassifyParameters(<br/>
        ///         judge=ParametersEvaluationClassifyParametersJudge(<br/>
        ///             model="openai/gpt-oss-120b",<br/>
        ///             model_source="serverless",<br/>
        ///             system_template="You are an expert evaluator...",<br/>
        ///         ),<br/>
        ///         input_data_file_path="file-abc123",<br/>
        ///         labels=["good", "bad"],<br/>
        ///         pass_labels=["good"],<br/>
        ///         model_to_evaluate="Qwen/Qwen3.5-9B"<br/>
        ///     )<br/>
        /// )<br/>
        /// print(response.workflow_id)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Together.EvaluationResponse> CreateEvaluationJobAsync(

            global::Together.EvaluationTypedRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create an evaluation job
        /// </summary>
        /// <param name="type">
        /// The type of evaluation to perform<br/>
        /// Example: classify
        /// </param>
        /// <param name="parameters">
        /// Type-specific parameters for the evaluation
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Together.EvaluationResponse> CreateEvaluationJobAsync(
            global::Together.EvaluationTypedRequestType type,
            global::Together.OneOf<global::Together.EvaluationClassifyParameters, global::Together.EvaluationScoreParameters, global::Together.EvaluationCompareParameters> parameters,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}