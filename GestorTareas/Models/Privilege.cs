namespace GestorTareas.Models{
    public class Privilege
    {
        public required int Id { get; set; }
        public required string PrivilegeName { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
