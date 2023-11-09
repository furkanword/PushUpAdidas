
namespace Domain.Entities;

public class DetailTransaction : BaseEntity
{
    public int Quantity { get; set; } //Cantidad
    public decimal Price { get; set; }

    public int TransaccionId { get; set; }
    public Transaction Transaction { get; set; }

     public int ProductoIdFk { get; set; }
    public  Product Product { get; set; }
}
