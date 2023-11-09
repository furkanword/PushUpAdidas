using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Rol : BaseEntity
{
    public string Name_Rol { get; set; }
    public ICollection<User> Users { get; set; } = new HashSet<User>();
    public ICollection<UserRol> UserRols { get; set; } = new HashSet<UserRol>();
    public string Description_Rol { get; set; }
}