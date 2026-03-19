# Chat Client Get Service Returns Self



This example assumes `using Together;` is in scope and `apiKey` contains your Together API key.

```csharp
using var client = CreateTestClient();
Meai.IChatClient chatClient = client;

var self = Meai.ChatClientExtensions.GetService<TogetherClient>(chatClient);
```