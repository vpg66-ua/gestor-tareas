public class UserControllerTests : IClassFixture<WebApplicationFactory<Startup>>
{
    private readonly HttpClient _client;

    public UserControllerTests(WebApplicationFactory<Startup> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task GetUser_ReturnsSuccess()
    {
        var response = await _client.GetAsync("/api/User/1");
        response.EnsureSuccessStatusCode();
    }
}
