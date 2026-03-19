# Chat Client Five Random Words



This example assumes `using Together;` is in scope and `apiKey` contains your Together API key.

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