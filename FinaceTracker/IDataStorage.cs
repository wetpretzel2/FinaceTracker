using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinaceTracker
{
    public interface IDataStorage
    {
        void Save(List<Transaction> allTransactions);
        List<Transaction> Load();

    }
}
