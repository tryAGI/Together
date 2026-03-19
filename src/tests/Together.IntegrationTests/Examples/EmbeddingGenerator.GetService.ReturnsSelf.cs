/*
order: 140
title: Embedding Generator Get Service Returns Self
slug: embedding-generator-get-service-returns-self
*/

using Meai = Microsoft.Extensions.AI;

namespace Together.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void EmbeddingGenerator_GetService_ReturnsSelf()
    {
        using var client = CreateTestClient();
        Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client;

        var self = Meai.EmbeddingGeneratorExtensions.GetService<TogetherClient>(generator);

        self.Should().BeSameAs(client);
    }
}
