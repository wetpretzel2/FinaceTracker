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
            Console.WriteLine("1. Add a new transaction");
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
                    // add a new transaction
                    break;
                case 2:
                    // add a new expense
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
}