using NetCoreWebApi.Data;

namespace NetCoreWebApi;

public interface ICredit : IAccount
{
    public decimal CreditLimit { get; set; }
    public decimal CreditAvailable { get; set; }
    public decimal Balance { get; }
    public decimal AnnualFee { get; set; }
    public IRewardsProgram RewardsProgram { get; set; }
    public IEnumerable<IBill> Bills { get; set; }
}