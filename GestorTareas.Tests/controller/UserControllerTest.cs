using System.Net.Http;
using System.Threading.Tasks;
using GestorTareas;
using GestorTareas.Controllers;
using GestorTareas.Models;
using GestorTareas.Services;

public class AuthControllerTests
{
    private readonly Mock<AuthService> _mockAuthService;
    private readonly AuthController _controller;

    public AuthControllerTests()
    {
        // Crea un mock del servicio de autenticación
        _mockAuthService = new Mock<AuthService>();
        _controller = new AuthController(_mockAuthService.Object);
    }
/*
    [Fact]
    public async Task Login_ReturnsOkResult_WhenCredentialsAreValid()
    {
        // Arrange
        var loginModel = new LoginModel { Username = "testuser", Password = "password" };
        var expectedResponse = new AuthResponse { Token = "some-token" };

        _mockAuthService.Setup(service => service.LoginAsync(loginModel))
                        .ReturnsAsync(expectedResponse);

        // Act
        var result = await _controller.Login(loginModel);

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result);
        var actualResponse = Assert.IsType<AuthResponse>(okResult.Value);
        Assert.Equal(expectedResponse.Token, actualResponse.Token);
    }

    [Fact]
    public async Task Login_ReturnsBadRequest_WhenCredentialsAreInvalid()
    {
        // Arrange
        var loginModel = new LoginModel { Username = "testuser", Password = "wrongpassword" };
        
        _mockAuthService.Setup(service => service.LoginAsync(loginModel))
                        .ReturnsAsync((AuthResponse)null); // Simula credenciales inválidas

        // Act
        var result = await _controller.Login(loginModel);

        // Assert
        var badRequestResult = Assert.IsType<BadRequestResult>(result);
        Assert.Null(badRequestResult);
    }
    */
}
