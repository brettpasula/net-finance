namespace NetCoreWebApi.Data;

public interface IRewardsProgram
{
    public decimal Balance { get; set; }
    public string Details { get; set; }
    public IUnit Unit { get; set; }
}
