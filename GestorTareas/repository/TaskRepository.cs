using GestorTareas.Repositories.Interfaces;
using GestorTareas.Models;
using GestorTareas.Data;

namespace GestorTareas.Repositories
{
    public class TaskRepository : GenericRepository<Tasks>, ITaskRepository
    {
        public TaskRepository(ApplicationDbContext context) : base(context)
        { }
    }
}