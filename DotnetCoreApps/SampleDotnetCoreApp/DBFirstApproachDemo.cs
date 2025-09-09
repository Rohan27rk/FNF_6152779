using SampleDotnetCoreApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDotnetCoreApp
{
    //Scaffold-DBContext "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=FnfTraining;Integrated Security=True;Encrypt=False;Trust Server Certificate=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Data -Tables "Employee", "DeptTable" 
    internal class DbFirstApproach
    {
        static void Main(string[] args)
        {
            //InsertEmployee();
            //UpdateEmployee();
            //DeleteEmployee();
            GetAllEmployees();
        }

        private static void InsertEmployee()
        {
            try
            {
                Console.Write("Enter Employee Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Employee Address: ");
                string address = Console.ReadLine();

                Console.Write("Enter Employee Salary: ");
                int salary = int.Parse(Console.ReadLine());

                Console.Write("Enter Department ID: ");
                int deptId = int.Parse(Console.ReadLine());

                var context = new FnftrainingContext();
                context.Employees.Add(new Employee
                {
                    EmpName = name,
                    EmpAddress = address,
                    EmpSalary = salary,
                    DeptId = deptId
                });
                context.SaveChanges();
                Console.WriteLine("Employee inserted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException?.Message);
            }
        }

        private static void UpdateEmployee()
        {
            try
            {
                Console.Write("Enter Employee ID to update: ");
                int id = int.Parse(Console.ReadLine());

                var context = new FnftrainingContext();
                var emp = context.Employees.Find(id);
                if (emp != null)
                {
                    Console.Write("Enter New Employee Name: ");
                    emp.EmpName = Console.ReadLine();

                    Console.Write("Enter New Employee Address: ");
                    emp.EmpAddress = Console.ReadLine();

                    Console.Write("Enter New Employee Salary: ");
                    emp.EmpSalary = int.Parse(Console.ReadLine());

                    Console.Write("Enter New Department ID: ");
                    emp.DeptId = int.Parse(Console.ReadLine());

                    context.SaveChanges();
                    Console.WriteLine("Employee updated successfully.");
                }
                else
                {
                    Console.WriteLine("No employee found with the given ID.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException?.Message);
            }
        }

        private static void DeleteEmployee()
        {
            try
            {
                Console.Write("Enter Employee ID to delete: ");
                int id = int.Parse(Console.ReadLine());

                var context = new FnftrainingContext();
                var emp = context.Employees.Find(id);
                if (emp != null)
                {
                    context.Employees.Remove(emp);
                    context.SaveChanges();
                    Console.WriteLine("Employee deleted successfully.");
                }
                else
                {
                    Console.WriteLine("No employee found with the given ID.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException?.Message);
            }
        }

        private static void GetAllEmployees()
        {
            try
            {
                var context = new FnftrainingContext();
                var employees = context.Employees.ToList();
                foreach (var emp in employees)
                {
                    Console.WriteLine($"ID: {emp.Id}, Name: {emp.EmpName}, Address: {emp.EmpAddress}, Salary: {emp.EmpSalary}, DeptId: {emp.DeptId}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException?.Message);
            }
        }

    }
}
