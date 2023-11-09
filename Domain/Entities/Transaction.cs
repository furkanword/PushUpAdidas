namespace Domain.Entities;

public class Transaction : BaseEntity
{
    public DateTime Date { get; set; }
    public decimal Total { get; set; }
    public string State { get; set; }
    public int UserIdFk { get; set; }
    public  User User { get; set; }
    public ICollection<DetailTransaction> DetailTransactions { get; set; }


}
