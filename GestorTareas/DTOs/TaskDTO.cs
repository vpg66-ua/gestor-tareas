namespace GestorTareas.DTO{
    public class Task
    {
        public required int Id { get; set; }
        public required string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime DueDate { get; set; }
        public bool Completed { get; set; }
        public required int UserId { get; set; }

        public User User { get; set; }
    }
}
