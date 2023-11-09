
namespace Domain.Interfaces;
public interface IUnitOfWork
{
    IRol Rols {get;} 
    IUser Users {get;} 
    ICustomer Customers {get;} 
    IDetailTransaction DetailTransactions {get;} 
    ITransaction Transactions {get;}
    IProduct Products {get;}

    Task<int> SaveAsync();
}