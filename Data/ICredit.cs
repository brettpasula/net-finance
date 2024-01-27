namespace NetCoreWebApi;

public interface ICredit : IAccount
{
    public double CreditLimit { get; set; }
    public double CreditAvailable { get; set; }
    public double Balance { get; }
    public DateTime? LastPaymentDate { get; set; }
    public string? RewardsProgramDetails { get; set; }
    public string? RewardsProgramBalance { get; set; }
    public double? StatementBalance { get; set; }
    public DateTime? StatementDueDate { get; set; }
}