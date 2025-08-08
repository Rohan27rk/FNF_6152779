//using CollectionAssignment.Entities;
//using CollectionAssignment.Utilities;
//using CollectionAssignment.DataLayer;
//using SampleConApp;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CollectionAssignment.Entities
//{


//    //In this i have to write what i want from thos program that i have to declare
//    class Customer
//    {
//        public int Id { get; set; }
//        public string Name { get; set; } = string.Empty;
//        //Because in starting we want empty string
//        public double BillAmount { get; set; }
//    }


//    //now here i want to give emum operations that i get from user as input or what user want to perform operation

//    enum Operations { Add = 1, Remove, Update, Find, GetAll }
//}
//namespace CollectionAssignment.DataLayer
//{
//    //I have to create a different methods for each features
//    //And pass the data type inside it
//    interface ICustomerManager
//    {
//        void AddCustomer(Customer cst);
//        void UpdateCustomer(int id, Customer cst);
//        void DeleteCustomer(int id);
//        IEnumerable<Customer> GetAllCustomer();
//        void FindCustomer(int id);
//    }
//    class CustomerManager : ICustomerManager
//    {
//        public void AddCustomer(Customer cst)
//        {
//            //get the original list from the file. 
//            //Here i have to get the data from the file and then add the customer
//            var original = GetAllCustomer() as List<Customer>;
//            //add the new customer to the list
//            original.Add(cst);
//            //save it back to the file.
//            CustomerUtil.SaveAllCustomer(original);

//        }

//        public void DeleteCustomer(int id)
//        {
//            //Get the list
//            var original = GetAllCustomer() as List<Customer>;
//            //Find the customer to delete
//            var selectedCst = FindCustomer(id);
//            if (selectedCst != null)
//            {
//                original.Remove(selectedCst);
//            }
//            else
//            {
//                throw new Exception("Customer not found to delete");
//            }
//            //Save it back
//            CustomerUtil.SaveAllCustomer(original);
//        }

//        public void FindCustomer(int id)
//        {
//            var orihinal =  GetAllCustomer() as List<Customer>;

//        } 
//        public IEnumerable<Customer> GetAllCustomer()
//        {
//            return Enumerable.Empty<Customer>();
//        }

        

//        public void UpdateCustomer(int id, Customer cst)
//        {
//        }

      
//    }
//}

//namespace CollectionAssignment.UILayer
//{


//}

//namespace CollectionAssignment.Utilities
//{
//    class CustomerUtil
//    {
//        const string menuFile = "\"C:\\Users\\6152779\\Downloads\\menu.txt\"";
//        const string cstFile = "\"C:\\Users\\6152779\\Desktop\\customer.csv\"";

//        public static string GetMenu()
//        {
//            var menu = File.ReadAllText(menuFile);
//            return menu;


//        }

//        public static void SaveAllCustomer(IEnumerable<Customer> customers)
//        {
//            var lines = string.Empty;
//            foreach (var customer in customers)
//            {
//                var line = $"{customer.Id},{customer.Name}, {customer.BillAmount}";
//                lines += line;
//            }
//            File.WriteAllText(cstFile, lines);
//        }
//    }
    
//}
