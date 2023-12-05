using Oracle.ManagedDataAccess.Client;

namespace NetCoreWebApi;

public class CreditAccountAccess
{
    public static ICreditAccount Get(int id) { 
        using (var sc = new SitchensisConnection()) {
            OracleCommand oc = sc.Connection.CreateCommand();
            oc.CommandText = "select * from account where account_id = :id";
            OracleParameter p_id = new("id", OracleDbType.Long)
            {
                Value = id
            };
            oc.Parameters.Add(p_id);
            OracleDataReader odr = oc.ExecuteReader();
            odr.Read();
            Console.WriteLine(odr[0]);
            return (ICreditAccount)odr[0];
        }
    }
}
