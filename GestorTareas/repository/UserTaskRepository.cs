using GestorTareas.Repositories.Interfaces;
using GestorTareas.Models;
using GestorTareas.Data;

namespace GestorTareas.Repositories
{
    public class UserTaskRepository : GenericRepository<UserTask>, IUserTaskRepository
    {
        public UserTaskRepository(ApplicationDbContext context) : base(context)
        { }
    }
}