namespace GestorTareas.DTO{
    public class UserDTO
    {
        public required int Id { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required string Email { get; set; }
        public required int GroupId { get; set; }
        public DateTime CreateTime { get; set; }

        public UserGroupDTO UserGroup { get; set; }
    }
}