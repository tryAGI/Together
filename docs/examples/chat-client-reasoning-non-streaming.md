# Chat Client Reasoning Non Streaming



This example assumes `using Together;` is in scope and `apiKey` contains your Together API key.

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