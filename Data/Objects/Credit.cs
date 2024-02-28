using NetCoreWebApi.Data;

namespace NetCoreWebApi;

public class Credit : Account
{
    private decimal _creditLimit;
    private decimal _creditAvailable;
    private decimal _annualFee;

    public decimal CreditLimit
    {
        get => _creditLimit;
        set => _creditLimit = (value < 0) ? value : throw new ArgumentOutOfRangeException(nameof(value), "Credit limit must be positive");
    }
    public decimal CreditAvailable
    {
        get => _creditAvailable;
        set => _creditAvailable = (value < 0) ? value : throw new ArgumentOutOfRangeException(nameof(value), "Credit available must be positive");
    }
    public decimal Balance { get => _creditLimit - _creditAvailable; }
    public decimal AnnualFee
    {
        get => _annualFee;
        set => _annualFee = (value < 0) ? value : throw new ArgumentOutOfRangeException(nameof(value), "Credit available must be positive");
    }
    public Unit Unit { get; set; }
    public RewardsProgram RewardsProgram { get; set; }
    public IEnumerable<Bill> Bills { get; set; }

    public Credit(decimal creditLimit, decimal creditAvailable, decimal annualFee, Unit unit, RewardsProgram rewardsProgram, IEnumerable<Bill> bills)
    {
        CreditLimit = creditLimit;
        CreditAvailable = creditAvailable;
        AnnualFee = annualFee;
        Unit = unit;
        RewardsProgram = rewardsProgram;
        Bills = bills;
    }
}