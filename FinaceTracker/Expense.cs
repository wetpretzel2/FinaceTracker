namespace FinaceTracker;

public class Expense : Transaction
{
    //default constructor   
    public Expense(DateTime date, decimal amount, string description) : base(date, amount, description)
    {
    }
}