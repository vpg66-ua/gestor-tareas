namespace GestorTareas.DTO{
    public class GroupPrivilege
    {
        public required int GroupId { get; set; }
        public required int PrivilegeId { get; set; }
        public string Description { get; set; }
        public DateTime CreateTime { get; set; }

        public UserGroup UserGroup { get; set; }
        public Privilege Privilege { get; set; }
    }
}
