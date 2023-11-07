//using Microsoft.AspNetCore.Mvc;
//using TaskMedicin.Data;
//using TaskMedicin.Models;

//namespace TaskMedicin.Controllers
//{
//    public class AddMenuController : Controller
//    {

//        private readonly TaskDbContext _taskDemoDbContext;


//        public AddMenuController(TaskDbContext taskDemoDbContext)


//        {
//            _taskDemoDbContext = taskDemoDbContext;
//        }
//        [HttpGet]
//        public IActionResult Index()
//        {
//            return View();
//        }

//        [HttpPost]
//        public async Task<IActionResult> Index(Medicin menu)
//        {
            
//            _taskDemoDbContext.Medicins.Add(menu);
//            _taskDemoDbContext.SaveChanges();
//            return View();
//        }


//        //SubMenu COntroller 


//        [HttpGet]
//        public IActionResult SubMenu()
//        {
//            return View();
//        }

//                    }
//                }
            
