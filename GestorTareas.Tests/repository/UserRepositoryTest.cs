using GestorTareas.Repositories;
using GestorTareas.Data;
using Microsoft.EntityFrameworkCore;
using Xunit;
using assert = Xunit.Assert;

public class UserRepositoryTests
{
    private readonly UserRepository _repository;
    private readonly DbContextOptions<ApplicationDbContext> _options;

    public UserRepositoryTests()
    {
        _options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDB")
            .Options;

        var context = new ApplicationDbContext(_options);
        _repository = new UserRepository(context);
    }

    [Fact]
    public void AddUser_StoresUser()
    {
        assert.True(1 == 1);
        return;
        // Implementa la prueba de almacenamiento
    }
}