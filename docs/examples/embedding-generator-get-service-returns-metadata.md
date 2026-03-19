# Embedding Generator Get Service Returns Metadata



This example assumes `using Together;` is in scope and `apiKey` contains your Together API key.

```csharp
using var client = CreateTestClient();
Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client;

var metadata = Meai.EmbeddingGeneratorExtensions.GetService<Meai.EmbeddingGeneratorMetadata>(generator);
```