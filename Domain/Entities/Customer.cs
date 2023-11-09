namespace Domain.Entities;

public class Customer : BaseEntity
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
    public string Email { get; set; }
    public int Phone { get; set; }
    public ICollection<User> Users { get; set; }
}
