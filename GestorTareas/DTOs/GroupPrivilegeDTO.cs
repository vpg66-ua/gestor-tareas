namespace GestorTareas.DTO{
    public class GroupPrivilegeDTO
    {
        public required int GroupId { get; set; }
        public required int PrivilegeId { get; set; }
        public string Description { get; set; }
        public DateTime CreateTime { get; set; }

        public UserGroupDTO UserGroup { get; set; }
        public PrivilegeDTO Privilege { get; set; }
    }
}
