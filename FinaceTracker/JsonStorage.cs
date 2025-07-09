using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace FinaceTracker
{
    public class JsonStorage : IDataStorage
    {
        public List<Transaction> Load()
        {
            try
            {
                if (!File.Exists("transaction.json"))
                {
                    return new List<Transaction>();
                }
                else
                {
                    string jsonString = File.ReadAllText("transactions.json");
                    return JsonSerializer.Deserialize<List<Transaction>>(jsonString) ?? new List<Transaction>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while loading the transactions: {ex.Message}");
                return new List<Transaction>();
            }
        }

        public void Save(List<Transaction> allTransactions)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(allTransactions,
                    new JsonSerializerOptions { WriteIndented = true });

                File.WriteAllText("transactions.json", jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while saving the transactions: {ex.Message}");
            }
        }
    }
}
