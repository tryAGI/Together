# Embedding Generator Get Service Returns Null For Unknown Key



This example assumes `using Together;` is in scope and `apiKey` contains your Together API key.

```csharp
using var client = CreateTestClient();
Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client;

var result = Meai.EmbeddingGeneratorExtensions.GetService<Meai.EmbeddingGeneratorMetadata>(generator, serviceKey: "unknown");
```