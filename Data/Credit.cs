namespace NetCoreWebApi;

public class Credit(
    int id,
    string name,
    string bank,
    decimal creditLimit,
    decimal creditAvailable,
    DateTime? lastPaymentDate = null,
    string? rewardsProgramDetails = null,
    string? rewardsProgramBalance = null,
    decimal? statementBalance = null,
    DateTime? statementDueDate = null) : ICredit
{
    private int _id = id; 
    private string _name = name;
    private string _bank = bank;
    private decimal _creditLimit = creditLimit;
    private decimal _creditAvailable = creditAvailable;
    private DateTime? _lastPaymentDate = lastPaymentDate;
    private string? _rewardsProgramDetails = rewardsProgramDetails;
    private string? _rewardsProgramBalance = rewardsProgramBalance;
    private decimal? _statementBalance = statementBalance;
    private DateTime? _statementDueDate = statementDueDate;

    public int ID { get => _id; set => _id = value; }
    public string Name { get => _name; set => _name = value; }
    public string Bank { get => _bank; set => _bank = value; }
    public decimal CreditLimit { get => _creditLimit; set => _creditLimit = value; }
    public decimal CreditAvailable { get => _creditAvailable; set => _creditAvailable = value; }
    public decimal Balance { get => _creditLimit - _creditAvailable; }
    public DateTime? LastPaymentDate { get => _lastPaymentDate; set => _lastPaymentDate = value; }
    public string? RewardsProgramDetails { get => _rewardsProgramDetails; set => _rewardsProgramDetails = value; }
    public string? RewardsProgramBalance { get => _rewardsProgramBalance; set => _rewardsProgramBalance = value; }
    public decimal? StatementBalance { get => _statementBalance; set => _statementBalance = value; }
    public DateTime? StatementDueDate { get => _statementDueDate; set => _statementDueDate = value; }
}
