namespace FinaceTracker;

public class Income : Transaction
{
    //default constructor
    public Income(DateTime date, decimal amount, string description) : base(date, amount, description)
    {
    }
}