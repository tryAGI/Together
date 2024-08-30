namespace Together.IntegrationTests;

[TestClass]
public partial class Tests
{
    [TestMethod]
    public TogetherApi GetAuthenticatedApi()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("TOGETHER_API_KEY") ??
            throw new AssertInconclusiveException("TOGETHER_API_KEY environment variable is not found.");

        var api = new TogetherApi(apiKey);
        
        return api;
    }
}
