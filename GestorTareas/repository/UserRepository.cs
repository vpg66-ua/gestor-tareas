using GestorTareas.Models;
using GestorTareas.Repositories.Interfaces;
using GestorTareas.Data;

namespace GestorTareas.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        { }
    }
}