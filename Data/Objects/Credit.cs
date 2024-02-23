using NetCoreWebApi.Data;

namespace NetCoreWebApi;

public class Credit : Account
{
    public decimal CreditLimit { get; set; }
    public decimal CreditAvailable { get; set; }
    public decimal Balance { get; }
    public decimal AnnualFee { get; set; }
    public RewardsProgram RewardsProgram { get; set; }
    public IEnumerable<Bill> Bills { get; set; }
}