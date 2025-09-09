using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DotnetCorelib.DTOs;

namespace SampleMvcApp.Controllers
{
    public class DllDemoController : Controller
    {

        private IEmployee _employeeRepo;
        public DllDemoController(IEmployee empRepo)
        {
            _employeeRepo = empRepo;
        }
        public IActionResult Index()
        {
            var records = _employeeRepo.GetAllEmployees();
            return View("AllEmployees", records);
        }
    }
}
