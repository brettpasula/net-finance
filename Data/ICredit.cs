namespace NetCoreWebApi;

public interface ICredit : IAccount
{
    public decimal CreditLimit { get; set; }
    public decimal CreditAvailable { get; set; }
    public decimal Balance { get; }
    public DateTime? LastPaymentDate { get; set; }
    public string? RewardsProgramDetails { get; set; }
    public string? RewardsProgramBalance { get; set; }
    public decimal? StatementBalance { get; set; }
    public DateTime? StatementDueDate { get; set; }
}