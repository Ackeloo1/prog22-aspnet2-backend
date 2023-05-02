using System.ComponentModel.DataAnnotations;

namespace WebApi.Models.Entities;

public class OrderEntity
{
    [Key]
    public int OrderId { get; set; }
    public UserEntity User { get; set; } = null!;
    public PaymentMethodEntity PaymentMethod { get; set; } = null!;
    public AddressEntity Address { get; set; } = null!;
    public ICollection<ProductEntity> Products { get; set; } = new List<ProductEntity>();
}
