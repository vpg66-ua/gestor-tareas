public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public int? GroupId { get; set; }
    public DateTime CreateTime { get; set; }

    public UserGroup UserGroup { get; set; }
}
