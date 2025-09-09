using System.ComponentModel.DataAnnotations;
using DotnetCorelib.Data;
using Microsoft.EntityFrameworkCore;

namespace DotnetCorelib.DTOs
{
    //Todo: Create Db first approach component with the interface for Employee Object
    public class EmployeeDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Employee name is mandatory")]
        public string EmpName { get; set; }

        [Required(ErrorMessage = "Employee address is mandatory")]
        public string EmpAddress { get; set; }

        [Required(ErrorMessage = "Employee salary is mandatory")]
        public double EmpSalary { get; set; }
        public int DeptId { get; set; }
    }
        public class DeptDto
        {
            public int DeptId { get; set; }
            [Required(ErrorMessage = "Department name is mandatory")]
            public string DeptName { get; set; }

        }
        public interface IEmployee
        {
            void AddEmployee(EmployeeDTO employee);
            IEnumerable<EmployeeDTO> GetAllEmployees();
            EmployeeDTO GetEmployeeById(int id);
            void UpdateEmployee(EmployeeDTO employee);
            void DeleteEmployee(int id);
        }

        public class EmployeeRepo : IEmployee
        {
            private readonly Data.FnftrainingContext _context;

            public EmployeeRepo(Data.FnftrainingContext context)
            {
                _context = context;
            }

            //Implement CRUD operations
            public void AddEmployee(EmployeeDTO employee)
            {
                _context.Employees.Add(new Employee
                {
                    EmpName = employee.EmpName,
                    EmpAddress = employee.EmpAddress,
                    EmpSalary = (decimal)employee.EmpSalary,
                    DeptId = (int)employee.DeptId
                });
                _context.SaveChanges();
            }

            public void DeleteEmployee(int id)
            {
                var employee = _context.Employees.Find(id);
                if (employee != null)
                {
                    _context.Employees.Remove(employee);
                    _context.SaveChanges();
                }
            }

            public IEnumerable<EmployeeDTO> GetAllEmployees()
            {
                var data = _context.Employees
                    
                    .Include(e => e.Dept)
                    .Select(e => new EmployeeDTO
                    {
                        Id = e.Id,
                        EmpName = e.EmpName,
                        EmpAddress = e.EmpAddress,
                        EmpSalary = (double)e.EmpSalary,
                        DeptId = e.DeptId.HasValue ? e.DeptId.Value : 0
                    }).ToList();

                //return _context.Employees.Select(e => new EmployeeDTO
                return data;
            }

            public EmployeeDTO GetEmployeeById(int id)
            {
                var employee = _context.Employees
                    .Include(e => e.Dept)
                    .FirstOrDefault(e => e.Id == id);

                if (employee == null) return null;
                {
                    return new EmployeeDTO
                    {
                        Id = employee.Id,
                        EmpName = employee.EmpName,
                        EmpAddress = employee.EmpAddress,
                        EmpSalary = (double)employee.EmpSalary,
                        DeptId = (int)employee.DeptId
                    };
                }
                return null;
            }

            public void UpdateEmployee(EmployeeDTO employee)
            {
                var emp = _context.Employees.Find(employee.Id);
                if (emp != null)
                {
                    emp.EmpName = employee.EmpName;
                    emp.EmpAddress = employee.EmpAddress;
                    emp.EmpSalary = (decimal)employee.EmpSalary;
                    emp.DeptId = employee.DeptId;
                    _context.SaveChanges();
                }
            }
        }
}

//   Scaffold-DBContext "Data Source=FNFIDVPRE22648;Initial Catalog=FNFTraining;Integrated Security=True;Encrypt=False;Trust Server Certificate=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Data -Tables "Employee", "DeptTable"