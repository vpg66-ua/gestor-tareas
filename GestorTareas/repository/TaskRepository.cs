public class TaskRepository : GenericRepository<Task>, ITaskRepository
{
    public TaskRepository(ApplicationDbContext context) : base(context)
    { }
}