namespace NetCoreWebApi;

public interface ICash : IAccount
{
    public double Value { get; set; }
}
