namespace NetCoreWebApi.Data;

public class RewardsProgram
{
    public int? ID { get; set; }
    public decimal Balance { get; set; }
    public string Details { get; set; }
    public Unit Unit { get; set; }
}
