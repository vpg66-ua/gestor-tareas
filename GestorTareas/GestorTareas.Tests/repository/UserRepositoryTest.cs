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
        // Implementa la prueba de almacenamiento
    }
}