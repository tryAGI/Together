/*
order: 100
title: Chat Client Tool Calling Streaming
slug: chat-client-tool-calling-streaming
*/

using Microsoft.Extensions.AI;
using Meai = Microsoft.Extensions.AI;

namespace Together.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_ToolCalling_Streaming()
    {
        using var client = GetAuthenticatedClient();
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

        functionCalls.Should().NotBeEmpty();
        functionCalls[0].Name.Should().Be("GetWeather");
    }
}
