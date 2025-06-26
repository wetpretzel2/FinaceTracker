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
    
    // ToString method - override the default ToString method
    /// <summary>
    /// Helper method to display the transaction details.
    /// </summary>
    /// <remarks>
    /// This method:
    /// 1. Displays the transaction details in a readable format.
    /// </remarks> 
    /// <returns></returns>
    public override string ToString()
    {
        return $"{Date:dd/MM/yyyy} | {Amount:C} | {Description}";
    }
}
