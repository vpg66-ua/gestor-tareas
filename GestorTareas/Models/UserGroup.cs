namespace GestorTareas.Models{
    public class UserGroup
    {
        public required int Id { get; set; }
        public required string GroupName { get; set; }
        public DateTime CreateTime { get; set; }
    }
}