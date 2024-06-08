namespace Sitchensis.Data.Object;

public class Bill : Entity
{
    public required decimal Balance { get; set; }
    public required DateTime DueDate { get; set; }
    public bool Paid { get => PaymentDate.HasValue; }
    public DateTime? PaymentDate { get; set; }
}
