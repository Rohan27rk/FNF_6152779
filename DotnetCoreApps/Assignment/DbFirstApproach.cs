using Assignment.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class DbFirstApproach
    {
        static void Main(string[] args)
        {
            //InsertCustomer();
            DeleteExample();
        }

        private static void DeleteExample()
        {

            try
            {
                var context = new FnftrainingContext();
                Console.WriteLine("Enter Customer ID to delete the record");
                int id = int.Parse(Console.ReadLine());
                var cst = context.Customers.FirstOrDefault(c => c.CstId == id);

                if(cst != null)
                {
                    context.Customers.Remove(cst);
                    context.SaveChanges();
                    Console.WriteLine("Customer deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Record not found");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Enter the valid ID ");
            }



        }


        private static void InsertCustomer()
        {
            try
            {
                var context = new FnftrainingContext();
                context.Customers.Add(new Customer
                {
                    CstName = "Rohan",
                    CstAddress = "Bangalore",
                    BillDate = DateTime.Now,
                    BillAmount = 2563
                });
                context.SaveChanges();
                Console.WriteLine("Customer Added Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
