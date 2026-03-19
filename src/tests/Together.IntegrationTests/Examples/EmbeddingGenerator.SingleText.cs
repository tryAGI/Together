/*
order: 150
title: Embedding Generator Single Text
slug: embedding-generator-single-text
*/

using Meai = Microsoft.Extensions.AI;

namespace Together.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task EmbeddingGenerator_SingleText()
    {
        using var client = GetAuthenticatedClient();

        Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client;
        var embeddings = await generator.GenerateAsync(
            ["Hello, world!"],
            new Meai.EmbeddingGenerationOptions
            {
                ModelId = "BAAI/bge-base-en-v1.5",
            });

        embeddings.Should().ContainSingle();
        embeddings[0].Vector.Length.Should().BeGreaterThan(0);
    }
}
