# Chat Client Tool Calling Streaming



This example assumes `using Together;` is in scope and `apiKey` contains your Together API key.

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
        ModelId = ToolCallingModel,
        Tools = [getWeatherTool],
    });

var functionCalls = new List<FunctionCallContent>();
await foreach (var update in updates)
{
    functionCalls.AddRange(update.Contents.OfType<FunctionCallContent>());
}
```