namespace NetCoreWebApi;

public class CreditAccount : ICreditAccount
{
    private int _id; 
    private string _name;
    private string _bank;
    private double _creditLimit;
    private double _creditAvailable;
    private DateTime? _lastPaymentDate;
    private string? _rewardsProgramDetails;
    private string? _rewardsProgramBalance;
    private double? _statementBalance;
    private DateTime? _statementDueDate;

    public CreditAccount(
        int id,
        string name,
        string bank,
        double creditLimit,
        double creditAvailable,
        DateTime? lastPaymentDate = null,
        string? rewardsProgramDetails = null,
        string? rewardsProgramBalance = null,
        double? statementBalance = null,
        DateTime? statementDueDate = null)
    {
        _id = id;
        _name = name;
        _bank = bank;
        _creditLimit = creditLimit;
        _creditAvailable = creditAvailable;
        _lastPaymentDate = lastPaymentDate;
        _rewardsProgramDetails = rewardsProgramDetails;
        _rewardsProgramBalance = rewardsProgramBalance;
        _statementBalance = statementBalance;
        _statementDueDate = statementDueDate;
    }

    public int ID { get => _id; set => _id = value; }
    public string Name { get => _name; set => _name = value; }
    public string Bank { get => _bank; set => _bank = value; }
    public double CreditLimit { get => _creditLimit; set => _creditLimit = value; }
    public double CreditAvailable { get => _creditAvailable; set => _creditAvailable = value; }
    public double Balance { get => _creditLimit - _creditAvailable; }
    public DateTime? LastPaymentDate { get => _lastPaymentDate; set => _lastPaymentDate = value; }
    public string? RewardsProgramDetails { get => _rewardsProgramDetails; set => _rewardsProgramDetails = value; }
    public string? RewardsProgramBalance { get => _rewardsProgramBalance; set => _rewardsProgramBalance = value; }
    public double? StatementBalance { get => _statementBalance; set => _statementBalance = value; }
    public DateTime? StatementDueDate { get => _statementDueDate; set => _statementDueDate = value; }
}
