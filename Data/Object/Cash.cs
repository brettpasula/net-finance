namespace Sitchensis.Data.Object;

public class Cash : Account
{
    public double Value { get; set; }
    public required Unit Unit { get; set; }
}
