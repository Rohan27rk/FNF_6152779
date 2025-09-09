using Microsoft.AspNetCore.Mvc;
using SampleMvcApp.Models;

namespace SampleMvcApp.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            var repo = new CustomerRepo();
            var model = repo.GetAllCustomers();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var model = new Customer();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                var repo = new CustomerRepo();
                repo.AddCustomer(customer);
                return RedirectToAction("Index");
            }
            return View(customer);
        }
        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Edit(int id)
        {
            // Read form values manually
            int cstId = int.Parse(Request.Form["CstId"]);
            string cstName = Request.Form["CstName"];
            string cstAddress = Request.Form["CstAddress"];
            decimal billAmount = decimal.TryParse(Request.Form["BillAmount"], out var parsedBillAmount) ? parsedBillAmount : 0;

            var repo = new CustomerRepo();
            var existingCustomer = repo.GetCustomerById(id);

            if (existingCustomer != null)
            {
                existingCustomer.CstName = cstName;
                existingCustomer.CstAddress = cstAddress;
                existingCustomer.BillAmount = (double)billAmount;
                repo.UpdateCustomer(existingCustomer);
            }

            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var repo = new CustomerRepo();
            var existingCustomer = repo.GetCustomerById(id);
            if (existingCustomer != null)
            {
                var context = new CstDbContext();
                context.Customers.Remove(existingCustomer);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}