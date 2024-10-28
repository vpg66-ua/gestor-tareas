using Xunit;
using Moq;
using GestorTareas.Services;
using GestorTareas.Repositories.Interfaces;

public class UserServiceTests
{
    private readonly AuthService _service;

    public UserServiceTests()
    {
        _service = new AuthService();
    }

    [Fact]
    public void CreateUser_ValidUser_ReturnsUser()
    {
        // Configura el mock y llama al método del servicio
    }
}