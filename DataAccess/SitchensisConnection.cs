using Oracle.ManagedDataAccess.Client;

namespace NetCoreWebApi;

public class SitchensisConnection : IDisposable
{
    private readonly string _connectionString = ""; // TODO
    private OracleConnection _oracleConnection;

    public SitchensisConnection()
    {
        _oracleConnection = new OracleConnection(_connectionString);
        _oracleConnection.Open();
    }

    public OracleConnection Connection { get => _oracleConnection; }

    public void Dispose()
    {
        Connection.Close();
        Connection.Dispose();
    }
}
