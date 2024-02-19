namespace NetCoreWebApi;

public interface IBill
{
    public decimal Balance { get; set; }
    public DateTime DueDate { get; set; }
    public bool Paid { get; set; }
    public DateTime? PaymentDate { get; set; }
}
