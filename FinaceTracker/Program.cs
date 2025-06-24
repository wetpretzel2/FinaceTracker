namespace FinaceTracker;

class Program
{
    static void Main(string[] args)
    {
        // list to hold all transaction objects - income and expenses
        List<Transaction> allTransactions = new List<Transaction>();
        int userChoice = 0;

        while (userChoice != 4)
        {
            // Menu display
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("\t\t\t Finance Tracker ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Please select an option: ");
            Console.WriteLine("1. Add a new income");
            Console.WriteLine("2. Add a new expense");
            Console.WriteLine("3. View all transactions");
            Console.WriteLine("4. Exit");

            if (!int.TryParse(Console.ReadLine(), out userChoice))
            {
                userChoice = 0;
            }

            Console.WriteLine();

            // switch statement
            switch (userChoice)
            {
                case 1:
                    // add a new income
                    AddIncome(allTransactions);
                    break;
                case 2:
                    // add a new expense
                    AddExpense(allTransactions);   
                    break;
                case 3:
                    // view all transactions
                    break;
                //exit
                case 4:
                    Console.WriteLine("Thank you for using the application.");
                    break;
                default:
                    // handles any input errors
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey();
            Console.Clear(); // clear the console - keep things clean
        }
    }
    
    /// <summary>
    /// Helper method to add a new income.
    /// </summary>
    /// <remarks>
    /// This method:
    /// 1. Prompts the user for the income amount and the description of the income.
    /// 2. validates the users input.
    /// 3. Creates a new Income object and adds it to the allTransactions list.
    /// </remarks>   
    /// <param name="allTransactions">The main list of transactions to which the new income will be added.</param>
    private static void AddIncome(List<Transaction> allTransactions)
    {
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("\t\t Add New Income");
        Console.WriteLine("----------------------------------------");
        // prompt and validate the users input for income amount
        Console.WriteLine("Please enter your income amount, including cents: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal amount))
        {
            Console.WriteLine("Invalid amount. Please enter a valid number.");
            return;
        }
        // Prompt user for description of income
        Console.WriteLine("Please enter a description of your income: ");
        string description = Console.ReadLine();
        // Add a time stamp to the income using the current date and time
        DateTime date = DateTime.Now;
        // Create a new Income object and add it to the allTransactions list
        Income income = new Income(date, amount, description);
        allTransactions.Add(income);
        // Display a success message
        Console.WriteLine("Income added successfully.");
    }

    /// <summary>
    /// Helper method to add a new expense.
    /// </summary>
    /// <remarks>
    /// This method:
    /// 1. Prompts the user for the expense amount and the description of the expense.
    /// 2. validates the users input.
    /// 3. Creates a new Expense object and adds it to the allTransactions list.
    /// <param name="allTransactions">The main list of transactions to which the new expense will be added.</param>
    private static void AddExpense(List<Transaction> allTransactions)
    {
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("\t\t Add New Expense");
        Console.WriteLine("----------------------------------------");
        // prompt and validate the users input for expense amount
        Console.WriteLine("Please enter your expense amount, including cents: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal amount))
        {
            Console.WriteLine("Invalid amount. Please enter a valid number.");
            return;
        }
        // prompt user for description of expense
        Console.WriteLine("Please enter a description of your expense: ");
        string description = Console.ReadLine();
        // add a time stamp to the expense using the current date and time
        DateTime date = DateTime.Now;
        // create a new Expense object and add it to the allTransactions list
        Expense expense = new Expense(date, amount, description);
        allTransactions.Add(expense);
        // display a success message
        Console.WriteLine("Expense added successfully.");
    }
}