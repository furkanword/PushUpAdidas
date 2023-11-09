using Application.Repository;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;
public class DetailTransactionRepository : GenericRepository<DetailTransaction>, IDetailTransaction
{
    private readonly ApiDbContext _context;
    public DetailTransactionRepository(ApiDbContext context) : base(context)
    {
        _context = context;
    }
}