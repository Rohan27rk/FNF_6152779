using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentProject.Data
{
    internal interface IExpenseManager
    {
        public void AddExpense(Expense expense);
        public void UpdateExpense(int id, Expense expense);
        IEnumerable<Expense> GetAllExpenses();
        IEnumerable<Expense> GetExpenseOnCategory(string category);
       
      
    }
}
