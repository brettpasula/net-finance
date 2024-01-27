namespace NetCoreWebApi;

public class Credit(
    int id,
    string name,
    string bank,
    double creditLimit,
    double creditAvailable,
    DateTime? lastPaymentDate = null,
    string? rewardsProgramDetails = null,
    string? rewardsProgramBalance = null,
    double? statementBalance = null,
    DateTime? statementDueDate = null) : ICredit
{
    private int _id = id; 
    private string _name = name;
    private string _bank = bank;
    private double _creditLimit = creditLimit;
    private double _creditAvailable = creditAvailable;
    private DateTime? _lastPaymentDate = lastPaymentDate;
    private string? _rewardsProgramDetails = rewardsProgramDetails;
    private string? _rewardsProgramBalance = rewardsProgramBalance;
    private double? _statementBalance = statementBalance;
    private DateTime? _statementDueDate = statementDueDate;

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
