namespace SampleMvcApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }

        public int EmpSalary { get; set; }
        public int DeptId { get; set; }
    
        public override string ToString()
        {
            return $"ID: {Id}, Name: {EmpName}, Address: {EmpAddress}, Salary: {EmpSalary}, Dept ID: {DeptId}";
        }

    }
}
