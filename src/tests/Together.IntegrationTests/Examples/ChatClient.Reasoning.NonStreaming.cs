/*
order: 60
title: Chat Client Reasoning Non Streaming
slug: chat-client-reasoning-non-streaming
*/

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
}
