namespace FinaceTracker;

public class Transaction
{
    // default constructor
    protected Transaction(DateTime date, decimal amount, string description)
    {
        Date = date;
        Amount = amount;
        Description = description;
    }
    
    // Properties
    public DateTime Date { get; private set; }
    public decimal Amount { get; private set; }
    public string Description { get; private set; }
}
