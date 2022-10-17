namespace WebApi.Entities;

public class User : BaseEntity
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }    
    public bool Confirmation { get; set; }
    public int RoleId { get; set; }
    public virtual ICollection<Role> Roles { get; set; }
}
