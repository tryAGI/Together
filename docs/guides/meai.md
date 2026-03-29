# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Together SDK implements `IChatClient` and `IEmbeddingGenerator<string, Embedding<float>>` and provides `AIFunction` tool wrappers, all compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai).

!!! warning "Namespace Conflict"
    This SDK has a generated `IChatClient` interface that conflicts with `Microsoft.Extensions.AI.IChatClient`. Use the `Meai` alias pattern shown below.

## Supported Interfaces

| Interface | Support Level |
|-----------|--------------|
| `IChatClient` | Full (text, streaming, tool calling, reasoning) |
| `IEmbeddingGenerator<string, Embedding<float>>` | Full |

## IChatClient

### Installation

```bash
dotnet add package tryAGI.Together
```

### Basic Usage

Because the SDK generates its own `IChatClient` interface, you must use a namespace alias:

```csharp
using Together;
using Meai = Microsoft.Extensions.AI;

using var client = new TogetherClient(apiKey);
Meai.IChatClient chatClient = client;

var response = await chatClient.GetResponseAsync(
    "What is the capital of France?",
    new Meai.ChatOptions
    {
        ModelId = "meta-llama/Llama-3.3-70B-Instruct-Turbo",
    });

Console.WriteLine(response.Text);
```

### Streaming

```csharp
using Meai = Microsoft.Extensions.AI;

Meai.IChatClient chatClient = client;

await foreach (var update in chatClient.GetStreamingResponseAsync(
    "Write a short poem about coding.",
    new Meai.ChatOptions
    {
        ModelId = "meta-llama/Llama-3.3-70B-Instruct-Turbo",
    }))
{
    Console.Write(update.Text);
}
```

### Tool Calling

```csharp
using CSharpToJsonSchema;
using Meai = Microsoft.Extensions.AI;

[GenerateJsonSchema]
public interface IWeatherTools
{
    [Description("Gets the current weather for a location.")]
    string GetWeather(
        [Description("The city name")] string city);
}

Meai.IChatClient chatClient = client;
var service = new WeatherToolsService();

var response = await chatClient.GetResponseAsync(
    "What's the weather in Paris?",
    new Meai.ChatOptions
    {
        ModelId = "meta-llama/Llama-3.3-70B-Instruct-Turbo",
        Tools = service.AsTools().AsAITools(),
    });
```

### Accessing Client Metadata

When using the `Meai` alias, call extension methods explicitly:

```csharp
var metadata = Meai.ChatClientExtensions.GetService<Meai.ChatClientMetadata>(chatClient);
var self = Meai.ChatClientExtensions.GetService<TogetherClient>(chatClient);
```

## IEmbeddingGenerator

### Basic Usage

```csharp
using Together;
using Meai = Microsoft.Extensions.AI;

using var client = new TogetherClient(apiKey);
Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client;

var embeddings = await generator.GenerateAsync(
    ["Hello, world!", "How are you?"],
    new Meai.EmbeddingGenerationOptions
    {
        ModelId = "BAAI/bge-large-en-v1.5",
    });

foreach (var embedding in embeddings)
{
    Console.WriteLine($"Dimensions: {embedding.Vector.Length}");
}
```
