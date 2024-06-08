namespace Sitchensis.Data.Object;

public class Credit : Account
{
    public required decimal CreditLimit { get; set; }
    public required decimal CreditAvailable { get; set; }
    public decimal Balance { get => CreditLimit - CreditAvailable; }
    public required decimal AnnualFee { get; set; }
    public required Unit Unit { get; set; }
    public RewardsProgram? RewardsProgram { get; set; }
    public IEnumerable<Bill>? Bills { get; set; }
}