using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentProject.Data
{
    
    public class Expense
    {
        public static int nextId = 100;
        public int Id { get; private set; } 
        public string Description { get; set; }
        public string Category { get; set; }
        public int Amount { get; set; }
        public DateTime DateOfExpenses { get; set; } 

       public Expense()
       {
            
          Id = ++nextId;
            
       }
    }
    
    
    
}
//