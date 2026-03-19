# Embedding Generator Batch Texts



This example assumes `using Together;` is in scope and `apiKey` contains your Together API key.

```csharp
using var client = new TogetherClient(apiKey);

Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client;
var embeddings = await generator.GenerateAsync(
    ["Hello", "World", "Test"],
    new Meai.EmbeddingGenerationOptions
    {
        ModelId = "BAAI/bge-base-en-v1.5",
    });

foreach (var embedding in embeddings)
{
}
```