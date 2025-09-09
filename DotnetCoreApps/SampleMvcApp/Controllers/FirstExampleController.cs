using Microsoft.AspNetCore.Mvc;
using SampleMvcApp.Models;

namespace SampleMvcApp.Controllers
{
    public class FirstExampleController : Controller
    {
        public string Welcome()
        {
            return "Welcome to the First Example!";
        }

        public Employee GetEmployee()
        {
            var emp = new Employee()
            {
                Id = 101,
                EmpName = "John Doe",
                EmpAddress = "123 Main St, Anytown, USA",
                EmpSalary = 60000,
                DeptId = 101
            };
            return emp;
        }

        public ViewResult Display()
        {
            var model = GetEmployee();
            return View(model);
        }
    }
}
