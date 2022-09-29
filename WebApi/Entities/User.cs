namespace WebApi.Entities;

public class User : Employee
{
    public string Username { get; set; }
    public string Password { get; set; }
    public int RoleId { get; set; }
    public virtual Role Role { get; set; }
}
