using System.Reflection;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

public class ApiDbContext : DbContext
{
        public ApiDbContext(DbContextOptions options) : base(options)
        {
        }
             public DbSet<User> Users { get; set; }
             public DbSet<Rol>  Rols { get; set; }
             public DbSet<UserRol> UsersRols { get; set; }
             public DbSet<Customer> Customers { get; set; }
             public DbSet<Product> Products { get; set; }
             public DbSet<DetailTransaction> DetailTransactions { get; set; }
             public DbSet<Transaction> Transactions { get; set; }

    public void Dispose()
    {
        throw new NotImplementedException();
    }


    public Task<int> SaveChangesAsync()
    {
        throw new NotImplementedException();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }

}