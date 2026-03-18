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

## Support

Priority place for bugs: https://github.com/tryAGI/Together/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Together/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).

![CodeRabbit logo](https://opengraph.githubassets.com/1c51002d7d0bbe0c4fd72ff8f2e58192702f73a7037102f77e4dbb98ac00ea8f/marketplace/coderabbitai)

This project is supported by CodeRabbit through the [Open Source Support Program](https://github.com/marketplace/coderabbitai).
