using Meai = Microsoft.Extensions.AI;

namespace Together;

public partial class TogetherClient : Meai.IEmbeddingGenerator<string, Meai.Embedding<float>>
{
    private Meai.EmbeddingGeneratorMetadata? _embeddingMetadata;

    object? Meai.IEmbeddingGenerator.GetService(Type serviceType, object? serviceKey)
    {
        ArgumentNullException.ThrowIfNull(serviceType);

        return
            serviceKey is not null ? null :
            serviceType == typeof(Meai.EmbeddingGeneratorMetadata) ? (_embeddingMetadata ??= new(nameof(TogetherClient), BaseUri)) :
            serviceType.IsInstanceOfType(this) ? this :
            null;
    }

    async Task<Meai.GeneratedEmbeddings<Meai.Embedding<float>>> Meai.IEmbeddingGenerator<string, Meai.Embedding<float>>.GenerateAsync(
        IEnumerable<string> values,
        Meai.EmbeddingGenerationOptions? options,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(values);

        var texts = values as IList<string> ?? values.ToList();

        var request = new EmbeddingsRequest
        {
            Model = options?.ModelId ?? "BAAI/bge-base-en-v1.5",
            Input = texts.Count == 1
                ? new OneOf<string, IList<string>>(texts[0])
                : new OneOf<string, IList<string>>(texts),
        };

        var response = await Embeddings.EmbeddingsAsync(request, cancellationToken).ConfigureAwait(false);

        var embeddings = new Meai.GeneratedEmbeddings<Meai.Embedding<float>>();

        foreach (var item in response.Data)
        {
            var floatArray = new float[item.Embedding.Count];
            for (var i = 0; i < item.Embedding.Count; i++)
            {
                floatArray[i] = (float)item.Embedding[i];
            }

            embeddings.Add(new Meai.Embedding<float>(floatArray)
            {
                ModelId = response.Model,
            });
        }

        return embeddings;
    }
}
