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

using var api = new TogetherApi(apiKey);
```

## Support

Priority place for bugs: https://github.com/tryAGI/Together/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Together/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  