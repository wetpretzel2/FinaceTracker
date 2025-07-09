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
        /// <summary>
        /// Helper method to load transactions from a JSON file.
        /// </summary>
        /// <remarks>
        /// this method:
        /// 1. Checks if the file exists.
        /// 2. If it does, reads the file and deserializes the JSON content into a list of Transaction objects.
        /// 3. If the file does not exist, it returns an empty list.
        /// 4. If an error occurs during the process, it catches the exception and returns an empty list.
        /// </remarks>
        /// <returns></returns>
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
        /// <summary>
        /// Helper method to save transactions to a JSON file.
        /// </summary>
        /// <remarks>
        /// This method:
        /// 1. Serializes the list of Transaction objects into a JSON string.
        /// 2. Writes the JSON string to a file named "transactions.json".
        /// 3. If an error occurs during the process, it catches the exception and displays an error message.
        /// 4. The file is created if it does not exist, and overwritten if it does.
        /// 5. The JSON is formatted with indentation for readability.
        /// 6. The method does not return any value.
        /// </remarks>
        /// <param name="allTransactions">The list of Transaction objects to save to the JSON file.</param>
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
