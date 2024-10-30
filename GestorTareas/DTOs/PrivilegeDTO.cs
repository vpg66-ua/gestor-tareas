namespace GestorTareas.DTO{
    public class PrivilegeDTO
    {
        public required int Id { get; set; }
        public required string PrivilegeName { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
