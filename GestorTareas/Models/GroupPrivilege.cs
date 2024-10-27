public class GroupPrivilege
{
    public int GroupId { get; set; }
    public int PrivilegeId { get; set; }
    public string Description { get; set; }
    public DateTime CreateTime { get; set; }

    public UserGroup UserGroup { get; set; }
    public Privilege Privilege { get; set; }
}
