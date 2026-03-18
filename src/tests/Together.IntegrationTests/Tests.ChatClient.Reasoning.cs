using Meai = Microsoft.Extensions.AI;

namespace Together.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_Reasoning_NonStreaming()
    {
        using var client = GetAuthenticatedClient();
        Meai.IChatClient chatClient = client;

        var response = await chatClient.GetResponseAsync(
            [new Meai.ChatMessage(Meai.ChatRole.User, "What is 25 * 37? Think step by step.")],
            new Meai.ChatOptions
            {
                ModelId = "deepseek-ai/DeepSeek-R1",
            });

        response.Messages.Should().NotBeEmpty();

        var reasoning = response.Messages
            .SelectMany(m => m.Contents)
            .OfType<Meai.TextReasoningContent>()
            .ToList();

        var text = response.Messages
            .SelectMany(m => m.Contents)
            .OfType<Meai.TextContent>()
            .ToList();

        // DeepSeek-R1 should produce reasoning content
        reasoning.Should().NotBeEmpty("DeepSeek-R1 should produce reasoning/thinking content");
        text.Should().NotBeEmpty("response should include a final text answer");
        response.Text.Should().Contain("925");
    }

    [TestMethod]
    public async Task ChatClient_Reasoning_Streaming()
    {
        using var client = GetAuthenticatedClient();
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

        reasoningDeltas.Should().NotBeEmpty("streaming should include reasoning deltas");
        textDeltas.Should().NotBeEmpty("streaming should include text deltas");
        string.Concat(textDeltas).Should().Contain("925");
    }
}
