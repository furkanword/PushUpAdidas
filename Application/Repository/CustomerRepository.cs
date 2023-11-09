using Application.Repository;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;
public class CustomerRepository : GenericRepository<Customer>, ICustomer
{
    private readonly ApiDbContext _context;
    public CustomerRepository(ApiDbContext context) : base(context)
    {
        _context = context;
    }
}