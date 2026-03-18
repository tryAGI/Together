namespace Together.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static TogetherClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("TOGETHER_API_KEY") ??
            throw new AssertInconclusiveException("TOGETHER_API_KEY environment variable is not found.");

        var client = new TogetherClient(apiKey);
        
        return client;
    }

    private static TogetherClient CreateTestClient() => new(apiKey: "test-key");
}
