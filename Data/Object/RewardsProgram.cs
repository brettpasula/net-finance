namespace Sitchensis.Data.Object;

public class RewardsProgram : Entity
{
    public required decimal Balance { get; set; }
    public string? Details { get; set; }
    public required Unit Unit { get; set; }
}
