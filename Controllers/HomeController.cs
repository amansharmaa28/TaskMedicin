using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

using TaskMedicin.Data;
using TaskMedicin.Models;

namespace TaskMedicin.Controllers
{
    public class HomeController : Controller
    {
        private readonly TaskDbContext taskDemoDbContext;


        public HomeController(TaskDbContext taskDemoDbContext)


        {
            this.taskDemoDbContext = taskDemoDbContext;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> GetDoctors()
        {
            var menus = await taskDemoDbContext.Doctors.ToListAsync();
            return new JsonResult(menus);
        }

        [HttpGet]
        public async Task<IActionResult> GetCustomers()
        {
            var menus = await taskDemoDbContext.Customers.ToListAsync();
            return new JsonResult(menus);
        }

        [HttpGet]
        public async Task<IActionResult> ListView()
        {
            var menus = await taskDemoDbContext.Category.ToListAsync();
            return View(menus);
        }

        public async Task<IActionResult> Medicins()
        {
            var menus = await taskDemoDbContext.Medicins.ToListAsync();
            return View(menus);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Addmedicin(Medicin medicin)
        {
            await taskDemoDbContext.Medicins.AddAsync(medicin);
            await taskDemoDbContext.SaveChangesAsync();
            return RedirectToAction("Medicins");
        }

        [HttpGet]
        public IActionResult Bill()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Customer()
        {
            return View();
        }
        public IActionResult Doctor(int Id)
        {
            var menus = taskDemoDbContext.Doctors.Where(e => e.categoryId == Id).ToList();
            return View(menus);
        }

        public IActionResult AllDoctors()
        {
            var menus = taskDemoDbContext.Doctors.ToList();
            return new JsonResult(menus);
        }


        [HttpPost]
        public async Task<IActionResult> Add(Customer customer)
        {
            var employee = new Customer()
            {
                CId = customer.CId,
                Name = customer.Name,
                Age = customer.Age,
                doctorname = customer.doctorname,
                DateOfBirth = customer.DateOfBirth,
                Problem = customer.Problem
            };

            await taskDemoDbContext.Customers.AddAsync(employee);
            await taskDemoDbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> ViewCustomer()
        {
            var employees = await taskDemoDbContext.Customers.ToListAsync();
            return View(employees);
        }

        [HttpPost]
        public ActionResult UpdateData(Customer model)
        {
            if (ModelState.IsValid)
            {
                taskDemoDbContext.Entry(model).State = EntityState.Modified;
                taskDemoDbContext.SaveChanges();
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }

        [HttpDelete]
        public ActionResult DeleteData(int id)
        {
            var dbData = taskDemoDbContext.Customers.Find(id);
            if (dbData != null)
            {
                taskDemoDbContext.Customers.Remove(dbData);
                taskDemoDbContext.SaveChanges(true);
                return new JsonResult(true);
            }
            return View("ViewCustomer");
        }
    }
}
