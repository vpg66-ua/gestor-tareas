public class UsuarioRepository : GenericRepository<Usuario>, IUsuarioRepository
{
    public UsuarioRepository(AplicationDbContext context) : base(context)
    { }
}