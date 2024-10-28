namespace GestorTareas.DTO{
    public class UserGroupDTO
    {
        public required int Id { get; set; }
        public required string GroupName { get; set; }
        public DateTime CreateTime { get; set; }
    }
}