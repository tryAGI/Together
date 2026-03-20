# Together

[![Nuget package](https://img.shields.io/nuget/vpre/Together)](https://www.nuget.org/packages/Together/)
[![dotnet](https://github.com/tryAGI/Together/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/Together/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/Together)](https://github.com/tryAGI/Together/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official Together OpenAPI specification](https://raw.githubusercontent.com/togethercomputer/openapi/main/openapi.yaml) using [OpenApiGenerator](https://github.com/HavenDV/OpenApiGenerator)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Support .Net Framework/.Net Standard 2.0
- Microsoft.Extensions.AI `IChatClient` and `IEmbeddingGenerator` support

### Usage
```csharp
using Together;

using var client = new TogetherClient(apiKey);
```

### Microsoft.Extensions.AI

The SDK implements [`IChatClient`](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.ai.ichatclient) and [`IEmbeddingGenerator`](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.ai.iembeddinggenerator-2):
```csharp
using Together;
using Meai = Microsoft.Extensions.AI;

// IChatClient
Meai.IChatClient chatClient = new TogetherClient(apiKey);
var response = await chatClient.GetResponseAsync(
    [new Meai.ChatMessage(Meai.ChatRole.User, "Hello!")],
    new Meai.ChatOptions { ModelId = "meta-llama/Llama-3.3-70B-Instruct-Turbo" });

// IEmbeddingGenerator
Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = new TogetherClient(apiKey);
var embeddings = await generator.GenerateAsync(
    ["Hello, world!"],
    new Meai.EmbeddingGenerationOptions { ModelId = "BAAI/bge-large-en-v1.5" });
```

> **Note:** Use the `Meai` alias because the Together SDK has its own generated `IChatClient` interface.

<!-- EXAMPLES:START -->
### Chat Client Five Random Words Streaming


```csharp
using var client = new TogetherClient(apiKey);

Meai.IChatClient chatClient = client;
var updates = chatClient.GetStreamingResponseAsync(
    [
        new Meai.ChatMessage(Meai.ChatRole.User, "Generate 5 random words.")
    ],
    new Meai.ChatOptions
    {
        ModelId = "meta-llama/Llama-3-8b-chat-hf",
    });

var deltas = new List<string>();
await foreach (var update in updates)
{
    if (!string.IsNullOrWhiteSpace(update.Text))
    {
        deltas.Add(update.Text);
    }
}
```

### Chat Client Five Random Words


```csharp
using var client = new TogetherClient(apiKey);

Meai.IChatClient chatClient = client;
var response = await chatClient.GetResponseAsync(
    [
        new Meai.ChatMessage(Meai.ChatRole.User, "Generate 5 random words.")
    ],
    new Meai.ChatOptions
    {
        ModelId = "meta-llama/Llama-3-8b-chat-hf",
    });
```

### Chat Client Get Service Returns Chat Client Metadata


```csharp
using var client = CreateTestClient();
Meai.IChatClient chatClient = client;

var metadata = Meai.ChatClientExtensions.GetService<Meai.ChatClientMetadata>(chatClient);
```

### Chat Client Get Service Returns Null For Unknown Key


```csharp
using var client = CreateTestClient();
Meai.IChatClient chatClient = client;

var result = Meai.ChatClientExtensions.GetService<Meai.ChatClientMetadata>(chatClient, serviceKey: "unknown");
```

### Chat Client Get Service Returns Self


```csharp
using var client = CreateTestClient();
Meai.IChatClient chatClient = client;

var self = Meai.ChatClientExtensions.GetService<TogetherClient>(chatClient);
```

### Chat Client Reasoning Non Streaming


```csharp
using var client = new TogetherClient(apiKey);
Meai.IChatClient chatClient = client;

var response = await chatClient.GetResponseAsync(
    [new Meai.ChatMessage(Meai.ChatRole.User, "What is 25 * 37? Think step by step.")],
    new Meai.ChatOptions
    {
        ModelId = "deepseek-ai/DeepSeek-R1",
    });

var reasoning = response.Messages
    .SelectMany(m => m.Contents)
    .OfType<Meai.TextReasoningContent>()
    .ToList();

var text = response.Messages
    .SelectMany(m => m.Contents)
    .OfType<Meai.TextContent>()
    .ToList();

// DeepSeek-R1 should produce reasoning content
```

### Chat Client Reasoning Streaming


```csharp
using var client = new TogetherClient(apiKey);
Meai.IChatClient chatClient = client;

var updates = chatClient.GetStreamingResponseAsync(
    [new Meai.ChatMessage(Meai.ChatRole.User, "What is 25 * 37? Think step by step.")],
    new Meai.ChatOptions
    {
        ModelId = "deepseek-ai/DeepSeek-R1",
    });

var reasoningDeltas = new List<string>();
var textDeltas = new List<string>();

await foreach (var update in updates)
{
    foreach (var content in update.Contents)
    {
        if (content is Meai.TextReasoningContent rc && !string.IsNullOrEmpty(rc.Text))
        {
            reasoningDeltas.Add(rc.Text);
        }
        else if (content is Meai.TextContent tc && !string.IsNullOrEmpty(tc.Text))
        {
            textDeltas.Add(tc.Text);
        }
    }
}
```

### Chat Client Tool Calling Multi Turn


```csharp
using var client = new TogetherClient(apiKey);
Meai.IChatClient chatClient = client;

var getWeatherTool = AIFunctionFactory.Create(
    (string location) => $"The weather in {location} is sunny, 72°F",
    "GetWeather",
    "Gets the current weather for a location");

var messages = new List<Meai.ChatMessage>
{
    new(Meai.ChatRole.User, "What's the weather in Seattle?"),
};

var options = new Meai.ChatOptions
{
    ModelId = "meta-llama/Llama-3.3-70B-Instruct-Turbo",
    Tools = [getWeatherTool],
};

// First turn: model should call the tool
var response = await chatClient.GetResponseAsync(messages, options);

var functionCall = response.Messages
    .SelectMany(m => m.Contents)
    .OfType<FunctionCallContent>()
    .FirstOrDefault();

// Add assistant response with tool call and tool result
messages.AddRange(response.Messages);

var toolResult = await getWeatherTool.InvokeAsync(
    functionCall!.Arguments is { } args ? new AIFunctionArguments(args) : null);

messages.Add(new Meai.ChatMessage(Meai.ChatRole.Tool,
[
    new FunctionResultContent(functionCall.CallId, toolResult),
]));

// Second turn: model should respond with the weather info
var finalResponse = await chatClient.GetResponseAsync(messages, options);
```

### Chat Client Tool Calling Single Turn


```csharp
using var client = new TogetherClient(apiKey);
Meai.IChatClient chatClient = client;

var getWeatherTool = AIFunctionFactory.Create(
    (string location) => $"The weather in {location} is sunny, 72°F",
    "GetWeather",
    "Gets the current weather for a location");

var response = await chatClient.GetResponseAsync(
    [new Meai.ChatMessage(Meai.ChatRole.User, "What's the weather in Seattle?")],
    new Meai.ChatOptions
    {
        ModelId = "meta-llama/Llama-3.3-70B-Instruct-Turbo",
        Tools = [getWeatherTool],
    });

var functionCall = response.Messages
    .SelectMany(m => m.Contents)
    .OfType<FunctionCallContent>()
    .FirstOrDefault();
```

### Chat Client Tool Calling Streaming


```csharp
using var client = new TogetherClient(apiKey);
Meai.IChatClient chatClient = client;

var getWeatherTool = AIFunctionFactory.Create(
    (string location) => $"The weather in {location} is sunny, 72°F",
    "GetWeather",
    "Gets the current weather for a location");

var updates = chatClient.GetStreamingResponseAsync(
    [new Meai.ChatMessage(Meai.ChatRole.User, "What's the weather in Seattle?")],
    new Meai.ChatOptions
    {
        ModelId = "meta-llama/Llama-3.3-70B-Instruct-Turbo",
        Tools = [getWeatherTool],
    });

var functionCalls = new List<FunctionCallContent>();
await foreach (var update in updates)
{
    functionCalls.AddRange(update.Contents.OfType<FunctionCallContent>());
}
```

### Embedding Generator Batch Texts


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

### Embedding Generator Get Service Returns Metadata


```csharp
using var client = CreateTestClient();
Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client;

var metadata = Meai.EmbeddingGeneratorExtensions.GetService<Meai.EmbeddingGeneratorMetadata>(generator);
```

### Embedding Generator Get Service Returns Null For Unknown Key


```csharp
using var client = CreateTestClient();
Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client;

var result = Meai.EmbeddingGeneratorExtensions.GetService<Meai.EmbeddingGeneratorMetadata>(generator, serviceKey: "unknown");
```

### Embedding Generator Get Service Returns Self


```csharp
using var client = CreateTestClient();
Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client;

var self = Meai.EmbeddingGeneratorExtensions.GetService<TogetherClient>(generator);
```

### Embedding Generator Single Text


```csharp
using var client = new TogetherClient(apiKey);

Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client;
var embeddings = await generator.GenerateAsync(
    ["Hello, world!"],
    new Meai.EmbeddingGenerationOptions
    {
        ModelId = "BAAI/bge-base-en-v1.5",
    });
```

### Test


```csharp
using var client = new TogetherClient(apiKey);
```
<!-- EXAMPLES:END -->

## Support

Priority place for bugs: https://github.com/tryAGI/Together/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Together/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).

![CodeRabbit logo](https://opengraph.githubassets.com/1c51002d7d0bbe0c4fd72ff8f2e58192702f73a7037102f77e4dbb98ac00ea8f/marketplace/coderabbitai)

This project is supported by CodeRabbit through the [Open Source Support Program](https://github.com/marketplace/coderabbitai).
