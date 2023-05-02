using System.ComponentModel.DataAnnotations;

namespace WebApi.Models.Entities;

public class PaymentMethodEntity
{
    [Key]
    public int PaymentMethodId { get; set; }
    public string PaymentMethodName { get; set; } = null!;
    public string CardHolderName { get; set; } = null!;
    public string CardNumber { get; set; } = null!;
    public string ExpiryDate { get; set; } = null!;
    public string CVC { get; set; } = null!;

}
